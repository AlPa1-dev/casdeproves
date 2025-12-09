namespace WarriorMethods
{
    public class WarriorUtils
    {
        public static void CalculateWarriorStatus(int hp, out string status,
        out int speed, out int attack, out bool canRun, out string screenColour)
        {
            hp = Math.Min(hp, 100);

            if (hp == 0)
            {
                status = "Dead";
                speed = 0;
                attack = 0;
                canRun = false;
                screenColour = "red";
            }
            else if (hp >= 1 && hp <= 25)
            {
                status = "Critical";
                speed = 50;
                attack = 50;
                canRun = false;
                screenColour = "red";
            }
            else if (hp >= 26 && hp <= 50)
            {
                status = "Severely injured";
                speed = 70;
                attack = 80;
                canRun = false;
                screenColour = "normal";
            }
            else if (hp >= 51 && hp <= 75)
            {
                status = "injured";
                speed = 90;
                attack = 100;
                canRun = true;
                screenColour = "normal";
            }
            else
            {
                status = "healthy";
                speed = 100;
                attack = 100;
                canRun = true;
                screenColour = "normal";
            }
        }
    }
}