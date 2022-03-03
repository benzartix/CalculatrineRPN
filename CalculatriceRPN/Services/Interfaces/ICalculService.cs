using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceRPN.Services.Interfaces
{
    public interface ICalculService
    {
        Stack<string> Operation(string[] ArrayInput);
    }
}
