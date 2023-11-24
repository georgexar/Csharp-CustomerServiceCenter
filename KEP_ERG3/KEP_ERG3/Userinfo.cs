using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEP_ERG3
{
    public class Userinfo
    {

        private string uniqueId;
        private string name;
        private string email;
        private long phonenum;
        private string birth_date;
        private string aitima;
        private string postal;
        private DateTime date;


        public Userinfo(string uniqueId, string name,string email,long phonenum,string birth_date,string aitima,string postal,DateTime date) 
        {
            this.uniqueId = uniqueId;
           this.name = name;  
           this.email = email; 
           this.phonenum = phonenum;   
           this.birth_date = birth_date;
           this.aitima = aitima;
           this.postal = postal;
           this.date = date;
        }

        public void setName(string name) { this.name = name; }
        public void setEmail(string email) { this.email = email; }
        public void setPhonenum(long num) { this.phonenum = num; }
        public void setBirth_date(string birth_date) { this.birth_date = birth_date; }
        public void setAitima(string aitima) { this.aitima = aitima; }
        public void setPostal(string postal) { this.postal = postal; }
        public void setDate(DateTime date) { this.date = date; }

        public String getUniqueId() { return this.uniqueId; }
        public void setUniqueId(string id) { this.uniqueId = id; }


        public string getName() { return this.name; }
        public string getEmail() { return this.email; }
        public long getPhonenum() { return this.phonenum; }
        public string getBirth_date() { return this.birth_date; }
        public string getAitima() { return this.aitima; }
        public string getPostal() { return this.postal; }
        public DateTime getDate() { return this.date; }
       





    }
}
