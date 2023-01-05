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
			for(int cock = 0; cock <=20; cock++)//一隻五元 最多20組
			{
				for(int hen = 0; hen <= 33; hen++)//一隻三元 最多33組
				{
					for (int chick = 0; chick <= 33; chick++)//一元三隻算一組 最多33組
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
