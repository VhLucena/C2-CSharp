using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {

        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("The player name is null or all whitespace");
            }
            else if (string.IsNullOrEmpty(player.Name))
            {
                Console.WriteLine("The player name is empty");
            }
            else
            {
                Console.WriteLine(player.Name);
            }
            
            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }

            if (player.DateOfBirth.HasValue)
            {
                Console.WriteLine(player.DateOfBirth);
            }
            else
            {
                Console.WriteLine("No Date of Birth was specified");
            }

            if (!player.isNoob.HasValue)
            {
                Console.WriteLine("Player status os unknown");
            }
            else if (player.isNoob == true)
            {
                Console.WriteLine("Player is Newbie");
            }
            else
            {
                Console.WriteLine("Player is experinced");
            }

            // Manners to get value of a Nullable<T>
            int days1 = player.DaysSinceLastLogin.GetValueOrDefault(-1);
            int days2 = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            int days3 = player.DaysSinceLastLogin ?? -1;

            // Checking if 'player' is null before access it (avaliable C#6)
            int days4 = player?.DaysSinceLastLogin ?? -1; 
        }
    }
}
