using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ToolsLibrary;

namespace Project_SFX_Config
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class Params
    {
        public static List<List<string>> Languages = new List<List<string>>();
        public static IniFile MainIniFile = new IniFile(Path.Combine(Application.StartupPath, "config.ini"));
        public bool AutoReplace; //bool.Parse(Params.MainIniFile.GetString("General", "AutoReplace", "false"));
        public static string SavedPath = "";

        public static readonly string[,] LangList = {{"Afrikaans", "1078"},{"Albanian", "1052"},{"Arabic (Algeria)", "5121"},{"Arabic (Bahrain)", "15361"},
			{"Arabic (Egypt)", "3073"},{"Arabic (Iraq)", "2049"},{"Arabic (Jordan)", "11265"},{"Arabic (Kuwait)", "13313"},{"Arabic (Lebanon)", "12289"},
			{"Arabic (Libya)", "4097"},{"Arabic (Morocco)", "6145"},{"Arabic (Oman)", "8193"},{"Arabic (Qatar)", "16385"},{"Arabic (Saudi Arabia)", "1025"},
			{"Arabic (Syria)", "10241"},{"Arabic (Tunisia)", "7169"},{"Arabic (U.A.E.)", "14337"},{"Arabic (Yemen)", "9217"},{"Basque", "1069"},
			{"Belarusian", "1059"},{"Bulgarian", "1026"},{"Catalan", "1027"},{"Chinese (Hong Kong SAR)", "3076"},{"Chinese (PRC)", "2052"},
			{"Chinese (Singapore)", "4100"},{"Chinese (Taiwan)", "1028"},{"Croatian", "1050"},{"Czech", "1029"},{"Danish", "1030"},
			{"Dutch", "1043"},{"Dutch (Belgium)", "2067"},{"English (Australia)", "3081"},{"English (Belize)", "10249"},{"English (Canada)", "4105"},
			{"English (Ireland)", "6153"},{"English (Jamaica)", "8201"},{"English (New Zealand)", "5129"},{"English (South Africa)", "7177"},
			{"English (Trinidad)", "11273"},{"English (United Kingdom)", "2057"},{"English (United States)", "1033"},{"Estonian", "1061"},
			{"Faeroese", "1080"},{"Farsi", "1065"},{"Finnish", "1035"},{"French (Standard)", "1036"},{"French (Belgium)", "2060"},
			{"French (Canada)", "3084"},{"French (Luxembourg)", "5132"},{"French (Switzerland)", "4108"},{"Gaelic (Scotland)", "1084"},
			{"German (Standard)", "1031"},{"German (Austrian)", "3079"},{"German (Liechtenstein)", "5127"},{"German (Luxembourg)", "4103"},
			{"German (Switzerland)", "2055"},{"Greek", "1032"},{"Hebrew", "1037"},{"Hindi", "1081"},{"Hungarian", "1038"},{"Icelandic", "1039"},
			{"Indonesian", "1057"},{"Italian (Standard)", "1040"},{"Italian (Switzerland)", "2064"},{"Japanese", "1041"},{"Korean", "1042"},
			{"Latvian", "1062"},{"Lithuanian", "1063"},{"Macedonian (FYROM)", "1071"},{"Malay (Malaysia)", "1086"},{"Maltese", "1082"},
			{"Norwegian (Bokmеl)", "1044"},{"Polish", "1045"},{"Portuguese (Brazil)", "1046"},{"Portuguese (Portugal)", "2070"},
			{"Raeto (Romance)", "1047"},{"Romanian", "1048"},{"Romanian (Moldova)", "2072"},{"Russian", "1049"},{"Russian (Moldova)", "2073"},
			{"Serbian (Cyrillic)", "3098"},{"Setsuana", "1074"},{"Slovak", "1051"},{"Slovenian", "1060"},{"Sorbian", "1070"},
			{"Spanish (Argentina)", "11274"},{"Spanish (Bolivia)", "16394"},{"Spanish (Chile)", "13322"},{"Spanish (Columbia)", "9226"},
			{"Spanish (Costa Rica)", "5130"},{"Spanish (Dominican Republic)", "7178"},{"Spanish (Ecuador)", "12298"},{"Spanish (El Salvador)", "17418"},
			{"Spanish (Guatemala)", "4106"},{"Spanish (Honduras)", "18442"},{"Spanish (Mexico)", "2058"},{"Spanish (Nicaragua)", "19466"},
			{"Spanish (Panama)", "6154"},{"Spanish (Paraguay)", "15370"},{"Spanish (Peru)", "10250"},{"Spanish (Puerto Rico)", "20490"},
			{"Spanish (Spain)", "1034"},{"Spanish (Uruguay)", "14346"},{"Spanish (Venezuela)", "8202"},{"Sutu", "1072"},
			{"Swedish", "1053"},{"Swedish (Finland)", "2077"},{"Thai", "1054"},{"Turkish", "1055"},{"Tsonga", "1073"},
			{"Ukranian", "1058"},{"Urdu (Pakistan)", "1056"},{"Vietnamese", "1066"},{"Xhosa", "1076"},{"Yiddish", "1085"},{"Zulu", "1077"}};
    }
}