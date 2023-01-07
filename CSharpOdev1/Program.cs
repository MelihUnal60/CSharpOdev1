namespace CSharpOdev1
{
    public class Program
    {
        public static void Main()
        {
            bool dogruMu;
            string secim = " ";
            do
            {
                #region İşlemler
                Console.Clear();
                Console.WriteLine("Merhaba, kliğinimize hoş geldiniz. Lütfen sizden istenen bilgileri giriniz.");
                Console.Write("Lütfen boy ölçünüzü metre cinsinden giriniz : ");
                double boy = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nLütfen kilonuzu giriniz : ");
                int kilo = Convert.ToInt32(Console.ReadLine());

                double VKI = kilo / (boy * boy);
                string teshis = " ";
                
                

                if (VKI < 18.49)
                {
                    teshis = "Zayıf Hasta";
                }
                else if (VKI >= 18.49 && VKI < 24.99)
                {
                    teshis = "İdeal Kiloda Hasta";
                }
                else if (VKI >= 24.99 && VKI < 29.99)
                {
                    teshis = "Hafif Kilolu Hasta";
                }
                else if (VKI >= 29.99)
                {
                    teshis = "Obez Hasta";
                }

                Console.WriteLine("Hastanın boyu : " + boy + " Hastanın kilosu : " + kilo + " VKI : " + VKI + " Teşhis : " + teshis);
                #endregion

                
                do
                {

                    Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunuz ? (E/H)");
                    secim = Console.ReadLine();
                    if (secim == "E" || secim == "H" || secim == "e" || secim=="h")
                    {
                        dogruMu = false;
                    }else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız");
                        dogruMu = true;
                    }
                    
                } while (dogruMu == true);
               
            } while (secim == "E" || secim == "e");
            
        }
    }

}