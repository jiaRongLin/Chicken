using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalChicken
{
	//題目:公雞5元1隻 母雞3元1隻 小雞1元3隻 用一百元買一百隻雞
	public class Calculate
    {
		
		/// <summary>
		/// 計算百元買百機的所有可能性
		/// 用責任練解題
		/// </summary>
		/// <returns>傳回每種雞的數量</returns>
		public static string HowManyChicken()
		{
			string result = string.Empty;
			int totalPrice = 100; //總金額
			int Num = 100; //總數量
			int cockPrice = 5; //公雞金額
			int henPrice = 3; //母雞金額
			int chickPrice = 1; //小雞金額
			int chick; //小雞數量
			int chickgroup = 3; //小雞一組3隻

			for (int cock = 0; cock <= Num/cockPrice; cock++)//公雞一隻五元 最多20組
			{
				for (int hen = 0; (cockPrice * cock)+(henPrice * hen) <= totalPrice; hen++)//母雞一隻三元 最多33組
				{
					chick = Num - cock - hen;
					if (chick % chickgroup == 0 &&(cockPrice * cock) + (henPrice * hen) + (chickPrice * chick / chickgroup) == totalPrice)
						result += $"{cock}隻公雞,{hen}隻母雞,{chick}隻小雞\n";
				}
			}

			return result;
		}
	}
}
