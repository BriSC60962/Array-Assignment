using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{
    class Program
    {
        static int weapon = 0;

        static int[] ammo = new int[6];
        static string[] weaponName = new string[6];

        static void Main(string[] args)
        {
            Console.WriteLine("arrays Assignment");
            Console.WriteLine("By: Brianna Chisholm");
            Console.WriteLine("///////////////////");
            Console.WriteLine();
            Console.WriteLine();
           
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 10;
            ammo[3] = 4;
            ammo[4] = 20;
            ammo[5] = 12;

            
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Spreader";
            weaponName[3] = "Laser";
            weaponName[4] = "Sniper";
            weaponName[5] = "BFG";


            GunRack(); //Calls for weapon information like current weapon name and ammo amount
            Console.ReadKey(true);
            Console.WriteLine();
            weapon = weapon + 1;
            Console.WriteLine("Player picks up " + weaponName[weapon] + "!");
            Console.ReadKey(true);
            Console.WriteLine();
            GunRack(); 
            Console.ReadKey(true);

            Console.WriteLine();
            weapon = weapon + 1;
            Console.WriteLine("Player picks up " + weaponName[weapon] + "!");
            Console.ReadKey(true);
            Console.WriteLine();
            GunRack();
            Console.ReadKey(true);
            Console.WriteLine();

            weapon = weapon + 1;
            Console.WriteLine("Player picks up " + weaponName[weapon] + "!");
            Console.ReadKey(true);
            Console.WriteLine();
            GunRack();
            Console.ReadKey(true);

            Console.WriteLine();
            weapon = weapon + 1;
            Console.WriteLine("Player picks up " + weaponName[weapon] + "!");
            
            Console.ReadKey(true);
            Console.WriteLine();
            GunRack();
            Console.ReadKey(true);
            Console.WriteLine();
            weapon = weapon + 1;
            Console.WriteLine("Player picks up " + weaponName[weapon] + "!");
            
            Console.ReadKey(true);
            Console.WriteLine();
            GunRack();
            Console.ReadKey(true);

            

           


            
        }
        static void GunRack() // displays current weapon and ammo
        {
            if (weapon > 5)
            {
                weapon = 5; // range checking
            }

            if (weapon < 0)
            {
                weapon = 0; // range checking
            }

            if (weapon == 0)
            {
                Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[0]);
            }
            else if (weapon == 1)
            {
                Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[1]);
            }
            else if (weapon == 2)
            {
                Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[2]);
            }
            else if (weapon == 3)
            {
                Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[3]);
            }
            else if (weapon == 4)
            {
                Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[4]);
            }
            else if (weapon == 5)
            {
                Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[5]);
            }
        }
       
        
    }
}
