using DatasetManagement.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetManagement.DL
{
    public class DatasetRepository
    {
        public Dataset Get(int datasetId)
        {
           var user = new User { Id = 1, FirstName = "john", LastName = "Joseph" };
           var dataset = new Dataset() { Id = datasetId, Description = "description", Name = "Name", PublishedDate = DateTime.UtcNow, Supplier = user };

            return dataset;
        }

        public IEnumerable<Dataset> Get()
        {
            List<Dataset> datasets = new List<Dataset>();
            
            for (int i = 0; i < 10; i++)
            {
                var user = new User { Id = i+10, FirstName = "john", LastName = "Joseph" };
                var dataset = new Dataset() { Id = i+1, Description = "description", Name = "Name_" +i.ToString(), PublishedDate = DateTime.UtcNow, Supplier = user };
                datasets.Add(dataset);
            }

            return datasets;
        }
    }
}
