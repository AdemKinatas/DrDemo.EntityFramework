using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Linq;
using System.Web.Security;

namespace DrDemo_MvcWebUI.Models
{
    public class AppUserRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (var db = new DrDemoContext())
            {
                var userRoleList = from appUser in db.AppUsers
                                   join appUserAndRole in db.AppUserAndRoles on appUser.AppUserId equals appUserAndRole.AppUserId
                                   join role in db.Roles on appUserAndRole.RoleId equals role.RoleId
                                   where appUser.UserName == username
                                   select role.RoleName;

                return userRoleList.ToArray();
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}