using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostDiary.Data
{
    public class Ghost
    {
        [Key]
        public int GhostId { get; set; }
        [Required]
        public string GhostName { get; set; }
        [Required]
        public string GhostClue1 { get; set; }
        [Required]
        public string GhostClue2 { get; set; }
        [Required]
        public string GhostClue3 { get; set; }

        public string GhostClue4 { get; set; }

    }
}
