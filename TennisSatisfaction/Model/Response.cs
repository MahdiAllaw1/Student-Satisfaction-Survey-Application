using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSatisfaction.Model
{
    public class Response
    {
        [Required]
        public string Answer { get; set; }  // Store responses (e.g., "8", "Oui", "Plus de matchs")

        public Response(string response) 
        {
            Answer = response;
        }
    }
}
