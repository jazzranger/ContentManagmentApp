using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagmentApp.Models
{
    static class Globals
    {
        public static User LoggedInUser { get; set; }

        public static Document selectedDoc { get; set; }

        public static List<Document> selectedBox { get; set; }
    }
}
