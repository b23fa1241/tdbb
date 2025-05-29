using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tdbb
{
    public partial class Skill : UserControl
    {
        public Skill()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Skill_Load);
        }

        private void Skill_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Class1.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM SkillLevel";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.AutoGenerateColumns = true; 
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа өгөгдөл ачаалахад: " + ex.Message);
            }
        }
    }
}
