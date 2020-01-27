using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class BookRatingsAndCommets
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? Ratings { get; set; }
        public string Comments { get; set; }
        public string RegionalComments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Books Book { get; set; }
    }
}
