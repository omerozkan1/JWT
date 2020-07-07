using JsonWebToken.Business.Interfaces;
using JsonWebToken.DataAccess.Interfaces;
using JsonWebToken.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.Business.Concrate
{
    public class AppUserRoleManager : GenericManager<AppUserRole>, IAppUserRoleService
    {
        public AppUserRoleManager(IGenericDal<AppUserRole> genericDal) : base(genericDal)
        {

        }
    }
}
