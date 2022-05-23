using System.Collections.Generic;
using sourcetree.Roles.Dto;

namespace sourcetree.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
