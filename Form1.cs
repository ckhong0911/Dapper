using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    // Data fields.
    private readonly string _sql = "Select * From [PreCaution] Where CustID = @CustID";

    public Form1()
    {
      InitializeComponent();
    }

    private void txtCustId_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        using (SqlConnection cnn = new SqlConnection(SqlCRUD.cnn))
        {
          var result = cnn.QueryFirstOrDefault<PreCuation>(_sql, new {CustID = txtCustId.Text});
          if (result != null)
            txtPrecaution.Text = result.Content.ToString();
          else
            txtPrecaution.Text = "";
        }
      }
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
      string custId = txtCustId.Text;
      string cmd;

      using (SqlConnection cnn = new SqlConnection(SqlCRUD.cnn))
      {
        var result = cnn.QueryFirstOrDefault<PreCuation>(_sql, new { CustID = custId });
        if (result != null)
        {
          // the second time is update data from database.
          cmd = "Update [PreCaution] Set Content = @Content Where CustID = @CustID";
        }
        else
        {
          // first time is inert data into database.
          cmd = "Insert into [PreCaution] (CustID,Content) Values(@CustID,@Content)";
        }

        // parameters.
        //var parameters = new PreCuation()
        //{
        //  CustID = custId,
        //  Content = txtPrecaution.Text
        //};

        // you can also use dynamicparameters object.
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("CustID", custId);
        parameters.Add("Content", txtPrecaution.Text);

        cnn.Execute(cmd, parameters);
        MessageBox.Show("Successfully");
      }
    }
  }


  /// <summary>
  /// Parameters.
  /// </summary>
  public class PreCuation
  {
    /// <summary>
    /// Customer number.
    /// </summary>
    public string CustID { get; set; }

    /// <summary>
    /// Precaution content.
    /// </summary>
    public string Content { get; set; }
  }
}
