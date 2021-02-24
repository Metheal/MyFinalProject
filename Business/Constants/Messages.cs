﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
