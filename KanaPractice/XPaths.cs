﻿using System;
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

        #region aiueo
        public struct aiueo {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;
            public static void Init() {
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
        #endregion

        #region K/G
        public struct kSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
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
        } //End Struct kSeries

        public struct gSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
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
        } //End Struct gSeries
        #endregion

        #region S/Z
        public struct sSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
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
                    "/kana/hirg/sSeries/so","/kana/kata/sSeries/so"
                };
            } //end Init
        } //end Struct sSeries

        public struct zSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
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
        } //End Struct zSeries
        #endregion

        #region T/D
        public struct tSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
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
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
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
        } //End Struct dSeries

        #endregion

        #region N
        public struct nSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/nSeries/na",
                    "/kana/hirg/nSeries/ni",
                    "/kana/hirg/nSeries/nu",
                    "/kana/hirg/nSeries/ne",
                    "/kana/hirg/nSeries/no"
                };

                kata = new string[] {
                    "/kana/kata/nSeries/na",
                    "/kana/kata/nSeries/ni",
                    "/kana/kata/nSeries/nu",
                    "/kana/kata/nSeries/ne",
                    "/kana/kata/nSeries/no"
                };

                mixed = new string[] {
                    "/kana/hirg/nSeries/na","/kana/kata/nSeries/na",
                    "/kana/hirg/nSeries/ni","/kana/kata/nSeries/ni",
                    "/kana/hirg/nSeries/nu","/kana/kata/nSeries/nu",
                    "/kana/hirg/nSeries/ne","/kana/kata/nSeries/ne",
                    "/kana/hirg/nSeries/no","/kana/kata/nSeries/no"
                };

            }//End Init

        } 
        #endregion

        #region H/B/P
        public struct hSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/hSeries/ha",
                    "/kana/hirg/hSeries/hi",
                    "/kana/hirg/hSeries/fu",
                    "/kana/hirg/hSeries/he",
                    "/kana/hirg/hSeries/ho"
                };

                kata = new string[] {
                    "/kana/kata/hSeries/ha",
                    "/kana/kata/hSeries/hi",
                    "/kana/kata/hSeries/fu",
                    "/kana/kata/hSeries/he",
                    "/kana/kata/hSeries/ho"
                };

                mixed = new string[] {
                    "/kana/hirg/hSeries/ha","/kana/kata/hSeries/ha",
                    "/kana/hirg/hSeries/hi","/kana/kata/hSeries/hi",
                    "/kana/hirg/hSeries/fu","/kana/kata/hSeries/fu",
                    "/kana/hirg/hSeries/he","/kana/kata/hSeries/he",
                    "/kana/hirg/hSeries/ho","/kana/kata/hSeries/ho"
                };
            } //End Init
        } //End Structure hSeries

        public struct bSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/bSeries/ba",
                    "/kana/hirg/bSeries/bi",
                    "/kana/hirg/bSeries/bu",
                    "/kana/hirg/bSeries/be",
                    "/kana/hirg/bSeries/bo"
                };

                kata = new string[] {
                    "/kana/kata/bSeries/ba",
                    "/kana/kata/bSeries/bi",
                    "/kana/kata/bSeries/bu",
                    "/kana/kata/bSeries/be",
                    "/kana/kata/bSeries/bo"
                };

                mixed = new string[] {
                    "/kana/hirg/bSeries/ba","/kana/kata/bSeries/ba",
                    "/kana/hirg/bSeries/bi","/kana/kata/bSeries/bi",
                    "/kana/hirg/bSeries/bu","/kana/kata/bSeries/bu",
                    "/kana/hirg/bSeries/be","/kana/kata/bSeries/be",
                    "/kana/hirg/bSeries/bo","/kana/kata/bSeries/bo"
                };
            } //End Init()

        } //End Structure bSeries

        public struct pSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/pSeries/pa",
                    "/kana/hirg/pSeries/pi",
                    "/kana/hirg/pSeries/pu",
                    "/kana/hirg/pSeries/pe",
                    "/kana/hirg/pSeries/po"
                };

                kata = new string[] {
                    "/kana/kata/pSeries/pa",
                    "/kana/kata/pSeries/pi",
                    "/kana/kata/pSeries/pu",
                    "/kana/kata/pSeries/pe",
                    "/kana/kata/pSeries/po"
                };

                mixed = new string[] {
                    "/kana/hirg/pSeries/pa","/kana/kata/pSeries/pa",
                    "/kana/hirg/pSeries/pi","/kana/kata/pSeries/pi",
                    "/kana/hirg/pSeries/pu","/kana/kata/pSeries/pu",
                    "/kana/hirg/pSeries/pe","/kana/kata/pSeries/pe",
                    "/kana/hirg/pSeries/po","/kana/kata/pSeries/po"
                };
            }//End Init

        } //End Structure pSeries
        #endregion

        #region M
        public struct mSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/mSeries/ma",
                    "/kana/hirg/mSeries/mi",
                    "/kana/hirg/mSeries/mu",
                    "/kana/hirg/mSeries/me",
                    "/kana/hirg/mSeries/mo"
                };

                kata = new string[] {
                    "/kana/kata/mSeries/ma",
                    "/kana/kata/mSeries/mi",
                    "/kana/kata/mSeries/mu",
                    "/kana/kata/mSeries/me",
                    "/kana/kata/mSeries/mo"
                };

                mixed = new string[] {
                    "/kana/hirg/mSeries/ma","/kana/kata/mSeries/ma",
                    "/kana/hirg/mSeries/mi","/kana/kata/mSeries/mi",
                    "/kana/hirg/mSeries/mu","/kana/kata/mSeries/mu",
                    "/kana/hirg/mSeries/me","/kana/kata/mSeries/me",
                    "/kana/hirg/mSeries/mo","/kana/kata/mSeries/mo"
                };
            } //End Init
        } //End Struct
        #endregion

        #region Y
        public struct ySeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/ySeries/ya",
                    "/kana/hirg/ySeries/yu",
                    "/kana/hirg/ySeries/yo"
                };

                kata = new string[] {
                    "/kana/kata/ySeries/ya",
                    "/kana/kata/ySeries/yu",
                    "/kana/kata/ySeries/yo"
                };

                mixed = new string[] {
                    "/kana/hirg/ySeries/ya","/kana/kata/ySeries/ya",
                    "/kana/hirg/ySeries/yu","/kana/kata/ySeries/yu",
                    "/kana/hirg/ySeries/yo","/kana/kata/ySeries/yo"
                };
            }//End INit
        }//End Struct
        #endregion

        #region R
        public struct rSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/rSeries/ra",
                    "/kana/hirg/rSeries/ri",
                    "/kana/hirg/rSeries/ru",
                    "/kana/hirg/rSeries/re",
                    "/kana/hirg/rSeries/ro"
                };

                kata = new string[] {
                    "/kana/kata/rSeries/ra",
                    "/kana/kata/rSeries/ri",
                    "/kana/kata/rSeries/ru",
                    "/kana/kata/rSeries/re",
                    "/kana/kata/rSeries/ro"
                };

                mixed = new string[] {
                    "/kana/hirg/rSeries/ra","/kana/kata/rSeries/ra",
                    "/kana/hirg/rSeries/ri","/kana/kata/rSeries/ri",
                    "/kana/hirg/rSeries/ru","/kana/kata/rSeries/ru",
                    "/kana/hirg/rSeries/re","/kana/kata/rSeries/re",
                    "/kana/hirg/rSeries/ro","/kana/kata/rSeries/ro"
                };
            }

        } //End Struct
        #endregion

        #region W
        public struct wSeries {
            public static string[] hirg;
            public static string[] kata;
            public static string[] mixed;

            public static void Init() {
                hirg = new string[] {
                    "/kana/hirg/wSeries/wa",
                    "/kana/hirg/wSeries/wo",
                    "/kana/hirg/wSeries/n"
                };

                kata = new string[] {
                    "/kana/kata/wSeries/wa",
                    "/kana/kata/wSeries/wo",
                    "/kana/kata/wSeries/n"
                };

                mixed = new string[] {
                    "/kana/hirg/wSeries/wa","/kana/kata/wSeries/wa",
                    "/kana/hirg/wSeries/wo","/kana/kata/wSeries/wo",
                    "/kana/hirg/wSeries/n","/kana/kata/wSeries/n"
                };
            }//End Init
        }//End Struct
        #endregion

        #region Compound Sounds
        //0-35 hirg & katakana
        //0-71 mixed

        public struct comboSounds {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void Init() {
                hirg = new string[] {
                    "/kana/hirg/comboSounds/comboK/kya", //0
                    "/kana/hirg/comboSounds/comboK/kyu", //1
                    "/kana/hirg/comboSounds/comboK/kyo", //2
                    "/kana/hirg/comboSounds/comboG/gya", //3
                    "/kana/hirg/comboSounds/comboG/gyu", //4
                    "/kana/hirg/comboSounds/comboG/gyo", //5
                    "/kana/hirg/comboSounds/comboS/sha", //6
                    "/kana/hirg/comboSounds/comboS/shu", //7
                    "/kana/hirg/comboSounds/comboS/sho", //8
                    "/kana/hirg/comboSounds/comboJ/ja", //9
                    "/kana/hirg/comboSounds/comboJ/ju", //10
                    "/kana/hirg/comboSounds/comboJ/jo", //11
                    "/kana/hirg/comboSounds/comboCH/cha", //12
                    "/kana/hirg/comboSounds/comboCH/chu", //13
                    "/kana/hirg/comboSounds/comboCH/cho", //14
                    "/kana/hirg/comboSounds/comboD/dya", //15
                    "/kana/hirg/comboSounds/comboD/dyu", //16
                    "/kana/hirg/comboSounds/comboD/dyo", //17
                    "/kana/hirg/comboSounds/comboN/nya", //18
                    "/kana/hirg/comboSounds/comboN/nyu", //19
                    "/kana/hirg/comboSounds/comboN/nyo", //20
                    "/kana/hirg/comboSounds/comboH/hya", //21
                    "/kana/hirg/comboSounds/comboH/hyu", //22
                    "/kana/hirg/comboSounds/comboH/hyo", //23
                    "/kana/hirg/comboSounds/comboB/bya", //24
                    "/kana/hirg/comboSounds/comboB/byu", //25
                    "/kana/hirg/comboSounds/comboB/byo", //26
                    "/kana/hirg/comboSounds/comboP/pya", //27
                    "/kana/hirg/comboSounds/comboP/pyu", //28
                    "/kana/hirg/comboSounds/comboP/pyo", //29
                    "/kana/hirg/comboSounds/comboM/mya", //30
                    "/kana/hirg/comboSounds/comboM/myu", //31
                    "/kana/hirg/comboSounds/comboM/myo", //32
                    "/kana/hirg/comboSounds/comboR/rya", //33
                    "/kana/hirg/comboSounds/comboR/ryu", //34
                    "/kana/hirg/comboSounds/comboR/ryo" //35
                };

                kata = new string[] {
                    "/kana/kata/comboSounds/comboK/kya", //0
                    "/kana/kata/comboSounds/comboK/kyu", //1
                    "/kana/kata/comboSounds/comboK/kyo", //2
                    "/kana/kata/comboSounds/comboG/gya", //3
                    "/kana/kata/comboSounds/comboG/gyu", //4
                    "/kana/kata/comboSounds/comboG/gyo", //5
                    "/kana/kata/comboSounds/comboS/sha", //6
                    "/kana/kata/comboSounds/comboS/shu", //7
                    "/kana/kata/comboSounds/comboS/sho", //8
                    "/kana/kata/comboSounds/comboJ/ja", //9
                    "/kana/kata/comboSounds/comboJ/ju", //10
                    "/kana/kata/comboSounds/comboJ/jo", //11
                    "/kana/kata/comboSounds/comboCH/cha", //12
                    "/kana/kata/comboSounds/comboCH/chu", //13
                    "/kana/kata/comboSounds/comboCH/cho", //14
                    "/kana/kata/comboSounds/comboD/dya", //15
                    "/kana/kata/comboSounds/comboD/dyu", //16
                    "/kana/kata/comboSounds/comboD/dyo", //17
                    "/kana/kata/comboSounds/comboN/nya", //18
                    "/kana/kata/comboSounds/comboN/nyu", //19
                    "/kana/kata/comboSounds/comboN/nyo", //20
                    "/kana/kata/comboSounds/comboH/hya", //21
                    "/kana/kata/comboSounds/comboH/hyu", //22
                    "/kana/kata/comboSounds/comboH/hyo", //23
                    "/kana/kata/comboSounds/comboB/bya", //24
                    "/kana/kata/comboSounds/comboB/byu", //25
                    "/kana/kata/comboSounds/comboB/byo", //26
                    "/kana/kata/comboSounds/comboP/pya", //27
                    "/kana/kata/comboSounds/comboP/pyu", //28
                    "/kana/kata/comboSounds/comboP/pyo", //29
                    "/kana/kata/comboSounds/comboM/mya", //30
                    "/kana/kata/comboSounds/comboM/myu", //31
                    "/kana/kata/comboSounds/comboM/myo", //32
                    "/kana/kata/comboSounds/comboR/rya", //33
                    "/kana/kata/comboSounds/comboR/ryu", //34
                    "/kana/kata/comboSounds/comboR/ryo" //35
                };

                mixed = new string[] {
                    "/kana/hirg/comboSounds/comboK/kya", //0
                    "/kana/hirg/comboSounds/comboK/kyu", //1
                    "/kana/hirg/comboSounds/comboK/kyo", //2
                    "/kana/hirg/comboSounds/comboG/gya", //3
                    "/kana/hirg/comboSounds/comboG/gyu", //4
                    "/kana/hirg/comboSounds/comboG/gyo", //5
                    "/kana/hirg/comboSounds/comboS/sha", //6
                    "/kana/hirg/comboSounds/comboS/shu", //7
                    "/kana/hirg/comboSounds/comboS/sho", //8
                    "/kana/hirg/comboSounds/comboJ/ja", //9
                    "/kana/hirg/comboSounds/comboJ/ju", //10
                    "/kana/hirg/comboSounds/comboJ/jo", //11
                    "/kana/hirg/comboSounds/comboCH/cha", //12
                    "/kana/hirg/comboSounds/comboCH/chu", //13
                    "/kana/hirg/comboSounds/comboCH/cho", //14
                    "/kana/hirg/comboSounds/comboD/dya", //15
                    "/kana/hirg/comboSounds/comboD/dyu", //16
                    "/kana/hirg/comboSounds/comboD/dyo", //17
                    "/kana/hirg/comboSounds/comboN/nya", //18
                    "/kana/hirg/comboSounds/comboN/nyu", //19
                    "/kana/hirg/comboSounds/comboN/nyo", //20
                    "/kana/hirg/comboSounds/comboH/hya", //21
                    "/kana/hirg/comboSounds/comboH/hyu", //22
                    "/kana/hirg/comboSounds/comboH/hyo", //23
                    "/kana/hirg/comboSounds/comboB/bya", //24
                    "/kana/hirg/comboSounds/comboB/byu", //25
                    "/kana/hirg/comboSounds/comboB/byo", //26
                    "/kana/hirg/comboSounds/comboP/pya", //27
                    "/kana/hirg/comboSounds/comboP/pyu", //28
                    "/kana/hirg/comboSounds/comboP/pyo", //29
                    "/kana/hirg/comboSounds/comboM/mya", //30
                    "/kana/hirg/comboSounds/comboM/myu", //31
                    "/kana/hirg/comboSounds/comboM/myo", //32
                    "/kana/hirg/comboSounds/comboR/rya", //33
                    "/kana/hirg/comboSounds/comboR/ryu", //34
                    "/kana/hirg/comboSounds/comboR/ryo", //35
                    "/kana/kata/comboSounds/comboK/kya", //36
                    "/kana/kata/comboSounds/comboK/kyu", //37
                    "/kana/kata/comboSounds/comboK/kyo", //38
                    "/kana/kata/comboSounds/comboG/gya", //39
                    "/kana/kata/comboSounds/comboG/gyu", //40
                    "/kana/kata/comboSounds/comboG/gyo", //41
                    "/kana/kata/comboSounds/comboS/sha", //42
                    "/kana/kata/comboSounds/comboS/shu", //43
                    "/kana/kata/comboSounds/comboS/sho", //44
                    "/kana/kata/comboSounds/comboJ/ja", //45
                    "/kana/kata/comboSounds/comboJ/ju", //46
                    "/kana/kata/comboSounds/comboJ/jo", //47
                    "/kana/kata/comboSounds/comboCH/cha", //48
                    "/kana/kata/comboSounds/comboCH/chu", //49
                    "/kana/kata/comboSounds/comboCH/cho", //50
                    "/kana/kata/comboSounds/comboD/dya", //51
                    "/kana/kata/comboSounds/comboD/dyu", //52
                    "/kana/kata/comboSounds/comboD/dyo", //53
                    "/kana/kata/comboSounds/comboN/nya", //54
                    "/kana/kata/comboSounds/comboN/nyu", //55
                    "/kana/kata/comboSounds/comboN/nyo", //56
                    "/kana/kata/comboSounds/comboH/hya", //57
                    "/kana/kata/comboSounds/comboH/hyu", //58
                    "/kana/kata/comboSounds/comboH/hyo", //59
                    "/kana/kata/comboSounds/comboB/bya", //60
                    "/kana/kata/comboSounds/comboB/byu", //61
                    "/kana/kata/comboSounds/comboB/byo", //62
                    "/kana/kata/comboSounds/comboP/pya", //63
                    "/kana/kata/comboSounds/comboP/pyu", //64
                    "/kana/kata/comboSounds/comboP/pyo", //65
                    "/kana/kata/comboSounds/comboM/mya", //66
                    "/kana/kata/comboSounds/comboM/myu", //67
                    "/kana/kata/comboSounds/comboM/myo", //68
                    "/kana/kata/comboSounds/comboR/rya", //69
                    "/kana/kata/comboSounds/comboR/ryu", //70
                    "/kana/kata/comboSounds/comboR/ryo" //71

                };
            }

        }



        #endregion
    }
}
