using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Banck
    {
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset PreviousDate { get; set; }
        public string PreviousUrl { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public Dictionary<string, Valute> Valute { get; set; }
    }
}
