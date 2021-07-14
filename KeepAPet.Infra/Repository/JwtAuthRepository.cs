using KeepAPet.Core.Common;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace KeepAPets.Infra.Repository
{
    public class JwtAuthRepository // : IJwtAuthRepository
    {
/*        private readonly IDBContext DBContext;
        public JwtAuthRepository(IDBContext dbContext)
        {
            DBContext = dbContext;
        }

        public int AuthenticateEmployee(Employees Emp)
        {

            DbConnection conn = DBContext.Connection;
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LoginEmployee";

            DbParameter UserName = cmd.CreateParameter();
            UserName.DbType = DbType.String;
            UserName.Direction = ParameterDirection.Input;
            UserName.ParameterName = "@UserName";
            UserName.Value = Emp.Email;
            cmd.Parameters.Add(UserName);

            DbParameter Password = cmd.CreateParameter();
            Password.DbType = DbType.String;
            Password.Direction = ParameterDirection.Input;
            Password.Value = Emp.Password;
            Password.ParameterName = "@Password";
            cmd.Parameters.Add(Password);

            DbParameter Check = cmd.CreateParameter();
            Check.DbType = DbType.Int32;
            Check.Direction = ParameterDirection.Output;
            Check.Size = 32;
            Check.ParameterName = "@Check";
            cmd.Parameters.Add(Check);
            cmd.ExecuteReader();


            return (int)Check.Value;
        }

        public int AuthenticateDoctor(Doctor doctor)
        {

            DbConnection conn = DBContext.Connection;
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LoginDoctor";

            DbParameter UserName = cmd.CreateParameter();
            UserName.DbType = DbType.String;
            UserName.Direction = ParameterDirection.Input;
            UserName.ParameterName = "@UserName";
            UserName.Value = doctor.Email;
            cmd.Parameters.Add(UserName);

            DbParameter Password = cmd.CreateParameter();
            Password.DbType = DbType.String;
            Password.Direction = ParameterDirection.Input;
            Password.Value = doctor.Password;
            Password.ParameterName = "@Password";
            cmd.Parameters.Add(Password);

            DbParameter Check = cmd.CreateParameter();
            Check.DbType = DbType.Int32;
            Check.Direction = ParameterDirection.Output;
            Check.Size = 32;
            Check.ParameterName = "@Check";
            cmd.Parameters.Add(Check);
            cmd.ExecuteReader();


            return (int)Check.Value;
        }
        public int AuthenticateCustomer(Customer customer)
        {

            DbConnection conn = DBContext.Connection;
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LoginCustomer";

            DbParameter UserName = cmd.CreateParameter();
            UserName.DbType = DbType.String;
            UserName.Direction = ParameterDirection.Input;
            UserName.ParameterName = "@UserName";
            UserName.Value = customer.Email;
            cmd.Parameters.Add(UserName);

            DbParameter Password = cmd.CreateParameter();
            Password.DbType = DbType.String;
            Password.Direction = ParameterDirection.Input;
            Password.Value = customer.Password;
            Password.ParameterName = "@Password";
            cmd.Parameters.Add(Password);

            DbParameter Check = cmd.CreateParameter();
            Check.DbType = DbType.Int32;
            Check.Direction = ParameterDirection.Output;
            Check.Size = 32;
            Check.ParameterName = "@Check";
            cmd.Parameters.Add(Check);
            cmd.ExecuteReader();


            return (int)Check.Value;
        }

       */
    }

}