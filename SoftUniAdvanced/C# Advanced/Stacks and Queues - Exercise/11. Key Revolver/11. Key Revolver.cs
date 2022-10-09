using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using static System.Collections.Specialized.BitVector32;
using System.Net.Sockets;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every bullet fired => deducted from the intelligence
            //Starts to shoot the locks front-to-back, while going through the bullets back-to-front
            //If bullet <= lock, print "Bang!", then remove the lock
            //If bullet > lock, print "Ping!", leaving the lock intact
            //If Sam runs out of bullets in his barrel, print "Reloading!" in the console, then continue shooting.
            //If there aren't any bullets left, don't print it.
            //The program ends when Sam either runs out of bullets or the safe runs out of locks.

            //If Sam runs out of bullets before the safe runs out of locks, print "Couldn't get through. Locks left: {locksLeft}"
            //If Sam manages to open the safe, print "{bulletsLeft} bullets left. Earned ${moneyEarned}"

            int prizePerBullet = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);

            //Console.WriteLine(String.Join(", ", locks));
            //Console.WriteLine(String.Join(", ", bullets));

            int bulletsShot = 0;

            while (locks.Any() && bullets.Any())
            {
                // While there are bullets left and locks left -> We shoot
                int lockSize = locks.Peek(); //Peek the value
                int bulletSize = bullets.Pop(); // Remove the bullet in both cases
                bulletsShot++;

                if (bulletSize <= lockSize)
                {
                    // We shot the lock
                    locks.Dequeue(); // Remove the lock itself
                    Console.WriteLine("Bang!");

                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bulletsShot % barrelSize == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int earnedMoney = intelligence - (bulletsShot * prizePerBullet);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }

        }
    }
}
