using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace chatServer
{
    [Serializable]
    public class iceCandidates
    {
        public List<String> candidates { get; set; }
        public iceCandidates()
        {
            this.candidates = new List<String>();
        }
    }
}
