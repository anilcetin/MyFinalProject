using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string UnitPriceInvalid = "Ürün fiyatı hatalı";
        public static string ProductCountOfCategoryError = "Bir kategoride maksimum 10 farklı ürün olabilir";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemez";
        public static string AuthorizationDenied = "Yetkilendirme reddedildi";
    }
}
