using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programming.Praxis.Lib.UI
{
	public partial class SieveOfEratosthenes : Form
	{
		public SieveOfEratosthenes()
		{
			InitializeComponent();
		}

		private void buttonExecute_Click(object sender, EventArgs e)
		{
			int n = 2;

			try
			{
				n = int.Parse(this.textBoxInput.Text);
			}
			catch (Exception)
			{
				MessageBox.Show(Properties.Resources.soe_invalid_n,
					Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				List<int> primeNumbers = _002_Sieve_of_Eratosthenes.GetPrimes(n);
				StringBuilder resultStringBuilder = new StringBuilder();

				foreach (int primeNumber in primeNumbers)
				{
					resultStringBuilder.Append(primeNumber);
					resultStringBuilder.Append(" ");
				}

				this.textBoxResult.Text = resultStringBuilder.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Properties.Resources.error,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void SieveOfEratosthenes_HelpButtonClicked(object sender, CancelEventArgs e)
		{
			ProgrammingPraxisUI.FrmAboutSieveOfEratosthenes.ShowDialog();
		}
	}
}
