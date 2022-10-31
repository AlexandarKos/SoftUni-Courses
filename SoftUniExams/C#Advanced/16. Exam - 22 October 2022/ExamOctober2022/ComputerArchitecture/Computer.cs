using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace ComputerArchitecture
{
    public class Computer
    {
        //private string model;
        //private List<CPU> multiprocessor;
        //private int capacity;

        public List<CPU> Multiprocessor { get; set; }

        public Computer(string model, int capacity)
        {
            this.Model = model;
            this.Capacity = capacity;
            this.Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }

        public int Count => this.Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (this.Multiprocessor.Count < this.Capacity)
            {
                this.Multiprocessor.Add(cpu);
            }
            else
            {
                return;
            }
        }

        public bool Remove(string brand)
        {
            var targetBrand = this.Multiprocessor.FirstOrDefault(b => b.Brand == brand);
            if (targetBrand == null)
            {
                return false;
            }
            this.Multiprocessor.Remove(targetBrand);
            return true;
        }

        public CPU MostPowerful()
        {
            return this.Multiprocessor.OrderByDescending(p => p.Frequency).FirstOrDefault();
            //CPU mostPowerfulCPU = this.Multiprocessor.FirstOrDefault(p => p.Frequency)
        }

        public CPU GetCPU(string brand)
        {
            var targetBrand = this.Multiprocessor.FirstOrDefault(b => b.Brand == brand);
            if (targetBrand == null)
            {
                return null;
            }

            return targetBrand;
        }

        public string Report()
        {
            // CPUs in the Computer Gaming Serioux:
            // AMD Ryzen 5 CPU:
            // Cores: 6
            // Frequency: 3.7 GHz
            // Intel Core i7 CPU:
            // Cores: 8
            // Frequency: 4.0 GHz
            Console.WriteLine($"CPUs in the Computer {this.Model}:");
            var sb = new StringBuilder();
            //sb.AppendLine($"CPUs in the Computer {this.Model}");
            foreach (CPU cPU in this.Multiprocessor)
            {
                Console.WriteLine(cPU);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
