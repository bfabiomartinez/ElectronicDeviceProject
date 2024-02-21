using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);
            VolumeButton volBut = new VolumeButton(TV);

            powBut.Execute();
            powBut.Undo();
            volBut.Execute();
            volBut.Undo();


        }
    }
}
