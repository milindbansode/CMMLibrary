using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CMMLibrary.Infrastructure.EFModels;

namespace CMMLibrary.Infrastructure
{
    public partial class CMMLibraryContext : DbContext
    {
        public CMMLibraryContext()
        {
        }

        public CMMLibraryContext(DbContextOptions<CMMLibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<BookCategories> BookCategories { get; set; }
        public virtual DbSet<BookImages> BookImages { get; set; }
        public virtual DbSet<BookRatingsAndCommets> BookRatingsAndCommets { get; set; }
        public virtual DbSet<BookTransactions> BookTransactions { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<FineDetails> FineDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMMLibrary");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Authors__737584F6D8D55925")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Decription).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookCategories>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__BookCate__737584F69547F6DE")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionalName).HasMaxLength(200);
            });

            modelBuilder.Entity<BookImages>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookImages)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__BookImage__BookI__797309D9");
            });

            modelBuilder.Entity<BookRatingsAndCommets>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookRatingsAndCommets)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__BookRatin__BookI__00200768");
            });

            modelBuilder.Entity<BookTransactions>(entity =>
            {
                entity.Property(e => e.BookHandoverDate).HasColumnType("datetime");

                entity.Property(e => e.BookReminderNotes).IsUnicode(false);

                entity.Property(e => e.BookRenewCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BookRenewDate).HasColumnType("datetime");

                entity.Property(e => e.BookReturndDate).HasColumnType("datetime");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsBookReturned).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRequestCompleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NextDueDate).HasColumnType("datetime");

                entity.Property(e => e.ReuestedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookTransactions)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__BookTrans__BookI__06CD04F7");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BookTransactionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__BookTrans__Creat__0D7A0286");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BookTransactionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__BookTrans__Modif__0F624AF8");

                entity.HasOne(d => d.RequestedByNavigation)
                    .WithMany(p => p.BookTransactionsRequestedByNavigation)
                    .HasForeignKey(d => d.RequestedBy)
                    .HasConstraintName("FK__BookTrans__Reque__08B54D69");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.AlternativeTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorNotes).IsUnicode(false);

                entity.Property(e => e.AvailableLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Decripton).IsUnicode(false);

                entity.Property(e => e.Edition)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfCopiesAvailble).HasDefaultValueSql("((1))");

                entity.Property(e => e.Publication)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionalDescription).IsUnicode(false);

                entity.Property(e => e.RegionalName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RegionalPublication)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__Books__AuthorId__71D1E811");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.InverseCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Books__CategoryI__72C60C4A");
            });

            modelBuilder.Entity<FineDetails>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.BookTransaction)
                    .WithMany(p => p.FineDetails)
                    .HasForeignKey(d => d.BookTransactionId)
                    .HasConstraintName("FK__FineDetai__BookT__123EB7A3");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FineDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__FineDetai__Creat__14270015");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FineDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__FineDetai__Modif__160F4887");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C613973CC");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
