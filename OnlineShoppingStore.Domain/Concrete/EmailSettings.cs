using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "soileep@gmail.com";
        public string MailFromAddress = "soileep@gmail.com";
        public bool UseSsl = true;
        public string UserName = "soileep@gmail.com";
        public string Password = "";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;

        //public bool WriteAsFile = true;
        //public string FileLocation = @"D:\VisualStudio2015\Projects\OnlineShoppingStore\OnlineShoppingStore.Domain\emails";
    }
}
