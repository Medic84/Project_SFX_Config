using System;
using System.Globalization;
using System.Windows.Forms;

namespace Project_SFX_Config
{
    public partial class SelectPrefix : Form
    {
        private string _prefixes = "";

        public string Prefix
        {
            get { return _prefixes; }
            set { _prefixes = value; }
        }

        public SelectPrefix()
        {
            InitializeComponent();
        }

        private void TnowaitCheck_Click(object sender, EventArgs e)
        {
            if (!TforcenowaitCheck.Checked && !TWaitAllCheck.Checked) return;
            TforcenowaitCheck.Checked = false;
            TWaitAllCheck.Checked = false;
        }

        private void TforcenowaitCheck_Click(object sender, EventArgs e)
        {
            if (!TnowaitCheck.Checked && !TWaitAllCheck.Checked) return;
            TnowaitCheck.Checked = false;
            TWaitAllCheck.Checked = false;
        }

        private void TOKBt_Click(object sender, EventArgs e)
        {
            _prefixes = "";

            if (TfmCheck.Checked) _prefixes += "fm" + Tfmnumber.Value.ToString(CultureInfo.InvariantCulture) + ":";
            if (TArchx86Radio.Checked) _prefixes += "x86:";
            if (TArchx64Radio.Checked) _prefixes += "x64:";
            if (TArchPRadio.Checked) _prefixes += "%%P:";
            if (ThidconCheck.Checked) _prefixes += "hidcon:";
            if (TnowaitCheck.Checked) _prefixes += "nowait:";
            if (TforcenowaitCheck.Checked) _prefixes += "forcenowait:";
            if (TWaitAllCheck.Checked) _prefixes += "waitall:";
            if (TshcCheck.Checked) _prefixes += "shc" + Tshcnumber.Value.ToString(CultureInfo.InvariantCulture) + ":";
            if (TdelCheck.Checked) _prefixes += "del" + Tdelnumber.Value.ToString(CultureInfo.InvariantCulture) + ":";
        }

        private void TWaitAllCheck_Click(object sender, EventArgs e)
        {
            if (!TnowaitCheck.Checked && !TforcenowaitCheck.Checked) return;
            TnowaitCheck.Checked = false;
            TforcenowaitCheck.Checked = false;
        }

        private void SelectPrefix_Load(object sender, EventArgs e)
        {
            string[] arrayprefixes = _prefixes.Split(':');
            foreach (string prefix in arrayprefixes)
            {
                if (prefix == "x86") TArchx86Radio.Checked = true;
                if (prefix == "x64") TArchx64Radio.Checked = true;
                if (prefix == "%%P") TArchPRadio.Checked = true;
                if (prefix == "hidcon") ThidconCheck.Checked = true;
                if (prefix == "nowait") TnowaitCheck.Checked = true;
                if (prefix == "forcenowait") TforcenowaitCheck.Checked = true;
                if (prefix == "waitall") TWaitAllCheck.Checked = true;
                if (prefix.Contains("fm"))
                {
                    string temp = prefix.Replace("fm", "");
                    TfmCheck.Checked = true;
                    Tfmnumber.Value = int.Parse(temp);
                }
                if (prefix.Contains("shc"))
                {
                    string temp = prefix.Replace("shc", "");
                    TshcCheck.Checked = true;
                    Tshcnumber.Value = int.Parse(temp);
                }
                if (prefix.Contains("del"))
                {
                    string temp = prefix.Replace("del", "");
                    TdelCheck.Checked = true;
                    Tdelnumber.Value = int.Parse(temp);
                }
            }

            ToolTiper.SetToolTip(Tfmnumber, "* 0 - запрет отображения диалога FinishMessage\n"
                + "* 1 - вывод диалога FinishMessage\n"
                + "* 2...999 - определяет время отображения диалога FinishMessage");

            ToolTiper.SetToolTip(TfmCheck, "* 0 - запрет отображения диалога FinishMessage\n"
                + "* 1 - вывод диалога FinishMessage\n"
                + "* 2...999 - определяет время отображения диалога FinishMessage");

            ToolTiper.SetToolTip(TforcenowaitCheck, "Заставляет не дожидаться окончания выполнения команды запуска.\nВ отличии от префикса 'nowait' работает и при распаковке во временную папку.");
            ToolTiper.SetToolTip(TnowaitCheck, "Заставляет не дожидаться окончания выполнения команды запуска.\nПри распаковке во временную папку префикс 'nowait' ИГНОРИРУЕТСЯ.");
            ToolTiper.SetToolTip(ThidconCheck, "Скрывает консольные окна.");
            ToolTiper.SetToolTip(TWaitAllCheck, "Заставляет дожидаться окончания выполнения команды запуска и всех \"дочерних\" процессов, запущенных этой командой.");
            ToolTiper.SetToolTip(TArchx86Radio, "Команда запуска будет выполнена ТОЛЬКО в 32-х битной системе.");
            ToolTiper.SetToolTip(TArchx64Radio, "Команда запуска будет выполнена ТОЛЬКО в 64-х битной системе.");

            ToolTiper.SetToolTip(Tshcnumber, "Режим обработки параметров 'Shortcut' и 'ShortcutX'.\n"
                + "* 0 - отключает выполнение параметра 'Shortcut' даже при отсутствии литерного 'ShortcutX'\n" 
                + "* 1 - добавляет к выполнению параметра 'Shortcut' выполнение литерного 'ShortcutX'");
            ToolTiper.SetToolTip(TshcCheck, "Режим обработки параметров 'Shortcut' и 'ShortcutX'.\n"
                + "* 0 - отключает выполнение параметра 'Shortcut' даже при отсутствии литерного 'ShortcutX'\n"
                + "* 1 - добавляет к выполнению параметра 'Shortcut' выполнение литерного 'ShortcutX'");
            ToolTiper.SetToolTip(Tdelnumber, "Режим обработки параметров 'Delete' и 'DeleteX'.\n"
                + "* 0 - отключает выполнение параметра 'Delete' даже при отсутствии литерного 'DeleteX'\n"
                + "* 1 - добавляет к выполнению параметра 'Delete' выполнение литерного 'DeleteX'");
            ToolTiper.SetToolTip(TdelCheck, "Режим обработки параметров 'Delete' и 'DeleteX'.\n"
                + "* 0 - отключает выполнение параметра 'Delete' даже при отсутствии литерного 'DeleteX'\n"
                + "* 1 - добавляет к выполнению параметра 'Delete' выполнение литерного 'DeleteX'");

        }
    }
}
