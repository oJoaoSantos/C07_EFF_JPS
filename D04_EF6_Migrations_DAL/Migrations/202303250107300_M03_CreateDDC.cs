namespace D04_EF6_Migrations_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M03_CreateDDC : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Book", "DaweyDecimalClassification_DaweyDecimalClassificationID", "dbo.DaweyDecimalClassification");
            DropIndex("dbo.Book", new[] { "DaweyDecimalClassification_DaweyDecimalClassificationID" });
            DropColumn("dbo.Book", "DaweyDecimalClassificationID");
            RenameColumn(table: "dbo.Book", name: "DaweyDecimalClassification_DaweyDecimalClassificationID", newName: "DaweyDecimalClassificationID");
            AlterColumn("dbo.Book", "DaweyDecimalClassificationID", c => c.Int(nullable: false));
            AlterColumn("dbo.Book", "DaweyDecimalClassificationID", c => c.Int(nullable: false));
            AlterColumn("dbo.DaweyDecimalClassification", "DDCCode", c => c.String());
            AlterColumn("dbo.DaweyDecimalClassification", "DDCClassification", c => c.String());
            CreateIndex("dbo.Book", "DaweyDecimalClassificationID");
            AddForeignKey("dbo.Book", "DaweyDecimalClassificationID", "dbo.DaweyDecimalClassification", "DaweyDecimalClassificationID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "DaweyDecimalClassificationID", "dbo.DaweyDecimalClassification");
            DropIndex("dbo.Book", new[] { "DaweyDecimalClassificationID" });
            AlterColumn("dbo.DaweyDecimalClassification", "DDCClassification", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.DaweyDecimalClassification", "DDCCode", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Book", "DaweyDecimalClassificationID", c => c.Int());
            AlterColumn("dbo.Book", "DaweyDecimalClassificationID", c => c.String());
            RenameColumn(table: "dbo.Book", name: "DaweyDecimalClassificationID", newName: "DaweyDecimalClassification_DaweyDecimalClassificationID");
            AddColumn("dbo.Book", "DaweyDecimalClassificationID", c => c.String());
            CreateIndex("dbo.Book", "DaweyDecimalClassification_DaweyDecimalClassificationID");
            AddForeignKey("dbo.Book", "DaweyDecimalClassification_DaweyDecimalClassificationID", "dbo.DaweyDecimalClassification", "DaweyDecimalClassificationID");
        }
    }
}
