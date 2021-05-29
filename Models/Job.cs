using System;

namespace Models.projectModels{

    public class Job{

        public int Id {get;set;}
        public string JobTitle   { get; set; }
        public string JobDetail {get;set;}
        public DateTime dateTime {get;set;}
        public string CompanyName { get; set; }
        public string userEmail { get; set; }
        public string CompanyNameLogo {get;set;}
        public string JobType {get;set;}
        public decimal SalaryRange {get;set;}
        
            
    }

}