using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    // static verdiğimizde new'lemiyoruz.
    //public PascalCase yazılır.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürün categori uyuşmazlığı";
        public static string ProductNameAlreadyExists = "Aynı isme sahip ürün var.";
        public static string CategoryLimitExceded = "Kategori limitini aştı";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered = "Kayıt yapıldı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Access token oluşturuldu";
        public static string SuccessfulLogin = "Giriş başarılı";
    }
}

