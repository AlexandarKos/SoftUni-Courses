using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четем размерите на жилището и изчисляваме колко е голямо
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());


            int freeSpace = w * l * h;

            string input = Console.ReadLine();
            int boxes;

            // пускаме цикъла, докато не получим вход= "Done"
            while (input != "Done")
            {

                //=> проверяваме дали има достатъчно свободно място за кашоните
                boxes = int.Parse(input);
                //  ако има => изваждаме обема на кашоните от свободното място
                if (boxes <= freeSpace)
                {
                    freeSpace -= boxes;
                }
                //  ако няма => отпечатваме колко кубични метра не достигат и спираме цикъла
                else
                {
                    Console.WriteLine($"No more free space! You need {boxes - freeSpace} Cubic meters more.");
                    freeSpace -= boxes;
                    break;
                }
                // накрая четем нов вход от конзолата
                input = Console.ReadLine();
            }
            // проверяваме дали е останало свободно място и колко?
            if (freeSpace > 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
