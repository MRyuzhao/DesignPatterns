using System;
using System.Collections.Generic;
using System.Text;
using Command_05.Devices;

namespace Command_05.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
