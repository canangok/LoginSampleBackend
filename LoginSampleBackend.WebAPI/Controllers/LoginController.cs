using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginSampleBackend.Business.Abstract;
using LoginSampleBackend.Business.Helpers;
using LoginSampleBackend.Entities.Concrete;
using LoginSampleBackend.Entities.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;

namespace LoginSampleBackend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IUserAccountService _userAccountService;

        public LoginController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        
        }

        [HttpPost("add")]
        public IActionResult Add(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                _userAccountService.Add(userLoginDto);
                return Ok("Ekleme işlemi başarılı");
            }
            return BadRequest("Ekleme işlemi başarısız");
           
        }

        [HttpPost("signin")]
        public IActionResult SignIn([FromBody] UserLoginDto userLoginDto)
        {
            
            var user = _userAccountService.Get(userLoginDto);

            if (user != null)
            {
               //burda son işlem tarihini güncelledim.
                user.LastUpdateDate = DateTime.Now;

                //Veritabanına kayıtlı hashlenmiş password ile kullanıcıdan gelen passwordü hashleyip kıyaslanıyor
                //iki hash birbinin aynısı ise şifre doğrudur
                if (user.PasswordHash == (new PasswordEncode().Encoder(userLoginDto.Password)))
                {           
                    //Son giriş tarihini güncelliyorum
                    user.LastLoginTime = DateTime.Now;
                    _userAccountService.Update(user);

                    return Ok(); //Giriş işlemi başarılı
                }
                else
                {
                    //şifre yanlış ise deneme sayısını arttır
                    user.TrialCount++;
                    if (user.TrialCount == 3)// değer 3 e ulaştı mı diye kontrol ediliyor 
                    {
                        //eğer 3 e ulaştıysa UserState, Bloke durumu olan 2 yapılıyor
                        user.UserState = 2;
                    }                  

                }
                //tüm bunlar güncelleniyor
                _userAccountService.Update(user);
               
            }
          
            return BadRequest("Giriş işlemi başarısız");//null

        }
    }
}
