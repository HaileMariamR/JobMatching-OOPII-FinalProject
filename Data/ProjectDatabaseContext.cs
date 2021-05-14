using Microsoft.EntityFrameworkCore;
using Models.projectModels;

namespace ProjectContext.Data{


        public class ProjectDatabaseContext:DbContext{

            public DbSet<User> users {get;set;}
            public DbSet<Applicants> applicants {get;set;}
            public DbSet<HiringManager> hiringManagers {get;set;}
            public DbSet<Job> jobs {get;set;}

            public ProjectDatabaseContext(DbContextOptions<ProjectDatabaseContext> options):base(options){

            }


                protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                 base.OnModelCreating(modelBuilder);
            }

        }



}