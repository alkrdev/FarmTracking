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

        ActiveMachine CreateActiveMachine(ActiveMachine newActiveMAchine);
        ActiveMachine GetActiveMachine(int activeMachineId);
        ActiveMachine UpdateActiveMachine(ActiveMachine updatedActiveMachine);
        ActiveMachine DeleteActiveMachine(int activeMachineId);


        // Field Information

        DbSet<ActiveMachine> GetAllActiveMachines(); 
    }
}
