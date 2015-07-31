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

namespace TestTxApp
{
  public partial class Form1 : Form
  {
    string localInfo;
    string remoteInfo;

    public Form1()
    {
      InitializeComponent();
      //
      // TextApp
      //
      // Sharad Tanwar
      // U. of Illinois, Chicago
      // CS480, Summer 2015
      // Homework 4 - App
      //
      // 
      // constructor: setup connection info
      //
      string filename = "TestTx.mdf";

      localInfo = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\{0};Integrated Security=True;", 
        filename);
      remoteInfo = String.Format(@"Data Source=crispix-W520;Initial Catalog={0};User ID=sa;Password=abc123!",
        filename);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //
      // setup local and remote connection strings:
      //
      this.txtLocal.Text = localInfo;
      this.txtRemote.Text = remoteInfo;

      //
      // check the "local" option to load users and songs locally:
      //
      this.radioLocal.Checked = true;
    }

    private void radioLocal_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioLocal.Checked)
      {
        this.listBox1.Items.Clear();
        this.listBox1.Items.Add("<<local>>");
      }
    }

    private void radioRemote_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioRemote.Checked)
      {
        this.listBox1.Items.Clear();
        this.listBox1.Items.Add("<<remote>>");
      }
    }

    private void cmdExecute_Click(object sender, EventArgs e)
    {
        string connectionInfo;

        if (radioLocal.Checked)
            connectionInfo = this.txtLocal.Text;
        else
            connectionInfo = this.txtRemote.Text;

        SqlConnection db;
        bool done = false;

        while (!done)
        {
            try
            {
                db = new SqlConnection(connectionInfo);
                db.Open();
            }
            catch (Exception Ex)
            {
                string msg2 = string.Format("Open Failed,'{0}'", Ex.Message);
                MessageBox.Show(msg2);
                return;
            }

            System.Diagnostics.Debug.Assert(db.State == ConnectionState.Open);

            SqlTransaction tx = null;

            try
            {
                tx = db.BeginTransaction(IsolationLevel.Serializable); // No duplicates
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Cant begin Transaction");
                db.Close();
                return;
            }


            //
            // compute max value in the table:
            //
            try
            {
                string sql = @"Select MAX(TestValue) From Tests (UPDLOCK);";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = sql;
                cmd.Transaction = tx;

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    tx.Rollback(); // Roll back...
                    db.Close();
                    MessageBox.Show("**Error: select failed?!");
                    return;
                }

                int max = Convert.ToInt32(result);

                //
                // add one for insert:
                //
                max++;

                //
                // pause to ensure others compute the same MAX value?
                //
                int timeInMS;
                if (Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true)
                    ;
                else
                    timeInMS = 0;  // no delay:

                System.Threading.Thread.Sleep(timeInMS);

                //
                // Now insert this value into table:
                //
                sql = string.Format(@"Insert Into Tests(TestValue) Values({0});", max);
                cmd.CommandText = sql;
                cmd.Transaction = tx;

                int rowsModified = cmd.ExecuteNonQuery();
                if (rowsModified != 1)
                {
                    tx.Rollback();
                    db.Close();
                    MessageBox.Show("**Error: insert failed?!");
                    return;
                }

                string msg = string.Format("Inserted: {0}", max);
                this.listBox1.Items.Insert(0, msg);
                tx.Commit(); // Commiting 
                done = true;
                // db.Close();
            }
            catch (SqlException Sqlex)
            {
                if (Sqlex.Number == 1205)
                {
                    MessageBox.Show("deadlock");
                }
                else
                {
                    tx.Rollback();
                    MessageBox.Show("Other SQL Exception");
                    done = true;
                    return;
                }
                // return;
            }
            catch (Exception Ex)
            {
                tx.Rollback();
                MessageBox.Show("Something bad happened");
                return;
            }
            finally
            {
                db.Close();
            }
        }
    }

  }//class
}//namespace
