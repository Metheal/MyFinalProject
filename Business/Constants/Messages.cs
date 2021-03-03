using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi!";
        public static string ProductNameInvalid = "Urun ismi gecersiz!";
        public static string MaintenanceTime = "Sistem bakimda!";
        public static string ProductsListed = "Urunler listelendi!";
        public static string ProductUpdated = "Urun Guncellendi!";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 urun olabilir!";
        public static string ProductNameAlreadyExists = "Bu isimde zaten baska bir urun var!";
        public static string CategoryLimitExceeded = "Kategori limiti asildigi icin yeni urun eklenemiyor!";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kullanici kaydi basarili!";
        public static string UserNotFound = "Kullanici bulunamadi!";
        public static string PasswordError = "Parola hatali!";
        public static string SuccessfulLogin = "Giris basarili!";
        public static string UserAlreadyExists = "Kullanici mevcut!";
        public static string AccessTokenCreated = "Token olusturuldu!";
    }
}
