namespace NguyenAnhToi_2011064314.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopublateCategoryTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "LectrerId", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Place", c => c.String(nullable: false, maxLength: 255));
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(1,'Development')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(2,'Business')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(3,'Marketing')");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Place", c => c.String());
            AlterColumn("dbo.Courses", "LectrerId", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
