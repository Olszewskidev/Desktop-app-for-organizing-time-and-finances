using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UserSettingInfoModel
    {
        private string GmailAdress;
        private string GmailPassword;
      
        public string Adress
        {
            get { return GmailAdress; }
            set { GmailAdress = value; }
        }
        public string Password
        {
            get { return GmailPassword; }
            set { GmailPassword = value; }
        }
     
    }
}
