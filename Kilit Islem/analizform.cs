using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilit
{
    public partial class analizform : Form
    {
        public analizform()
        {
            InitializeComponent();
        }
        OleDbConnection bag2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "/usersdb.mdb");

        private void analizformcs_Load(object sender, EventArgs e)
        {

            OleDbCommand cmd = new OleDbCommand("Select * From Users ", bag2);
            bag2.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable veriler = new DataTable();
            da.Fill(veriler);
            bag2.Close();
            dataGridView1.DataSource = veriler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
