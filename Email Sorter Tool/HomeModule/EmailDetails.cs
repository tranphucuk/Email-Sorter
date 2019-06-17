using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sorter_Tool.HomeModule
{
    public class EmailDetails
    {
        [DisplayName("Type")]
        public string EmailType { get; set; }
        [DisplayName("Count")]
        public int ResultCount { get; set; }
        [DisplayName("Percent")]
        public string Percentage { get; set; }
        [DisplayName("File")]
        public string FileName { get; set; }
        public bool IsSaved { get; set; }
    }
}
