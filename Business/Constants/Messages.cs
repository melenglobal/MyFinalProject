using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
