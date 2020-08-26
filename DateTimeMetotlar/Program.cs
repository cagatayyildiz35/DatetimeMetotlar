using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            string data = x.ToString();

            DateTime date;

            //Mevcut tarihi verir
            date = DateTime.Now;

            //Mevcut tarihin ayını ver
            //int ay = date.Month;
            int ay = DateTime.Now.Month;

            //Mevcut tarihin gününü ver
            int day = date.Day;

            //Mevcut tarih yılı
            int year = date.Year;

            //yılın kaçıncı günü
            int dayofyear = date.DayOfYear;

            //Mevcut tarihe 3 gün sonraya git
            DateTime yeni;

            //yeni = date.AddDays(3);

            //Mevcut tarihten 3 gün geriye git
            yeni = date.AddDays(-28);


            string format1 = date.ToShortDateString();
            string format2 = date.ToLongDateString();
            string format3 = date.ToShortTimeString();
            string format4 = date.ToLongTimeString();

            //özel formatlar
            string format5 = date.ToString("dd.MM.yyyy");
            string format6 = date.ToString("dd MMMM yyyy dddd");

            //26 Ağustos Çarşamba
            string format7 = date.ToString("dd MMMM dddd");


            //26.08.2020 10:15
            string format8 = date.ToString("dd.MM.yyyy hh:mm");


            //DateTime dt = Convert.ToDateTime("08 13 2020");




            //DateTime launchDate = new DateTime(2020, 8, 1, 0, 0, 0);
            //DateTime now = DateTime.Now;
            //TimeSpan ts = launchDate - now;

            //ayın 1 inden bugüne kaç gün geçti?

            DateTime launchdate = new DateTime(2020, 8, 1, 0, 0, 0);
            DateTime now = DateTime.Now;

            TimeSpan ts = launchdate - now;

            int d = ts.Days;



            Console.WriteLine(d);
            Console.ReadLine();



            ;
        }
    }
}
