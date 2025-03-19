using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSatisfaction.Model
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(500)]
        public string QuestionText_fr { get; set; }

        [Required]
        public string QuestionType { get; set; }  // Example: "scale", "yes_no", "text"

        // Navigation property: One question can have multiple responses
        public List<Response> Responses { get; set; } = new List<Response>();
    }
}
