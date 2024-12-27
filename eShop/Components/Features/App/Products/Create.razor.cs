using eShop.Data;
using Microsoft.AspNetCore.Components;

namespace eShop.Components.Features.App.Products;

record CreateProductForm
{
	public string Name = string.Empty;
	public float Price;
}

public partial class Create
{
	[SupplyParameterFromForm] CreateProductForm Form { get; set; } = new();
	[Inject] EShopContext Context { get; set; } = null!;
	[Inject] NavigationManager NavMan { get; set; } = null!;

	async Task Submit()
	{
		var product = Product.Create(Form.Name, Form.Price);

		Context.Products.Add(product);
		await Context.SaveChangesAsync();

		NavMan.NavigateTo("/products");
	}
}