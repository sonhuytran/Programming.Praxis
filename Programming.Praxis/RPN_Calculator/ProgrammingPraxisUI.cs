
namespace Programming.Praxis.Lib.UI
{
	public class ProgrammingPraxisUI
	{
		private static RPNCalculator frmRPNCalculator = null;
		private static AboutRPNCalculator frmAboutRPNCalculator = null;
		private static SieveOfEratosthenes frmSieveOfEratosthenes = null;
		private static AboutSieveOfEratosthenes frmAboutSieveOfEratosthenes = null;

		public static RPNCalculator FrmRPNCalculator
		{
			get
			{
				if (frmRPNCalculator == null)
				{
					frmRPNCalculator = new RPNCalculator();
				}

				return frmRPNCalculator;
			}
		}
		public static AboutRPNCalculator FrmAboutRPNCalculator
		{
			get
			{
				if (frmAboutRPNCalculator == null)
				{
					frmAboutRPNCalculator = new AboutRPNCalculator();
				}

				return frmAboutRPNCalculator;
			}
		}
		public static SieveOfEratosthenes FrmSieveOfEratosthenes
		{
			get
			{
				if (ProgrammingPraxisUI.frmSieveOfEratosthenes == null)
				{
					ProgrammingPraxisUI.frmSieveOfEratosthenes = new SieveOfEratosthenes();
				}

				return ProgrammingPraxisUI.frmSieveOfEratosthenes;
			}
		}
		public static AboutSieveOfEratosthenes FrmAboutSieveOfEratosthenes
		{
			get
			{
				if (ProgrammingPraxisUI.frmAboutSieveOfEratosthenes == null)
				{
					ProgrammingPraxisUI.frmAboutSieveOfEratosthenes = new AboutSieveOfEratosthenes();
				}

				return ProgrammingPraxisUI.frmAboutSieveOfEratosthenes;
			}
		}
	}
}
