namespace NominaDePago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingemployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpleadoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Identification = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        Address = c.String(nullable: false),
                        DateOfBirth = c.DateTime(),
                        BankAccount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpleadoModels");
        }
    }
}
