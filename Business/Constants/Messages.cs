using System;
using System.Collections.Generic;
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
    }
}
