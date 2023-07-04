using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace M11LabShaymaa.model
{
    public class Album
    {
        public int Id { get; set; }

        public string AlbumName { get; set; }

        public DateTime Released { get; set; }

        public List<Song> Songs { get; set; }

        public Singer  ParentSinger { get; set; }

        [ForeignKey("ParentSinger")]
        public int SingerId { get; set; }

    }
}
