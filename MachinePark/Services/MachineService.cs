using MachinePark.Models;

namespace MachinePark.Services
{
    public class MachineService
    {
        private readonly List<Machine> machines;

        public MachineService()
        {
            machines = new List<Machine>
            {
                new Machine { Id = Guid.NewGuid(), Name = "Machine 1", IsOnline = true, LatestData = "Data 1" },
                new Machine { Id = Guid.NewGuid(), Name = "Machine 2", IsOnline = false, LatestData = "Data 2" }
            };
        }

        public List<Machine> GetMachines() => machines;

        public void AddMachine(Machine machine) => machines.Add(machine);

        public void RemoveMachine(Guid id) => machines.RemoveAll(m => m.Id == id);

        public void UpdateMachine(Machine machine)
        {
            var index = machines.FindIndex(m => m.Id == machine.Id);
            if (index != -1)
            {
                machines[index] = machine;
            }
        }

        public void StartMachine(Guid id)
        {
            var machine = machines.FirstOrDefault(m => m.Id == id);
            if (machine != null)
            {
                machine.IsOnline = true;
            }
        }

        public void StopMachine(Guid id)
        {
            var machine = machines.FirstOrDefault(m => m.Id == id);
            if (machine != null)
            {
                machine.IsOnline = false;
            }
        }
    }
}
