namespace WarriorMethods
{
    public static class WarriorUtils
    {

        public static int TakeDamage(int playerHP, int damage)
        {
            return playerHP - damage;
        }

        public static string CheckPlayerState(int playerHP, out int playerVelocity, out int playerAttack, out bool canRun, out string backgroundColor)
        {
            if (playerHP <= 100 && playerHP >= 76)
            {
                playerVelocity = 100;
                playerAttack = 100;
                canRun = true;
                backgroundColor = "normal";
                return "health";
            }
            else if (playerHP <= 75 && playerHP >= 51)
            {
                playerVelocity = -10;
                playerAttack = -10;
                canRun = true;
                backgroundColor = "normal";
                return "injured state";
            }
            else if (playerHP <= 50 && playerHP >= 26)
            {
                playerVelocity = -20;
                playerAttack = -20;
                canRun = false;
                backgroundColor = "normal";
                return "seriously injured state";
            }
            else if (playerHP <= 25 && playerHP >= 1)
            {
                playerVelocity = -50;
                playerAttack = -50;
                canRun = false;
                backgroundColor = "normal";
                return "critic state";
            }
            else
            {
                playerVelocity = 0;
                playerAttack = 0;
                canRun = false;
                backgroundColor = "normal";
                return "Dead state";
            }
        }
    }
}
