using System.Collections.Generic;
using sourcetree.Roles.Dto;

namespace sourcetree.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}