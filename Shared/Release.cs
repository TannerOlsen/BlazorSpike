using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSpike.Shared
{
    public class Release
    {

        public Release() { }

        public Release(int id, string name, string notes)
        {
            this.Id = id;
            this.Name = name;
            this.Notes = notes;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }
    }
}
