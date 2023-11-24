using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KEP_ERG3
{
    public partial class DataShow : Form
    {

        public static String name = "";
        public static String email = "";
        public static String postal = "";
        public static String phone = "";
        public static String birthdate = "";
        public static String request = "";

        public DataShow()
        {
            InitializeComponent();
        }

        private void DataShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDatabaseDataSet.clientInfo' table. You can move, or remove it, as needed.
            clientInfoTableAdapter.Connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ClientDatabase.mdb;";

            Program.getFileManager().getConnection().Open();
            
            // TODO: This line of code loads data into the 'clientDatabaseDataSet.clientInfo' table. You can move, or remove it, as needed.

            OleDbCommand cmd = Program.getFileManager().getConnection().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientInfo";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            

            Program.getFileManager().getConnection().Close();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("clientName LIKE '%{0}%'", textBox1.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("clientPhone LIKE '%{0}%'", textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("clientEmail LIKE '%{0}%'", textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM clientInfo WHERE uniqueId=[@uniqueId]";

            Program.getFileManager().getConnection().Open();

            OleDbCommand cmd = Program.getFileManager().getConnection().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@uniqueId", textBox4.Text);

            int i = cmd.ExecuteNonQuery();

            if(i == 0)
            {
                MessageBox.Show("Invalid UniqueID!");
            }
            else
            {
                MessageBox.Show("Request has been deleted!");
            }

            Program.getFileManager().getConnection().Close();

            DataShow_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string uniqueId = textBox4.Text;



            string sql = "SELECT * FROM clientInfo WHERE uniqueId=[@uniqueId]";
            Program.getFileManager().getConnection().Open();
            OleDbCommand cmd = Program.getFileManager().getConnection().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@uniqueId", uniqueId);
            OleDbDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while(reader.Read())
            {
                i++;
                name = reader.GetString(0);
                email = reader.GetString(1);
                phone = reader.GetString(2);
                birthdate = reader.GetString(3);
                request = reader.GetString(5);
                postal = reader.GetString(6);


            }




            if(i == 0)
            {
                MessageBox.Show("Invalid Request!");
            }
            else
            {
                Program.uniqueId = uniqueId;
                this.Hide();
                Program.form4 = new Form4();
                Program.form4.Show();
                
            }
            reader.Close();

            Program.getFileManager().getConnection().Close();

            



        }
    }
}
