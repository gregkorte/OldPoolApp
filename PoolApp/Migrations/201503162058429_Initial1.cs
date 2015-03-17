namespace PoolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Products", new[] { "InvoiceID" });
            RenameColumn(table: "dbo.Products", name: "InvoiceID", newName: "Invoice_ID");
            AlterColumn("dbo.Products", "Invoice_ID", c => c.Int());
            CreateIndex("dbo.Products", "Invoice_ID");
            AddForeignKey("dbo.Products", "Invoice_ID", "dbo.Invoices", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Invoice_ID", "dbo.Invoices");
            DropIndex("dbo.Products", new[] { "Invoice_ID" });
            AlterColumn("dbo.Products", "Invoice_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Products", name: "Invoice_ID", newName: "InvoiceID");
            CreateIndex("dbo.Products", "InvoiceID");
            AddForeignKey("dbo.Products", "InvoiceID", "dbo.Invoices", "ID", cascadeDelete: true);
        }
    }
}
