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
using System.Xml.XPath;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KanaPractice {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
      

        private void MainWindow_Loaded(object sender,EventArgs e) {
            lblError.Content = "";
            lblKana.Content = "";
            lblPoints.Content = "";

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
        private void btnStartGame_Click(object sender,EventArgs e) {
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
                case 1:
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        } //end While

                    } else if(radKatakana.IsChecked == true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        } //End While
                    } else if(radMixed.IsChecked== true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        } //End While
                    }
                    break; //Case 1
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        } //end While

                    } else if(radKatakana.IsChecked == true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        }//end While
                    } else if(radMixed.IsChecked == true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("value",
                                "");
                            lblKana.Content = kana;
                        }//end While
                    } //end if
                    break; //Case 2
                case 3:
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
                    } else if(radKatakana.IsChecked == true) {
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

                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        } //End While
                    } else if(radMixed.IsChecked == true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        } //end While

                    } //end if
                    break; //Case 3
                case 4:
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        }//end While
                    } else if (radKatakana.IsChecked == true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);

                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana", "");
                            lblKana.Content = kana;
                        } //End While
                    } else if (radMixed.IsChecked == true) {
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
                        nav.Evaluate(strExpression);
                        nodeIter = nav.Select(strExpression);
                        while (nodeIter.MoveNext()) {
                            string kana = nodeIter.Current.GetAttribute("kana",
                                "");
                            lblKana.Content = kana;
                        }
                    }
                    break; //Case 4
                case 5:
                    XPaths.zSeries.Init();


            } //End Switch


        }

        private void btnCheck_Click(object sender,EventArgs e) {

        }

        private void btnNext_Click(object sender, EventArgs e) {
            
        }

        private void btnQuit_Click(object sender,EventArgs e) {
            Application.Current.Shutdown();

        }

        private void GetNextKana() { }

        private void OnKeyDown(object sender,KeyEventArgs e) {

        }
    }
}
