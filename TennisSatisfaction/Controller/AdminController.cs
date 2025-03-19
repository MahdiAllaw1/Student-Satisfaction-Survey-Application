using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TennisSatisfaction.Model;

namespace TennisSatisfaction.Controller
{
    internal class AdminController
    {
        private Admin admin;
        private const string adminInfo = "AdminInfo.txt";

        public AdminController() { }

        public AdminController(string name, string password)
        {
            this.admin = new Admin(name, password);
        }

        public Boolean SignIn()
        {
            if (File.Exists(adminInfo))
            {
                StreamReader Reader = new StreamReader(adminInfo);
                string str = Reader.ReadLine();
                if (str != null)
                {
                    string[] Data = str.Split('|');
                    if (admin.VerifyName(Data[0]))
                    {
                        if (admin.VerifyPassword(Data[1]))
                        {
                            Reader.Close();
                            return true;
                            MessageBox.Show("Welcome " + admin.Name);
                        }
                        else
                        {
                            MessageBox.Show("incorrect password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username: aka " + admin.Name);
                    }
                }
                Reader.Close();
                return false;
            }
            else
            {
                MessageBox.Show("there's no admin yet");
            }
            return false;
        }        
    }
}
