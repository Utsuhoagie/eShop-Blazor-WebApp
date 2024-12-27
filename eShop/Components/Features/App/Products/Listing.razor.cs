using eShop.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace eShop.Components.Features.App.Products;

[StreamRendering]
public partial class Listing
{
	[Inject] private EShopContext Context { get; set; } = default!;

	List<ProductResponse> Products = [];

	protected override async Task OnInitializedAsync()
	{
		Products = await Context.Products
			.AsNoTracking()
			.Where(p => true)
			.Select(p => ProductResponse.New(p))
			.ToListAsync();
	}
}