namespace WindowsFormsApp1
{
  partial class Form1
  {
    /// <summary>
    /// 設計工具所需的變數。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清除任何使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 設計工具產生的程式碼

    /// <summary>
    /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
    /// 這個方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtCustId = new System.Windows.Forms.TextBox();
      this.txtPrecaution = new System.Windows.Forms.TextBox();
      this.btnExecute = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label1.Location = new System.Drawing.Point(28, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Cust ID:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label2.Location = new System.Drawing.Point(28, 131);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(110, 24);
      this.label2.TabIndex = 1;
      this.label2.Text = "Precaution:";
      // 
      // txtCustId
      // 
      this.txtCustId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.txtCustId.Location = new System.Drawing.Point(32, 73);
      this.txtCustId.Name = "txtCustId";
      this.txtCustId.Size = new System.Drawing.Size(121, 33);
      this.txtCustId.TabIndex = 2;
      this.txtCustId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustId_KeyDown);
      // 
      // txtPrecaution
      // 
      this.txtPrecaution.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.txtPrecaution.Location = new System.Drawing.Point(32, 169);
      this.txtPrecaution.Multiline = true;
      this.txtPrecaution.Name = "txtPrecaution";
      this.txtPrecaution.Size = new System.Drawing.Size(373, 151);
      this.txtPrecaution.TabIndex = 3;
      // 
      // btnExecute
      // 
      this.btnExecute.BackColor = System.Drawing.Color.ForestGreen;
      this.btnExecute.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.btnExecute.ForeColor = System.Drawing.Color.White;
      this.btnExecute.Location = new System.Drawing.Point(277, 340);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(128, 49);
      this.btnExecute.TabIndex = 4;
      this.btnExecute.Text = "Execute";
      this.btnExecute.UseVisualStyleBackColor = false;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(441, 405);
      this.Controls.Add(this.btnExecute);
      this.Controls.Add(this.txtPrecaution);
      this.Controls.Add(this.txtCustId);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCustId;
    private System.Windows.Forms.TextBox txtPrecaution;
    private System.Windows.Forms.Button btnExecute;
  }
}

