using BackendLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendLibrary {
    public class LibraryImplementation : ILibraryInterface {
        private readonly LibraryContext farmerDb;

        public LibraryImplementation(LibraryContext db)
        {
            farmerDb = db;
        }

        // Database - Commit

        public int Commit()
        {
            return farmerDb.SaveChanges();
        }


        // CRUD - Machines

        public Machine CreateMachine(Machine newMachine)
        {
            farmerDb.Machines.Add(newMachine);
            return newMachine;
        }

        public Machine GetMachine(int machineId)
        {
            return farmerDb.Machines.Find(machineId);
        }

        public Machine UpdateMachine(Machine updatedMachine)
        {
            farmerDb.Machines.Update(updatedMachine);
            return updatedMachine;
        }

        public Machine DeleteMachine(int machineId)
        {
            var toDelete = farmerDb.Machines.Find(machineId);
            farmerDb.Machines.Remove(toDelete);
            return toDelete;
        }


        // CRUD - Fields

        public Field CreateField(Field newField)
        {
            farmerDb.Fields.Add(newField);
            return newField;
        }

        public Field GetField(int fieldId)
        {
            return farmerDb.Fields.Find(fieldId);
        }

        public Field UpdateField(Field updatedField)
        {
            farmerDb.Fields.Update(updatedField);
            return updatedField;
        }

        public Field DeleteField(int fieldId)
        {
            var toDelete = farmerDb.Fields.Find(fieldId);
            farmerDb.Fields.Remove(toDelete);
            return toDelete;
        }


        // CRUD - ActiveMachines

        public ActiveMachine CreateActiveMachine(ActiveMachine newActiveMachine)
        {
            farmerDb.ActiveMachines.Add(newActiveMachine);
            return newActiveMachine;
        }

        public ActiveMachine GetActiveMachine(int activeMachineId)
        {
            return farmerDb.ActiveMachines.Find(activeMachineId);
        }

        public ActiveMachine UpdateActiveMachine(ActiveMachine updatedActiveMachine)
        {
            farmerDb.ActiveMachines.Update(updatedActiveMachine);
            return updatedActiveMachine;
        }

        public void DeleteActiveMachine(int activeMachineId)
        {
            var toDelete = farmerDb.ActiveMachines.Find(activeMachineId);
            farmerDb.ActiveMachines.Remove(toDelete);            
        }


        // field Information

        public DbSet<ActiveMachine> GetAllActiveMachines()
        {
            return farmerDb.ActiveMachines;
        }

        public DbSet<Machine> GetAllMachines()
        {
            return farmerDb.Machines;
        }
        public DbSet<Field> GetAllFields()
        {
            return farmerDb.Fields;
        }


        // Adjust Machinery

        //StartMachine
    }
}
