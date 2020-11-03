using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // this interface lists all method signatures that we are providing to a consumer
    public interface ICommanderRepo
    {
        // method signatures:
        // 1) list all command objects (resources) => read all
        IEnumerable<Command> GetAppCommands();
        // 2) show single command => read one
        Command GetCommandById(int id);
    }
}