using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Programming.Praxis.Lib.UI
{
	public partial class RPNCalculator : Form
	{
		public RPNCalculator()
		{
			InitializeComponent();
			this.labelResultValue.Text = String.Empty;
		}

		private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
		{
			ProgrammingPraxisUI.FrmAboutRPNCalculator.ShowDialog();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

		}

		private void buttonExecute_Click(object sender, System.EventArgs e)
		{
			try
			{
				String expression = this.textBoxExpression.Text;
				_001_RPN_Calculator calculator = _001_RPN_Calculator.GetInstance();
				Double result = calculator.Calculate(expression);
				this.labelResultValue.Text = result.ToString("f4",
					CultureInfo.InvariantCulture.NumberFormat);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), Properties.Resources.error,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
