using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_SFX_Config
{
	static class SFX
	{
		static public void ListUp(object sender)
		{
			var list = sender as ListView;
			if (list != null)
				ListUpDown(list);
		}

		static public void ListDown(object sender)
		{
			var list = sender as ListView;
			if (list != null)
				ListUpDown(list, -1);
		}

		private static void ListUpDown(ListView list, int updown = 1)
		{
			int count = list.Items.Count - 1;
			for (var i = 0; i < list.SelectedItems.Count; i++)
			{
				if (list.SelectedItems[i].Index == count) continue;
				var index = list.SelectedItems[i].ImageIndex;
				var command = list.SelectedItems[i].SubItems[1].Text;
				var parameter = list.SelectedItems[i].SubItems[2].Text;
				var section = list.SelectedItems[i].SubItems[3].Text;

				list.SelectedItems[i].ImageIndex = list.Items[list.SelectedItems[i].Index + updown].ImageIndex;
				list.SelectedItems[i].SubItems[1].Text = list.Items[list.SelectedItems[i].Index + updown].SubItems[1].Text;
				list.SelectedItems[i].SubItems[2].Text = list.Items[list.SelectedItems[i].Index + updown].SubItems[2].Text;
				list.SelectedItems[i].SubItems[3].Text = list.Items[list.SelectedItems[i].Index + updown].SubItems[3].Text;
				list.Items[list.SelectedItems[i].Index + updown].ImageIndex = index;
				list.Items[list.SelectedItems[i].Index + updown].SubItems[1].Text = command;
				list.Items[list.SelectedItems[i].Index + updown].SubItems[2].Text = parameter;
				list.Items[list.SelectedItems[i].Index + updown].SubItems[3].Text = section;
			}
			list.SelectedItems.Clear();
		}

		static public void Duplicate(ref ListView list)
		{
			if (list != null)
			{
				foreach (ListViewItem item in list.SelectedItems)
				{
					var newItem =
						new ListViewItem(
							new[]
								{
									(list.Items.Count + 1).ToString(CultureInfo.InvariantCulture), item.SubItems[1].Text,
									item.SubItems[2].Text, item.SubItems[3].Text
								}, item.ImageIndex);
					list.Items.Add(newItem);

				}
			}
		}

		static public int Delete(object sender)
		{
			var list = sender as ListView;
			if (list != null)
			{
				foreach (ListViewItem item in list.SelectedItems)
					list.Items.Remove(item);
				for (int i = 0; i < list.Items.Count; i++)
					list.Items[i].SubItems[0].Text = (i + 1).ToString(CultureInfo.InvariantCulture);
				return -1;
			}
			return 0;
		}
	
		static public void ClearText(params object[] sender)
		{
			foreach (TextBox o in sender)
				o.Text = "";
		}

		static public void AntiModification(object sender,KeyPressEventArgs e)
		{
			var regex = new Regex("[0-9a-zA-Z]");
			if (regex.Matches(Convert.ToChar(e.KeyChar).ToString(CultureInfo.InvariantCulture)).Count != 1)
				if (e.KeyChar != '\b') e.Handled = true;
		}

		static public MatchCollection GetMatches(string text, string pattern, RegexOptions options = RegexOptions.Singleline)
		{
			var sections = new Regex(pattern, options);
			var sectionsMatches = sections.Matches(text);
			return sectionsMatches;
		}

		static  public void SetFlags(string input, ref CheckedListBox list, int max)
		{
			var guiFlags = input.Split('+');
			foreach (var guiflag in guiFlags)
			{

				if (Regex.IsMatch(guiflag, @"\s*\d+\s*"))
				{
					var flag = Math.Log(double.Parse(guiflag.Trim()), 2);
					if (flag.ToString(CultureInfo.InvariantCulture).Contains(",") || flag > max)
						MessageBox.Show(null, "Элемент " + guiflag + " будет пропущен.", "Неверное значение.");
					else
						list.SetItemChecked(Convert.ToInt32(flag), true);
				}
				else
					MessageBox.Show(null, "Элемент " + guiflag + " будет пропущен.", "Не соответствие шаблону.");
			}
		}
	}
}
