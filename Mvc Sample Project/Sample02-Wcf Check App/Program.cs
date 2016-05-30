using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sample02_Wcf_Check_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start... \n---------------------");
            Console.WriteLine("Pinging : [ http://sampleservice.com/WinService.svc/IsAlive ] \n---------------------"); // //replace service link

            Thread thread = new Thread(new ThreadStart(CheckWcfStatus));
            thread.Start();

            Console.ReadLine();
        }

        static void CheckWcfStatus()
        {
            Thread.CurrentThread.IsBackground = true;
            try
            {
                //süreyi ölçmek adına
                var swatch = Stopwatch.StartNew();

                while (true)
                {
                    swatch.Start();

                    using (var client = new System.Net.WebClient())
                    {
                        client.Encoding = System.Text.Encoding.UTF8;
                        var responseString = client.DownloadString("http://sampleservice.com/WinService.svc/IsAlive"); //replace service link

                        Console.WriteLine("Service Is Alive : " + responseString + " - Total Second : " + swatch.Elapsed.Seconds.ToString());
                    }


                    swatch.Stop();
                    swatch.Reset();

                    Thread.Sleep(new TimeSpan(0, 20, 0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
