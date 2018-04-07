using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp
{
    class UserData
    {
        public string Qiyet;
        public string Vaxt;
        public string Oturacaq;
        public static List<UserData> users = new List<UserData>();
        public UserData(string qiymet, string vaxt, string oturcaq)
        {
            Qiyet = qiymet;
            Vaxt = vaxt;
            Oturacaq = oturcaq;
            users.Add(this);
            
        }
    }
}
