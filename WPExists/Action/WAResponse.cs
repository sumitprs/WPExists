using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPExists.Action
{
    public class WAResponse
    {
        public string Number { get; set; }
        public string Exists { get; set; }
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public string Exception { get; set; }
        public string InnerException { get; set; }
    }
}
