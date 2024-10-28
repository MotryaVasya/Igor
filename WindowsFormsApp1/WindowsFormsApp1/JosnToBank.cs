using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JosnToBank
    {
        public Banck GetBanck(string json)
        {
            return JsonConvert.DeserializeObject<Banck>(json);
        }
    }
}
