using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor AOC = new Monitor(20, 30, 25.5);
            Console.WriteLine(AOC.GetSpecsOfMonitor());
            Console.ReadKey();
        }
    }
}

class Device
{
    public int height
    {
        get;
        protected set;
    }
    public int width
    {
        get;
        protected set;
    }
    public Device()
    {
        this.height = 0;
        this.width = 0;

    }
    public Device(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
    public string GetSpecs()
    {
        return this.height + ", " + this.width;

    }
}

class Monitor : Device
{
    public double inches
    {
        get;
        protected set;

    }
    public Monitor(int height, int width, double inches) : base(height, width)
    {
        this.inches = inches;
    }
    public string GetSpecsOfMonitor()
    {
        return base.GetSpecs() + " " + this.inches;
    }
}