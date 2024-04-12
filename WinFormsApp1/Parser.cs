using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TLV
{
    public class Parser:IParser
    {
        private readonly List<TLV> tlv_data;
        private readonly List<TLV> tlv_parser;
        private readonly IList<AID> aids;
        public Parser()
        {
            tlv_data = new List<TLV>();
            tlv_parser = new List<TLV>();
            aids = new List<AID>();
            readTag();
            readAid();
        }
        private void readAid()
        {
            AID aid;
            foreach (string line in File.ReadLines(@"C:\TLV\aid.txt", Encoding.UTF8))
            {
                var model = line.Split('*');
                aid = new AID()
                {
                    ApplicationIdentifier = model[0],
                    Vendor = model[1].Replace("null", ""),
                    Country = model[2].Replace("null", ""),
                    Name = model[3].Replace("null", ""),
                    Description = model[4].Replace("null", ""),
                    Type = model[5].Replace("null", "")
                };
                aids.Add(aid);
            }
        }
        private void readTag()
        {
            TLV tlv;
            foreach (string line in File.ReadLines(@"C:\TLV\data.txt", Encoding.UTF8))
            {
                var model = line.Split(':');
                tlv = new TLV
                {
                    Value = model[1],
                    Description = model[1],
                    Tag = model[0].Trim()
                };

                tlv_data.Add(tlv);
            }
        }
        public AID getAid(string data)=>aids.Where(i => i.ApplicationIdentifier == data).FirstOrDefault();
        public List<TLV> getTlv(string data)
        {
            tlv_parser.Clear();
            string model = "";
            string len = "";
            string value = "";
            int i = 0;
           
            while (i < data.Length)
            {
                
                model += data[i];
                TLV tlv=new();
                for (int j = 0; j < tlv_data.Count; j++)
                {
                    tlv = tlv_data.Find(i => i.Tag == model);

                }
                if (tlv != null)
                {
                    TLV mod = new();
                    len += data[++i];
                    len += data[++i];
                    uint step = Convert.ToUInt32(len, 16) * 2;
                    mod.Length = len;
                    int j = 0;
                    for (; j < step; j++)
                    {
                        value += data[(j + i + 1)];
                    }
                    i += j;
                    mod.Tag = tlv.Tag;
                    mod.Description = tlv.Description;
                    mod.Value = value;
                    tlv_parser.Add(mod);
                    value = "";
                    len = "";
                    model = "";
                }
                i++;
            }
            return tlv_parser;
        }

    }


    public interface IParser
    {
        public AID getAid(string data);
        public List<TLV> getTlv(string data);
    }
}
