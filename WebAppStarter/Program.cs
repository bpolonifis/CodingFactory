namespace WebAppStarter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            // Ordering of Middleware is Important!!
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); // Hsts = Http strick transport security -> https
            }

            app.UseHttpsRedirection();

            app.UseDefaultFiles(); //https://localhost:5001/Index razorpage ean einai energo auto

            app.UseStaticFiles();

            app.UseRouting();
            //Authenctication()
            app.UseAuthorization();

            app.MapRazorPages();

            //minimal endpoints  - lightweight services RESTful Webservices (WS)
            app.MapGet("/hello", () => "Hello Coding Factory"); // i apli logiki se aggistra, prototype or test

            app.Run();
            Console.WriteLine("Thanks for using our app");
        }
    }
}