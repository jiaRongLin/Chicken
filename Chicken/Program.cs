using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(Calculate.HowManyChicken());
		}
	}
	public class Calculate
	{
		public static string HowManyChicken()
		{
			string result =string.Empty;
			for(int cock = 1; cock <=20; cock++)
			{
				for(int hen = 1; hen <= 33; hen++)
				{
					for (int chick = 1; chick <= 33; chick++)
					{
						if (cock + hen + (chick * 3) == 100 && (5 * cock) + (3 * hen) + chick == 100)
							result += $"{cock}隻公雞,{hen}隻母雞,{chick * 3}隻小雞\n";
					}
				}
			}
			return result;
		}
	}

}
