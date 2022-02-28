using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Helpers.Project
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public List<Project> SubProjects { get; set; }


    }
}
