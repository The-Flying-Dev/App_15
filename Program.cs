namespace TurnBasedCombatGame;

class Program
{
    static void Main(string[] args)
    {
        // Variables of type integer representing player's and enemy's health
        int playerHp = 30;
        int enemyHp = 15;

        // Variables of type integer representing player's and enemy's attack power
        int playerAttack = 5;
        int enemyAttack = 7;

        // Variables of type integer representing player's and enemy's healing power
        int healAmount = 5;

        // Creating a Random Object
        Random random = new Random();

        // Loop only runs if both conditions are true
        while (playerHp > 0 && enemyHp > 0)
        {
            // Player turn
            Console.WriteLine("-- Player turn --");

            // Displays both player's and enemy's current power
            Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);

            Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

            string choice = Console.ReadLine();

            if (choice == "a")
            {
                enemyHp -= playerAttack; // subtracts points from player
                Console.WriteLine("Player attackes and deals " + playerAttack + " damage!");
            }
            else
            {
                playerHp += healAmount; // adds points to player
                Console.WriteLine("Player restores " + healAmount + " health points!");
            }

            // Enemy turn
            if (enemyHp > 0)
            {
                Console.WriteLine("-- Enemy turn --");

                // Displays both player's and enemy's current power
                Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);

                // Generates a random number from 0 to 1 with 2 being exclusive
                int enemyChoice = random.Next(0, 2);

                if (enemyChoice == 0)
                {
                    playerHp -= enemyAttack; // subtracts points from enemy
                    Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                }
                else
                {
                    enemyHp += healAmount; // adds points to enemy
                    Console.WriteLine("Enemy restores " + healAmount + " health points!");
                }
            }
        }
        if (playerHp > 0)
        {
            Console.WriteLine("Congratulations, you have won!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}
