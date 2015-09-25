using System;

namespace DesignPatternDemo
{
	public class StrategyPattern
	{
		public static void Main(string[] agrs)
		{
			string line = Console.ReadLine ();
			var values = line.Split (' ');

			ContextStrategy cs = new ContextStrategy (Convert.ToInt32 (values [2]));

			int result = cs.GetValue (Convert.ToInt32(values[0]),Convert.ToInt32(values[1]));

			Console.WriteLine (result);

		}
	}

	//定义一个基类或者接口 ，限定算法的名字和参数
	public abstract class Strategy
	{
		public abstract int Computer (int a, int b);
	}

	public class StrategyA:Strategy
	{
		public override int Computer (int a, int b)
		{
			return a + b;
		}
	}

	public class StrategyB:Strategy
	{
		public override int Computer (int a, int b)
		{
			return a * b;
		}
	}


	public class ContextStrategy
	{
		Strategy strategy =null;

		//简单工厂和策略模式的结合
		public ContextStrategy(int type)
		{
			if (type == 0)
				strategy = new StrategyA ();
			else 
				strategy = new StrategyB ();
		}

		public int GetValue(int a,int b)
		{
			return strategy.Computer (a,b);

		}
	}

}

