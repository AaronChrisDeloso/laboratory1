using System.Collections.Generic;
using sourcetree.Roles.Dto;

namespace sourcetree.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
