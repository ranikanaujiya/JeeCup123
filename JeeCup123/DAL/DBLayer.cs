using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JeeCup123.Models.DAL
{
    public class DBLayer:DbContext

    {
        // constructer ban gya
        public DBLayer():base("Conn")
        {

        }
        SqlConnection dbcon;

        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["Conn"].ToString();
            dbcon = new SqlConnection(constring);

        }

        // calling db proc start//

        public RegisterModel InsertData_RegFrom(RegisterModel model)
        {

            //   parameter ke liye 
            var SqlParams = new SqlParameter[]
            {
                new SqlParameter{ParameterName="@name",Value=model.name},
                 new SqlParameter{ParameterName="@father_name",Value=model.father_name},
                  new SqlParameter{ParameterName="@mother_name",Value=model.mother_name},
                   new SqlParameter{ParameterName="@dob",Value=model.dob},
                   new SqlParameter{ParameterName="@gender",Value=model.gender},

            };

            var proc = @"Proc_InsertData @name,@father_name,@mother_name,@dob,@gender";
            var list = this.Database.SqlQuery<RegisterModel>(proc, SqlParams).ToList().FirstOrDefault();
            return list;
           // @name,@father_name,@mother_name,dob,gender

        }

        public List<RegisterModel> GetDatafromProc()
        {

           
            var SqlParams = new SqlParameter[]
            {
          

            };

            var proc = @"GetRegistrationData";
            var list = this.Database.SqlQuery<RegisterModel>(proc, SqlParams).ToList();
            return list;
          
        }


    }
}