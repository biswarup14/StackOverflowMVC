using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowMVC.DomainModels
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; } 
        public string QuestionName { get; set; }
        public DateTime QuestionDateAndTime { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int VotesCount { get; set; }
        public int ViewsCount { get; set; }
        public int AnswersCount { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        /*
         One Question may have multiple solutions/answers, so to store the answers of a 
        specific question we created a property of List type called Answers
        */
        public virtual List<Answer> Answers { get; set; }
    }
}
