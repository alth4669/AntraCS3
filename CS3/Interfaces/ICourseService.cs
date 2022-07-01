using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3.DataModel;

namespace CS3.Interfaces
{
    public interface ICourseService
    {  
        int AddStudent(CS3.DataModel.Student student);
        int RemoveStudent(CS3.DataModel.Student student);
    }
}
