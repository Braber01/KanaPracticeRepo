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

        public struct zSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/zSeries/za",
                    "/kana/hirg/zSeries/ji",
                    "/kana/hirg/zSeries/zu",
                    "/kana/hirg/zSeries/ze",
                    "/kana/hirg/zSeries/zo"
                };

                kata = new string[] {
                    "/kana/kata/zSeries/za",
                    "/kana/kata/zSeries/ji",
                    "/kana/kata/zSeries/zu",
                    "/kana/kata/zSeries/ze",
                    "/kana/kata/zSeries/zo"
                };

                mixed = new string[] {
                    "/kana/hirg/zSeries/za","/kana/kata/zSeries/za",
                    "/kana/hirg/zSeries/ji","/kana/kata/zSeries/ji",
                    "/kana/hirg/zSeries/zu","/kana/kata/zSeries/zu",
                    "/kana/hirg/zSeries/ze","/kana/kata/zSeries/ze",
                    "/kana/hirg/zSeries/zo","/kana/kata/zSeries/zo"
                };

            } //End init()
        } //End Struct

        public struct comboS {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboS/sha",
                    "/kana/hirg/comboS/shu",
                    "/kana/hirg/comboS/sho"
                };

                kata = new string[] {
                    "/kana/kata/comboS/sha",
                    "/kana/kata/comboS/shu",
                    "/kana/kata/comboS/sho"
                };

                mixed = new string[] {
                    "/kana/hirg/comboS/sha","/kana/kata/comboS/sha",
                    "/kana/hirg/comboS/shu","/kana/kata/comboS/shu",
                    "/kana/hirg/comboS/sho","/kana/kata/comboS/sho"
                };
            }//End Init
        } //End Struct

        public struct comboJ {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {

                hirg = new string[] {
                    "/kana/hirg/comboJ/ja",
                    "/kana/hirg/comboJ/ju",
                    "/kana/hirg/comboJ/jo"
                };

                kata = new string[] {
                    "/kana/kata/comboJ/ja",
                    "/kana/kata/comboJ/ju",
                    "/kana/kata/comboJ/jo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboJ/ja","/kana/kata/comboJ/ja",
                    "/kana/hirg/comboJ/ju","/kana/kata/comboJ/ju",
                    "/kana/hirg/comboJ/jo","/kana/kata/comboJ/jo"
                };
            }//End Init
        } //End Struct
        #endregion

        #region T/D
        public struct tSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/tSeries/ta",
                    "/kana/hirg/tSeries/chi",
                    "/kana/hirg/tSeries/tsu",
                    "/kana/hirg/tSeries/te",
                    "/kana/hirg/tSeries/to"
                };

                kata = new string[] {
                    "/kana/kata/tSeries/ta",
                    "/kana/kata/tSeries/chi",
                    "/kana/kata/tSeries/tsu",
                    "/kana/kata/tSeries/te",
                    "/kana/kata/tSeries/to"
                };

                mixed = new string[] {
                    "/kana/hirg/tSeries/ta","/kana/kata/tSeries/ta",
                    "/kana/hirg/tSeries/chi","/kana/kata/tSeries/chi",
                    "/kana/hirg/tSeries/tsu","/kana/kata/tSeries/tsu",
                    "/kana/hirg/tSeries/te","/kana/kata/tSeries/te",
                    "/kana/hirg/tSeries/to","/kana/kata/tSeries/to"
                };
            } //End Init
        } //End struct tSeries

        public struct dSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/dSeries/da",
                    "/kana/hirg/dSeries/di",
                    "/kana/hirg/dSeries/du",
                    "/kana/hirg/dSeries/de",
                    "/kana/hirg/dSeries/do"
                };

                kata = new string[] {
                    "/kana/kata/dSeries/da",
                    "/kana/kata/dSeries/di",
                    "/kana/kata/dSeries/du",
                    "/kana/kata/dSeries/de",
                    "/kana/kata/dSeries/do"
                };

                mixed = new string[] {
                    "/kana/hirg/dSeries/da","/kana/kata/dSeries/da",
                    "/kana/hirg/dSeries/di","/kana/kata/dSeries/di",
                    "/kana/hirg/dSeries/du","/kana/kata/dSeries/du",
                    "/kana/hirg/dSeries/de","/kana/kata/dSeries/de",
                    "/kana/hirg/dSeries/do","/kana/kata/dSeries/do"
                };
            } //End Init
        } //End Struct

        public struct comboCH {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() { }//End Init
        }

        public struct comboD { }
        #endregion



    }
}
