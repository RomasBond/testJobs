namespace testHttp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UsersModel : DbContext
    {

        public UsersModel()
            : base("name=UsersModel")
        {
        }

         public virtual DbSet<UsersInfo> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersInfo>().HasMany(i => i.Results).WithMany();          
        }

    }


}