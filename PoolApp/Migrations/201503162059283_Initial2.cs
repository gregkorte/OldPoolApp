namespace PoolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Services", new[] { "InvoiceID" });
            RenameColumn(table: "dbo.Services", name: "InvoiceID", newName: "Invoices_ID");
            AlterColumn("dbo.Services", "Invoices_ID", c => c.Int());
            CreateIndex("dbo.Services", "Invoices_ID");
            AddForeignKey("dbo.Services", "Invoices_ID", "dbo.Invoices", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "Invoices_ID", "dbo.Invoices");
            DropIndex("dbo.Services", new[] { "Invoices_ID" });
            AlterColumn("dbo.Services", "Invoices_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Services", name: "Invoices_ID", newName: "InvoiceID");
            CreateIndex("dbo.Services", "InvoiceID");
            AddForeignKey("dbo.Services", "InvoiceID", "dbo.Invoices", "ID", cascadeDelete: true);
        }
    }
}
