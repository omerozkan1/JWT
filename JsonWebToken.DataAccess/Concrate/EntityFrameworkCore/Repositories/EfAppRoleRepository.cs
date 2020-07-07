using JsonWebToken.DataAccess.Interfaces;
using JsonWebToken.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.DataAccess.Concrate.EntityFrameworkCore.Repositories
{
    public class EfAppRoleRepository : EfGenericRepository<AppRole>, IAppRoleDal
    {
    }
}
