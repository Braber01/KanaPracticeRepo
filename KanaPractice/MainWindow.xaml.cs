using System;
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
using System.Xml.XPath;

#pragma warning disable CC0001

namespace KanaPractice {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, EventArgs e) {
            lblError.Content = "";
            lblKana.Content = "";
            lblPoints.Content = "";
        }

        /// <summary>
        /// Refactor of repeated code:
        /// <code>
        /// nav.Evaluate(strExpression);
        ///nodeIter = nav.Select(strExpression);
        ///while (nodeIter.MoveNext()) {
        ///string kana = nodeIter.Current.GetAttribute("kana","");
        ///lblKana.Content = kana;
        ///} //end While
        /// </code>
        /// </summary>
        /// <param name="navagiator">nav</param>
        /// <param name="xPath">strExpression</param>
        private void GetKana(XPathNavigator navagiator, string xPath) {
            XPathNodeIterator iter;
            navagiator.Evaluate(xPath);
            iter = navagiator.Select(xPath);
            while (iter.MoveNext()) {
                string kana = iter.Current.GetAttribute("kana", "");
                lblKana.Content = kana;
            } //end While
        }

        /// <summary>
        /// <para>
        /// Starts Game, gets random Kana
        /// From Data.xml</para>
        /// <para>
        /// Also uses Data.xml and XPaths.cs to help
        /// get the Random Kana
        /// </para>
        /// </summary>
        /// <see file="Data.xml"/>
        /// <seealso file="XPaths.cs"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e) {
            //C:/Users/Bens%20Computer/Documents/GitHub/KanaPracticeRepo/KanaPractice/Data.xml
            XPathNavigator nav; //Provides a cursor model for Navigating and editing XML Data
            XPathDocument docNav; //Provides a fast, read-only in-memory resperntation of an xml document by using the xpath data model
            string strExpression;

            docNav = new XPathDocument(@"C:\Users\Bens Computer\Documents\GitHub\KanaPracticeRepo\KanaPractice\Data.xml");
            nav = docNav.CreateNavigator();

            Random randomKana = new Random();

            int result;

            //0-16
            switch (cboKana.SelectedIndex) {
                case 0:
                    //Do Nothing;
                    break;//Case 0
                case 1: //vowels
                    //aiueo
                    XPaths.aiueo.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/aiueo/*";
                        strExpression = XPaths.aiueo.hirg[randomKana.Next(XPaths.aiueo.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/aiueo/*";
                        strExpression = XPaths.aiueo.kata[randomKana.Next(XPaths.aiueo.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//aiueo/*"; //Selects All aiueo elements no matter where they are.
                        strExpression = XPaths.aiueo.mixed[randomKana.Next(XPaths.aiueo.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break; //Vowels,1
                case 2: //kSeries
                    XPaths.kSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/kSeries/*";
                        strExpression = XPaths.kSeries.hirg[randomKana.Next(XPaths.kSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/kSeries/*";
                        strExpression = XPaths.kSeries.kata[randomKana.Next(XPaths.kSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//kSeries/*";
                        strExpression = XPaths.kSeries.mixed[randomKana.Next(XPaths.kSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    } //end if
                    break; //Case kSeries
                case 3: //gSeries,2
                    XPaths.gSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/gSeries/*";
                        strExpression = XPaths.gSeries.hirg[randomKana.Next(XPaths.gSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/kSeries/*";
                        strExpression = XPaths.gSeries.kata[randomKana.Next(XPaths.gSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//gSeries/*";
                        strExpression = XPaths.gSeries.mixed[randomKana.Next(XPaths.gSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    } //end if
                    break; //gSeries,3
                case 4: //sSeries
                    XPaths.sSeries.Init();

                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/sSeries/*";
                        strExpression = XPaths.sSeries.hirg[randomKana.Next(XPaths.sSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/sSeries/*";
                        strExpression = XPaths.sSeries.kata[randomKana.Next(XPaths.sSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//sSeries/*";
                        strExpression = XPaths.sSeries.mixed[randomKana.Next(XPaths.sSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break; //sSeries,4
                case 5: //zSeries
                    XPaths.zSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/zSeries/*";
                        strExpression = XPaths.zSeries.hirg[randomKana.Next(XPaths.zSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        //zSeries
                        strExpression = "/kana/kata/zSeries/*";
                        strExpression = XPaths.zSeries.kata[randomKana.Next(XPaths.zSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//zSeries/*";
                        strExpression = XPaths.zSeries.mixed[randomKana.Next(XPaths.zSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break;//zSeries,5
                case 6: //tSeries
                    XPaths.tSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/tSeries/*";
                        strExpression = XPaths.tSeries.hirg[randomKana.Next(XPaths.tSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/tSeries/*";
                        strExpression = XPaths.tSeries.kata[randomKana.Next(XPaths.tSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//tSeries/*";
                        strExpression = XPaths.tSeries.mixed[randomKana.Next(XPaths.tSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    } //End If
                    break; //tSeries,6
                case 7: //dSeries
                    XPaths.dSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/dSeries/*";
                        strExpression = XPaths.dSeries.hirg[randomKana.Next(XPaths.dSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/dSeries/*";
                        strExpression = XPaths.dSeries.kata[randomKana.Next(XPaths.dSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//dSeries/*";
                        strExpression = XPaths.dSeries.mixed[randomKana.Next(XPaths.dSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    } //end if
                    break;//dSeries,7
                case 8:
                    XPaths.nSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/nSeries/*";
                        strExpression = XPaths.nSeries.hirg[randomKana.Next(XPaths.nSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/nSeries/*";
                        strExpression = XPaths.nSeries.kata[randomKana.Next(XPaths.nSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//nSeries/*";
                        strExpression = XPaths.nSeries.mixed[randomKana.Next(XPaths.nSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break;//nSeries,8
                case 9: //hSeries,9
                    XPaths.hSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/hSeries/*";
                        strExpression = XPaths.hSeries.hirg[randomKana.Next(XPaths.hSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/hSeries/*";
                        strExpression = XPaths.hSeries.kata[randomKana.Next(XPaths.hSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//hSeries/*";
                        strExpression = XPaths.hSeries.mixed[randomKana.Next(XPaths.hSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    } //end if
                    break; //hSeries,9
                case 10: //bSeries
                    XPaths.bSeries.Init();

                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/bSeries/*";
                        strExpression = XPaths.bSeries.hirg[randomKana.Next(XPaths.bSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/bSeries/*";
                        strExpression = XPaths.bSeries.kata[randomKana.Next(XPaths.bSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//bSeries/*";
                        strExpression = XPaths.bSeries.mixed[randomKana.Next(XPaths.bSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    } //end if
                    break; //bSeries,10
                case 11: //pSeries
                    XPaths.pSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/pSeries/*";
                        strExpression = XPaths.pSeries.hirg[randomKana.Next(XPaths.pSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/pSeries/*";
                        strExpression = XPaths.pSeries.kata[randomKana.Next(XPaths.pSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//pSeries/*";
                        strExpression = XPaths.pSeries.mixed[randomKana.Next(XPaths.pSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break; //pSeries,11
                case 12:
                    //mSeries
                    XPaths.mSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/mSeries/*";
                        strExpression = XPaths.mSeries.hirg[randomKana.Next(XPaths.mSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/mSeries/*";
                        strExpression = XPaths.mSeries.kata[randomKana.Next(XPaths.mSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//mSeries/*";
                        strExpression = XPaths.mSeries.mixed[randomKana.Next(XPaths.mSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }//End If
                    break; //mSeries,12
                case 13:
                    XPaths.ySeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/ySeries/*";
                        strExpression = XPaths.ySeries.hirg[randomKana.Next(XPaths.ySeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/ySeries/*";
                        strExpression = XPaths.ySeries.kata[randomKana.Next(XPaths.ySeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//ySeries/*";
                        strExpression = XPaths.ySeries.mixed[randomKana.Next(XPaths.ySeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break;//ySeries,13
                case 14:
                    //r Sounds
                    XPaths.rSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/rSeries/*";
                        strExpression = XPaths.rSeries.hirg[randomKana.Next(XPaths.rSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/rSeries/*";
                        strExpression = XPaths.rSeries.kata[randomKana.Next(XPaths.rSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//rSeries/*";
                        strExpression = XPaths.rSeries.mixed[randomKana.Next(XPaths.rSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break;//rSeries,14
                case 15:
                    XPaths.wSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/wSeries/*";
                        strExpression = XPaths.wSeries.hirg[randomKana.Next(XPaths.wSeries.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/wSeries/*";
                        strExpression = XPaths.wSeries.kata[randomKana.Next(XPaths.wSeries.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//wSeries/*";
                        strExpression = XPaths.wSeries.mixed[randomKana.Next(XPaths.wSeries.mixed.Length)];
                        GetKana(nav, strExpression);
                    }
                    break;//wSeries,15
                case 16:
                    XPaths.comboSounds.Init();
                    //TODO add implementation for Compound sounds later
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/comboSounds/*";
                        strExpression = XPaths.comboSounds.hirg[randomKana.Next(XPaths.comboSounds.hirg.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/comboSounds/*";
                        strExpression = XPaths.comboSounds.kata[randomKana.Next(XPaths.comboSounds.kata.Length)];
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//comboSounds/*";
                        strExpression = XPaths.comboSounds.mixed[randomKana.Next(XPaths.comboSounds.mixed.Length)];
                    }
                    break;
            } //End Switch (ComboBox)
        } //end btnStartGame_Click

        private void btnCheck_Click(object sender, EventArgs e) {
        }

        private void btnNext_Click(object sender, EventArgs e) {
        }

        private void btnQuit_Click(object sender, EventArgs e) {
            Application.Current.Shutdown();
        }

        private void GetNextKana(int sound) {
        }

        private void OnKeyDown(object sender, KeyEventArgs e) {
        }
    }
}