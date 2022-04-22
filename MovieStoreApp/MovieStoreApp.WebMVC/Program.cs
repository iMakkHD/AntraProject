using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Infrastructure.Service;
using MovieStoreApp.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

//code below this was written in configureservices method
#region ConfigureServices
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MovieStore"));
});

//services
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
builder.Services.AddScoped<IFavoriteServiceAsync, FavoriteServiceAsync>();
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<IMovieCastServiceAsync, MovieCastServiceAsync>();
builder.Services.AddScoped<IMovieGenreServiceAsync, MovieGenreServiceAsync>();
builder.Services.AddScoped<IPurchaseServiceAsync, PurchaseServiceAsync>();
builder.Services.AddScoped<IReviewServiceAsync, ReviewServiceAsync>();
builder.Services.AddScoped<IRoleServiceAsync, RoleServiceAsync>();
builder.Services.AddScoped<ITrailerServiceAsync, TrailerServiceAsync>();
builder.Services.AddScoped<IUserServiceAsync, UserServiceAsync>();
builder.Services.AddScoped<IUserRoleServiceAsync, UserRoleServiceAsync>();


//repository
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
builder.Services.AddScoped<IFavoriteRepository, FavoriteRepositoryAsync>();
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();
builder.Services.AddScoped<IMovieGenreRepositoryAsync, MovieGenreRepositoryAsync>();
builder.Services.AddScoped<IPurchaseRepositoryAsync, PurchaseRepositoryAsync>();
builder.Services.AddScoped<IReviewRepositoryAsync, ReviewRepositoryAsync>();
builder.Services.AddScoped<IRoleRepositoryAsync, RoleRepositoryAsync>();
builder.Services.AddScoped<ITrailerRepositoryAsync, TrailerRepositoryAsync>();
builder.Services.AddScoped<IUserRepositoryAsync, UserRepositoryAsync>();
builder.Services.AddScoped<IUserRoleRepositoryAsync, UserRoleRepositoryAsync>();
#endregion

//code below this was written in configure method and it will contain middleware
// and environment related code
#region Configure
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
#endregion