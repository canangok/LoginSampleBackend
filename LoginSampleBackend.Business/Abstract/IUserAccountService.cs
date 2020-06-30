using LoginSampleBackend.Entities.Concrete;
using LoginSampleBackend.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginSampleBackend.Business.Abstract
{
    public interface IUserAccountService
    {
        void Add(UserLoginDto userLoginDto);
        void Update(UserAccount userAccount);
        UserAccount Get(UserLoginDto userLoginDto);
    }
}
