using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using FluentValidation;
using Sepidar.Infrastructure.Base;
using Sepidar.Logger.Implements;
using Sepidar.Logger.Models;

namespace Sepidar.Api.Activators.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ExceptionLogger logger)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (ValidationException exception)
            {
                 await LogException(exception, logger);
                await ConfigureResponse(context, HttpStatusCode.BadRequest, exception.Message,
                    (long)HttpStatusCode.BadRequest, "ValidationError");
            }
            catch (CommandValidationException exception)
            {
                 await LogException(exception, logger);
                await ConfigureResponse(context, HttpStatusCode.BadRequest, exception.Message);
            }

            catch (ManagedException exception)
            {
                await LogException(exception.Message, logger);
                await ConfigureResponse(context, HttpStatusCode.BadRequest, exception.Message);
            }
            catch (Exception exception)
            {
                  await LogException(exception, logger);
                await ConfigureResponse(context, HttpStatusCode.InternalServerError, "متاسفانه خطای سیستمی رخ داده است، در صورت لزوم با پشتیبانی تماس حاصل نمایید");
            }
        }

        private static async Task LogException(Exception exception, ExceptionLogger logger)
        {
            await logger.LogAsync(new ExceptionLog(exception?.ToString(), exception?.StackTrace));
        }
        private static async Task LogException(string exceptionMessage, ExceptionLogger logger)
        {
            await logger.LogAsync(new ExceptionLog(exceptionMessage, exceptionMessage));
        }

        private static async Task ConfigureResponse(HttpContext context, HttpStatusCode statusCode, string message,
            long? exceptionCode = null, string exceptionReason = "")
        {
            exceptionCode ??= (long)statusCode;
            exceptionReason = !string.IsNullOrEmpty(exceptionReason) ? exceptionReason : statusCode.ToString();

            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(
                new FailedResponseMessage(message).ToString());
        }
    }
}