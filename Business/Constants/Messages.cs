using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün Eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Ürünler Listelendi";
        public static string UsersNameInvalid = "Kullanıcı İsmi Geçersiz";
        public static string CarNoReturnDate = "Araba Teslim Edilmemiş";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string CarImageAdded = "Araç görseli eklendi.";
        public static string CarImageDeleted = "Araç görseli silindi.";
        public static string CarImageUpdated= "Araç görseli güncellendi.";
        public static string AuthorizationDenied= "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola yanlış.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string UserRegistered = "Kayıt başarılı.";
        public static string AccessTokenCreated = "Erişim belirteci oluşturuldu.";
        public static string RentalDetailListed = "Kiralama detayları listelendi.";
    }
}
