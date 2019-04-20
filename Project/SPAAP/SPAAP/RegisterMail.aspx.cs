using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ObjectAccess;

namespace SPAAP
{
    public partial class RegisterMail : System.Web.UI.Page
    {
        public enum MessageType { Success, Error, Info, Warning };
        ObjectAccess.SPAAP obj = new   ObjectAccess.SPAAP();
     
        DataAccess.SPAAPDA objda = new DataAccess.SPAAPDA();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnRegister_Click(object sender, EventArgs e)
        {

            string randdom = CreateRandomPassword(10);
            int t = Insert(txtEmail.Text, randdom);
            if (t == 1)
            {
                if(txtEmail.Text.Contains("gmail.com"))
                { 
                string subject1 = "Your Password is :";
                MailMessage _mailmsg = new MailMessage();

                //Make TRUE because our body text is html  
                _mailmsg.IsBodyHtml = true;

                //Set From Email ID  
                _mailmsg.From = new MailAddress("m.mohankrishna007@gmail.com");

                //Set To Email ID  
                _mailmsg.To.Add(txtEmail.Text);

                //Set Subject  
                _mailmsg.Subject = "Welcome to new user";

                //Set Body Text of Email   
                _mailmsg.Body = subject1 + randdom;


                //Now set your SMTP   
                SmtpClient _smtp = new SmtpClient();

                //Set HOST server SMTP detail  
                _smtp.Host = "smtp.mail.yahoo.com";

                //Set PORT number of SMTP  
                _smtp.Port = 465;

                //Set SSL --> True / False  
                _smtp.EnableSsl = true;

                //Set Sender UserEmailID, Password  
                NetworkCredential _network = new NetworkCredential("fasaksudheer2019@gmail.com", "9701030174");
                _smtp.Credentials = _network;

                //Send Method will send your MailMessage create above.  
                _smtp.Send(_mailmsg);
                }
                else if (txtEmail.Text.Contains("yahoo"))
                {
                    string subject1 = "Your Password is :";
                    MailMessage _mailmsg = new MailMessage();

                    //Make TRUE because our body text is html  
                    _mailmsg.IsBodyHtml = true;

                    //Set From Email ID  
                    _mailmsg.From = new MailAddress("m.mohankrishna007@gmail.com");

                    //Set To Email ID  
                    _mailmsg.To.Add(txtEmail.Text);

                    //Set Subject  
                    _mailmsg.Subject = "Welcome to new user";

                    //Set Body Text of Email   
                    _mailmsg.Body = subject1 + randdom;


                    //Now set your SMTP   
                    SmtpClient _smtp = new SmtpClient();

                    //Set HOST server SMTP detail  
                    _smtp.Host = "smtp.gmail.com";

                    //Set PORT number of SMTP  
                    _smtp.Port = 587;

                    //Set SSL --> True / False  
                    _smtp.EnableSsl = true;

                    //Set Sender UserEmailID, Password  
                    NetworkCredential _network = new NetworkCredential("fasaksudheer2019@gmail.com", "9701030174");
                    _smtp.Credentials = _network;

                    //Send Method will send your MailMessage create above.  
                    _smtp.Send(_mailmsg);

                }
               // ShowMessage("Record submitted successfully", MessageType.Success);

            }
            else
            {

            }
        }
        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        private static string CreateRandomPassword(int length)
        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        protected int  Insert(string emailid, string randdom)
        {

                obj.EmailID = txtEmail.Text;
                obj.Password = randdom;
                int i= objda.AddUserDetails(obj);

                return i;

           
        }
           
            
                 
        
    }
}