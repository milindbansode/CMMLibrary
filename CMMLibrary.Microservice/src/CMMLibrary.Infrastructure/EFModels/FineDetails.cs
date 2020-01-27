using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class FineDetails
    {
        public int Id { get; set; }
        public int? BookTransactionId { get; set; }
        public int? TotalNoOfDelay { get; set; }
        public int? TotalFineGiven { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual BookTransactions BookTransaction { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
