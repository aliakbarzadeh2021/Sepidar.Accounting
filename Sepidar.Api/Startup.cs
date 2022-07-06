using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Sepidar.Repository;
using Sepidar.Repository.Implementation;
using Sepidar.api.Base;
using Sepidar.api.Base.JsonConverters;
using Sepidar.api.Base.SeedData;
using Sepidar.api.Base.Validators;
using Sepidar.Api;
using Sepidar.Api.Activators.Middlewares;
using Sepidar.Logger.Context;
using Sepidar.Logger.Implements;

namespace Sepidar.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("*")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            services.AddControllers().AddJsonOptions(opt =>
            {
                //opt.JsonSerializerOptions.Converters.Add(new EnumJsonConverter());
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                opt.JsonSerializerOptions.Converters.Add(new PersianDateTimeConverter());
                opt.JsonSerializerOptions.Converters.Add(new GuidJsonConverter());
                opt.JsonSerializerOptions.Converters.Add(new IntToStringConverter());
                opt.JsonSerializerOptions.Converters.Add(new LongToStringConverter());
                opt.JsonSerializerOptions.Converters.Add(new DictionaryInt32Converter());
                opt.JsonSerializerOptions.Converters.Add(new DictionaryInt64Converter());
                opt.JsonSerializerOptions.Converters.Add(new DictionaryTKeyEnumTValueConverter());
                opt.JsonSerializerOptions.WriteIndented = true;
            });
            //services.AddControllers().AddNewtonsoftJson();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ExceptionLogger>();
            //services.AddTransient<PermissionActionFilter>();

            this.ConfigureServicesForDbContexts(services);

            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Main")));

            services.AddDbContext<LogContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("LogDb")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseCustomExceptionHandler();
            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers().RequireCors(MyAllowSpecificOrigins); });
        }

        private void ConfigureServicesForDbContexts(IServiceCollection services)
        {
            // Register db contexts
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("Main")));
            services.AddDbContext<LogContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("LogDb")));

            // configure jwt authentication
            var jwtIssuerOptions = Program.AppSettingsInfo.JwtIssuerOptions;

            services.AddScoped<IJwtTokenValidator, JwtTokenValidator>();

            SymmetricSecurityKey signingKey =
                new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(jwtIssuerOptions.SecretKey));

            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtIssuerOptions.Issuer;
                options.Audience = jwtIssuerOptions.Audience;
                options.SecretKey = jwtIssuerOptions.SecretKey;
                options.ExpireTimeTokenInMinute = jwtIssuerOptions.ExpireTimeTokenInMinute;
                options.ValidTimeInMinute = jwtIssuerOptions.ValidTimeInMinute;
                options.SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            });

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtIssuerOptions.Issuer,

                ValidateAudience = true,
                ValidAudience = jwtIssuerOptions.Audience,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, configureOptions =>

            {
                configureOptions.ClaimsIssuer = jwtIssuerOptions.Issuer;
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin",
                    authBuilder => { authBuilder.RequireRole("Admin"); });

                options.AddPolicy("User",
                    authBuilder => { authBuilder.RequireRole("User"); });
            });
            // api user claim policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiUser",
                    policy => policy.RequireClaim(AuthDataService.JwtClaimIdentifiers.Rol,
                        AuthDataService.JwtClaims.ApiAccess));
            });
        }
    }
}
