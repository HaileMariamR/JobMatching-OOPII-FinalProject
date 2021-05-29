using System;


namespace Models.projectModels{

        public class EmployeeApplication  {
                public int Id { get; set; }
                public string ComapanyName { get; set; }
                public string Jobtitle { get; set; }
                public string EmployeeEmail { get; set; }
                public bool status {get;set;}
                public string jobOwnerEmail {get;set;}
                public DateTime DateofApplication {get;set;}

        
        }

}
