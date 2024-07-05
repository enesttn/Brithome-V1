using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PropertyDetailDto : IDto
    {
        public int PropertyID { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string? City { get; set; }
        public string Status { get; set; }
    }
}
