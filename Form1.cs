using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Data.Common;


namespace SimTge
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TaiButton_Click(object sender, EventArgs e)
        {
           
            KetNoi ketNoi = new KetNoi();           
            DataSet ds = ketNoi.LayDuLieu("SELECT * FROM Sim");                       

            if (ds != null && ds.Tables.Count > 0 )
            {
              
                dgvSimThe.DataSource = ds.Tables[0];                             
            }
            else
            {
                MessageBox.Show("Không lấy được dữ liệu.");
            }
        }

        class KetNoi
        {
            string conStr = @"Data Source=LAPTOP-LU5D34UJ\SQLEXPRESS;Initial Catalog=SimThe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection conn;

            public KetNoi()
            {
                conn = new SqlConnection(conStr);
            }

            public DataSet LayDuLieu(string truyvan)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                    da.Fill(ds);
                    return ds;                  
                }
                catch
                {
                    return null;
                }
            }

            public bool ThucThi(string truyvan)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(truyvan, conn);
                    int r = cmd.ExecuteNonQuery();
                    conn.Close();
                    return r > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}




