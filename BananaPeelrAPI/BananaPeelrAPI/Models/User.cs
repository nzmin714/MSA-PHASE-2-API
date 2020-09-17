using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BananaPeelrAPI.Models
{
    public class User
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserID { get; set; }

        public string F_name { get; set; }
        public string L_name { get; set; }
        public string Email { get; set; }

        // foreign key to Playlist
        public ICollection<Playlist> Playlists { get; set; }
    }
}
