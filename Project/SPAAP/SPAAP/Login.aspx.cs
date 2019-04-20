using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObjectAccess;
using System.Data.SqlClient;
namespace SPAAP
{
    public partial class Login : System.Web.UI.Page
    {
        ObjectAccess.SPAAP obj = new ObjectAccess.SPAAP();

        DataAccess.SPAAPDA objda = new DataAccess.SPAAPDA();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void  OnSignIn_Click(object sender, EventArgs e)
        {
            obj.EmailID = txtEmail.Text;
            obj.Password = txtPassword.Text;
           
            SqlDataReader dr= objda.validateuser(obj);

            if (dr.HasRows)
            {


            }
            else
            {

            }
        
        }
    }
}