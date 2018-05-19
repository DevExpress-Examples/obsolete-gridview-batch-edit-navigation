using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T283418.Models
{
    public class Data
    {
        public int ID { get; set; }
        public string SomeData { get; set; }
        public string AnotherData { get; set; }
        public static List<Data> GetData()
        {
            return Enumerable.Range(0, 50).Select(i => new Data() { ID = i, SomeData = "Data " + i, AnotherData = "AnotherData" + i }).ToList<Data>();
        }
    }
}