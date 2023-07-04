using System;
using System.Collections.Generic;
using System.Text;

namespace M11LabShaymaa.model
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public int ActiveSince { get; set; }

        public List<Album> Albums { get; set; }
    }
}
