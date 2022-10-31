using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private int cores;

        public int Cores
        {
            get { return cores; }
            set { cores = value; }
        }

        private double frequency;

        public double Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        public CPU(string brand, int cores, double frequency)
        {
            this.Brand = brand;
            this.Cores = cores;
            this.Frequency = frequency;
        }

        public override string ToString()
        {
            //"{brand} CPU:
            //Cores: { cores}
            //Frequency: { frequency} GHz"

            // AMD Ryzen 5 CPU:
            // Cores: 6
            // Frequency: 3.7 GHz

            var sb = new StringBuilder();
            sb.AppendLine($"{this.Brand} CPU:");
            sb.AppendLine($"Cores: {this.Cores}");
            sb.AppendLine($"Frequency: {this.Frequency:F1} GHz");

            return sb.ToString().TrimEnd();
        }
    }
}
