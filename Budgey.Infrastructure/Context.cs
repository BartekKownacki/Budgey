using Budgey.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactDetailType> ContactDetailTypes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseTag> ExpenseTag { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Domain.Model.Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ExpenseTag>()
                .HasKey(ex => new { ex.ExpenseId, ex.TagId });

            builder.Entity<ExpenseTag>()
                .HasOne<Expense>(ex => ex.Expense).WithMany(e => e.ExpenseTags)
                .HasForeignKey(ex => ex.ExpenseId);

            builder.Entity<ExpenseTag>()
                .HasOne<Tag>(ex => ex.Tag).WithMany(e => e.ExpenseTags)
                .HasForeignKey(ex => ex.TagId);

            builder.Entity<Expense>()
                .HasOne<User>(ex => ex.User)
                .WithMany(e => e.Expenses)
                .HasForeignKey(ex => ex.UserId);

            builder.Entity<ContactDetail>()
                .HasOne<User>(c => c.User)
                .WithMany(u => u.ContactDetails)
                .HasForeignKey(u => u.UserId);

            builder.Entity<Note>()
                .HasOne<User>(c => c.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserId);

        }
    }
}
