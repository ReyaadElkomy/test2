using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
        private void Form1_Load(object sender, EventArgs e)
        {

            #region old code
            ////SqlDataReader dr = null;
            ////TreeNode parents = new TreeNode();
            ////TreeNode[] myTreeNodeArrayMain = null;
            ////TreeNode[] pp;

            ////List<TreeNode> parents = new List<TreeNode>();
            //using (SqlConnection con = new SqlConnection(conn))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("select name from test", con);
            //    using (SqlDataReader dr = cmd.ExecuteReader())
            //    {
            //        DataTable dt = new DataTable();
            //        dt.Load(dr);
            //        TreeNode[] myTreeNodeArray = new TreeNode[dt.Rows.Count];
            //        while (dr.Read())
            //        {
            //            for (int i = 0; i < dt.Rows.Count; i++)
            //            {
            //                myTreeNodeArray[i] = dr["name"] as TreeNode;
            //            }
            //            //parents.Nodes.Add(dr["name"].ToString());
            //            //.Add( as TreeNode);
            //        }
            //        treeView1.Nodes.AddRange(myTreeNodeArray);
            //    }
            //} 
            #endregion


            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getallcities", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow item in dt.Rows)
                {
                    TreeNode node = new TreeNode(item["name"].ToString());
                    //node.Nodes.Add(item["number"].ToString());
                    treeView1.Nodes.Add(node);
                }
            }



        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string x = e.Node.Text;

            //using (SqlConnection con = new SqlConnection(conn))
            //{
            //    int x = e.Node.Index;
            //    treeView1.Nodes.
            //    treeView1.Nodes.Remove(from q in treeView1.Nodes
            //                           where e.Node.Index !=x)
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("select * from test", con);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        TreeNode node = new TreeNode(item["name"].ToString());
            //        node.Nodes.Add(item["number"].ToString());
            //        treeView1.Nodes.Add(node);
            //    }

            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
