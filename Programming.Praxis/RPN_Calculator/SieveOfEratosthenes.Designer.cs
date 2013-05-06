namespace Programming.Praxis.Lib.UI
{
	partial class SieveOfEratosthenes
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
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "N :";
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(42, 10);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(287, 22);
			this.textBoxInput.TabIndex = 1;
			this.textBoxInput.Text = "100";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "Prime numbers less than or equal to N :";
			// 
			// buttonExecute
			// 
			this.buttonExecute.Location = new System.Drawing.Point(16, 38);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(313, 23);
			this.buttonExecute.TabIndex = 3;
			this.buttonExecute.Text = "&Execute";
			this.buttonExecute.UseVisualStyleBackColor = true;
			this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
			// 
			// textBoxResult
			// 
			this.textBoxResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxResult.Location = new System.Drawing.Point(16, 84);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ReadOnly = true;
			this.textBoxResult.Size = new System.Drawing.Size(313, 198);
			this.textBoxResult.TabIndex = 4;
			// 
			// SieveOfEratosthenes
			// 
			this.AcceptButton = this.buttonExecute;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 294);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SieveOfEratosthenes";
			this.Text = "Sieve Of Eratosthenes";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.SieveOfEratosthenes_HelpButtonClicked);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.TextBox textBoxResult;
	}
}