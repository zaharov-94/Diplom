using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class HelpPage
    {
        string name;
        string url;
        public HelpPage(string name, string url)
        {
            this.name = name;
            this.url = url;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = Name;
            }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                this.url = Url;
            }
        }
    }
}
