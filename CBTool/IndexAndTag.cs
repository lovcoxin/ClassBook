using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CBTool
{
    public class IndexAndTag
    {
        public class Element(string name, IndexAndTag.Tag tag)
        {
            [JsonIgnore]
            [JsonPropertyName("name")]
            public string name = name;
            public Tag tag = tag;

            public override bool Equals(object? obj)
            {
                if (obj == null) return false;
                Element e = obj as Element;
                if (e == null) return false;
                return e.name.Equals(name);
            }

            public override int GetHashCode()
            {
                int hash = 17;
                hash = hash * 23 + name.GetHashCode();
                return hash;
            }
        }

        public class Tag(string scene_numbering, string category_numbering, List<string> member_numbering)
        {
            public string scene_numbering = scene_numbering;
            public string category_numbering = category_numbering;
            public List<string> member_numbering = member_numbering;
        }

        [JsonPropertyName("elemets")]
        [JsonIgnore]
        public HashSet<Element> elements = new HashSet<Element>();
    }
}
