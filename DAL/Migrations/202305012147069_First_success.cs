namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_success : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Uname = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false),
                        Age = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        T_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId)
                .ForeignKey("dbo.Transactions", t => t.T_ID, cascadeDelete: true)
                .Index(t => t.T_ID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        trans_ID = c.Int(nullable: false, identity: true),
                        trans_name = c.String(nullable: false, maxLength: 25),
                        trans_date = c.DateTime(nullable: false),
                        ticket_ID = c.Int(nullable: false),
                        res_ID = c.Int(nullable: false),
                        User_uID = c.Int(),
                    })
                .PrimaryKey(t => t.trans_ID)
                .ForeignKey("dbo.Bookings", t => t.res_ID, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.ticket_ID, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.User_uID)
                .Index(t => t.ticket_ID)
                .Index(t => t.res_ID)
                .Index(t => t.User_uID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Booking_ID = c.Int(nullable: false, identity: true),
                        User_ID = c.Int(nullable: false),
                        Ticket_ID = c.Int(nullable: false),
                        booking_Date = c.DateTime(nullable: false),
                        payment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Booking_ID)
                .ForeignKey("dbo.Tickets", t => t.Ticket_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Ticket_ID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EventId = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        Price = c.Single(nullable: false),
                        Destinetations = c.String(),
                        posted_by = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TId)
                .ForeignKey("dbo.Users", t => t.posted_by, cascadeDelete: false)
                .Index(t => t.posted_by);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        uID = c.Int(nullable: false, identity: true),
                        uName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 30),
                        Type = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.uID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        Report_date = c.DateTime(nullable: false),
                        Income = c.String(nullable: false),
                        Expense = c.String(nullable: false),
                        T_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId)
                .ForeignKey("dbo.Transactions", t => t.T_ID, cascadeDelete: true)
                .Index(t => t.T_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "T_ID", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "User_uID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "ticket_ID", "dbo.Tickets");
            DropForeignKey("dbo.Reports", "T_ID", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "res_ID", "dbo.Bookings");
            DropForeignKey("dbo.Bookings", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Bookings", "Ticket_ID", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "posted_by", "dbo.Users");
            DropIndex("dbo.Reports", new[] { "T_ID" });
            DropIndex("dbo.Tickets", new[] { "posted_by" });
            DropIndex("dbo.Bookings", new[] { "Ticket_ID" });
            DropIndex("dbo.Bookings", new[] { "User_ID" });
            DropIndex("dbo.Transactions", new[] { "User_uID" });
            DropIndex("dbo.Transactions", new[] { "res_ID" });
            DropIndex("dbo.Transactions", new[] { "ticket_ID" });
            DropIndex("dbo.Admins", new[] { "T_ID" });
            DropTable("dbo.Reports");
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.Bookings");
            DropTable("dbo.Transactions");
            DropTable("dbo.Admins");
        }
    }
}
