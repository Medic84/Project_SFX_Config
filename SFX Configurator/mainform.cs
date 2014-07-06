using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ToolsLibrary;

namespace Project_SFX_Config
{
    public partial class MainForm : Form
    {
        private int _index = -1;
        protected MRUClass MRUMenu;
        private const string MRURegKey = "SOFTWARE\\MedicLab\\Project SFX Config";

        public MainForm()
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "ToolsLibrary.dll")))
            {
                MessageBox.Show(this, "Библиотека с базовыми функциями отсутствует.\nПрограмма будет закрыта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            InitializeComponent();
            MRUMenu = new MRUClassInline(MRUList, Clean, OnMruFile, MRURegKey + "\\MRU", 12);
            MRUMenu.LoadFromRegistry();
        }

        #region Extended Functions

        private void ClearForm()
        {
			SFX.ClearText(TTitle, TBeginPromptEdit, TErrorTitle, TPasswordTitleEdit, TExtractCancelText, 
				TPasswordText, TCancelPromptText,THelpTextEdit,TWarningTitleEdit, TFinishMessageEdit, TExtractTitle,
				TExtractPathTitle, TExtractPathText, TExtractDialogText, TCommText, TModifText, TParamText);
            TBeginPromptTimeOut.Value = 0;
            for (var i = 0; i < TMiscList.Items.Count; i++)
                TMiscList.SetItemChecked(i, false);
            for (var i = 0; i < TDesignList.Items.Count; i++)
                TDesignList.SetItemChecked(i, false);
            TOverWriteCombo.Text = "Нет";
            TGUIMode.Text = "Нет";
			TCommandsList.Items.Clear();
            TOverwritesysCheck.Checked = false;
            TSelfDeleteCheck.Checked = false;
            Params.Languages.Clear();
            LoadLangsArray(TTextLangsCombo.Items.Count + 1);
            SetStateSaveButton(false);
	        _index = -1;
        }

        private void OnMruFile(int number, String filename)
        {
                OpeningFile(filename);
                MRUMenu.SetFirstFile(number);
        }

        public void OpeningFile(string filePath)
        {
            MRUMenu.AddFile(filePath);
            MRUMenu.SaveToRegistry();
            var read = new StreamReader(filePath);
	        var sectionsMatches = SFX.GetMatches(read.ReadToEnd(),
	                       @";!@Install@!UTF-8((?:\:x\d{2,2})?(?:\:Language\:\d{4,5})?)!\s?(.+?)\s?;!@InstallEnd@(?:\:x\d{2})?(?:\:Language\:\d{4,5})?!");
		foreach (Match match in sectionsMatches)
            {
                var sectiontext = match.Groups[2].Value;
                var section = match.Groups[1].Value == "" ? "Основная" : match.Groups[1].Value.Remove(0, 1);
	            var paramsMatches = SFX.GetMatches(sectiontext,
	                                               @"(?s)(;?\x20*\t*\w+\d?)\s*=\s*(?:""(.+?)""|(-))(?=\s*[\r\n]|$)",
	                                               RegexOptions.None);

                foreach (Match paramsMatch in paramsMatches)
                {
                    string findedcomm = paramsMatch.Groups[1].Value.Replace(" ",""), findedparam = paramsMatch.Groups[2].Value;
                    if (paramsMatch.Groups[3].Value == "-") findedparam = paramsMatch.Groups[3].Value;
                    var index = 4;

                    switch (findedcomm.Trim())
                    {
                        case "GUIMode":
                            SetGUIMode(findedparam);
                            break;
                        case "OverwriteMode":
                            SetOverwriteMode(findedparam);
                            break;
                        case "MiscFlags":
							SFX.SetFlags(findedparam, ref TMiscList, 9);
                            break;
                        case "GUIFlags":
							SFX.SetFlags(findedparam, ref TDesignList, 16385);
                            break;
                        case "Title":
                            FoundIn(section, findedparam, 0);
                            break;
                        case "BeginPrompt":
                            FoundIn(section, findedparam, 1);
                            break;
                        case "FinishMessage":
                            FoundIn(section, findedparam, 2);
                            break;
                        case "ExtractTitle":
                            FoundIn(section, findedparam, 3);
                            break;
                        case "ExtractPathTitle":
                            FoundIn(section, findedparam, 4);
                            break;
                        case "ExtractPathText":
                            FoundIn(section, findedparam, 5);
                            break;
                        case "ExtractDialogText":
                            FoundIn(section, findedparam, 6);
                            break;
                        case "ErrorTitle":
                            FoundIn(section, findedparam, 7);
                            break;
                        case "ExtractCancelText":
                            FoundIn(section, findedparam, 8);
                            break;
                        case "CancelPrompt":
                            FoundIn(section, findedparam, 9);
                            break;
                        case "HelpText":
                            FoundIn(section, findedparam, 10);
                            break;
                        case "WarningTitle":
                            FoundIn(section, findedparam, 11);
                            break;
                        case "PasswordTitle":
                            FoundIn(section, findedparam, 12);
                            break;
                        case "PasswordText":
                            FoundIn(section, findedparam, 13);
                            break;
                        case "BeginPromptTimeout":
                            FoundIn(section, findedparam, 14);
                            break;
                        default:
                                if (!CheckInListCombo( (section.Replace("Language:", "").Trim() )))
                                    AddLangInCombos(section.Replace("Language:", "").Trim());
                            if (findedcomm.Contains("Delete")) index = 3;
                            if (findedcomm.Contains("Shortcut")) index = 0;
                            if ((findedcomm.Contains("SetEnvironment")) || (findedcomm.Contains("InstallPath"))) index = 1;
                            if ((findedcomm.Contains("RunProgram")) || (findedcomm.Contains("ExecuteFile"))
                                || (findedcomm.Contains("ExecuteParameters")) || (findedcomm.Contains("AutoInstall"))) index = 2;
                            TCommandsList.Items.Add(new ListViewItem(new[] { (TCommandsList.Items.Count + 1).ToString(CultureInfo.InvariantCulture), findedcomm, findedparam, section }, index));
                            break;
                    }
                    read.Dispose();
                }
            }
        }
        
        private void BuildFile(string path, bool notCheckSyn = true)
        {
            if (notCheckSyn)
            {
                MRUMenu.AddFile(path);
                MRUMenu.SaveToRegistry();
            }
            try
            {
                double num;
                string guiFlags = "", miscFlags = "";
                var prefs = new Params();

                var sections = new ArrayList();
                for (var i = 0; i < TCommandsList.Items.Count; i++)
                    if ((!sections.Contains(TCommandsList.Items[i].SubItems[3].Text)) && TCommandsList.Items[i].SubItems[3].Text != "Основная")
                        sections.Add(TCommandsList.Items[i].SubItems[3].Text);

                var configFile = new StreamWriter(path, false, Encoding.UTF8);
                configFile.WriteLine(";!@Install@!UTF-8!");
                for (var i = 0; i < TCommandsList.Items.Count; i++)
                {
                    if (TCommandsList.Items[i].SubItems[3].Text != "Основная") continue;
                    if (TCommandsList.Items[i].SubItems[2].Text == "-")
                    {
                        configFile.WriteLine(TCommandsList.Items[i].SubItems[1].Text + "=" + TCommandsList.Items[i].SubItems[2].Text);
                        continue;
                    }
                    configFile.WriteLine(TCommandsList.Items[i].SubItems[1].Text + "=\"" + Tools.ReplaceStrings(TCommandsList.Items[i].SubItems[2].Text, new[] { "\\", "\"" }, new[] { "\\\\", "\\\"" }, prefs.AutoReplace) + "\"");
                }
                
                for (int i = 0; i < 15; i++)
                {
                    if ((Params.Languages[i][1] != null) && (Params.Languages[i][1] != "")) configFile.WriteLine(Params.Languages[i][0] + "=\"" + Tools.ReplaceStrings(Params.Languages[i][1], new[] { "\\", "\"" }, new[] { "\\\\", "\\\"" }, prefs.AutoReplace) + "\"");
                }
                
                switch (TGUIMode.Text)
                {
                    case "(0) - обычный режим":
                        configFile.WriteLine("GUIMode=\"0\"");
                        break;
                    case "(1) - без возможности отмены распаковки":
                        configFile.WriteLine("GUIMode=\"1\"");
                        break;
                    case "(2) - невидимый режим":
                        configFile.WriteLine("GUIMode=\"2\"");
                        break;
                }

                switch (TOverWriteCombo.Text)
                {
                    case "(0) - перезаписывать все файлы":
                        configFile.WriteLine(TOverwritesysCheck.Checked 
												? "OverwriteMode=\"8\"" 
							: "OverwriteMode=\"0\"");
                        break;
                    case "(1) - не перезаписывать существующие":
                        configFile.WriteLine(TOverwritesysCheck.Checked
                                                ? "OverwriteMode=\"1+8\""
                                                : "OverwriteMode=\"1\"");
                        break;
                    case "(2) - перезаписывать только старые":
                        configFile.WriteLine(TOverwritesysCheck.Checked
                                                ? "OverwriteMode=\"2+8\""
                                                : "OverwriteMode=\"2\"");
                        break;
                    default:
                        if (TOverwritesysCheck.Checked)
                            configFile.WriteLine("OverwriteMode=\"8\"");
                        break;
                }

                if (TSelfDeleteCheck.Checked) configFile.WriteLine("SelfDelete=\"1\"");
                if (TDesignList.CheckedIndices.Count > 0) guiFlags = Math.Pow(2, TDesignList.CheckedIndices[0]).ToString(CultureInfo.InvariantCulture);
                for (var i = 1; i < TDesignList.CheckedIndices.Count; i++)
                {
                    num = Math.Pow(2, TDesignList.CheckedIndices[i]);
                    guiFlags += "+" + num.ToString(CultureInfo.InvariantCulture);
                }
                if (TMiscList.CheckedIndices.Count > 0) miscFlags = Math.Pow(2, TMiscList.CheckedIndices[0]).ToString(CultureInfo.InvariantCulture);
                for (var i = 1; i < TMiscList.CheckedIndices.Count; i++)
                {
                    num = Math.Pow(2, TMiscList.CheckedIndices[i]);
                    miscFlags += "+" + num.ToString(CultureInfo.InvariantCulture);
                }
                if (guiFlags != "") configFile.WriteLine("GUIFlags=\"" + guiFlags + "\"");
                if (miscFlags != "") configFile.WriteLine("MiscFlags=\"" + miscFlags + "\"");
                configFile.Write(";!@InstallEnd@!");

                    for (var i = 0; i < sections.Count; i++)
                    {
                        configFile.WriteLine("\r\n;!@Install@!UTF-8:" + (string)sections[i] + "!");
                        for (var j = 0; j < TCommandsList.Items.Count; j++)
                        {
                            if ((TCommandsList.Items[j].SubItems[3].Text != (string) sections[i])) continue;
                            if (TCommandsList.Items[i].SubItems[2].Text == "-")
                            {
                                configFile.WriteLine(TCommandsList.Items[i].SubItems[1].Text + "=" + TCommandsList.Items[i].SubItems[2].Text);
                                continue;
                            }
                            configFile.WriteLine(TCommandsList.Items[j].SubItems[1].Text + "=\"" + Tools.ReplaceStrings(TCommandsList.Items[j].SubItems[2].Text, new[] { "\\", "\"" }, new[] { "\\\\", "\\\"" }, prefs.AutoReplace) + "\"");
                                
                            for (int g = 2; g < Params.Languages[0].Count; g++)
                            {
                                if (CheckFoundLangString(g))
                                {
                                    var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                                    var text = reg.Replace(TTextLangsCombo.Items[g - 1].ToString(), "Language:$1");
                                    for (var f = 0; f < 15; f++)
                                    {
                                        if ((Params.Languages[f][g] == null) || (Params.Languages[f][g] == "") ||
                                            ((string) sections[i] != text)) continue;
                                        configFile.WriteLine(Params.Languages[f][0] + "=\"" + Tools.ReplaceStrings(Params.Languages[f][g], new[] { "\\", "\"" }, new[] { "\\\\", "\\\"" }, prefs.AutoReplace) + "\"");
                                        Params.Languages[f][g] = null;
                                    }
                                }
                            }
                        }
                        configFile.Write(";!@InstallEnd@:" + (string)sections[i] + "!");
                    }
                  for (var i = 2; i < Params.Languages[0].Count; i++)
                   {
                       if (!CheckFoundLangString(i)) continue;
                       var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                       var text = reg.Replace(TTextLangsCombo.Items[i - 1].ToString(), "Language:$1");
                       configFile.WriteLine(";!@Install@!UTF-8:" + text + "!");
                       for (var j = 0; j < 15; j++)
                       {
                           if ((Params.Languages[j][i] != null) && (Params.Languages[j][i] != "")) configFile.WriteLine(
                               Params.Languages[j][0] + "=\"" + Tools.ReplaceStrings(Params.Languages[j][i], new[] { "\\", "\"" },
                                                                                     new[] { "\\\\", "\\\"" }, prefs.AutoReplace) + "\"");
                       }
                       configFile.WriteLine(";!@InstallEnd@:" + text + "!\r\n");
                   }
                configFile.Close();
                configFile.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка программы. Ниже приведен текст ошибки:\n\n" + ex.Message + "\n\nТекущая операция будет завершена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FoundIn(string section, string param, int num)
        {
            var reg = new Regex(@"(?:Language:(\d{4,5}))|(x\d{2,2})");
            var founded = false;

            if ((reg.IsMatch(section)) || (section == "Основная"))
            {
                for (var i = 0; i < TTextLangsCombo.Items.Count; i++)
                {
                    if (((TTextLangsCombo.Items[i].ToString().Contains(reg.Match(section).Groups[2].Value + reg.Match(section).Groups[1].Value))
                        && (reg.Match(section).Groups[2].Value + reg.Match(section).Groups[1].Value != "")))
                    {
                        Params.Languages[num][i + 1] = Tools.ReplaceStrings(param, new[] { "\n", "\t", "\r" }, new[] { "\\n", "\\t", "" });
                        founded = true;
                        break;
                    }
                    if (section != "Основная") continue;
                    Params.Languages[num][i + 1] = Tools.ReplaceStrings(param, new[] { "\n", "\t", "\r" }, new[] { "\\n", "\\t", "" });
                    int timeOut;
                    TTitle.Text = Params.Languages[0][TTextLangsCombo.SelectedIndex + 1];
                    TBeginPromptEdit.Text = Params.Languages[1][TTextLangsCombo.SelectedIndex + 1];
                    TFinishMessageEdit.Text = Params.Languages[2][TTextLangsCombo.SelectedIndex + 1];
                    TExtractTitle.Text = Params.Languages[3][TTextLangsCombo.SelectedIndex + 1];
                    TExtractPathTitle.Text = Params.Languages[4][TTextLangsCombo.SelectedIndex + 1];
                    TExtractPathText.Text = Params.Languages[5][TTextLangsCombo.SelectedIndex + 1];
                    TExtractDialogText.Text = Params.Languages[6][TTextLangsCombo.SelectedIndex + 1];
                    TErrorTitle.Text = Params.Languages[7][TTextLangsCombo.SelectedIndex + 1];
                    TExtractCancelText.Text = Params.Languages[8][TTextLangsCombo.SelectedIndex + 1];
                    TCancelPromptText.Text = Params.Languages[9][TTextLangsCombo.SelectedIndex + 1];
                    THelpTextEdit.Text = Params.Languages[10][TTextLangsCombo.SelectedIndex + 1];
                    TWarningTitleEdit.Text = Params.Languages[11][TTextLangsCombo.SelectedIndex + 1];
                    TPasswordTitleEdit.Text = Params.Languages[12][TTextLangsCombo.SelectedIndex + 1];
                    TPasswordText.Text = Params.Languages[13][TTextLangsCombo.SelectedIndex + 1];
                    if ((Params.Languages[14][TTextLangsCombo.SelectedIndex + 1] == null) || (Params.Languages[14][TTextLangsCombo.SelectedIndex + 1] == ""))
                        timeOut = 0;
                    else
                        timeOut = int.Parse(Params.Languages[14][TTextLangsCombo.SelectedIndex + 1]);
                    TBeginPromptTimeOut.Value = timeOut;
                    founded = true;
                    break;
                }
            }
            if (founded) return;
            for (var j = 0; j < (Params.LangList.Length / 2); j++)
            {
                if ((reg.Match(section).Groups[1].Value != Params.LangList[j, 1])) continue;
                TTextLangsCombo.Items.Add(Params.LangList[j, 0] + " - " + Params.LangList[j, 1]);
                for (var k = 0; k < 15; k++)
                {
                    if (k == num)
                    {
                        Params.Languages[num].Add(Tools.ReplaceStrings(param, new[] { "\n", "\t" }, new[] { "\\n", "\\t" }));
                        continue;
                    }
                    Params.Languages[k].Add(null);   
                }
                break;
            }
        }

        private static bool CheckFoundLangString(int index)
        {
	        for (var i = 0; i < 15; i++)
	        {
                if ((Params.Languages[i][index] != null) && (Params.Languages[i][index] != ""))
                    return true;   
            }
        
            return false;
        }

        private void OpenEditForm(TextBox strToEdit)
        {
            var edit = new EditForm
                           {
                               TextEdit =
                                   Tools.ReplaceStrings(strToEdit.Text, new[] {"\\\\", "\\\"", "\\n", "\\t"},
                                                        new[] {"\\", "\"", "\r\n", "\t"})
                           };
            if (edit.ShowDialog() == DialogResult.OK)
            {
                strToEdit.Text = Tools.ReplaceStrings(edit.TextEdit, new[] { "\\", "\"", "\n", "\t", "\r" }, new[] { "\\\\", "\\\"", "\\n", "\\t", "" });
                SetStateSaveButton(true);
                
            }
            edit.Dispose();
        }

        private void SetGuiFlags(string input)
        {
            var guiFlags = input.Split('+');
            foreach (var guiflag in guiFlags)
            {

                if (Regex.IsMatch(guiflag, @"\s*\d+\s*"))
                {
                    var flag = Math.Log(double.Parse(guiflag.Trim()), 2);
                    if (flag.ToString(CultureInfo.InvariantCulture).Contains(",") || flag > 16385)
                        MessageBox.Show(this, "Элемент " + guiflag + " будет пропущен.", "Неверное значение.");
                    else
                        TDesignList.SetItemChecked(Convert.ToInt32(flag), true);
                }
                else
                    MessageBox.Show(this, "Элемент " + guiflag + " будет пропущен.", "Не соответствие шаблону.");
            }
        }

        private void SetOverwriteMode(string input)
        {
            var overwrite = input.Split('+');
            if ((overwrite.Length > 1) || (overwrite[0] == "8")) TOverwritesysCheck.Checked = true;
            for (var i = 0; i < TOverWriteCombo.Items.Count; i++)
            {
                if (TOverWriteCombo.Items[i].ToString().Contains(overwrite[0])) TOverWriteCombo.SelectedIndex = i;
            }
        }

        private void SetGUIMode(string input)
        {
            var guimode = input;

            for (var i = 0; i < TGUIMode.Items.Count; i++)
            {
                if (TGUIMode.Items[i].ToString().Contains(guimode)) TGUIMode.SelectedIndex = i;
            }
        }

        private void SetMiscFlags(string input)
        {
            string[] miscFlags = input.Split('+');
            foreach (string miscflag in miscFlags)
            {
                if (Regex.IsMatch(miscflag, @"\s*\d+\s*"))
                {
                    var flag = Math.Log(double.Parse(miscflag.Trim()), 2);
                    if (flag.ToString(CultureInfo.InvariantCulture).Contains(",") || flag > 9)
                        MessageBox.Show(this, "Элемент " + miscflag + " будет пропущен.", "Неверное значение.");
                    else
                        TMiscList.SetItemChecked(Convert.ToInt32(flag), true);
                }
                else
                    MessageBox.Show(this, "Элемент " + miscflag + " будет пропущен.", "Не соответствие шаблону.");
            }
        }

        private bool CheckInListCombo(string input)
        {
            for (int j = 0; j < (Params.LangList.Length / 2); j++)
            {
                for (int k = 0; k < TTextLangsCombo.Items.Count; k++)
                    if (TTextLangsCombo.Items[k].ToString().Contains(input))
                        return true;
            }
            return false;
        }

        private void AddLangInCombos(string lang)
        {
            for (var j = 0; j < (Params.LangList.Length / 2); j++)
            {
                if (lang != Params.LangList[j, 1]) continue;
                TListLangCombo.Items.Add(Params.LangList[j, 0] + " - " + Params.LangList[j, 1]);
                TTextLangsCombo.Items.Add(Params.LangList[j, 0] + " - " + Params.LangList[j, 1]);
                for (var k = 0; k < 15; k++)
                    Params.Languages[k].Add(null);
            }
        }

        private void LoadLangsArray(int count)
        {
            for (var i = 0; i < 15; i++)
            {
                var temp = new List<string>();
                Params.Languages.Add(temp);
                for (var j = 0; j < count; j++)
                    temp.Add(null);
            }

            Params.Languages[0][0] = "Title";
            Params.Languages[1][0] = "BeginPrompt";
            Params.Languages[2][0] = "FinishMessage";
            Params.Languages[3][0] = "ExtractTitle";
            Params.Languages[4][0] = "ExtractPathTitle";
            Params.Languages[5][0] = "ExtractPathText";
            Params.Languages[6][0] = "ExtractDialogText";
            Params.Languages[7][0] = "ErrorTitle";
            Params.Languages[8][0] = "ExtractCancelText";
            Params.Languages[9][0] = "CancelPrompt";
            Params.Languages[10][0] = "HelpText";
            Params.Languages[11][0] = "WarningTitle";
            Params.Languages[12][0] = "PasswordTitle";
            Params.Languages[13][0] = "PasswordText";
            Params.Languages[14][0] = "BeginPromptTimeout";
        }

        private void SetStateSaveButton(bool state)
        {
            TSaveFile_Menu.Enabled = state;
            TSaveToolButton.Enabled = state;
        }

        #endregion

        #region List Commands & Buttons

        private void ComDeleteClick(object sender, EventArgs e)
        {
	        SFX.Delete(TCommandsList);
            _index = -1;
        }

        private void ComAddBtClick(object sender, EventArgs e)
        {
            var commandsWin = new SelectCom();
            if (commandsWin.ShowDialog() != DialogResult.OK) return;
            foreach (ListViewItem item in commandsWin.ItemList)
            {
                var newItem = new ListViewItem(new[] { (TCommandsList.Items.Count + 1).ToString(CultureInfo.InvariantCulture), item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text }, item.ImageIndex);
                TCommandsList.Items.Add(newItem);
                SetStateSaveButton(true);
            }
        }

        private void CommandsListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCommandsList.SelectedItems.Count <= 0) return;
            _index = TCommandsList.SelectedItems[0].Index;
            string comm = TCommandsList.SelectedItems[0].SubItems[1].Text , liter = "";
            if (comm.Contains("AutoInstall") || comm.Contains("Delete") || comm.Contains("Shortcut"))
            {
                liter = comm.Replace("AutoInstall", "");
                liter = liter.Replace("Delete", "");
                liter = liter.Replace("Shortcut", "");

            }
            else
                TModifText.Text = "";

            TCommText.Text = liter != "" ? comm.Replace(liter, "") : comm;
               
            TModifText.Text = liter;
            TParamText.Text = TCommandsList.SelectedItems[0].SubItems[2].Text;
            var matchReg = new Regex(@"(?<arch>x\d{2})?(:?Language:(?<lang>\d{4}))?");

            var arch = matchReg.Match(TCommandsList.SelectedItems[0].SubItems[3].Text).Groups["arch"].ToString();
            var lang = matchReg.Match(TCommandsList.SelectedItems[0].SubItems[3].Text).Groups["lang"].ToString();

            if (arch != "")
            {
                switch (arch)
                {
                    case "x86":
                        TListx86Arch.Checked = true;
                        break;
                    case "x64":
                        TListx64Arch.Checked = true;
                        break;
                }
            }
            else
                TListNoArch.Checked = true;


            if (lang != "")
            {
                for (var j = 0; j < TListLangCombo.Items.Count; j++)
                {
                    if (TListLangCombo.Items[j].ToString().Contains(lang))
                    {
                        TListLangCombo.Text = TListLangCombo.Items[j].ToString();
                    }
                }
            }
            else
                TListLangCombo.Text = "Отсутствует";
        }

        private void CommTextTextChanged(object sender, EventArgs e)
        {
            if (_index == -1) return;
            TCommandsList.Items[_index].SubItems[1].Text = TCommText.Text + TModifText.Text;
            SetStateSaveButton(true);
        }

        private void ParamTextTextChanged(object sender, EventArgs e)
        {
            if (_index == -1) return;
            TCommandsList.Items[_index].SubItems[2].Text = TParamText.Text;
            SetStateSaveButton(true);
        }

        private void ListNoArchClick(object sender, EventArgs e)
        {
            if (_index == -1) return;
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                var temp = reg.Replace(TListLangCombo.Text, "$1");
                TCommandsList.SelectedItems[0].SubItems[3].Text = "Language:" + temp;
            }
            else
                TCommandsList.SelectedItems[0].SubItems[3].Text = "Основная";
            SetStateSaveButton(true);
        }

        private void Listx86ArchClick(object sender, EventArgs e)
        {
            if (_index == -1) return;
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                var temp = reg.Replace(TListLangCombo.Text, "$1");
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x86:Language:" + temp;
            }
            else
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x86";
            SetStateSaveButton(true);
        }

        private void Listx64ArchClick(object sender, EventArgs e)
        {
            if (_index == -1) return;
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                var temp = reg.Replace(TListLangCombo.Text, "$1");
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x64:Language:" + temp;
            }
            else
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x64";
            SetStateSaveButton(true);
        }

        private void ListUpClick(object sender, EventArgs e)
        {
            SFX.ListUp(TCommandsList);
            SetStateSaveButton(true);
        }

        private void TlistDownClick(object sender, EventArgs e)
        {
            SFX.ListDown(TCommandsList);
            SetStateSaveButton(true);
        }

        private void DoublicateListClick(object sender, EventArgs e)
        {
			SFX.Duplicate(ref TCommandsList);
			SetStateSaveButton(true);
        }

        private void DeleteListClick(object sender, EventArgs e)
        {
			_index = SFX.Delete(TCommandsList);
			SetStateSaveButton(true);
        }

        private void ListLangComboSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_index == -1) return;
            var section = "";

            if (TListx86Arch.Checked) section += ":x86";
            if (TListx64Arch.Checked) section += ":x64";
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                var temp = reg.Replace(TListLangCombo.Text, "$1");
                section += ":Language:" + temp;
            }

            section = section != "" ? section.Remove(0, 1) : "Основная";

            TCommandsList.SelectedItems[0].SubItems[3].Text = section;
            SetStateSaveButton(true);
        }

        private void ModifTextKeyPress(object sender, KeyPressEventArgs e)
        {
	        SFX.AntiModification(sender, e);
        }

        private void ModifTextTextChanged(object sender, EventArgs e)
        {
            if ((_index == -1) ||
                ((TCommText.Text != "AutoInstall") && (TCommText.Text != "Delete") && (TCommText.Text != "Shortcut")))
                return;
            TCommandsList.Items[_index].SubItems[1].Text = TCommText.Text + TModifText.Text;
            SetStateSaveButton(true);
        }

        #endregion

        #region TextEditing

        private void TitleTextChanged(object sender, EventArgs e)
        {
            Params.Languages[0][TTextLangsCombo.SelectedIndex + 1] = TTitle.Text;
            SetStateSaveButton(true);
        }

        private void BeginPromptEditTextChanged(object sender, EventArgs e)
        {
            Params.Languages[1][TTextLangsCombo.SelectedIndex + 1] = TBeginPromptEdit.Text;
            SetStateSaveButton(true);
        }

        private void FinishMessageEditTextChanged(object sender, EventArgs e)
        {
            Params.Languages[2][TTextLangsCombo.SelectedIndex + 1] = TFinishMessageEdit.Text;
            SetStateSaveButton(true);
        }

        private void ExtractTitleTextChanged(object sender, EventArgs e)
        {
            Params.Languages[3][TTextLangsCombo.SelectedIndex + 1] = TExtractTitle.Text;
            SetStateSaveButton(true);
        }

        private void ExtractPathTitleTextChanged(object sender, EventArgs e)
        {
            Params.Languages[4][TTextLangsCombo.SelectedIndex + 1] = TExtractPathTitle.Text;
            SetStateSaveButton(true);
        }

        private void ExtractPathTextTextChanged(object sender, EventArgs e)
        {
            Params.Languages[5][TTextLangsCombo.SelectedIndex + 1] = TExtractPathText.Text;
            SetStateSaveButton(true);
        }

        private void ExtractDialogTextTextChanged(object sender, EventArgs e)
        {
            Params.Languages[6][TTextLangsCombo.SelectedIndex + 1] = TExtractDialogText.Text;
            SetStateSaveButton(true);
        }

        private void ErrorTitleTextChanged(object sender, EventArgs e)
        {
            Params.Languages[7][TTextLangsCombo.SelectedIndex + 1] = TErrorTitle.Text;
            SetStateSaveButton(true);
        }

        private void ExtractCancelTextTextChanged(object sender, EventArgs e)
        {
            Params.Languages[8][TTextLangsCombo.SelectedIndex + 1] = TExtractCancelText.Text;
            SetStateSaveButton(true);
        }

        private void CancelPromptTextTextChanged(object sender, EventArgs e)
        {
            Params.Languages[9][TTextLangsCombo.SelectedIndex + 1] = TCancelPromptText.Text;
            SetStateSaveButton(true);
        }

        private void HelpTextEditTextChanged(object sender, EventArgs e)
        {
            Params.Languages[10][TTextLangsCombo.SelectedIndex + 1] = THelpTextEdit.Text;
            SetStateSaveButton(true);
        }

        private void WarningTitleEditTextChanged(object sender, EventArgs e)
        {
            Params.Languages[11][TTextLangsCombo.SelectedIndex + 1] = TWarningTitleEdit.Text;
            SetStateSaveButton(true);
        }

        private void PasswordTitleEditTextChanged(object sender, EventArgs e)
        {
            Params.Languages[12][TTextLangsCombo.SelectedIndex + 1] = TPasswordTitleEdit.Text;
            SetStateSaveButton(true);
        }

        private void PasswordTextTextChanged(object sender, EventArgs e)
        {
            Params.Languages[13][TTextLangsCombo.SelectedIndex + 1] = TPasswordText.Text;
            SetStateSaveButton(true);
        }

        private void BeginPromptTimeOutValueChanged(object sender, EventArgs e)
        {
            Params.Languages[14][TTextLangsCombo.SelectedIndex + 1] = TBeginPromptTimeOut.Value.ToString(CultureInfo.InvariantCulture);
            SetStateSaveButton(true);
        }

        private void TextLangsComboSelectedIndexChanged(object sender, EventArgs e)
        {
            int timeOut;
            TTitle.Text = Params.Languages[0][TTextLangsCombo.SelectedIndex + 1];
            TBeginPromptEdit.Text = Params.Languages[1][TTextLangsCombo.SelectedIndex + 1];
            TFinishMessageEdit.Text = Params.Languages[2][TTextLangsCombo.SelectedIndex + 1];
            TExtractTitle.Text = Params.Languages[3][TTextLangsCombo.SelectedIndex + 1];
            TExtractPathTitle.Text = Params.Languages[4][TTextLangsCombo.SelectedIndex + 1];
            TExtractPathText.Text = Params.Languages[5][TTextLangsCombo.SelectedIndex + 1];
            TExtractDialogText.Text = Params.Languages[6][TTextLangsCombo.SelectedIndex + 1];
            TErrorTitle.Text = Params.Languages[7][TTextLangsCombo.SelectedIndex + 1];
            TExtractCancelText.Text = Params.Languages[8][TTextLangsCombo.SelectedIndex + 1];
            TCancelPromptText.Text = Params.Languages[9][TTextLangsCombo.SelectedIndex + 1];
            THelpTextEdit.Text = Params.Languages[10][TTextLangsCombo.SelectedIndex + 1];
            TWarningTitleEdit.Text = Params.Languages[11][TTextLangsCombo.SelectedIndex + 1];
            TPasswordTitleEdit.Text = Params.Languages[12][TTextLangsCombo.SelectedIndex + 1];
            TPasswordText.Text = Params.Languages[13][TTextLangsCombo.SelectedIndex + 1];
            if ((Params.Languages[14][TTextLangsCombo.SelectedIndex + 1] == null) || (Params.Languages[14][TTextLangsCombo.SelectedIndex + 1] == "")) 
                timeOut = 0;
            else
                timeOut = int.Parse(Params.Languages[14][TTextLangsCombo.SelectedIndex + 1]);
            TBeginPromptTimeOut.Value = timeOut;
        }

        private void BeginPromptBtClick(object sender, EventArgs e)
        {
            OpenEditForm(TBeginPromptEdit);
        }

        private void FinishMessageBtClick(object sender, EventArgs e)
        {
            OpenEditForm(TFinishMessageEdit);
        }

        private void ExtractPathTextBtClick(object sender, EventArgs e)
        {
            OpenEditForm(TExtractPathText);
        }

        private void ExtractDialogBtClick(object sender, EventArgs e)
        {
            OpenEditForm(TExtractDialogText);
        }

        private void CancelPromptBtClick(object sender, EventArgs e)
        {
            OpenEditForm(TCancelPromptText);
        }

        private void HelpTextBtClick(object sender, EventArgs e)
        {
            OpenEditForm(THelpTextEdit);
        }

        #endregion

        #region ToolButtons & Menu

        private void ClearMRU_Click(object sender, EventArgs e)
        {
            MRUMenu.RemoveAll();
            MRUMenu.SaveToRegistry();
        }
        
        private void CheckButtonClick(object sender, EventArgs e)
        {
            var tempFile = Path.Combine(Path.GetTempPath(), "conf.txt");
            BuildFile(tempFile, false);

            TStateLabel.Text = Tools.Execute(Path.Combine(Application.StartupPath, "7zsd.sfx"), "-sfxtest:cc -sfxconfig:\"" + tempFile + "\"", true) == 0 ? "Синтаксис файла верен." : "Произошла ошибка.";

            File.Delete(tempFile);
        }
       
        private void ToolStripButton1Click(object sender, EventArgs e)
        {
            BuildFile(Path.Combine(Application.StartupPath, "test.txt"));
            Tools.Execute(Path.Combine(Application.StartupPath, "test.bat"), Path.Combine(Application.StartupPath, "test.txt"));
        }
        
        private void NewFileMenuClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы уверены, что хотите создать новый файл?\nВсе изменения будут утеряны.", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearForm();
                SetGUIMode(Params.MainIniFile.GetString("General", "GUIMode", "1"));
                SetOverwriteMode(Params.MainIniFile.GetString("General", "OverwriteMode", "Нет"));
				SFX.SetFlags(Params.MainIniFile.GetString("General", "MiscFlags", "4"), ref TMiscList, 9);
				SFX.SetFlags(Params.MainIniFile.GetString("General", "GUIFlags", "2+4+8+16+32+2048+4096"), ref TDesignList, 16385);
            }
        }

        private void OpenFileMenuClick(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                ClearForm();
                OpeningFile(OpenFile.FileName);
                SetStateSaveButton(false);
                Params.SavedPath = OpenFile.FileName;
            }
        }

        private void SaveFileMenuClick(object sender, EventArgs e)
        {
            if (Params.SavedPath == "")
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Params.SavedPath = SaveFile.FileName;
                    BuildFile(Params.SavedPath);
                    SetStateSaveButton(false);
                }
            }
            else
            {
                BuildFile(Params.SavedPath);
                SetStateSaveButton(false);
            }
        }

        private void SaveFileAsMenuClick(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                Params.SavedPath = SaveFile.FileName;
                BuildFile(Params.SavedPath);
                SetStateSaveButton(false);
            }
        } 

        private void CloseMenuClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PreferenceMenuClick(object sender, EventArgs e)
        {
            var optionsWin = new OptForm();
            optionsWin.ShowDialog();
        }

        private void HelpMenuClick(object sender, EventArgs e)
        {
            Tools.Execute(Path.Combine(Application.StartupPath, "7zSD_RU.chm"));
        }

        private void SiteModuleMenuClick(object sender, EventArgs e)
        {
            Tools.Execute("http://7zsfx.info/ru/");
        }

        private void SiteProgrammMenuClick(object sender, EventArgs e)
        {
            Tools.Execute("http://mediclab.org/files/more/project-sfx-config-gui-dlja-sozdanija-konfiguracij-modificirovannogo-modulja-7zip.html");
        }

        private void AboutMenuClick(object sender, EventArgs e)
        {
            var aboutWin = new AboutForm();
            aboutWin.ShowDialog();
        }

        #endregion

        #region Changing State

        private void DesignListMouseClick(object sender, MouseEventArgs e)
        {
            SetStateSaveButton(true);
        }

        private void MiscListMouseClick(object sender, MouseEventArgs e)
        {
            SetStateSaveButton(true);
        }

        private void SelfDeleteCheckCheckedChanged(object sender, EventArgs e)
        {
            SetStateSaveButton(true);
        }

        private void OverwritesysCheckCheckedChanged(object sender, EventArgs e)
        {
            SetStateSaveButton(true);
        }

        private void TguiModeTextChanged(object sender, EventArgs e)
        {
            SetStateSaveButton(true);
        }

        private void OverWriteComboTextChanged(object sender, EventArgs e)
        {
            SetStateSaveButton(true);
        }

        #endregion

        #region Form Events

        private void MainFormLoad(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "7zsd.sfx")))
            {
                MessageBox.Show(this, "модифицированный модуль 7zsd.sfx отсутствует.\nФункция проверки синтаксиса будет отключена.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TCheckButton.Enabled = false;
            }

            var langs = Params.MainIniFile.GetString("General", "Languages", "1049;1058;1059;1033").Split(';');

            LoadLangsArray(langs.Length);

            for (var i = 0; i < langs.Length; i++)
                AddLangInCombos(langs[i]);


            TListLangCombo.Text = "Отсутствует";
            TTextLangsCombo.Text = "Основная";
            
            SetGUIMode(Params.MainIniFile.GetString("General", "GUIMode", "1"));
            SetOverwriteMode(Params.MainIniFile.GetString("General", "OverwriteMode", "Нет"));
			SFX.SetFlags(Params.MainIniFile.GetString("General", "MiscFlags", "4"), ref TMiscList, 9);
			SFX.SetFlags(Params.MainIniFile.GetString("General", "GUIFlags", "2+4+8+16+32+2048+4096"), ref TDesignList, 16385);
            SetStateSaveButton(false);

            ToolTiper.SetToolTip(TBeginPromptTimeOut,
                "*   1...999 - обратный отсчет времени на кнопке \"Да\" (\"OK\")\n" 
                + "* - 1...-999 - обратный отсчет времени на кнопке \"Нет\" (\"Отмена\")\n"
                + "*   0 - игнорируется\n"
                + "По истечении времени кнопки автоматически нажимаются.");

            ToolTiper.SetToolTip(label16,
                "*   1...999 - обратный отсчет времени на кнопке \"Да\" (\"OK\")\n"
                + "* - 1...-999 - обратный отсчет времени на кнопке \"Нет\" (\"Отмена\")\n"
                + "*   0 - игнорируется\n"
                + "По истечении времени кнопки автоматически нажимаются.");
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TSaveToolButton.Enabled) return;
            if (MessageBox.Show(this, "Вы уверены, что хотите создать выйти?\nВсе изменения будут утеряны.", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
