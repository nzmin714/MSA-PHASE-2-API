using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BananaPeelrAPI.Models
{
    public class Playlist
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PlaylistID { get; set; }
        public string Playlist_Name { get; set; }
        public int UserID { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}
