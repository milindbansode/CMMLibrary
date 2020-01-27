using System;
using System.Collections.Generic;

namespace CMMLibrary.Infrastructure.EFModels
{
    public partial class Books
    {
        public Books()
        {
            BookImages = new HashSet<BookImages>();
            BookRatingsAndCommets = new HashSet<BookRatingsAndCommets>();
            BookTransactions = new HashSet<BookTransactions>();
            InverseCategory = new HashSet<Books>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RegionalName { get; set; }
        public string Title { get; set; }
        public string AlternativeTitle { get; set; }
        public string Decripton { get; set; }
        public string RegionalDescription { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
        public int? PublishedYear { get; set; }
        public string Publication { get; set; }
        public string Edition { get; set; }
        public string RegionalPublication { get; set; }
        public int? TotalNumberOfCopies { get; set; }
        public string AvailableLocation { get; set; }
        public int? TotalPages { get; set; }
        public bool? IsFiction { get; set; }
        public string Isbn { get; set; }
        public string BookCode { get; set; }
        public string AuthorNotes { get; set; }
        public string RegionalAuthorNotes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? NumberOfCopiesAvailble { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Books Category { get; set; }
        public virtual ICollection<BookImages> BookImages { get; set; }
        public virtual ICollection<BookRatingsAndCommets> BookRatingsAndCommets { get; set; }
        public virtual ICollection<BookTransactions> BookTransactions { get; set; }
        public virtual ICollection<Books> InverseCategory { get; set; }
    }
}
