using System;

namespace PlayerAchievements
{
//enumeration flag(DefeatOptionalBoss, FindHiddenLevel, FinishGame)
[Flags]
public enum Achievements
{
    DefeatOptionalBoss = 0,
    FindHiddenLevel = 1,
    FinishGame = 2
}

    class Program
    {
        static void Main(string[] args)
        {
            //Ask user number of players
            Console.Write("Number of Players: ");

            //Save input on a variable n
            string n = Console.ReadLine();

            //Array with n size

            //Each Array position will have each player's achievements

            //Go through players one by one, 
        }
    }
}
