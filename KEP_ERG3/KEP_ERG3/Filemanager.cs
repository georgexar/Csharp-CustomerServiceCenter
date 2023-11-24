using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace KEP_ERG3
{
    public class Filemanager
    {

        private OleDbConnection connection;
        private String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ClientDatabase.mdb;";

        public Filemanager()
        {
            connection = new OleDbConnection(connectionString);
            
        }


        public void saveuser(Userinfo user) 
        {
            
            connection.Open();

            String sql = "INSERT INTO clientInfo([clientName], [clientEmail], [clientPhone], [clientBirthdate]" +
                ", [clientDate], [clientRequest], [clientPostal], [uniqueId]) VALUES(@name, @email, @phone, @birthdate, @clientDate, @request, @postal, @uniqueId)";

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddRange(new OleDbParameter[]
            {
                
                new OleDbParameter("@name", user.getName()),
                new OleDbParameter("@email", user.getEmail()),
                new OleDbParameter("@phone", user.getPhonenum()),
                new OleDbParameter("@birthdate", user.getBirth_date().ToString()),
                new OleDbParameter("@clientDate", user.getDate().ToString()),
                new OleDbParameter("@request", user.getAitima()),
                new OleDbParameter("@postal", user.getPostal()),
                new OleDbParameter("@uniqueId", user.getUniqueId())
            });

            command.ExecuteNonQuery();

            connection.Close();
            

        }

        public OleDbConnection getConnection() { return this.connection; }
    }
}
