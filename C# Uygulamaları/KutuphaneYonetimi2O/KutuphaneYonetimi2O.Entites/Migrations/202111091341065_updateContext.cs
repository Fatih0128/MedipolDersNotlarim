﻿namespace KutuphaneYonetimi2O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateContext : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblUye", "Fotograf");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblUye", "Fotograf", c => c.String(maxLength: 200, unicode: false));
        }
    }
}
