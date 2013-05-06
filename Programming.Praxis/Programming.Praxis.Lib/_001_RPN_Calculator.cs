using System;
using System.Collections.Generic;
using System.Globalization;

namespace Programming.Praxis.Lib
{
	public abstract class Operator<T>
	{

	}

	public abstract class DoubleOperator : Operator<Double>
	{
		public abstract Double Calculate(Double operand1, Double operand2);

		private static Add add = null;
		private static Substract substract = null;
		private static Multiply multiply = null;
		private static Div div = null;
		private static Mod mod = null;

		private static Add AddOperator
		{
			get
			{
				if (DoubleOperator.add == null)
				{
					DoubleOperator.add = new Add();
				}

				return DoubleOperator.add;
			}
		}

		private static Substract SubstractOperator
		{
			get
			{
				if (DoubleOperator.substract == null)
				{
					DoubleOperator.substract = new Substract();
				}

				return DoubleOperator.substract;
			}
		}

		private static Multiply MultiplyOperator
		{
			get
			{
				if (DoubleOperator.multiply == null)
				{
					DoubleOperator.multiply = new Multiply();
				}

				return DoubleOperator.multiply;
			}
		}

		private static Div DivOperator
		{
			get
			{
				if (DoubleOperator.div == null)
				{
					DoubleOperator.div = new Div();
				}

				return DoubleOperator.div;
			}
		}

		private static Mod ModOperator
		{
			get
			{
				if (DoubleOperator.mod == null)
				{
					DoubleOperator.mod = new Mod();
				}

				return DoubleOperator.mod;
			}
		}

		public static DoubleOperator CreateOperator(string operatorString)
		{
			if (operatorString == "+")
			{
				return DoubleOperator.AddOperator;
			}
			else if (operatorString == "-")
			{
				return DoubleOperator.SubstractOperator;
			}
			else if (operatorString == "*")
			{
				return DoubleOperator.MultiplyOperator;
			}
			else if (operatorString == "/")
			{
				return DoubleOperator.DivOperator;
			}
			else if (operatorString == "%")
			{
				return DoubleOperator.ModOperator;
			}

			return null;
		}
	}

	public class Add : DoubleOperator
	{
		public override Double Calculate(Double operand1, Double operand2)
		{
			return operand1 + operand2;
		}
	}

	public class Substract : DoubleOperator
	{
		public override Double Calculate(Double operand1, Double operand2)
		{
			return operand1 - operand2;
		}
	}

	public class Multiply : DoubleOperator
	{
		public override Double Calculate(Double operand1, Double operand2)
		{
			return operand1 * operand2;
		}
	}

	public class Div : DoubleOperator
	{
		public override Double Calculate(Double operand1, Double operand2)
		{
			return operand1 / operand2;
		}
	}

	public class Mod : DoubleOperator
	{
		public override Double Calculate(Double operand1, Double operand2)
		{
			return operand1 % operand2;
		}
	}

	public class _001_RPN_Calculator
	{
		private static _001_RPN_Calculator calculator = null;

		public static _001_RPN_Calculator GetInstance()
		{
			if (_001_RPN_Calculator.calculator == null)
			{
				_001_RPN_Calculator.calculator = new _001_RPN_Calculator();
			}

			return _001_RPN_Calculator.calculator;
		}

		private _001_RPN_Calculator()
		{
		}

		private Stack<Double> operandStack = null;

		private void InitializeOperandStack()
		{
			if (this.operandStack == null)
			{
				this.operandStack = new Stack<Double>();
			}
			else
			{
				this.operandStack.Clear();
			}
		}

		private void AddOperand(Double operandString)
		{
			this.operandStack.Push(operandString);
		}

		private Double GetOperand()
		{
			return this.operandStack.Pop();
		}

		private Double GetResult()
		{
			if (this.operandStack.Count == 1)
			{
				return this.operandStack.Pop();
			}
			else
			{
				throw new ArgumentException(Properties.Resources.error_expression_invalid,
					"inputExpression");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <exception cref="System.ArgumentException">Throw when can not parse the expression
		/// or the expression contains invalid number/order of operators/operands</exception>
		/// <returns></returns>
		public Double Calculate(String inputExpression)
		{
			try
			{
				this.InitializeOperandStack();
				string[] elements = inputExpression.Trim().Split();

				foreach (string element in elements)
				{
					DoubleOperator DoubleOperator = DoubleOperator.CreateOperator(element);

					if (DoubleOperator == null)
					{
						// Add new operand
						this.AddOperand(Double.Parse(element,
							CultureInfo.InvariantCulture.NumberFormat));
					}
					else
					{
						// Calculate two last operands in stack and add the result
						Double operand1 = this.GetOperand();
						Double operand2 = this.GetOperand();
						Double result = DoubleOperator.Calculate(operand2, operand1);
						this.AddOperand(result);
					}
				}

				return this.GetResult();
			}
			catch (Exception ex)
			{
				throw new ArgumentException(Properties.Resources.error_expression_invalid,
					ex);
			}
		}
	}
}
