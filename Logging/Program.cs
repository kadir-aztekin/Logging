using System;
using System.IO;

namespace Logging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loglama(); 
        }

        private static void Loglama()
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı == 3)
                {
                    throw new Exception("Yanlış Sayı");
                }
            }
            catch (Exception hata)
            {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd,MM,yyyy HH:mm"));
                File.AppendAllText("log.txt","\r\n");
                File.AppendAllText("log.txt", hata.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", hata.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine+"*****"+Environment.NewLine);







            }

        }
    }
}
