namespace WPF_Login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_T_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tb_T_User");
        }
    }
}
