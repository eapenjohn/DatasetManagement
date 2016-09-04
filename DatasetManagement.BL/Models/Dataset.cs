using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetManagement.BL.Models
{
    public class Dataset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public User Supplier { get; set; }
    }
}
