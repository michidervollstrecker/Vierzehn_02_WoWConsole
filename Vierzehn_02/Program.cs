namespace Vierzehn_02
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Geben Sie die SpielerZahl ein: ");
            int pcount = int.Parse(Console.ReadLine());
            int ip = 1;
            for (int i = 0; i < pcount; i++)
            {
                Console.WriteLine("Wählen Sie aus\n [1]_BadBoss \n [2]_Warrior \n [3]_Shaman \n [4]_Shield");
                int pclass = int.Parse(Console.ReadLine());
                if (pclass == 1)
                {
                    bool boolbs = true;
                    Console.WriteLine("BadBoss ausgewählt, Namen eingeben: ");
                    BadBoss badBss = new BadBoss();
                    badBss.Name = Console.ReadLine();
                    badBss.Attack = rnd.Next(600, 1000);
                    badBss.Health = rnd.Next(2000, 3000);
                    badBss.Defense = rnd.Next(500, 600);
                }
                if (pclass == 2)
                {

                    bool war = true;
                    Console.WriteLine("Warrior ausgewählt, Namen eingeben: ");
                    Warrior warr = new Warrior();
                    warr.Name = Console.ReadLine();
                    warr.Attack = rnd.Next(200, 350);
                    warr.Health = rnd.Next(1000, 1500);
                    warr.Defense = rnd.Next(800, 1200);
                }
                if (pclass == 3)
                {
                    bool sham = true;
                    Console.WriteLine("Schaman ausgewählt, Namen eingeben: ");
                    Shaman shama = new Shaman();
                    shama.Name = Console.ReadLine();
                    shama.Attack = rnd.Next(50, 100);
                    shama.Defense = rnd.Next(100, 200);
                    shama.Health = rnd.Next(500, 1000);
                }
                if (pclass == 4)
                {
                    bool shld = true;
                    Console.WriteLine("Shield ausgewählt, Namen eingeben: ");
                    Shield shield = new Shield();
                    shield.Name = Console.ReadLine();
                    shield.Attack = rnd.Next(200, 500);
                    shield.Defense = rnd.Next(1000, 2000);
                    shield.Health = rnd.Next(2000, 3000);
                }
                ip++;
            }
        }
    }
    public class BadBoss
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }

    }
    public class Warrior()
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
    }
    public class Shaman
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Healingvalue { get; set; }
        public string Name { get; set; }
    }
    public class Shield
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
    }
}
