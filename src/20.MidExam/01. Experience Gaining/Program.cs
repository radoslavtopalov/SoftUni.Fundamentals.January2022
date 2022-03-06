using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var experienceAmount = decimal.Parse(Console.ReadLine());
            var battlesCount = int.Parse(Console.ReadLine());
            //var battleExperienceOnEachBattle = decimal.Parse(Console.ReadLine());

            var collectedExperience = 0.0m;

            //15% more experiance on every third battle 
            // 10% less on very fifth battle
            // 5% more on every fiftheenth battle

            for (var i = 1; i <= battlesCount; i++)
            {
                var battleExperienceOnEachBattle = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    battleExperienceOnEachBattle += battleExperienceOnEachBattle * 0.15m;
                }

                if (i % 5 == 0)
                {
                    battleExperienceOnEachBattle -= battleExperienceOnEachBattle * 0.10m;
                }

                if (i % 15 == 0)
                {
                    battleExperienceOnEachBattle += battleExperienceOnEachBattle * 0.05m;
                }

                collectedExperience += battleExperienceOnEachBattle;
                
                if (collectedExperience >= experienceAmount)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }

                if (i == battlesCount && experienceAmount > collectedExperience)
                {
                    Console.WriteLine($"Player was not able to collect the needed experience, {(experienceAmount - collectedExperience):F2} more needed.");
                }
            }
            
        }
    }
}
