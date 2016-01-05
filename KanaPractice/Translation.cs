using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice {

	public class Translation {
		public Dictionary<string, string> myHiragana;
		public Dictionary<string, string> myKatakana;
		public Dictionary<string, string> myMixed;

		public Translation() {
			myHiragana = new Dictionary<string, string>();
			myKatakana = new Dictionary<string, string>();
			//Add vowel sounds
			myHiragana.Add("a", "あ");
			myKatakana.Add("k_a", "ア");

			myHiragana.Add("i", "い");
			myKatakana.Add("k_i", "イ");

			myHiragana.Add("u", "う");
			myKatakana.Add("k_u", "ウ");

			myHiragana.Add("e", "え");
			myKatakana.Add("k_e", "エ");

			myHiragana.Add("o", "お");
			myKatakana.Add("k_o", "オ");

			//add "k" sounds
			myHiragana.Add("ka", "か");
			myKatakana.Add("k_ka", "カ");

			myHiragana.Add("ki", "き");
			myKatakana.Add("k_ki", "キ");

			myHiragana.Add("ku", "く");
			myKatakana.Add("k_ku", "ク");

			myHiragana.Add("ke", "け");
			myKatakana.Add("k_ke", "ケ");

			myHiragana.Add("ko", "こ");
			myKatakana.Add("k_ko", "コ");
			//Add "g" sounds

			myHiragana.Add("ga", "が");
			myKatakana.Add("k_ga", "ガ");

			myHiragana.Add("gi", "ぎ");
			myKatakana.Add("k_gi", "ギ");

			myHiragana.Add("gu", "ぐ");
			myKatakana.Add("k_gu", "グ");

			myHiragana.Add("ge", "げ");
			myKatakana.Add("k_ge", "ゲ");

			myHiragana.Add("go", "ご");
			myKatakana.Add("k_go", "ゴ");

			//Add S sounds
			myHiragana.Add("sa", "さ");
			myKatakana.Add("k_sa", "サ");

			myHiragana.Add("shi", "し");
			myKatakana.Add("k_shi", "シ");

			myHiragana.Add("su", "す");
			myKatakana.Add("k_su", "ス");

			myHiragana.Add("se", "せ");
			myKatakana.Add("k_se", "セ");

			myHiragana.Add("so", "そ");
			myKatakana.Add("k_so", "ソ");

			//Add Z sounds
			myHiragana.Add("za", "ざ");
			myKatakana.Add("k_za", "ザ");

			myHiragana.Add("ji", "じ");
			myKatakana.Add("k_ji", "ジ");

			myHiragana.Add("zu", "ず");
			myKatakana.Add("k_zu", "ズ");

			myHiragana.Add("ze", "ぜ");
			myKatakana.Add("k_ze", "ゼ");

			myHiragana.Add("zo", "ぞ");
			myKatakana.Add("k_zo", "ゾ");

			//Add T Sounds
			myHiragana.Add("ta", "た");
			myKatakana.Add("k_ta", "タ");

			myHiragana.Add("chi", "ち");
			myKatakana.Add("k_chi", "チ");

			myHiragana.Add("tsu", "つ");
			myKatakana.Add("k_tsu", "ツ");

			myHiragana.Add("te", "て");
			myKatakana.Add("k_te", "テ");

			myHiragana.Add("to", "と");
			myKatakana.Add("k_to", "ト");

			//Add D sounds
			myHiragana.Add("da", "だ");
			myKatakana.Add("k_da", "ダ");

			myHiragana.Add("di", "ぢ");//Not used in Japanese
			myKatakana.Add("k_di", "ヂ");

			myHiragana.Add("du", "づ");//also not used in Japanese
			myKatakana.Add("k_du", "ヅ");

			myHiragana.Add("de", "で");
			myKatakana.Add("k_de", "デ");

			myHiragana.Add("do", "ど");
			myKatakana.Add("k_do", "ド");

			//add N sounds
			myHiragana.Add("na", "な");
			myKatakana.Add("k_na", "ナ");

			myHiragana.Add("ni", "に");
			myKatakana.Add("k_ni", "ニ");

			myHiragana.Add("nu", "ぬ");
			myKatakana.Add("k_nu", "ヌ");

			myHiragana.Add("ne", "ね");
			myKatakana.Add("k_ne", "ネ");

			myHiragana.Add("no", "の");
			myKatakana.Add("k_no", "ノ");
			//add H sounds
			myHiragana.Add("ha", "は");
			myKatakana.Add("k_ha", "ハ");

			myHiragana.Add("hi", "ひ");
			myKatakana.Add("k_hi", "ヒ");

			myHiragana.Add("fu", "ふ"); //Can also be Romanized as "hu"
			myKatakana.Add("k_fu", "フ");

			myHiragana.Add("he", "へ");
			myKatakana.Add("k_he", "ヘ");

			myHiragana.Add("ho", "ほ");
			myKatakana.Add("k_ho", "ホ");

			//add B sounds
			myHiragana.Add("ba", "ば");
			myKatakana.Add("k_ba", "バ");

			myHiragana.Add("bi", "び");
			myKatakana.Add("k_bi", "ビ");

			myHiragana.Add("bu", "ぶ");
			myKatakana.Add("k_bu", "ブ");

			myHiragana.Add("be", "べ");
			myKatakana.Add("k_be", "ベ");

			myHiragana.Add("bo", "ぼ");
			myKatakana.Add("k_bo", "ボ");
			//Add p sounds
			myHiragana.Add("pa", "ぱ");
			myKatakana.Add("k_pa", "パ");

			myHiragana.Add("pi", "ぴ");
			myKatakana.Add("k_pi", "ピ");

			myHiragana.Add("pu", "ぷ");
			myKatakana.Add("k_pu", "プ");

			myHiragana.Add("pe", "ぺ");
			myKatakana.Add("k_pe", "ペ");

			myHiragana.Add("po", "ぽ");
			myKatakana.Add("k_po", "ポ");

			//Add m Sounds
			myHiragana.Add("ma", "ま");
			myKatakana.Add("k_ma", "マ");

			myHiragana.Add("mi", "み");
			myKatakana.Add("k_mi", "ミ");

			myHiragana.Add("mu", "む");
			myKatakana.Add("k_mu", "ム");

			myHiragana.Add("me", "め");
			myKatakana.Add("k_me", "メ");

			myHiragana.Add("mo", "も");
			myKatakana.Add("k_mo", "モ");

			//add y sounds
			myHiragana.Add("ya", "や");
			myKatakana.Add("k_ya", "ヤ");

			myHiragana.Add("yu", "ゆ");
			myKatakana.Add("k_yu", "ユ");

			myHiragana.Add("yo", "よ");
			myKatakana.Add("k_yo", "ヨ");
			//Add R sounds
			myHiragana.Add("ra", "ら");
			myKatakana.Add("k_ra", "ラ");

			myHiragana.Add("ri", "り");
			myKatakana.Add("k_ri", "リ");

			myHiragana.Add("ru", "る");
			myKatakana.Add("k_ru", "ル");

			myHiragana.Add("re", "れ");
			myKatakana.Add("k_re", "レ");

			myHiragana.Add("ro", "ろ");
			myKatakana.Add("k_ro", "ロ");
			//w sounds
			myHiragana.Add("wa", "わ");
			myKatakana.Add("k_wa", "ワ");

			myHiragana.Add("wo", "を");
			myKatakana.Add("k_wo", "ヲ");

			myHiragana.Add("n", "ん");
			myKatakana.Add("k_n", "ン");
			//compound sounds,k
			myHiragana.Add("kya", "きゃ");
			myKatakana.Add("k_kya", "キャ");

			myHiragana.Add("kyu", "きゅ");
			myKatakana.Add("k_kyu", "キュ");

			myHiragana.Add("kyo", "きょ");
			myKatakana.Add("k_kyo", "キョ");
			//g
			myHiragana.Add("gya", "ぎゃ");
			myKatakana.Add("k_gya", "ギャ");

			myHiragana.Add("gyu", "ぎゅ");
			myKatakana.Add("k_gyu", "ギュ");

			myHiragana.Add("gyo", "ぎょ");
			myKatakana.Add("k_gyo", "ギョ");
			//s
			myHiragana.Add("sha", "しゃ");
			myKatakana.Add("k_sha", "シャ");

			myHiragana.Add("shu", "しゅ");
			myKatakana.Add("k_shu", "シュ");

			myHiragana.Add("sho", "しょ");
			myKatakana.Add("k_sho", "ショ");
			//J sounds
			myHiragana.Add("ja", "じゃ");
			myKatakana.Add("k_ja", "ジャ");

			myHiragana.Add("ju", "じゅ");
			myKatakana.Add("k_ju", "ジュ");

			myHiragana.Add("jo", "じょ");
			myKatakana.Add("k_jo", "ジョ");
			//C sounds
			myHiragana.Add("cha", "ちゃ");
			myKatakana.Add("k_cha", "チャ");

			myHiragana.Add("chu", "ちゅ");
			myKatakana.Add("k_chu", "チュ");

			myHiragana.Add("cho", "ちょ");
			myKatakana.Add("k_cho", "チョ");
			//D sounds Not used in hiragana,
			myHiragana.Add("dya", "ぢゃ");
			myKatakana.Add("k_dya", "ヂャ");

			myHiragana.Add("dyu", "ぢゅ");
			myKatakana.Add("k_dyu", "ヂュ");

			myHiragana.Add("dyo", "ぢょ");
			myKatakana.Add("k_dyo", "ヂョ");

			//n Sounds
			myHiragana.Add("nya", "にゃ");
			myKatakana.Add("k_nya", "ニャ");

			myHiragana.Add("nyu", "にゅ");
			myKatakana.Add("k_nyu", "ニュ");

			myHiragana.Add("nyo", "にょ");
			myKatakana.Add("k_nyo", "ニョ");
			//r sounds
			myHiragana.Add("rya", "りゃ");
			myKatakana.Add("k_rya", "リャ");

			myHiragana.Add("ryu", "りゅ");
			myKatakana.Add("k_ryu", "リュ");

			myHiragana.Add("ryo", "りょ");
			myKatakana.Add("k_ryo", "リョ");

			myMixed = (Dictionary<string, string>)myHiragana.Concat(myKatakana);
		}
	}
}