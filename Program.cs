using System;
using System.Linq;
using System.Collections.Generic;

namespace hiragana
{
	class MainClass
	{
		static List<string> sp_words_hiragana = new List<string>
		{
			"A","I","U","E","O","KA","GA","KI","GI","KU","GU","KE","GE",
			"KO","GO","SA","ZA","SHI","JI","SU","ZU","SE","ZE","SO","ZO",
			"TA","DA","CHI","JI","TSU","ZU","TE","DE","TO","DO","NA","NI",
			"NU","NE","NO","HA","BA","PA","HI","BI","PI","FU","BU","PU","HE",
			"BE","PE","HO","BO","PO","MA","MI","MU","ME","MO","YA","YU","YO",
			"RA","RI","RU","RE","RO","WA","(W)O","N",

		};

		public static List<string> RandomizeList(List<string> _list) {
			var rnd = new Random();
			var randomized = _list.OrderBy(item => rnd.Next());
			return randomized.ToList();
		}

		public static void Main(string[] args)
		{
			int lenght = sp_words_hiragana.Count;
			string strRoud = "Пройдено по всiм буквам: ";
			int roud = 0;

			while (true)
			{
				Console.Clear();
				var b = RandomizeList(sp_words_hiragana);

				for (int i = 0; i < lenght; i++)
				{
					Console.Clear();

					if (roud <= 1){
						Console.WriteLine($"{strRoud}{roud} раз");
					}
					else if (roud <= 4){
						Console.WriteLine($"{strRoud}{roud} рази");
					}
					else if (roud > 4){
						Console.WriteLine($"{strRoud}{roud} разiв");
					}

					Console.Write(b.ElementAt(i));
					Console.ReadKey();
				}

				roud++;
			}
		}

	}
}
