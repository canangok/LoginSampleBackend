using LoginSampleBackend.Core.DataAccess;
using LoginSampleBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginSampleBackend.DataAccess.Abstract
{
   
    public interface IUserAccountDal :  IEntityRepository<UserAccount>
    {
        
    }
}
