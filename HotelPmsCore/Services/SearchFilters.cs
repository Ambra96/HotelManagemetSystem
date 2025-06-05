using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Services
{
    public interface SearchFilters
    {
        Dictionary<string, object> FilterValues { get; set; }
        void ApplyFilters();
    }
}
