using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice {

	public class Symbols {

		public Symbols() {
			JapaneseList = new List<Kana>();
			//aiueo
			JapaneseList.Add(new Kana("a", "あ", "ア")); //0
			JapaneseList.Add(new Kana("i", "い", "イ")); //1
			JapaneseList.Add(new Kana("u", "う", "ウ")); //2
			JapaneseList.Add(new Kana("e", "え", "エ")); //3
			JapaneseList.Add(new Kana("o", "お", "オ")); //4

			//kSeries
			JapaneseList.Add(new Kana("ka", "か", "カ"));
			JapaneseList.Add(new Kana("ki", "き", "キ"));
			JapaneseList.Add(new Kana("ku", "く", "ク"));
			JapaneseList.Add(new Kana("ke", "け", "ケ"));
			JapaneseList.Add(new Kana("ko", "こ", "コ"));

			//gSeries
			JapaneseList.Add(new Kana("ga", "が", "ガ"));
		}

		private List<Kana> JapaneseList { get; set; }
	}
}