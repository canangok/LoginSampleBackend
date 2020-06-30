using LoginSampleBackend.Core.DataAccess;
using LoginSampleBackend.Core.EntityFramework;
using LoginSampleBackend.DataAccess.Abstract;
using LoginSampleBackend.DataAccess.Concrete.EntityFramework.Contexts;
using LoginSampleBackend.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginSampleBackend.DataAccess.Concrete.EntityFramework
{
    
    public class EfUserAccountDal : EfEntityRepositoryBase<UserAccount, LoginSampleContext>, IUserAccountDal
    {

    }
}
