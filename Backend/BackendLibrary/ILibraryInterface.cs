using System;
using System.Collections.Generic;
using System.Text;
using BackendLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendLibrary {
    public interface ILibraryInterface {


        // Database Commit

        int Commit();

        // CRUD - Machines

        Machine CreateMachine(Machine newMachine);
        Machine GetMachine(int machineId);
        Machine UpdateMachine(Machine updatedMachine);
        Machine DeleteMachine(int machineId);

        // CRUD - Fields

        Field CreateField(Field newField);
        Field GetField(int fieldId);
        Field UpdateField(Field updatedField);
        Field DeleteField(int fieldId);

        // CRUD - ActiveMachines

        ActiveMachine CreateActiveMachine(ActiveMachine newActiveMachine);
        ActiveMachine GetActiveMachine(int activeMachineId);
        ActiveMachine UpdateActiveMachine(ActiveMachine updatedActiveMachine);
        void DeleteActiveMachine(int activeMachineId);


        // field Information

        DbSet<ActiveMachine> GetAllActiveMachines();
        DbSet<Machine> GetAllMachines();
        DbSet<Field> GetAllFields();
    }
}
