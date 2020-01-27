using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class BookCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RegionalName { get; set; }
        public string RegionalDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
