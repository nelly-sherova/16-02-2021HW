using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixHomeWork
{
    class Matrix
    {
        public int Width {get; set;} // ширина
        public int Height {get; set;} // высота
        public int Lines {get; set;} // линии
        public int StartDelay {get; set;} // остановка 
        Matrix(){}
        Matrix(int Width, int Height; int Lines; int StartDelay)
        {
            this.Width = Width;
            this.Height = Height;
            this.Lines = Lines;
            this.StartDelay = StartDelay;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
