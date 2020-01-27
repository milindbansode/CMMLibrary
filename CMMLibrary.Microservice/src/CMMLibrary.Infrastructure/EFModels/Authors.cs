using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string RegionalDecription { get; set; }
        public int? TotalBooksWritten { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
