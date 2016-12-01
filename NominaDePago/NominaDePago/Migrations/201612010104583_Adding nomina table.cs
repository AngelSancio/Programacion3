namespace NominaDePago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingnominatable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nominas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BonoTransporte = c.Int(nullable: false),
                        BonoALimenticio = c.Int(nullable: false),
                        HorasExtras = c.Int(nullable: false),
                        TotalAsignaciones = c.Int(nullable: false),
                        Seguro = c.Int(nullable: false),
                        Pension = c.Int(nullable: false),
                        TotalDeducciones = c.Int(nullable: false),
                        SalarioAPagar = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmpleadoModels", t => t.EmpleadoId, cascadeDelete: true)
                .Index(t => t.EmpleadoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nominas", "EmpleadoId", "dbo.EmpleadoModels");
            DropIndex("dbo.Nominas", new[] { "EmpleadoId" });
            DropTable("dbo.Nominas");
        }
    }
}
