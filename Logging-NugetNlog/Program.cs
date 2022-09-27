using NLog;
using System;

namespace Logging_NugetNlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commander test = new Commander();
            test.StartTransaction();
            test.StopTransaction();
            test.DoSomething();
        }
    }
     class Commander
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public void StartTransaction()
        {
            logger.Info("Transaction başlatıldı");
        }
        public void DoSomething()
        {
            logger.Fatal("Abc servisi çalışmıyor");
            logger.Error("Db bağlantısı sağlanamadı");
        }
        public void StopTransaction()
        {
            logger.Warn("Transaction sonlandı fakat işlemler çalışmıyor");
        }
    }
}
