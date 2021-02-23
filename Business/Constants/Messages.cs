using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarValueInvalid = "Araç minimum kiralama değeri çok düşük,Tekrar Deneyiniz";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarsListedFailed = "Bu saatler içerisinde araçları göremezsiniz";
        public static string UserNameInvalid = "Kullanıcı Adı yeterli uzunlukta değil!";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserFound = "Kullanıcı Bulundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string RentFail = "Kiralamak istediğiniz araç henüz teslim edilmemiştir";
        public static string RentSuccess = "Kiralama işleminiz başarılı,Mutlu Yolculuklar";
        public static string CarUpdated = "Araç başarıyla güncellendi";
        public static string CarDeleted = "Araç silindi";
    }
}
