using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3.Interfaces
{
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
        int AddAddress(string addr);
        int RemoveAddress(string addr);
    }
}
