namespace Programming.Praxis.Lib.UI
{
	partial class RPNCalculator
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxExpression = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.labelResultValue = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the expression";
			// 
			// textBoxExpression
			// 
			this.textBoxExpression.Location = new System.Drawing.Point(12, 30);
			this.textBoxExpression.Name = "textBoxExpression";
			this.textBoxExpression.Size = new System.Drawing.Size(316, 22);
			this.textBoxExpression.TabIndex = 1;
			this.textBoxExpression.Text = "19 2.14 + 4.5 2 4.3 / - *";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 14);
			this.label2.TabIndex = 0;
			this.label2.Text = "Result :";
			// 
			// buttonExecute
			// 
			this.buttonExecute.Location = new System.Drawing.Point(13, 73);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(315, 23);
			this.buttonExecute.TabIndex = 2;
			this.buttonExecute.Text = "&Execute";
			this.buttonExecute.UseVisualStyleBackColor = true;
			this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
			// 
			// labelResultValue
			// 
			this.labelResultValue.AutoSize = true;
			this.labelResultValue.Location = new System.Drawing.Point(66, 55);
			this.labelResultValue.Name = "labelResultValue";
			this.labelResultValue.Size = new System.Drawing.Size(85, 14);
			this.labelResultValue.TabIndex = 0;
			this.labelResultValue.Text = "<resultValue>";
			// 
			// RPNCalculator
			// 
			this.AcceptButton = this.buttonExecute;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 108);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.textBoxExpression);
			this.Controls.Add(this.labelResultValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RPNCalculator";
			this.Text = "RPN Calculator";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxExpression;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.Label labelResultValue;
	}
}

