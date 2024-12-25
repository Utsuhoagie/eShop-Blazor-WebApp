namespace eShop.Components.Features.App.Products;

public class Product
{
	public int Id { get; private set; }

	public string Name { get; private set; }
	public float Price { get; private set; }

	public static Product Create(string name, float price) => new()
	{
		Name = name,
		Price = price,
	};
}