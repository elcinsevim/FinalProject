using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime ="sistem bakımda";
        public static string ProductListed ="ürünler listelendi";
        public static string ProductCountOfCategoryError = "ürün sınırını aştınız";
        public static string ProductNameAlreadyExists = "aynı isimde ürün var";
        public static string ProductAddNot = "kategori sayısının üzerine cıkıldı";
        internal static string AuthorizationDenied = "yetkiniz yok";
        //publicler pascalcase yazılır
    }
}
