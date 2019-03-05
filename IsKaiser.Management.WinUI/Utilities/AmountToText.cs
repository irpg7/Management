using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.WinUI.Utilities
{
    public static class AmountToText
    {
        public static string ConvertToText(decimal amount)
        {
            string correctedAmount = amount.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = correctedAmount.Substring(0, correctedAmount.IndexOf(',')); //tutarın tam kısmı
            string kurus = correctedAmount.Substring(correctedAmount.IndexOf(',') + 1, 2);
            string convertedText = "";

            string[] oneToTen = { "", "Bir ", "İki ", "Üç ", "Dört ", "Beş ", "Altı ", "Yedi ", "Sekiz ", "Dokuz " };
            string[] TenToHundred = { "", "On ", "Yirmi ", "Otuz ", "Kırk ", "Elli ", "Altmış ", "Yetmiş ", "Seksen ", "Doksan " };
            string[] HundredToTrillion = { "Kattrilyon ", "Trilyon ", "Milyar ", "Milyon ", "Bin ", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int groupNumber = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(groupNumber * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string groupValue;

            for (int i = 0; i < groupNumber * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                groupValue = "";

                if (lira.Substring(i, 1) != "0")
                    groupValue += oneToTen[Convert.ToInt32(lira.Substring(i, 1))] + " Yüz "; //yüzler                

                if (groupValue == "BİRYÜZ") //biryüz düzeltiliyor.
                    groupValue = " Yüz ";

                groupValue += TenToHundred[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                groupValue += oneToTen[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (groupValue != "") //binler
                    groupValue += HundredToTrillion[i / 3];

                if (groupValue == "BİRBİN") //birbin düzeltiliyor.
                    groupValue = " Bin ";

                convertedText += groupValue;
            }

            if (convertedText != "")
                convertedText += " ₺ ";

            int textLength = convertedText.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                convertedText += TenToHundred[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                convertedText += oneToTen[Convert.ToInt32(kurus.Substring(1, 1))];

            if (convertedText.Length > textLength)
                convertedText += " Kr.";
            else
                convertedText += "";

            return convertedText;
        }
    }
}
