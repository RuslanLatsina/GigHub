namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Name) values(N'��������'),(N'������'),(N'�����'),(N'��������'),(N'ĳ���'),(N'������'),(N'�������'),(N'������'),(N'ʳ��'),(N'����'),(N'�����'),('Stand-Up')");
        }
        
        public override void Down()
        {
            Sql("delete from Genres ");
        }
    }
}
