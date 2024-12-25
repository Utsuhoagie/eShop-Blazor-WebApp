namespace eShop.Components.Features.Auth.Models;

public class User
{
	public int Id { get; private set; }

	public string Username { get; private set; }
	public string Email { get; private set; }
	public string PasswordHash { get; private set; }

	public static User Create(string username, string email, string passwordHash) => new()
	{
		Username = username,
		Email = email,
		PasswordHash = passwordHash,
	};
}