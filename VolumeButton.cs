using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VolumeButton : ICommand
    {
        IElectronicDevice device;

        public VolumeButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.VolumeUp();
        }
        public void Undo()
        {
            device.VolumeDown();
        }
    }
}
