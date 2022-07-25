using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четем размерите на тортата и изчисляваме колко е голяма
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int cakeSize = w*h;
            string input = Console.ReadLine();
            int cakePieces;

            // пускаме цикъла, докато не свършат парчетата или не получим вход= "STOP"
            while (input != "STOP")
            {
                //=> проверяваме дали иома достатъчно парчета, колкото гостите искат
                cakePieces = int.Parse(input);
                //  ако има => трябва да извадим броя парчета от тортата
                if (cakePieces <= cakeSize)
                {
                    cakeSize -= cakePieces;
                }
                //  ако няма => отпечатваме колко парчета не достигат и спираме цикъла
                else
                {
                    Console.WriteLine($"No more cake left! You need {cakePieces - cakeSize} pieces more.");
                    cakeSize -= cakePieces;
                    break;
                }
                // накрая четем нов вход от конзолата
                input = Console.ReadLine();
            }
            // проверяваме дали са останали парчета и колко?
            if (cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
