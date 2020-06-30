using LoginSampleBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoginSampleBackend.Entities.Concrete
{
    //IEntity, bir veritabanı nesnesi olduğunu ifade ediyor 
    public class UserAccount : IEntity
    {
        [Key]
        public string CustomerId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public int UserState { get; set; } //1-aktif , 2-bloke , 3-iptal //giriş yapabilme durumu
        public DateTime? LastUpdateDate { get; set; }
        public int RecordState { get; set; } // 1-aktif, 2-pasif // kullanıcının kaydının aktif olup olmama durumu
        public string HashType { get; set; }
        public int TrialCount { get; set; } // yanlış şifre deneme sayısı

    }
}
