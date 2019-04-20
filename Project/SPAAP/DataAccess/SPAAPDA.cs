using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectAccess;
using System.Data;
namespace DataAccess
{
    public class SPAAPDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sapap"].ToString());

        public int AddUserDetails(SPAAP ObjBO) // passing Bussiness object Here  
        {
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx) To in Bussiness object and then Pass it to Bussiness logic and then to DataAcess  this way the flow carry on*/
                SqlCommand cmd = new SqlCommand("SP_EmailRegisteration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", ObjBO.EmailID);
                cmd.Parameters.AddWithValue("@Password", ObjBO.Password);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;
            }
            catch
            {
                throw;
            }
        }

        public SqlDataReader validateuser(SPAAP ObjBO) // passing Bussiness object Here  
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sapap"].ToString());
           
           
            SqlCommand cmd = new SqlCommand("Sp_Validate_User", con);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", ObjBO.EmailID.Trim());
            cmd.Parameters.AddWithValue("@Password", ObjBO.Password.Trim());
            cmd.CommandTimeout = 0;
            return cmd.ExecuteReader();


        }
    }
}
