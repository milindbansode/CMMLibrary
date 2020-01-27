using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class BookImages
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public byte[] Image { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Books Book { get; set; }
    }
}
