namespace ZV_CursusAdministratie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titel = c.String(maxLength: 300),
                        Code = c.String(maxLength: 10),
                        Duur = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CursusInstanties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Startdatum = c.DateTime(nullable: false),
                        CursusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursus", t => t.CursusId, cascadeDelete: true)
                .Index(t => t.CursusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CursusInstanties", "CursusId", "dbo.Cursus");
            DropIndex("dbo.CursusInstanties", new[] { "CursusId" });
            DropTable("dbo.CursusInstanties");
            DropTable("dbo.Cursus");
        }
    }
}
