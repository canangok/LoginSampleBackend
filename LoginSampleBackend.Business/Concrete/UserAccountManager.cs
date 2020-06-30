using LoginSampleBackend.Business.Abstract;
using LoginSampleBackend.Business.Helpers;
using LoginSampleBackend.DataAccess.Abstract;
using LoginSampleBackend.Entities.Concrete;
using LoginSampleBackend.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginSampleBackend.Business.Concrete
{
    public class UserAccountManager : IUserAccountService
    {
        //burada önyüzden gelen inputları işleyeceğiz
        private IUserAccountDal _userAccountDal;
        public UserAccountManager(IUserAccountDal userAccountDal)
        {
            _userAccountDal = userAccountDal;
        }
        public void Add(UserLoginDto userLoginDto)
        {
            UserAccount user = new UserAccount
            {
                CustomerId = Guid.NewGuid().ToString(),
                Username = userLoginDto.Username,
                PasswordHash = new PasswordEncode().Encoder(userLoginDto.Password), // SHA256
                UserState = 1,
                RecordState = 1,
                LastUpdateDate = DateTime.Now,
                HashType = "SHA256"
            };
            _userAccountDal.Add(user);
        }

        public UserAccount Get(UserLoginDto userLoginDto)
        {
            //Gelen Username ile kayıtlı bir kullanıcı varsa ve recorState durumu ve Userstate durumu aktif olan kullanıcıyı getir
            UserAccount dbuser = _userAccountDal.Get(p => p.Username == userLoginDto.Username && p.RecordState == 1 && p.UserState == 1);

            if (dbuser != null)
            {
                return dbuser;
            }
            return null;

        }

        public void Update(UserAccount userAccount)
        {
            _userAccountDal.Update(userAccount);
        }
    }
}
