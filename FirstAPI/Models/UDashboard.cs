using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FirstAPI.Models
{
    public class UDashboard
    {
        public int PId { get; set; }
        public int Jig_ID { get; set; }
        public string Jig_Name { get; set; }
        public string Level_Name { get; set; }
        public string issue { get; set; }      
        public DateTime Fromdate { get; set; }
        public int Aging { get; set; }
        public int Hour { get; set; }
    }
}
