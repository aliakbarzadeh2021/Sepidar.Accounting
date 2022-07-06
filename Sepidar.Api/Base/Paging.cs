using Sepidar.Infrastructure.Base;
using Sepidar.Message.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sepidar.api.Base
{
    public class Paging<T> : IPaging<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalRecord { get; set; }
    }

    public static class Paging
    {
        public static IQueryable<T> ToPagingAndSorting<T>(this IQueryable<T> dataModels, IPageQuery objectQuery)
        {
            return objectQuery.PageSize == 0
                ? dataModels
                : dataModels
                    .Skip((objectQuery.PageIndex - 1) * objectQuery.PageSize)
                    .Take(objectQuery.PageSize);
        }

        public static IEnumerable<T> ToPagingAndSorting<T>(this IEnumerable<T> dataModels, IPageQuery objectQuery)
        {
            return objectQuery.PageSize == 0
                ? dataModels
                : dataModels
                    .Skip((objectQuery.PageIndex - 1) * objectQuery.PageSize)
                    .Take(objectQuery.PageSize);
        }

        public static Paging<T> ToPaging<T>(this IEnumerable<T> data, int totalRecord)
        {
            return new Paging<T>
            {
                Data = data,
                TotalRecord = totalRecord
            };
        }

        public static IEnumerable<T> ToOrderBy<T>(this IEnumerable<T> dataModels, string ordeByProperty = "CreationDate~desc")
        {
            if (ordeByProperty == null)
                ordeByProperty = "CreationDate~desc";

            var desc = !string.IsNullOrEmpty(ordeByProperty) && ordeByProperty.Split('~')[1] == "desc";
            ordeByProperty = !string.IsNullOrEmpty(ordeByProperty) ? ordeByProperty.Split('~')[0] : string.Empty;


            var result = dataModels.AsQueryable();
            if (ordeByProperty != string.Empty)
                result = result.OrderBy(ordeByProperty, desc);
            //else
            //    loans = loans.OrderBy(c => c.).ThenBy(t => t.);

            return result;
        }

        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string orderByProperty, bool desc)
        {
            try
            {
                orderByProperty = char.ToUpper(orderByProperty[0]) + orderByProperty.Substring(1);
                string command = desc ? "OrderByDescending" : "OrderBy";
                var type = typeof(TEntity);
                var property = type.GetProperty(orderByProperty);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);
                var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                              source.Expression, Expression.Quote(orderByExpression));
                return source.Provider.CreateQuery<TEntity>(resultExpression);
            }
            catch (Exception)
            {
                throw new ManagedException("نام ستون اشتباه است");
            }
        }
    }
}
