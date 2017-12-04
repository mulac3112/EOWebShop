using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EOWebShop.Models
{
    [Table("Proizvodaci")]
    public class Proizvodac
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }
        public string Drzava { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public DateTime DatumUnosa { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual ICollection<Proizvod> Proizvodi { get; set; }
    }
}