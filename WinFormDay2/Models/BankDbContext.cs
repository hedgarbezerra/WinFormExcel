namespace WinFormDay2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BankDbContext : DbContext
    {
        public BankDbContext()
            : base("name=BankDbContext")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Conta> Contas { get; set; }
        public virtual DbSet<Transferencia> Transferencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Contas)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta>()
                .Property(e => e.Valor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Conta>()
                .HasMany(e => e.Transferencias)
                .WithRequired(e => e.Conta)
                .HasForeignKey(e => e.IdConta_Remetente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta>()
                .HasMany(e => e.Transferencias1)
                .WithRequired(e => e.Conta1)
                .HasForeignKey(e => e.IdConta_Destinatario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transferencia>()
                .Property(e => e.Valor)
                .HasPrecision(10, 2);
        }
    }
}
