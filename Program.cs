using System;
using System.Text;
using WarriorMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main()
    {
        const string WelcomeMSG = "This is a game about a knight";
        const string MenuMSG = "Choose what to do";
        const string FormatError = "must be a number";
        const string RangeError = "must be between 1 and 5";
        const string ThxForPlay = "thanks for playing, have a good day";
        const string DamageMSG = "you taked {0} damage, now you have {1} hp";
        const string HealMSG = "you healed {0} hp, now you have {1} hp";
        const string CurrentStats = "\nyour current stats are:\nhp: {0}\nstatus: {1}\nspeed: {2}\nattack: {3}\ncanRun: {4}\nscreenColour: {5}\n";

        int option= 0;
        int hp = 100;
        int speed = 100;
        int attack = 100;
        int damage = 0;
        int heal;
        bool canRun;
        bool validOption= false;
        string screenColour;
        string status;
        string[] menuOptions= {"1 - view stats","2 - take damage","3 - take heal","4 - run","5 - attack","0 - exit"};
        Random rnd = new Random();
        Console.WriteLine(WelcomeMSG);
        do
        {
            WarriorUtils.CalculateWarriorStatus(hp, out status, out speed, out attack, out canRun, out screenColour);
            Console.WriteLine(MenuMSG);
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine(menuOptions[i]);
            }
            do
            {
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    validOption = true;
                    if (option < 0 || option > 5)
                    {
                        Console.WriteLine(RangeError);
                        validOption = false;
                    }
                }
                catch
                {
                    Console.WriteLine(FormatError);
                    validOption = false;
                }
            } while (!validOption);
            switch (option)
            {
                case 1:
                    Console.WriteLine(CurrentStats, hp, status, speed, attack, canRun, screenColour);
                    break;
                case 2:

                    damage=rnd.Next(1,101);
                    hp = hp - damage;
                    if (hp < 0)
                    {
                        hp = 0;
                    }
                    Console.WriteLine(DamageMSG,damage,hp);
                    
                    break;
                case 3:
                    heal = rnd.Next(1, 101);
                    hp = hp + heal;
                    if (hp > 100)
                    {
                        hp = 100;
                    }
                    Console.WriteLine(HealMSG, heal, hp);
                    break;
                case 4:

                    if (speed <= 70)
                    {
                        Console.WriteLine("you can't run");
                    }
                    else
                    {
                        Console.WriteLine("you run the fastest you can");
                    }
                        break;
                case 5:
                    
                    break;
                case 0:
                    Console.WriteLine(ThxForPlay);
                    break;
            }
        } while (option != 0);
    }
}
