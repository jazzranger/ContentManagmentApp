using Newtonsoft.Json;
using System.Collections.Generic;

namespace WpfApp2.Models
{
    class Document
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("FileName")]
        public string FileName { get; set; }

        [JsonProperty("File")]
        public string File { get; set; }

        [JsonProperty("ContentTypeID")]
        public int ContentTypeID { get; set; }

        [JsonProperty("ObjectID")]
        public int ObjectID { get; set; }

        [JsonProperty("Fields")]
        public List<Field> Fields { get; set; }

    }
}
