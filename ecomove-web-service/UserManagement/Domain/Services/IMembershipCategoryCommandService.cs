using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Model.Entities;

namespace ecomove_web_service.UserManagement.Domain.Services;

/**
 * IMembershipCategoryCommandService interface
 * Represents a service for membership categories
 */
public interface IMembershipCategoryCommandService
{
    public Task<MembershipCategory?> Handle(CreateMembershipCategoryCommand command);
}