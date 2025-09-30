using System.Collections.Generic;
namespace Vierzehn_02
{
    internal class Program
    {
        internal static void WoWSampleSimulation()
        {
          
            Random rnd = new Random();
        }
       

        static void Main(string[] args)
        {

            BadBoss bdbs = new BadBoss(1, 1, "a");
            Warrior wror = new Warrior(1, 1, "a");
            Shaman shmn = new Shaman(1, 1, 1, "a"); 
                
            Console.WriteLine("Attack: {0},Health: {1} Name: {2} ", bdbs.Attack , bdbs.Health ,bdbs.Name);
            Console.WriteLine("Attack: {0},Health: {1} Name: {2}", wror.Attack, wror.Health, wror.Name);
            Console.WriteLine("Attack: {0}, Health: {1}, Heal: {2}, Name: {3}", shmn.Attack,shmn.Health,shmn.Healingvalue,shmn.Name);
            //
            int playercount = 3;
            int deadplayers = 0;
            while (deadplayers < playercount )
            {
                if (wror.Health <= 0) { deadplayers++; Console.WriteLine("Dead" + "DeadPlayers: " + deadplayers);
               
                }
                if(wror.Health < 0) { Console.WriteLine("Ein Untoter"); }
                wror.Health -= bdbs.Attack;
                Console.WriteLine("Warrior.Health: " + wror.Health);
            }
            {

            }
           
            List<int> players = new List<int>();
            
        }
    }
}
