using CinemaBlazor.Client.Services;
using CinemaBlazor.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CinemaBlazor.Client.IServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IActorService, ActorService>();
builder.Services.AddScoped<IDirectorService, DirectorService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IPromotionServise, PromotionService>();
builder.Services.AddScoped<ICinemaService, CinemaService>();
builder.Services.AddScoped<IFilmGenreService, FilmGenreService>();
builder.Services.AddScoped<IFilmService, FilmService>();
builder.Services.AddScoped<IFilmDirectorService, FilmDirectorService>();
builder.Services.AddScoped<IFilmActorService, FilmActorService>();
builder.Services.AddScoped<IRateService, RateService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ILikeActorService, LikeActorService>();
builder.Services.AddScoped<ILikeDirectorService, LikeDirectorService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<IInvoiceDetailService, InvoiceDetailService>();

await builder.Build().RunAsync();
