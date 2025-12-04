public class Program
{
    public static void Main()
    {
        const string PlayerStatsMsg = "--- Welcome dark knigth ---\nHP: {0} Velocity: {1} Power Attack: {2}\nState: {3} Can run: {4} Backgroung color: {5}";
        const string SpacerMsg = "------------------------------";
        const string AskUserMenuOptionMsg = "Write an option:\n1. Take damage\n2. Deal damage (attack)\n3. Move\n0. Exit";
        const string InvalidMenuOptionMsg = "Invalid menu option, my lord.";

        //Player Stats
        int playerHP = 100, playerVelocity = 100, playerAttack = 100;
        bool canRun = true;
        string backgroundColor = "normal";
        string playerState = "health";
        int userMenuOption;
        

        do
        {
            Console.WriteLine(SpacerMsg);
            Console.WriteLine(PlayerStatsMsg, playerHP, playerVelocity, playerAttack, playerState, canRun, backgroundColor);
            Console.WriteLine(SpacerMsg);
            userMenuOption = UserInput(AskUserMenuOptionMsg, InvalidMenuOptionMsg);

            switch (userMenuOption)
            {
                
            }
            playerState = CheckPlayerState(playerHP, out playerVelocity, out playerAttack, out canRun, out backgroundColor);
        } while (userMenuOption != 0);
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


    public static int UserInput(string AskUserMsg, string InvalidInputMsg)
    {
        int userNumber;
        bool isValidInput = true;

        do
        {
            Console.WriteLine(isValidInput ? AskUserMsg : InvalidInputMsg);
            isValidInput = int.TryParse(Console.ReadLine(), out userNumber);
        } while (!isValidInput);

        return userNumber;
    }

    public static int UserInput(int min, int max, string AskUserMsg, string InvalidInputMsg)
    {
        int userNumber;
        bool isValidInput = true;
        bool isInRange = true;

        do
        {
            Console.WriteLine((isValidInput && isInRange) ? AskUserMsg : InvalidInputMsg);
            isValidInput = int.TryParse(Console.ReadLine(), out userNumber);
            isInRange = userNumber >= min && userNumber <= max;
        } while (!(isValidInput && isInRange));

        return userNumber;
    }

}