using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class BookTransactions
    {
        public BookTransactions()
        {
            FineDetails = new HashSet<FineDetails>();
        }

        public int Id { get; set; }
        public int? BookId { get; set; }
        public DateTime? ReuestedDate { get; set; }
        public int? RequestedBy { get; set; }
        public bool? IsRequestCompleted { get; set; }
        public DateTime? BookHandoverDate { get; set; }
        public bool? IsBookReturned { get; set; }
        public DateTime? BookReturndDate { get; set; }
        public string Comments { get; set; }
        public int? BookRenewCount { get; set; }
        public DateTime? BookRenewDate { get; set; }
        public DateTime? NextDueDate { get; set; }
        public bool? IsReminderSent { get; set; }
        public string BookReminderNotes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Books Book { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual Users RequestedByNavigation { get; set; }
        public virtual ICollection<FineDetails> FineDetails { get; set; }
    }
}
