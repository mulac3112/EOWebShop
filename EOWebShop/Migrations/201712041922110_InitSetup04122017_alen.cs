namespace EOWebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitSetup04122017_alen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proizvodacs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        Adresa = c.String(),
                        Mjesto = c.String(),
                        Drzava = c.String(),
                        Telefon = c.String(),
                        Fax = c.String(),
                        Email = c.String(),
                        Web = c.String(),
                        DatumUnosa = c.DateTime(nullable: false),
                        DatumIzmjene = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proizvods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProizvodacId = c.Int(nullable: false),
                        Naziv = c.String(),
                        Opis = c.String(),
                        KataloskiBroj = c.String(),
                        OsnovnaJedinicaMjere = c.Int(nullable: false),
                        JedinicnaCijena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StanjeSkladista = c.Int(nullable: false),
                        DatumUnosa = c.DateTime(nullable: false),
                        DatumIzmjene = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proizvodacs", t => t.ProizvodacId, cascadeDelete: true)
                .Index(t => t.ProizvodacId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proizvods", "ProizvodacId", "dbo.Proizvodacs");
            DropIndex("dbo.Proizvods", new[] { "ProizvodacId" });
            DropTable("dbo.Proizvods");
            DropTable("dbo.Proizvodacs");
        }
    }
}
