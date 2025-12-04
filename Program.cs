using System;
using System.Text;
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

        int option= 0;
        int hp = 100;
        int speed = 100;
        int attack = 100;
        int damage;
        bool validOption= false;
        string[] menuOptions= {"1 - view stats","2 - take damage","3 - take heal","4 - run","5 - attack","0 - exit"};
        Random rnd = new Random();
        Console.WriteLine(WelcomeMSG);
        do
        {
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
                    Console.WriteLine("heal points - "+ hp);
                    Console.WriteLine("speed - "+ speed);
                    Console.WriteLine("attack - "+ attack);
                    break;
                case 2:

                    damage=rnd.Next(1,101);
                    hp = hp - damage;
                    Console.WriteLine(DamageMSG,damage,hp);
                    
                    break;
                case 3:

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
    public static void CheckClass()
    {

    }
}
