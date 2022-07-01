using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3.Interfaces
{
    public interface IInstructorService : IPersonService
    {
        int YearsExperience();
    }
}
