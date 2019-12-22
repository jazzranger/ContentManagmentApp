using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagmentApp.Models
{
    class Field
    {
        //[JsonProperty("Title")]
        public string Title { get; set; }

        //[JsonProperty("Value")]
        public string Value { get; set; }

    }
}
