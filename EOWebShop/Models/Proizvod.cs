using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EOWebShop.Helpers;

namespace EOWebShop.Models
{
    [Table("Proizvodi")]
    public class Proizvod
    {
        [Key]
        public int Id { get; set; }

        public int ProizvodacId { get; set; }
        [ForeignKey("ProizvodacId")]
        public virtual Proizvodac Proizvodac { get; set; }

        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string KataloskiBroj { get; set; }
        public JediniceMjere.JedinicaMjere OsnovnaJedinicaMjere { get; set; }
        public decimal JedinicnaCijena { get; set; }
        public int StanjeSkladista { get; set; }
        public DateTime DatumUnosa { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}