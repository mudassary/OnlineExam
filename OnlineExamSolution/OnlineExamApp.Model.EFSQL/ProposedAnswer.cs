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
    
    public partial class ProposedAnswer
    {
        public ProposedAnswer()
        {
            this.QuestionProposedAnswers = new HashSet<QuestionProposedAnswer>();
            this.UserResponseDetails = new HashSet<UserResponseDetail>();
            this.QuestionAnswers = new HashSet<QuestionAnswer>();
        }
    
        public int ID { get; set; }
        public string AnswerText { get; set; }
    
        public virtual ICollection<QuestionProposedAnswer> QuestionProposedAnswers { get; set; }
        public virtual ICollection<UserResponseDetail> UserResponseDetails { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}