using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
  public  class SPAAPBO
    {
      public int AddUserDetails(SPAAP objUserBL) // passing Bussiness object Here  
      {
          try
          {
              SPAAPDA objUserda = new SPAAPDA(); // Creating object of Dataccess  
              return objUserda.AddUserDetails(objUserBL); // calling Method of DataAccess  
          }
          catch
          {
              throw;
          }
      } 
    }
}
