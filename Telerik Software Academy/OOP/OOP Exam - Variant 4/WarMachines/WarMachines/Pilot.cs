namespace WarMachines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;

        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The pilot name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentException("The machine cannot be null!");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            var count = this.machines.Count;

            var result = new StringBuilder();
            result.AppendFormat("{0} - {1} {2}", this.Name, count == 0 ? "no" : count.ToString(), count == 1 ? "machine" : "machines");
            result.Append(string.Join("", this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name)));

            return result.ToString();
        }
    }
}