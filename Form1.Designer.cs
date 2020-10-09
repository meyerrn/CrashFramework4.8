namespace CrashFramework48
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
			this.comboBoxCrash1 = new ComboBoxCrash();
			this.SuspendLayout();
			// 
			// comboBoxCrash1
			// 
			this.comboBoxCrash1.FormattingEnabled = true;
			this.comboBoxCrash1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.comboBoxCrash1.Location = new System.Drawing.Point(33, 26);
			this.comboBoxCrash1.Name = "comboBoxCrash1";
			this.comboBoxCrash1.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCrash1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(223, 89);
			this.Controls.Add(this.comboBoxCrash1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBoxCrash comboBoxCrash1;
	}
}

