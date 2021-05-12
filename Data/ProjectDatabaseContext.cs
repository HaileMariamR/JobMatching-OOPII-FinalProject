using Microsoft.EntityFrameworkCore;

namespace ProjectContext.Data{


        public class ProjectDatabaseContext:DbContext{

            public ProjectDatabaseContext(DbContextOptions<ProjectDatabaseContext> options):base(options){

            }



        }



}