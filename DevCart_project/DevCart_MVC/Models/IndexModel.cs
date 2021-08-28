using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCart_MVC.Models
{
    public class IndexModel
    {
        public List<Project> Projects { get; set; }
        public List<Article> Articles { get; set; }
    }
}
