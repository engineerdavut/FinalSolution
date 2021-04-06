using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Constants
{
    //instance den kaçmak için newden kaçmak için static
    public static class Messages
    {
        // public fieldlar büyük yazilir.
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";

        public static string MaintenanceTime = " Sistem bakimda ";
        public static string ProductsListed = " urunler listelendi.";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = " Bu isimde başkaürün var";
        public static string CategoryLimitExceded = "Kategori Limiti aşıldı.";
        public static string AuthorizationDenied= " Yetkilendirme Reddedildi. ";
        public static string UserRegistered = " Kullanıcı kayıt edildi.";
        public static string UserNotFound = "Kullanıcı bulunamadi";
        public static string PasswordError = "Sifre Hatali";
        public static string SuccessfulLogin = "Giris basarili";
        public static string UserAlreadyExists = "Kullanici zaten kayıtlı.";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu.";
        public static string ProductUpdated;
    }
}