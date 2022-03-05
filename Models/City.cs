using System;
using System.Collections.Generic;

#nullable disable

namespace InsaatBackendAPI.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Project Project { get; set; }
    }
}
