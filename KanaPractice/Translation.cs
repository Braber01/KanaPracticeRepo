using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice {

	public class Translation {
		private Dictionary<string, string> myHiragana;
		private Dictionary<string, string> myKatakana;

		public Translation() {
			myHiragana = new Dictionary<string, string>();
			//Add vowel sounds
			myHiragana.Add("a", "あ");
			myHiragana.Add("i", "い");
			myHiragana.Add("u", "う");
			myHiragana.Add("e", "え");
			myHiragana.Add("o", "お");

			//add "k" sounds
			myHiragana.Add("ka", "か");
			myHiragana.Add("ki", "き");
			myHiragana.Add("ku", "く");
			myHiragana.Add("ke", "け");
			myHiragana.Add("ko", "こ");

			//Add "g" sounds
			myHiragana.Add("ga", "が");
			myHiragana.Add("gi", "ぎ");
			myHiragana.Add("gu", "ぐ");
			myHiragana.Add("ge", "げ");
			myHiragana.Add("go", "ご");

			//Add S sounds
			myHiragana.Add("sa", "さ");
			myHiragana.Add("shi", "し");
			myHiragana.Add("su", "す");
			myHiragana.Add("se", "せ");
			myHiragana.Add("so", "そ");

			//Add Z sounds
			myHiragana.Add("za", "ざ");
			myHiragana.Add("ji", "じ");
			myHiragana.Add("zu", "ず");
			myHiragana.Add("ze", "ぜ");
			myHiragana.Add("zo", "ぞ");

			//Add T Sounds
			myHiragana.Add("ta", "た");
			myHiragana.Add("chi", "ち");
			myHiragana.Add("tsu", "つ");
			myHiragana.Add("te", "て");
			myHiragana.Add("to", "と");

			//Add D sounds
			myHiragana.Add("da", "だ");
			myHiragana.Add("di", "ぢ");//Not used in Japanese
			myHiragana.Add("du", "づ");//also not used in Japanese
			myHiragana.Add("de", "で");
			myHiragana.Add("do", "ど");

			//add N sounds
			myHiragana.Add("na", "な");
			myHiragana.Add("ni", "に");
			myHiragana.Add("nu", "ぬ");
			myHiragana.Add("ne", "ね");
			myHiragana.Add("no", "の");

			//add H sounds
			myHiragana.Add("ha", "は");
			myHiragana.Add("hi", "ひ");
			myHiragana.Add("fu", "ふ");
			myHiragana.Add("he", "へ");
			myHiragana.Add("ho", "ほ");

			//add B sounds
			myHiragana.Add("ba", "ば");
			myHiragana.Add("bi", "び");
			myHiragana.Add("bu", "ぶ");
			myHiragana.Add("be", "べ");
			myHiragana.Add("bo", "ぼ");

			//Add p sounds
			myHiragana.Add("pa", "ぱ");
			myHiragana.Add("pi", "ぴ");
			myHiragana.Add("pu", "ぷ");
			myHiragana.Add("pe", "ぺ");
			myHiragana.Add("po", "ぽ");

			//Add m Sounds
			myHiragana.Add("ma", "ま");
			myHiragana.Add("mi", "み");
			myHiragana.Add("mu", "む");
			myHiragana.Add("me", "め");
			myHiragana.Add("mo", "も");

			//add y sounds
			myHiragana.Add("ya", "や");
			myHiragana.Add("yu", "ゆ");
			myHiragana.Add("yo", "よ");

			//Add R sounds
			myHiragana.Add("ra", "ら");
			myHiragana.Add("ri", "り");
			myHiragana.Add("ru", "る");
			myHiragana.Add("re", "れ");
			myHiragana.Add("ro", "ろ");

			//w sounds
			myHiragana.Add("wa", "わ");
			myHiragana.Add("wo", "を");
			myHiragana.Add("n", "ん");

			//compound sounds,k
			myHiragana.Add("kya", "きゃ");
			myHiragana.Add("kyu", "きゅ");
			myHiragana.Add("kyo", "きょ");

			//g
			myHiragana.Add("gya", "ぎゃ");
			myHiragana.Add("gyu", "ぎゅ");
			myHiragana.Add("gyo", "ぎょ");

			//s
			myHiragana.Add("sha", "しゃ");
			myHiragana.Add("shu", "しゅ");
			myHiragana.Add("sho", "しょ");

			//J sounds
			myHiragana.Add("ja", "じゃ");
			myHiragana.Add("ju", "じゅ");
			myHiragana.Add("jo", "じょ");

			//C sounds
			myHiragana.Add("cha", "ちゃ");
			myHiragana.Add("chu", "ちゅ");
			myHiragana.Add("cho", "ちょ");

			//D sounds Not used in hiragana,
			myHiragana.Add("dya", "ぢゃ");
			myHiragana.Add("dyu", "ぢゅ");
			myHiragana.Add("dyo", "ぢょ");

			//n Sounds
			myHiragana.Add("nya", "にゃ");
			myHiragana.Add("nyu", "にゅ");
			myHiragana.Add("nyo", "にょ");

			//r sounds
			myHiragana.Add("rya", "りゃ");
			myHiragana.Add("ryu", "りゅ");
			myHiragana.Add("ryo", "りょ");
		}
	}
}