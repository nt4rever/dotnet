using Microsoft.OpenApi.Models;

namespace Learning.Configs
{
    public class Swagger
    {
        public static Action<Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenOptions> GetConfig()
        {
            return (options) =>
            {
                // set up api documentation with swagger
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "API (learning NET Core)", Version = "v1" });

                // set up bearer token
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            };
        }

    }
}
