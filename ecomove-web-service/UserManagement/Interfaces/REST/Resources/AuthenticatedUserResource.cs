namespace ecomove_web_service.UserManagement.Interfaces.REST.Resources;

public record AuthenticatedUserResource(int UserId, string Username, string Token);