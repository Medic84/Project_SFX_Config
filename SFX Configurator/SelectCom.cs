using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_SFX_Config
{
    public partial class SelectCom : Form
    {
        private TextBox _tempBox;
        private int _index = -1;

        public ListView.ListViewItemCollection ItemList
        {
            get { return TCommandsList.Items; }
        }

        public SelectCom()
        {
            InitializeComponent();
		}

        #region RightButtonPanel
        
        private void TContextCopy_Click(object sender, EventArgs e)
        {
            _tempBox.Copy();
        }

        private void TContextCut_Click(object sender, EventArgs e)
        {
            _tempBox.Cut();
        }

        private void TContextPaste_Click(object sender, EventArgs e)
        {
            _tempBox.Paste();
        }

        private void TInsM_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%%M");
        }

        private void TInsP_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%%P");
        }

        private void TInsS_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%%S");
        }

        private void TInsT_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%%T");
        }

        private void TInsProgFiles_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%ProgramFiles%");
        }

        private void TInsSysDrv_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%SystemDrive%");
        }

        private void TInsComDesc_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%CommonDesktop%");
        }

        private void TInsComDoc_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%CommonDocuments%");
        }

        private void TInsMyDoc_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%MyDocuments%");
        }

        private void TInsUserDesc_Click(object sender, EventArgs e)
        {
            _tempBox.Paste("%UserDesktop%");
        }

        private void TContextMenu_Opening(object sender, CancelEventArgs e)
        {
            _tempBox = (TextBox)TContextMenu.SourceControl;
        }

        #endregion

        private void TPrpefixExecuteFileBt_Click(object sender, EventArgs e)
        {
            var prefixWin = new SelectPrefix {Prefix = TPrpefixExecuteFile.Text};
            if (prefixWin.ShowDialog() == DialogResult.OK)
                TPrpefixExecuteFile.Text = prefixWin.Prefix;
        }

        private void TPrpefixRunProgramBt_Click(object sender, EventArgs e)
        {
            var prefixWin = new SelectPrefix {Prefix = TPrpefixRunProgram.Text};
            if (prefixWin.ShowDialog() == DialogResult.OK)
                TPrpefixRunProgram.Text = prefixWin.Prefix;
        }

        private void TPrpefixAutoInstallBt_Click(object sender, EventArgs e)
        {
            var prefixWin = new SelectPrefix {Prefix = TPrpefixAutoInstall.Text};
            if (prefixWin.ShowDialog() == DialogResult.OK)
                TPrpefixAutoInstall.Text = prefixWin.Prefix;
        }

        private void TAddExecuteFile_Click(object sender, EventArgs e)
        {
            if (TExecuteEdit.Text == "") 
            {
                MessageBox.Show(this, "Поле \"Файл\" не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddItemToList("ExecuteFile", TPrpefixExecuteFile.Text + TExecuteEdit.Text, 2);

            if (TExecuteParamEdit.Text != "")
                AddItemToList("ExecuteParameters", TExecuteParamEdit.Text, 2);
        }

        private void TAddRunProgram_Click(object sender, EventArgs e)
        {
            if (TRunProg.Text == "")
            {
                MessageBox.Show(this, "Поле \"Файл\" не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddItemToList("RunProgram", TPrpefixRunProgram.Text + TRunProg.Text, 2);
        }

        private void TAddAutoInstall_Click(object sender, EventArgs e)
        {
            if (TAutoInstEdit.Text == "")
            {
                MessageBox.Show(this, "Поле \"Файл\" не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddItemToList("AutoInstall" + TAutoInsModtEdit.Text, TPrpefixAutoInstall.Text + TAutoInstEdit.Text, 2);
        }

        private void TAddDelete_Click(object sender, EventArgs e)
        {
            if (TDeleteFileName.Text == "")
            {
                MessageBox.Show(this, "Поле \"Путь до объекта\" не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddItemToList("Delete" + TDeleteModifer.Text, TDeleteFileName.Text, 3);
        }

        private void TAddShortcut_Click(object sender, EventArgs e)
        {
            var type = "";

            if (TScorRadioDesctop.Checked)
            {
                type = "D";
                if (TScorRadioUser.Checked) type += "u";
            }
            if (TScorRadioStart.Checked)
            {
                type = "S";
                if (TScorRadioUser.Checked) type += "u";
            }
            if (TScorRadioAllProg.Checked)
            {
                type = "P";
                if (TScorRadioUser.Checked) type += "u";
            }
            if (TScorRadioStartup.Checked)
            {
                type = "T";
                if (TScorRadioUser.Checked) type += "u";
            }
            if (TScorRadioOther.Checked) type = TScorUpDownOther.Value.ToString(CultureInfo.InvariantCulture);
            
            var command = type + ",{" + TScorFileName.Text + "},{" + TScorArgs.Text + "},{" + TScorFolder.Text + "},{" + TScorDescr.Text + "},{" + TScorName.Text + "},{" + TScorWorkingDir.Text + "},{" + TScorIcon.Text + "},{" + TScorIconIndex.Value + "}";

            AddItemToList("Shortcut" + TModiferShorcBox.Text, command, 0);
        }

        private void TAddEnviroment_Click(object sender, EventArgs e)
        {
            if (TEnvName.Text == "")
            {
                MessageBox.Show(this, "Поле \"Имя\" не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TEnvParameter.Text == "")
            {
                MessageBox.Show(this, "Поле \"Значение\" не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddItemToList("SetEnvironment", TEnvName.Text + "=" + TEnvParameter.Text, 1);
        }

        private void TAddInstallPath_Click(object sender, EventArgs e)
        {
            AddItemToList("InstallPath", TInstallPathBox.Text, 1);
        }

        private void AddItemToList(string commname, string command, int @in)
        {
            var section = "";

            if (Tx86SectRadio.Checked) section += ":x86";
            if (Tx64SectRadio.Checked) section += ":x64";
            if (TLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                string temp = reg.Replace(TLangCombo.Text,"$1");
                section += ":Language:" + temp;
            }
            section = section != "" ? section.Remove(0, 1) : "Основная";

            var newItem = new ListViewItem(new[] { (TCommandsList.Items.Count + 1).ToString(CultureInfo.InvariantCulture), commname, command, section }, @in);
            TCommandsList.Items.Add(newItem);

            TItemsCount.Text = TCommandsList.Items.Count.ToString(CultureInfo.InvariantCulture) + " элементов";
        }

        private void TCommandsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (TCommandsList.SelectedItems.Count > 0)
            {
                _index = TCommandsList.SelectedItems[0].Index;
                TModifText.Text = "";
                string comm = TCommandsList.SelectedItems[0].SubItems[1].Text, liter = "";
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
                    if (arch == "x86") TListx86Arch.Checked = true;
                    if (arch == "x64") TListx64Arch.Checked = true;
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
        }

        private void TCommText_TextChanged(object sender, EventArgs e)
        {
            if (_index != -1) TCommandsList.Items[_index].SubItems[1].Text = TCommText.Text + TModifText.Text;
        }

        private void TParamText_TextChanged(object sender, EventArgs e)
        {
            if (_index != -1) TCommandsList.Items[_index].SubItems[2].Text = TParamText.Text;
        }

        private void TListNoArch_Click(object sender, EventArgs e)
        {
            if (_index == -1) return;
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                string temp = reg.Replace(TListLangCombo.Text, "$1");
                TCommandsList.SelectedItems[0].SubItems[3].Text = "Language:" + temp;
            }   
            else
                TCommandsList.SelectedItems[0].SubItems[3].Text = "Основная";
        }

        private void TListx86Arch_Click(object sender, EventArgs e)
        {
            if (_index == -1) return;
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                string temp = reg.Replace(TListLangCombo.Text, "$1");
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x86:Language:" + temp;
            }
            else
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x86";
        }

        private void TListx64Arch_Click(object sender, EventArgs e)
        {
            if (_index == -1) return;
            if (TListLangCombo.Text != "Отсутствует")
            {
                var reg = new Regex(@"[\w\(\)\s]+\s*-\s*(\d{4,5})");
                string temp = reg.Replace(TListLangCombo.Text, "$1");
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x64:Language:" + temp;
            }  
            else
                TCommandsList.SelectedItems[0].SubItems[3].Text = "x64";
        }

        private void вверхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFX.ListUp(TCommandsList);
            TCommandsList.SelectedItems.Clear();
        }

        private void внизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFX.ListDown(TCommandsList);
            TCommandsList.SelectedItems.Clear();
        }

        private void дублироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFX.Duplicate(ref TCommandsList);
            TItemsCount.Text = TCommandsList.Items.Count.ToString(CultureInfo.InvariantCulture) + " элементов";
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
	        SFX.Delete(TCommandsList);
            _index = -1;
			TItemsCount.Text = TCommandsList.Items.Count.ToString(CultureInfo.InvariantCulture) + " элементов";
        }

        private void SelectCom_Load(object sender, EventArgs e)
        {
            var langs = Params.MainIniFile.GetString("General", "Languages", "1049;1058;1059;1033").Split(';');
            for (var i = 0; i < langs.Length; i++)
            {
                for (var j = 0; j < (Params.LangList.Length / 2); j++)
                {
                    if (langs[i] != Params.LangList[j, 1]) continue;
                    TListLangCombo.Items.Add(Params.LangList[j, 0] + " - " + Params.LangList[j, 1]);
                    TLangCombo.Items.Add(Params.LangList[j, 0] + " - " + Params.LangList[j, 1]);
                }
            }
            TListLangCombo.Text = "Отсутствует";
            TLangCombo.Text = "Отсутствует";
        }

        private void TListLangCombo_SelectionChangeCommitted(object sender, EventArgs e)
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
        }

        private void TModifText_TextChanged(object sender, EventArgs e)
        {
            if ((_index != -1) && ((TCommText.Text == "AutoInstall") || (TCommText.Text == "Delete") || (TCommText.Text == "Shortcut")))
            {
                TCommandsList.Items[_index].SubItems[1].Text = TCommText.Text + TModifText.Text;
            }
        }

		private void KeyPressing(object sender, KeyPressEventArgs e)
		{
			SFX.AntiModification(sender, e);
		}
    }
}
