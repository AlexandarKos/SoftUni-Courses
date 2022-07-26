using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfLeft = 0;
            int sumOfRight = 0;
            bool notExist = false;
            // 1. Обхождам целия масив с един цикъл
            // 2. Проверявам дали масива има само един елемент и ако да, принтирам 0 и спирам цикъла
            // 3. Нулирам си лявата сума и създавам един цикъл който обхожда числата от лявата страна на сегашния индекс
            // 3.1 цикъла почва от сегашния индекс и върви докато индекса не е 0 => индекса се намаля с 1 на всяка итерация
            // 3.2 събирам сегашния индекс на масива във sumOfLeft
            // 4. Нулирам си дясната сума и създавам един цикъл който обхожда числата от дясната страна на сегашния индекс
            // 4.1 цикъла почва от сегашния индекс и върви до дължината на масива => индекса се увеличава с 1 на всяка итерация
            // 4.2 събирам сегашния индекс на масива във sumOfRight
            // 5. След това във главния цикъл проверявам дали сумата от ляво и дясно са равни, ако са равни принтирам сегашния индекс
            // 5.1 ако не са равни продължава цикъла

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                sumOfLeft = 0;                
                for (int leftSum = i; leftSum > 0; leftSum--)
                {
                    int nextElement = leftSum - 1;
                    if (leftSum > 0)
                    {
                        sumOfLeft += numbers[nextElement];
                    }
                }

                sumOfRight = 0;
                for (int rightSum = i; rightSum < numbers.Length; rightSum++)
                {
                    int nextElement = rightSum + 1;
                    if (rightSum < numbers.Length - 1)
                    {
                        sumOfRight += numbers[nextElement];
                    }
                }

                if (sumOfLeft == sumOfRight)
                {
                    Console.WriteLine(i);
                    notExist = true;
                    break;
                }
            }

            if (!notExist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
