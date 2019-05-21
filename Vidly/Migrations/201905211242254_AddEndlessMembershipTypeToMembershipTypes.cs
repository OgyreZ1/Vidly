namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEndlessMembershipTypeToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Int(nullable: false));
            Sql("INSERT INTO MembershipTypes (ID, SignUpFee, DurationInMonth,DiscountRate, Name) VALUES (5, 1000, 99999, 100, 'Endless')");

        }

        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Byte(nullable: false));
        }
    }
}
