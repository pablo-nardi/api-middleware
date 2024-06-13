using ApiDevolverJson.Controllers;

namespace ApiDevolverJson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(
                options =>
                {
                    options.AddPolicy("CorsBasico",
                        policy =>
                        {
                            policy.WithOrigins("http://localhost:52330");
                        });
                });

            builder.Services.AddControllers();            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            /*if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }*/

            app.UseHttpsRedirection();
            app.UseCors();
            app.UseAuthorization();
            app.MapControllers();
            //app.MapPersonaEndpoints();
            
            app.Run();
        }
    }
}