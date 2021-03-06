//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nwd.BackOffice.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Album
    {
        public Album()
        {
            this.Tracks = new HashSet<Track>();
        }
        
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public System.TimeSpan Duration { get; set; }

        [Required]
        public System.DateTime ReleaseDate { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string CoverImagePath { get; set; }

        public Nullable<int> Artist_Id { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
