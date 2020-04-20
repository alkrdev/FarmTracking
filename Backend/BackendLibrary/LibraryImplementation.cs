using BackendLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace BackendLibrary {
    class LibraryImplementation : LibraryInterface {
        private readonly LibraryContext farmerDb;

        public LibraryImplementation(LibraryContext db)
        {
            this.farmerDb = db;
        }

        // Database Commit

        public int Commit()
        {
            return farmerDb.SaveChanges();
        }

        // CRUD Machines

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
            Machine toDelete = farmerDb.Machines.Find(machineId);
            farmerDb.Machines.Remove(toDelete);
            return toDelete;
        }


        // CRUD Fields

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
            Field toDelete = farmerDb.Fields.Find(fieldId);
            farmerDb.Fields.Remove(toDelete);
            return toDelete;
        }
    }
}
