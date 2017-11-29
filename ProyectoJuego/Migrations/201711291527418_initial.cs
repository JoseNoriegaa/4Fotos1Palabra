namespace ProyectoJuego.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jugadas",
                c => new
                    {
                        palabraId = c.String(nullable: false, maxLength: 128),
                        foto1 = c.Binary(),
                        foto2 = c.Binary(),
                        foto3 = c.Binary(),
                        foto4 = c.Binary(),
                    })
                .PrimaryKey(t => t.palabraId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jugadas");
        }
    }
}
