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
            XPathNodeIterator nodeIter; //Provides an iterator over a selected set of nodes
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
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.aiueo.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.aiueo.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.aiueo.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.aiueo.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.aiueo.hirg[4];
                                break;
                        } //End Switch
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/aiueo/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.aiueo.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.aiueo.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.aiueo.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.aiueo.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.aiueo.kata[4];
                                break;
                        }//End Switch

                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//aiueo/*"; //Selects All aiueo elements no matter where they are.
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.aiueo.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.aiueo.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.aiueo.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.aiueo.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.aiueo.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.aiueo.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.aiueo.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.aiueo.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.aiueo.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.aiueo.mixed[9];
                                break;
                        }//end Switch
                        GetKana(nav, strExpression);
                    }
                    break; //Vowels,1
                case 2: //kSeries
                    XPaths.kSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        result = randomKana.Next(0, 4);
                        strExpression = "/kana/hirg/kSeries/*";

                        switch (result) {
                            case 0:
                                strExpression = XPaths.kSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.kSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.kSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.kSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.kSeries.hirg[4];
                                break;
                        } //End switch
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/kSeries/*";
                        result = randomKana.Next(0, 4);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.kSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.kSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.kSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.kSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.kSeries.kata[4];
                                break;
                        } //end Switch
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//kSeries/*";
                        result = randomKana.Next(0, 9);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.kSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.kSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.kSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.kSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.kSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.kSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.kSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.kSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.kSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.kSeries.mixed[9];
                                break;
                        }//End Switch
                        GetKana(nav, strExpression);
                    } //end if
                    break; //Case kSeries
                case 3: //gSeries,2
                    XPaths.gSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        result = randomKana.Next(0, 4);
                        strExpression = "/kana/hirg/gSeries/*";

                        switch (result) {
                            case 0:
                                strExpression = XPaths.gSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.gSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.gSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.gSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.gSeries.hirg[4];
                                break;
                        }//End switch
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        }//end while
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/kSeries/*";
                        result = randomKana.Next(0, 4);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.gSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.gSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.gSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.gSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.gSeries.kata[4];
                                break;
                        } //End Switch
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//gSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.gSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.gSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.gSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.gSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.gSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.gSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.gSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.gSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.gSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.gSeries.mixed[9];
                                break;
                        }//End Switch
                        GetKana(nav, strExpression);
                    } //end if
                    break; //gSeries,3
                case 4: //sSeries
                    XPaths.sSeries.Init();

                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/sSeries/*";
                        result = randomKana.Next(0, 4);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.sSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.sSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.sSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.sSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.sSeries.hirg[4];
                                break;
                        }//End switch
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/sSeries/*";
                        result = randomKana.Next(0, 4);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.sSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.sSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.sSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.sSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.sSeries.kata[4];
                                break;
                        } //End Switch
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//sSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.sSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.sSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.sSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.sSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.sSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.sSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.sSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.sSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.sSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.sSeries.mixed[9];
                                break;
                        }//end Switch
                        GetKana(nav, strExpression);
                    }
                    break; //sSeries,4
                case 5: //zSeries
                    XPaths.zSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/zSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.zSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.zSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.zSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.zSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.zSeries.hirg[4];
                                break;
                        }
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        //zSeries
                        strExpression = "/kana/kata/zSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.zSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.zSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.zSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.zSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.zSeries.kata[4];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//zSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.zSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.zSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.zSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.zSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.zSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.zSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.zSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.zSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.zSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.zSeries.mixed[9];
                                break;
                        } //end Switch result
                        GetKana(nav, strExpression);
                    }
                    break;//zSeries,5
                case 6: //tSeries
                    XPaths.tSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/tSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.tSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.tSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.tSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.tSeries.hirg[4];
                                break;

                            case 4:
                                strExpression = XPaths.tSeries.hirg[4];
                                break;
                        } //End Switch Result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/tSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.tSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.tSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.tSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.tSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.tSeries.kata[4];
                                break;
                        } //End Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//tSeries/*";
                        result = randomKana.Next(0, 9);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.tSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.tSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.tSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.tSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.tSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.tSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.tSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.tSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.tSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.tSeries.mixed[9];
                                break;
                        } //end Switch result
                        GetKana(nav, strExpression);
                    } //End If
                    break; //tSeries,6
                case 7: //dSeries
                    XPaths.dSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/dSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.dSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.dSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.dSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.dSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.dSeries.hirg[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/dSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.dSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.dSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.dSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.dSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.dSeries.kata[4];
                                break;
                        }
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//dSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.dSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.dSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.dSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.dSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.dSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.dSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.dSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.dSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.dSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.dSeries.mixed[9];
                                break;
                        } //end Switch result
                        GetKana(nav, strExpression);
                    } //end if
                    break;//dSeries,7
                case 8:
                    XPaths.nSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/nSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.nSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.nSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.nSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.nSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.nSeries.hirg[4];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/nSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.nSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.nSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.nSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.nSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.nSeries.kata[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//nSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.nSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.nSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.nSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.nSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.nSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.nSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.nSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.nSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.nSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.nSeries.mixed[9];
                                break;
                        }//End Switch result
                        GetKana(nav, strExpression);
                    }
                    break;//nSeries,8
                case 9: //hSeries,9
                    XPaths.hSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/hSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.hSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.hSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.hSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.hSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.hSeries.hirg[4];
                                break;
                        } //end Switch Result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/hSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.hSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.hSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.hSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.hSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.hSeries.kata[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//hSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.hSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.hSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.hSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.hSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.hSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.hSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.hSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.hSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.hSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.hSeries.mixed[9];
                                break;
                        } //end Switch result
                        GetKana(nav, strExpression);
                    } //end if
                    break; //hSeries,9
                case 10: //bSeries
                    XPaths.bSeries.Init();

                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/bSeries/*";
                        result = randomKana.Next(0, 4);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.bSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.bSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.bSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.bSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.bSeries.hirg[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/bSeries/*";
                        result = randomKana.Next(0, 4);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.bSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.bSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.bSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.bSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.bSeries.kata[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//bSeries/*";
                        result = randomKana.Next(0, 9);

                        switch (result) {
                            case 0:
                                strExpression = XPaths.bSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.bSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.bSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.bSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.bSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.bSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.bSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.bSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.bSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.bSeries.mixed[9];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    } //end if
                    break; //bSeries,10
                case 11: //pSeries
                    XPaths.pSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/pSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.pSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.pSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.pSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.pSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.pSeries.hirg[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/pSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.pSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.pSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.pSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.pSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.pSeries.kata[4];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//pSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.pSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.pSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.pSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.pSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.pSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.pSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.pSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.pSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.pSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.pSeries.mixed[9];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    break; //pSeries,11
                case 12:
                    //mSeries
                    XPaths.mSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/mSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.mSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.mSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.mSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.mSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.mSeries.hirg[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/mSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.mSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.mSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.mSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.mSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.mSeries.kata[4];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//mSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.mSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.mSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.mSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.mSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.mSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.mSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.mSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.mSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.mSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.mSeries.mixed[9];
                                break;
                        }//end Switch Result
                        GetKana(nav, strExpression);
                    }//End If
                    break; //mSeries,12
                case 13:
                    XPaths.ySeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/ySeries/*";
                        result = randomKana.Next(0, 2);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.ySeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.ySeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.ySeries.hirg[2];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/ySeries/*";
                        result = randomKana.Next(0, 2);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.ySeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.ySeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.ySeries.kata[2];
                                break;
                        }
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//ySeries/*";
                        result = randomKana.Next(0, 5);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.ySeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.ySeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.ySeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.ySeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.ySeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.ySeries.mixed[5];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    break;//ySeries,13
                case 14:
                    //r Sounds
                    XPaths.rSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/rSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.rSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.rSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.rSeries.hirg[2];
                                break;

                            case 3:
                                strExpression = XPaths.rSeries.hirg[3];
                                break;

                            case 4:
                                strExpression = XPaths.rSeries.hirg[4];
                                break;
                        }
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/rSeries/*";
                        result = randomKana.Next(0, 4);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.rSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.rSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.rSeries.kata[2];
                                break;

                            case 3:
                                strExpression = XPaths.rSeries.kata[3];
                                break;

                            case 4:
                                strExpression = XPaths.rSeries.kata[4];
                                break;
                        }//end Switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//rSeries/*";
                        result = randomKana.Next(0, 9);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.rSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.rSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.rSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.rSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.rSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.rSeries.mixed[5];
                                break;

                            case 6:
                                strExpression = XPaths.rSeries.mixed[6];
                                break;

                            case 7:
                                strExpression = XPaths.rSeries.mixed[7];
                                break;

                            case 8:
                                strExpression = XPaths.rSeries.mixed[8];
                                break;

                            case 9:
                                strExpression = XPaths.rSeries.mixed[9];
                                break;
                        }
                        GetKana(nav, strExpression);
                    }
                    break;//rSeries,14
                case 15:
                    XPaths.wSeries.Init();
                    if (radHiragana.IsChecked == true) {
                        strExpression = "/kana/hirg/wSeries/*";
                        result = randomKana.Next(0, 2);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.wSeries.hirg[0];
                                break;

                            case 1:
                                strExpression = XPaths.wSeries.hirg[1];
                                break;

                            case 2:
                                strExpression = XPaths.wSeries.hirg[2];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radKatakana.IsChecked == true) {
                        strExpression = "/kana/kata/wSeries/*";
                        result = randomKana.Next(0, 2);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.wSeries.kata[0];
                                break;

                            case 1:
                                strExpression = XPaths.wSeries.kata[1];
                                break;

                            case 2:
                                strExpression = XPaths.wSeries.kata[2];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    else if (radMixed.IsChecked == true) {
                        strExpression = "//wSeries/*";
                        result = randomKana.Next(0, 5);
                        switch (result) {
                            case 0:
                                strExpression = XPaths.wSeries.mixed[0];
                                break;

                            case 1:
                                strExpression = XPaths.wSeries.mixed[1];
                                break;

                            case 2:
                                strExpression = XPaths.wSeries.mixed[2];
                                break;

                            case 3:
                                strExpression = XPaths.wSeries.mixed[3];
                                break;

                            case 4:
                                strExpression = XPaths.wSeries.mixed[4];
                                break;

                            case 5:
                                strExpression = XPaths.wSeries.mixed[5];
                                break;
                        }//end switch result
                        GetKana(nav, strExpression);
                    }
                    break;//wSeries,15
                case 16:
                    //XPaths.comboSounds.Init();
                    //TODO add implementation for Compound sounds later
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

        private void GetNextKana(int sound) { }

        private void OnKeyDown(object sender, KeyEventArgs e) {
        }
    }
}