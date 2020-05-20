using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_ralasic
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad > this.previousCPULoad + 10 || currentLoad < this.previousCPULoad - 10)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentLoad = this.AvailableRAM;
            if (currentLoad > this.previousRAMAvailable * 1.1 || currentLoad < this.previousRAMAvailable * 0.9)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentLoad;
            return currentLoad;
        }

    }
}
