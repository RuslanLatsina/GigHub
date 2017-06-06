namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Name) values(N'Концерти'),(N'Театри'),(N'Клуби'),(N'Фестивалі'),(N'Дітям'),(N'Ескурсії'),(N'Семінари'),(N'Квести'),(N'Кіно'),(N'Цирк'),(N'Спорт'),('Stand-Up')");
        }
        
        public override void Down()
        {
            Sql("delete from Genres ");
        }
    }
}
