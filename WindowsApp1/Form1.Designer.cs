namespace WindowsApp1
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002750 File Offset: 0x00000950
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000027A0 File Offset: 0x000009A0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsApp1.Form1));
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer3 = new global::System.Windows.Forms.Timer(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.NumericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.NumericUpDown3 = new global::System.Windows.Forms.NumericUpDown();
			this.Label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown3).BeginInit();
			base.SuspendLayout();
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 20;
			this.Timer2.Enabled = true;
			this.Timer2.Interval = 1000;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(76, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Shake Interval";
			this.NumericUpDown1.Location = new global::System.Drawing.Point(15, 25);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.NumericUpDown1;
			int[] array = new int[4];
			array[0] = 9999999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.NumericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new global::System.Drawing.Size(120, 20);
			this.NumericUpDown1.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.NumericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 20;
			numericUpDown3.Value = new decimal(array3);
			this.NumericUpDown2.Location = new global::System.Drawing.Point(15, 74);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.NumericUpDown2;
			int[] array4 = new int[4];
			array4[0] = 9999999;
			numericUpDown4.Maximum = new decimal(array4);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new global::System.Drawing.Size(120, 20);
			this.NumericUpDown2.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.NumericUpDown2;
			int[] array5 = new int[4];
			array5[0] = 10;
			numericUpDown5.Value = new decimal(array5);
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(12, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(14, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "X";
			this.NumericUpDown3.Location = new global::System.Drawing.Point(15, 121);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.NumericUpDown3;
			int[] array6 = new int[4];
			array6[0] = 9999999;
			numericUpDown6.Maximum = new decimal(array6);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new global::System.Drawing.Size(120, 20);
			this.NumericUpDown3.TabIndex = 6;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.NumericUpDown3;
			int[] array7 = new int[4];
			array7[0] = 10;
			numericUpDown7.Value = new decimal(array7);
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(12, 105);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(14, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Y";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(152, 164);
			base.Controls.Add(this.NumericUpDown3);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.NumericUpDown2);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.Label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shaker";
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;
	}
}
