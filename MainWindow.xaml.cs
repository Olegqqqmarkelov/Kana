using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kana
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

    	static List<string> sp_words = new List<string>
		{
			"A","I","U","E","O","KA","GA","KI","GI","KU","GU","KE","GE",
			"KO","GO","SA","ZA","SHI","JI","SU","ZU","SE","ZE","SO","ZO",
			"TA","DA","CHI","JI","TSU","ZU","TE","DE","TO","DO","NA","NI",
			"NU","NE","NO","HA","BA","PA","HI","BI","PI","FU","BU","PU","HE",
			"BE","PE","HO","BO","PO","MA","MI","MU","ME","MO","YA","YU","YO",
			"RA","RI","RU","RE","RO","WA","(W)O","N",

		};


		static Dictionary<string, string> sp_words_hiragana = new Dictionary<string, string>() {
			{"A","あ"},{"I","い"},{"U","う"},{"E","え"},{"O","お"},{"KA","か"},{"GA","が"},{"KI","き"},{"GI","ぎ"},
			{"KU","く"},{"GU","ぐ"},{"KE","け"},{"GE","げ"},{"KO","こ"},{"GO","ご"},{"SA","さ"},{"ZA","ざ"},
			{"SHI","し"},{"JI","じ"},{"SU","す"},{"ZU","ず"},{"SE","せ"},{"ZE","ぜ"},{"SO","そ"},{"ZO","ぞ"},
			{"TA","た"},{"DA","だ"},{"CHI","ち"},{"TSU","つ"},{"TE","て"},{"DE","で"},
			{"TO","と"},{"DO","ど"},{"NA","な"},{"NI","に"},{"NU","ぬ"},{"NE","ね"},{"NO","の"},{"HA","は"},{"BA","ば"},
			{"PA","ぱ"},{"HI","ひ"},{"BI","び"},{"PI","ぴ"},{"FU","ふ"},{"BU","ぶ"},{"PU","ぷ"},{"HE","へ"},{"BE","べ"},
			{"PE","ぺ"},{"HO","ほ"},{"BO","ぼ"},{"PO","ぽ"},{"MA","ま"},{"MI","み"},{"MU","む"},{"ME","め"},{"MO","も"},
			{"YA","や"},{"YU","ゆ"},{"YO","よ"},{"RA","ら"},{"RI","り"},{"RU","る"},{"RE","れ"},{"RO","ろ"},{"WA","わ"},
			{"(W)O","を"},{"N","ん"},
		};

		public static Dictionary<string, string> sp_words_katakana = new Dictionary<string, string>() {
			{"A","ｱ"},{"I","ｲ"},{"U","ｳ"},{"E","ｴ"},{"O","ｵ"},{"KA","ｶ"},{"GA","ｶﾞ"},{"KI","ｷ"},{"GI","ｷﾞ"},
			{"KU","ｸ"},{"GU","ｸﾞ"},{"KE","ｹ"},{"GE","ｹﾞ"},{"KO","ｺ"},{"GO","ｺﾞ"},{"SA","ｻ"},{"ZA","ｻﾞ"},
			{"SHI","ｼ"},{"JI","ｼﾞ"},{"SU","ｽ"},{"ZU","ｽﾞ"},{"SE","ｾ"},{"ZE","ｾﾞ"},{"SO","ｿ"},{"ZO","ｿﾞ"},
			{"TA","ﾀ"},{"DA","ﾀﾞ"},{"CHI","ﾁ"},{"TSU","ﾂ"},{"TE","ﾃ"},{"DE","ﾃﾞ"},
			{"TO","ﾄ"},{"DO","ﾄﾞ"},{"NA","ﾅ"},{"NI","ﾆ"},{"NU","ﾇ"},{"NE","ﾈ"},{"NO","ﾉ"},{"HA","ﾊ"},{"BA","ﾊﾞ"},
			{"PA","ﾊﾟ"},{"HI","ﾋ"},{"BI","ﾋﾞ"},{"PI","ﾋﾟ"},{"FU","ﾌ"},{"BU","ﾌﾞ"},{"PU","ﾌﾟ"},{"HE","ﾍ"},{"BE","ﾍﾞ"},
			{"PE","ﾍﾟ"},{"HO","ﾎ"},{"BO","ﾎﾞ"},{"PO","ﾎﾟ"},{"MA","ﾏ"},{"MI","ﾐ"},{"MU","ﾑ"},{"ME","ﾒ"},{"MO","ﾓ"},
			{"YA","ﾔ"},{"YU","ﾕ"},{"YO","ﾖ"},{"RA","ﾗ"},{"RI","ﾘ"},{"RU","ﾙ"},{"RE","ﾚ"},{"RO","ﾛ"},{"WA","ﾜ"},
			{"(W)O","ｦ"},{"N","ン"},
		};

		//Function for shuffling the list
		public static List<string> RandomizeList(List<string> _list) {
			var rnd = new Random();
			var randomized = _list.OrderBy(item => rnd.Next());
			return randomized.ToList();
		}

        public MainWindow()
        {
            InitializeComponent();
        }

        static List<string> b = new List<string>();
        private void ButtonStart(object sender, RoutedEventArgs e)
        {
        	b = RandomizeList(sp_words);
        	TextLabel.Text=b[0];
        	b.RemoveAt(0);
        }
        private void ButtonWrite(object sender, RoutedEventArgs e)
        {
        	b = RandomizeList(sp_words);
        	TextLabel.Text=b[0];
            //MessageBox.Show("Write");
        }
        private void ButtonDontWrite(object sender, RoutedEventArgs e)
        {
        	b = RandomizeList(sp_words);
        	TextLabel.Text=b[0];
            //MessageBox.Show("DontWrite");
        }
    }
}
