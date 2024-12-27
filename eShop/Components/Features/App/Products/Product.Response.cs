namespace eShop.Components.Features.App.Products;

record ProductResponse
{
	public int Id { get; private set; }
	public string Name { get; private set; } = string.Empty;
	public string Price { get; private set; } = string.Empty;

	public static ProductResponse New(Product product) => new()
	{
		Id = product.Id,
		Name = product.Name,
		Price = $"${product.Price}",
	};
}