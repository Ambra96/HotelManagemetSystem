using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelPmsCore.Services
{

    public interface IModule
    {
        void New();
        void Edit();
        void Delete();
        //void RefreshGrid();
        bool HasSelection { get; }
    }
}

