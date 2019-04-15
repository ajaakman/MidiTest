using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Midi midi = new Midi();
            Console.WriteLine(Midi.InputCount);
            midi.Open(0);
            midi.Start();
            while (true) { };
        }
    }
}
