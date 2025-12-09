using WarriorMethods;

public class Program
{
    public static void Main()
    {
        const string PlayerStatsMsg = "--- Welcome dark knigth ---\nHP: {0} Velocity: {1} Power Attack: {2}\nState: {3} Can run: {4} Backgroung color: {5}";
        const string SpacerMsg = "------------------------------";
        const string AskUserMenuOptionMsg = "Write an option:\n1. Take damage\n2. Deal damage (attack)\n3. Move\n0. Exit";
        const string InvalidMenuOptionMsg = "Invalid menu option, my lord.";
        const string AskUserTakeDamageMsg = "Enter how much damage you take: ";
        const string InvalidTakeDamageMsg = "Invalid damage";
        const int MinHP = 0;
        const int MaxHP = 100;

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
                case 1:
                    playerHP = WarriorUtils.TakeDamage(playerHP, UserInput(MinHP, MaxHP, AskUserTakeDamageMsg, InvalidTakeDamageMsg));
                    break;
            }
            playerState = WarriorUtils.CheckPlayerState(playerHP, out playerVelocity, out playerAttack, out canRun, out backgroundColor);
        } while (userMenuOption != 0);
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