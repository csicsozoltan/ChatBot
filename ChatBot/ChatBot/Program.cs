using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class Program
    {
        static void botTurn()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void meTurn()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void Main(string[] args)
        {
            Console.Title = "ChatBot";
            Random rnd = new Random();
            string joke1 = "A pap kimegy a hegyekbe sétálni amikor hirtelen kibukkan a sűrűből egy medve. \n Elkezd rohanni, a medve utána. Látja, hogy semmi esélye már, ezért letérdel és elkezd imádkozni: \n-Istenem add, hogy ez a medve irgalmas keresztény legyen! \nIsten meghallgatta az imát, ezért a medve, mielőtt megette volna a papot, letérdelt és így szólt:\n-Édes Jézus légy vendégünk, áldd meg amit adtál nékünk, ÁMEN!";
            string joke2 = "Egy részeg ül a kocsmában. Kér tíz felest és megissza. Ezután kilencet kér, \n és azt is megissza. Azután 8, 7, majd hat felest húz le egymás után, majd megszólal:\n - Nem értem... Egyre kevesebbet iszom, mégis egyre részegebb vagyok!";
            string joke3 = "-Mi lesz a csipet csapat ha felrobban? \n -???\n -Cifet Cafat";
            string joke4 = "-Hány órát alszol egy nap Móricka? -kérdezi az iskola orvos \n -Két-három órát. \n -Jajj.de hát ez nagyon kevés! \n -Mind az öt órán nem merek aludni.";
            string joke5 = "A csatár sorozatban hagyja ki a jobbnál jobb helyzeteket. Amikor már \n tizedszer lő az üres kapu fölé két lépésről, szomorúan fordul a \n játékostársához: \n -Úgy látszik ma nincs szerencsém! \n -Dehogy nincs ez a mi kapunk!";
            string joke6 = "-Pistike! Először fordult elő, hogy hibátlan házi feladatot adtál be. Hogy \n lehet ez? \n -Az apukám elutazott hétvégére és nem tudott segíteni.";
            string[] jokes = { joke1, joke2, joke3, joke4, joke5, joke6};
            botTurn();
            Console.WriteLine("Szia! Az én nevem ChatBot. Téged hogy hívnak?");
            meTurn();
            string userName = Console.ReadLine();
            botTurn();
            Console.WriteLine("Ó, imádom azt a nevet hogy " + userName + "! És hogy vagy ma?");
            meTurn();
            string howAreU = Console.ReadLine();
            if (howAreU == "szarul" || howAreU == "Szarul" || howAreU == "rosszul" || howAreU == "Rosszul")
            {
                botTurn();
                Console.WriteLine("Az nem jó. Mi a baj?");
                meTurn();
                string problemOne = Console.ReadLine();
                botTurn();
                Console.WriteLine("Értem... Fel tudnálak vidítani egy viccel?");
                string jokeTF = Console.ReadLine();
                if (jokeTF == "igen" || jokeTF == "Igen")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(jokes[rnd.Next(0, 7)]);
                }
                else
                {
                    botTurn();
                    Console.WriteLine("Értem...");
                }
            }
            botTurn();
            Console.WriteLine("Melyik a kedvenc zenei műfajod?");
            meTurn();
            string favKindOfMusic = Console.ReadLine();
            botTurn();
            Console.WriteLine("Ó, az nagyon jó! Én is szeretek " + favKindOfMusic + "-t hallgatni. Az én kedvenc műfajom a RoboMusic. És a kedvenc zenéd micsoda?");
            meTurn();
            string favMusic = Console.ReadLine();
            botTurn();
            Console.WriteLine("Az egy tök jó szám! Az én kedvencem a LK-9000. Van kedvenc gyorséttermed?");
            meTurn();
            string favRestTF = Console.ReadLine();
            if (favRestTF == "igen" || favRestTF == "Igen" || favRestTF == "van" || favRestTF == "Van")
            {
                botTurn();
                Console.WriteLine("Mi az?");
                meTurn();
                string favRest = Console.ReadLine();
                botTurn();
                Console.WriteLine(favRest + "? Fincsik ott a kaják, de az én kedvencem a GépZsírozó, próbáld ki ");
            }
            else
            {
                botTurn();
                Console.WriteLine("Nincs... Kevés ilyen ember van!");
            }
            botTurn();
            Console.WriteLine("Mi a hobbid?");
            meTurn();
            string hobby = Console.ReadLine();
            botTurn();
            Console.WriteLine(hobby + "? Azzal könnyen el lehet ütni az időt. Az én kedvencem a robottánc.");
            Console.WriteLine("Köszönjük hogy kipróbálta a(z) ChatBot szolgáltatásunkant!");
            //A vége elött
            Console.ReadKey();
        }
    }  
}
