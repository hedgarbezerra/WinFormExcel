namespace WinFormDay2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transferencia")]
    public partial class Transferencia
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public int IdConta_Remetente { get; set; }

        public int IdConta_Destinatario { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual Conta Conta1 { get; set; }
    }
}
