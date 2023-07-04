using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace M11LabShaymaa.model
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Length { get; set; }

        public Album ParentAlbum { get; set; }

        [ForeignKey("ParentAlbum")]
        public int AlbumId { get; set; }
    }
}
