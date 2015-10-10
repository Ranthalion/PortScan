using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Computer
    {
        //public string name;
        public string ip { get; set; }


        public Computer()
        {
            //name = "unknown";
            ip = "unknown";
        }
        public void SetIP(string newIP)
        {
            ip = newIP;
        }


        /*public virtual string ToPrintableString()
        {
            return string.Join(", ",
                this.GetType()
                .GetFields()
                .Select(p => p.Name + ": " + p.GetValue(this));
        }*/
    }
    //public List<Computer> computers = new List

}
