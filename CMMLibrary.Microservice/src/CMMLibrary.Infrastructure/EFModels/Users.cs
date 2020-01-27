using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class Users
    {
        public Users()
        {
            BookTransactionsCreatedByNavigation = new HashSet<BookTransactions>();
            BookTransactionsModifiedByNavigation = new HashSet<BookTransactions>();
            BookTransactionsRequestedByNavigation = new HashSet<BookTransactions>();
            FineDetailsCreatedByNavigation = new HashSet<FineDetails>();
            FineDetailsModifiedByNavigation = new HashSet<FineDetails>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? IsAdmin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsMember { get; set; }
        public string MembershipId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<BookTransactions> BookTransactionsCreatedByNavigation { get; set; }
        public virtual ICollection<BookTransactions> BookTransactionsModifiedByNavigation { get; set; }
        public virtual ICollection<BookTransactions> BookTransactionsRequestedByNavigation { get; set; }
        public virtual ICollection<FineDetails> FineDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<FineDetails> FineDetailsModifiedByNavigation { get; set; }
    }
}
