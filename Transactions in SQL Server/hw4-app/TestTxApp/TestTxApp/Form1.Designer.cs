namespace TestTxApp
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.cmdExecute = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.radioLocal = new System.Windows.Forms.RadioButton();
      this.radioRemote = new System.Windows.Forms.RadioButton();
      this.txtLocal = new System.Windows.Forms.TextBox();
      this.txtRemote = new System.Windows.Forms.TextBox();
      this.txtTimeInMS = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdExecute
      // 
      this.cmdExecute.Location = new System.Drawing.Point(12, 12);
      this.cmdExecute.Name = "cmdExecute";
      this.cmdExecute.Size = new System.Drawing.Size(142, 59);
      this.cmdExecute.TabIndex = 0;
      this.cmdExecute.Text = "Find Max";
      this.cmdExecute.UseVisualStyleBackColor = true;
      this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 24;
      this.listBox1.Location = new System.Drawing.Point(12, 100);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(142, 172);
      this.listBox1.TabIndex = 1;
      // 
      // radioLocal
      // 
      this.radioLocal.AutoSize = true;
      this.radioLocal.Location = new System.Drawing.Point(189, 100);
      this.radioLocal.Name = "radioLocal";
      this.radioLocal.Size = new System.Drawing.Size(73, 28);
      this.radioLocal.TabIndex = 2;
      this.radioLocal.TabStop = true;
      this.radioLocal.Text = "Local";
      this.radioLocal.UseVisualStyleBackColor = true;
      this.radioLocal.CheckedChanged += new System.EventHandler(this.radioLocal_CheckedChanged);
      // 
      // radioRemote
      // 
      this.radioRemote.AutoSize = true;
      this.radioRemote.Location = new System.Drawing.Point(189, 194);
      this.radioRemote.Name = "radioRemote";
      this.radioRemote.Size = new System.Drawing.Size(94, 28);
      this.radioRemote.TabIndex = 3;
      this.radioRemote.TabStop = true;
      this.radioRemote.Text = "Remote";
      this.radioRemote.UseVisualStyleBackColor = true;
      this.radioRemote.CheckedChanged += new System.EventHandler(this.radioRemote_CheckedChanged);
      // 
      // txtLocal
      // 
      this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLocal.Location = new System.Drawing.Point(189, 134);
      this.txtLocal.Name = "txtLocal";
      this.txtLocal.Size = new System.Drawing.Size(735, 26);
      this.txtLocal.TabIndex = 4;
      // 
      // txtRemote
      // 
      this.txtRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRemote.Location = new System.Drawing.Point(189, 228);
      this.txtRemote.Name = "txtRemote";
      this.txtRemote.Size = new System.Drawing.Size(735, 26);
      this.txtRemote.TabIndex = 5;
      // 
      // txtTimeInMS
      // 
      this.txtTimeInMS.Location = new System.Drawing.Point(846, 12);
      this.txtTimeInMS.Name = "txtTimeInMS";
      this.txtTimeInMS.Size = new System.Drawing.Size(78, 29);
      this.txtTimeInMS.TabIndex = 6;
      this.txtTimeInMS.Text = "0";
      this.txtTimeInMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(741, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 24);
      this.label1.TabIndex = 7;
      this.label1.Text = "Delay (ms)";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(936, 293);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtTimeInMS);
      this.Controls.Add(this.txtRemote);
      this.Controls.Add(this.txtLocal);
      this.Controls.Add(this.radioRemote);
      this.Controls.Add(this.radioLocal);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.cmdExecute);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdExecute;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.RadioButton radioLocal;
    private System.Windows.Forms.RadioButton radioRemote;
    private System.Windows.Forms.TextBox txtLocal;
    private System.Windows.Forms.TextBox txtRemote;
    private System.Windows.Forms.TextBox txtTimeInMS;
    private System.Windows.Forms.Label label1;
  }
}

