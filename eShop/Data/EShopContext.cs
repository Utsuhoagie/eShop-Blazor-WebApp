using eShop.Components.Features.App.Products;
using eShop.Components.Features.Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data;

public class EShopContext : DbContext
{
	public EShopContext(DbContextOptions<EShopContext> options) : base(options)
	{
	}

	public DbSet<User> Users { get; set; }

	public DbSet<Product> Products { get; set; }
}