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
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Böyle bir ürün yok ama çok satıyorsa kesin koyarız!";
        public static string MaintenanceTime = "Sisteme bişeyler oldu,birisinin ayağı kablolara takılmış olabilir. Önce o birisini sonra kabloları bulmaya çalışıyoruz.";
        public static string ProductsListed = "Ürünler ayağınıza geldi !";
        public static string ProductCountOfCategoryError = "Sepetiniz doldu taştı !";
        public static string ProductNameAlreadyExists = "Bir ipte iki cambaz oynamaz!(Bu isimde başka bir ürün zaten var)";
        public static string CategoryLimitExceded = "Basit bir şekilde Anasayfaya mı tıklasan ?";
        public static string AuthorizationDenied = "Hop Birader nereye ?";

        public static string UserRegistered = "Çırak koş iki çay kap bize,buyrun buyrun hoşgeldiniz!";
        public static string SuccessfulLogin = "Özlettiniz cüzdanınızı,nerelerdesiniz?";
        public static string UserAlreadyExists = "Git bak bakalım ben içerdemiyim?-(Başka bir kullanıcı adı deneyiniz.)";
        public static string AccessTokenCreated ="Başarılı bir şekilde süper kahraman girişi yaptınız!";

        public static string UserNotFound = "Aradım,taradım valla böyle birisini bulamadım.";
        public static string PasswordError = "Girdiğin şifre ya da kullanıcı adın ile elimdeki bilgiler eşleşmiyor.Bi kaç tur dene istersen.";
    }
}
