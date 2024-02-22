using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningTask
{
    public class Merhaba
    {
        static async Task Main(string[] args)  
        {
            Console.WriteLine("Bir selam ver: ");
            string Selam = await Selamla();
            Console.WriteLine($"Al sana selam: {Selam}");
        }

        static async Task<string> Selamla()
        {

            Console.WriteLine("biraz bekle be!");
            await Task.Delay(2000);

            return "merhaba";


        }
             

    }
}
