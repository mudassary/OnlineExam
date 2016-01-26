//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineExamApp.Model.EFSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public Exam()
        {
            this.ExamDetails = new HashSet<ExamDetail>();
            this.UserResponseHeaders = new HashSet<UserResponseHeader>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }
        public virtual ICollection<UserResponseHeader> UserResponseHeaders { get; set; }
    }
}
