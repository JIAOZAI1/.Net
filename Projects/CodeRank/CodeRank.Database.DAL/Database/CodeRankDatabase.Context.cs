﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class CodeRankEntities : DbContext
    {
        public CodeRankEntities()
            : base("name=CodeRankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<PaperSet> PaperSets { get; set; }
        public DbSet<PaperSetQuestion> PaperSetQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
    
        public virtual ObjectResult<GetPaperSetQuestions_Result> GetPaperSetQuestions(Nullable<int> paperSetID)
        {
            var paperSetIDParameter = paperSetID.HasValue ?
                new ObjectParameter("PaperSetID", paperSetID) :
                new ObjectParameter("PaperSetID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPaperSetQuestions_Result>("GetPaperSetQuestions", paperSetIDParameter);
        }
    
        public virtual ObjectResult<GetCandidate_Result> GetCandidate(Nullable<int> candidateID)
        {
            var candidateIDParameter = candidateID.HasValue ?
                new ObjectParameter("CandidateID", candidateID) :
                new ObjectParameter("CandidateID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCandidate_Result>("GetCandidate", candidateIDParameter);
        }
    
        public virtual ObjectResult<GetCandidateExamResult_Result> GetCandidateExamResult(Nullable<int> candidateID, Nullable<int> examID)
        {
            var candidateIDParameter = candidateID.HasValue ?
                new ObjectParameter("CandidateID", candidateID) :
                new ObjectParameter("CandidateID", typeof(int));
    
            var examIDParameter = examID.HasValue ?
                new ObjectParameter("ExamID", examID) :
                new ObjectParameter("ExamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCandidateExamResult_Result>("GetCandidateExamResult", candidateIDParameter, examIDParameter);
        }
    
        public virtual ObjectResult<GetCandidateExams_Result> GetCandidateExams(Nullable<int> candidateID)
        {
            var candidateIDParameter = candidateID.HasValue ?
                new ObjectParameter("CandidateID", candidateID) :
                new ObjectParameter("CandidateID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCandidateExams_Result>("GetCandidateExams", candidateIDParameter);
        }
    }
}
