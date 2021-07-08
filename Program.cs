using System;
using System.Linq;
using System.Threading;
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

		//Function for shuffling the list
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
				List<string> words_for_repeat = new List<string>();

				Console.Clear();
				var b = RandomizeList(sp_words_hiragana);

				for (int i = 0; i < lenght; i++)
				{
					var _i = b.ElementAt(i);

					Console.Clear();
					Console.WriteLine(Rounds(roud));
					Console.Write(_i);

					System.Console.WriteLine("\n\n\nНатисьнiсть на 'C' якщо не знаєте | Якщо знаєте то на будь яку кнопку крiм 'C'.");
					var input = Console.ReadKey();

					switch (input.Key){
						case ConsoleKey.C:
							words_for_repeat.Add(_i);
							break;
					}
				}

				Console.Clear();
				WordsRepeat(words_for_repeat);

				Console.ReadKey();
				roud++;
			}

			//Function for output 'words_for_repeat'
			void WordsRepeat(List<string> _list){
				Console.Write("Повторiть написанння цих слiв: ");

				foreach(var item in _list){
					Console.Write($"{item}, ");
				}

				Thread.Sleep(20000);
			}

			//Function for output 'roud'
			string Rounds(int round){
				string i;

				if (roud <= 1){
					i = $"{strRoud}{roud} раз";
				}
				else if (roud <= 4){
					i = $"{strRoud}{roud} рази";
				}
				else{i = $"{strRoud}{roud} разiв";}

				return i.ToString();
			
			}
		}

	}
}
