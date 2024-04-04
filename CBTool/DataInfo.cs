using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBTool
{
    internal class DataInfo
    {
        public static Dictionary<string, string> scene_numbering = new Dictionary<string, string>()
        {
            {"00000","操场"},
            {"00001","教室"},
            {"00010","伟鸿教育基地"},
            {"00011","校外活动"},
        };

        public static Dictionary<string, string> category_numbering = new Dictionary<string, string>()
        {
            {"a0000","大合照"},
            {"a0001","集体照"},
            {"a0010","军训"},
            {"a0011","百日誓师"},
            {"a0100","体能训练"},
            {"a0110","学校日常"},
            {"a0111","冬至happiness"},
            {"a1111","趣味运动会"},
            {"b0000","颁奖"},
            {"b0001","初三晋级仪式"},
        };

        public static Dictionary<string, string> member_numbering = new Dictionary<string, string>
        {
            {"A0000", "All" },
            {"A0001", "班旖旎"},
            {"A0002", "车魏安"},
            {"A0003", "陈晓红"},
            {"A0004", "付锦慈"},
            {"A0005", "付尚辉"},
            {"A0006", "葛俊烨"},
            {"A0007", "古鹤松"},
            {"A0008", "古新春"},
            {"A0009", "贺新伟"},
            {"A0010", "黄炳杰"},
            {"A0011", "黄浩宇"},
            {"A0012", "黄嘉兴"},
            {"A0013", "黄子龙"},
            {"A0014", "黄子轩"},
            {"A0015", "李搌通"},
            {"A0016", "梁流怀"},
            {"A0017", "梁子康"},
            {"A0018", "林梓杰"},
            {"A0019", "刘佳鹏"},
            {"A0020", "刘洁滢"},
            {"A0021", "刘鑫"},
            {"A0022", "刘宇轩"},
            {"A0023", "柳慧砚"},
            {"A0024", "罗精精"},
            {"A0025", "罗镘烯"},
            {"A0026", "马宇翔"},
            {"A0027", "梅杨阳"},
            {"A0028", "那澜蓝"},
            {"A0029", "彭佳旺"},
            {"A0030", "孙瑾"},
            {"A0031", "王晨"},
            {"A0032", "熊心怡"},
            {"A0033", "杨婉佳"},
            {"A0034", "杨智文"},
            {"A0035", "杨梓涵"},
            {"A0036", "姚淋淋"},
            {"A0037", "张施嘉"},
            {"A0038", "钟家煜"},
            {"A0039", "周炟"},
            {"A0040", "周欣烨"},
            {"A0041", "庄亮"},
            {"A0042", "卓铂洋"},
            {"A0043", "卓志聪"},
            {"A0044", "邹荣"},
            {"A0045", "张智睿" }
        };

        public static void LoadFile() 
        {
            string jsonString = File.ReadAllText("data/scene_numbering.json");
            Dictionary<string, string> scene_numbering = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            string jsonString2 = File.ReadAllText("data/category_numbering.json");
            Dictionary<string, string> category_numbering = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString2);
            string jsonString3 = File.ReadAllText("data/member_numbering.json");
            Dictionary<string, string> member_numbering = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString3);
            DataInfo.scene_numbering = scene_numbering;
            DataInfo.category_numbering = category_numbering;
            DataInfo.member_numbering = member_numbering;
        }

        public static void GenData() 
        {
            if(!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            string updatedJson = Newtonsoft.Json.JsonConvert.SerializeObject(scene_numbering, Formatting.Indented);
            File.WriteAllText("data/scene_numbering.json", updatedJson);
            string updatedJson2 = Newtonsoft.Json.JsonConvert.SerializeObject(category_numbering, Formatting.Indented);
            File.WriteAllText("data/category_numbering.json", updatedJson2);
            string updatedJson3 = Newtonsoft.Json.JsonConvert.SerializeObject(member_numbering, Formatting.Indented);
            File.WriteAllText("data/member_numbering.json", updatedJson3);
        }
    }
}
