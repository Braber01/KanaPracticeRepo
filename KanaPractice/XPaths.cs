using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice {

    /// <summary>
    /// A Class to hold Strings 
    /// of Each XPath Element 
    /// Based on what Kana the user 
    /// wants to practice.
    /// </summary>
    public static class XPaths {
        
        public struct aiueo {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;
            public void init() {
                hirg = new string[] {
                    "/kana/hirg/aiueo/a",
                    "/kana/hirg/aiueo/i",
                    "/kana/hirg/aiueo/u",
                    "/kana/hirg/aiueo/e",
                    "/kana/hirg/aiueo/o"
                }; //0-4

                kata = new string[] {
                    "/kana/kata/aiueo/a",
                    "/kana/kata/aiueo/i",
                    "/kana/kata/aiueo/u",
                    "/kana/kata/aiueo/e",
                    "/kana/kata/aiueo/o"
                }; //0-4

                mixed = new string[] {
                    "/kana/hirg/aiueo/a","/kana/kata/aiueo/a",
                    "/kana/hirg/aiueo/i","/kana/kata/aiueo/i",
                    "/kana/hirg/aiueo/u","/kana/kata/aiueo/u",
                    "/kana/hirg/aiueo/e","/kana/kata/aiueo/e",
                    "/kana/hirg/aiueo/o","/kana/kata/aiueo/o"
                }; //0-9
            } //End Init
        } //End Struct


        #region K/G
        public struct kSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                //aiueo
                hirg = new string[] {
                    "/kana/hirg/kSeries/ka",
                    "/kana/hirg/kSeries/ki",
                    "/kana/hirg/kSeries/ku",
                    "/kana/hirg/kSeries/ke",
                    "/kana/hirg/kSeries/ko"
                }; //0-4

                kata = new string[] {
                    "/kana/kata/kSeries/ka",
                    "/kana/kata/kSeries/ki",
                    "/kana/kata/kSeries/ku",
                    "/kana/kata/kSeries/ke",
                    "/kana/kata/kSeries/ko"
                }; //0-4

                mixed = new string[] {
                    "/kana/hirg/kSeries/ka","/kana/kata/kSeries/ka",
                    "/kana/hirg/kSeries/ki","/kana/kata/kSeries/ki",
                    "/kana/hirg/kSeries/ku","/kana/kata/kSeries/ku",
                    "/kana/hirg/kSeries/ke","/kana/kata/kSeries/ke",
                    "/kana/hirg/kSeries/ko","/kana/kata/kSeries/ko"
                }; //0-9
            } //End Init
        } //End Struct

        public struct gSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/gSeries/ga",
                    "/kana/hirg/gSeries/gi",
                    "/kana/hirg/gSeries/gu",
                    "/kana/hirg/gSeries/ge",
                    "/kana/hirg/gSeries/go"
                }; //0-4

                kata = new string[] {
                    "/kana/kata/gSeries/ga",
                    "/kana/kata/gSeries/gi",
                    "/kana/kata/gSeries/gu",
                    "/kana/kata/gSeries/ge",
                    "/kana/kata/gSeries/go"
                }; //0-4

                mixed = new string[] {
                    "/kana/hirg/gSeries/ga","/kana/kata/gSeries/ga",
                    "/kana/hirg/gSeries/gi","/kana/kata/gSeries/gi",
                    "/kana/hirg/gSeries/gu","/kana/kata/gSeries/gu",
                    "/kana/hirg/gSeries/ge","/kana/kata/gSeries/ge",
                    "/kana/hirg/gSeries/go","/kana/kata/gSeries/go"
                }; // 0-9
            } //end Init
        }

        public struct comboK {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboK/kya",
                    "/kana/hirg/comboK/kyu",
                    "/kana/hirg/comboK/kyo"
                }; //0-2

                kata = new string[] {
                    "/kana/kata/comboK/kya",
                    "/kana/kata/comboK/kyu",
                    "/kana/kata/comboK/kyo"
                }; //0-2

                mixed = new string[] {
                    "/kana/hirg/comboK/kya","/kana/kata/comboK/kya",
                    "/kana/hirg/comboK/kyu","/kana/kata/comboK/kyu",
                    "/kana/hirg/comboK/kyo","/kana/kata/comboK/kyo"
                }; //0-5


            } //End Init
        } //End Struct

        public struct comboG {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboG/gya",
                    "/kana/hirg/comboG/gyu",
                    "/kana/hirg/comboG/gyo"
                }; //0-2

                kata = new string[] {
                    "/kana/kata/comboG/gya",
                    "/kana/kata/comboG/gyu",
                    "/kana/kata/comboG/gyo"
                }; //0-2

                mixed = new string[] {
                    "/kana/hirg/comboG/gya","/kana/kata/comboG/gya",
                    "/kana/hirg/comboG/gyu","kana/kata/comboG/gyu",
                    "/kana/hirg/comboG/gyo","/kana/kata/comboG/gyo"
                };
            } //End Init
        } //End Struct
        #endregion

        #region S/Z
        public struct sSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/sSeries/sa",
                    "/kana/hirg/sSeries/shi",
                    "/kana/hirg/sSeries/su",
                    "/kana/hirg/sSeries/se",
                    "/kana/hirg/sSeries/so"
                };

                kata = new string[] {
                    "/kana/kata/sSeries/sa",
                    "/kana/kata/sSeries/shi",
                    "/kana/kata/sSeries/su",
                    "/kana/kata/sSeries/se",
                    "/kana/kata/sSeries/so"
                };

                mixed = new string[] {
                    "/kana/hirg/sSeries/sa","/kana/kata/sSeries/sa",
                    "/kana/hirg/sSeries/shi","/kana/kata/sSeries/shi",
                    "/kana/hirg/sSeries/su","/kana/kata/sSeries/su",
                    "/kana/hirg/sSeries/se","/kana/kata/sSeries/se",
                    ""
                };
            } //end Init
        } //end Struct



        
    }
}
