namespace ZV_CursusAdministratie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursus", "Titel", c => c.String());
            AlterColumn("dbo.Cursus", "Code", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cursus", "Code", c => c.String(maxLength: 10));
            AlterColumn("dbo.Cursus", "Titel", c => c.String(maxLength: 300));
        }
    }
}
