//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeRank.Database.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        public Candidate()
        {
            this.Exams = new HashSet<Exam>();
        }
    
        public int CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string emailID { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
