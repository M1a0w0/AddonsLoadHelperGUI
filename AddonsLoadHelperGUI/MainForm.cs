using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Text.RegularExpressions;

namespace AddonsLoadHelperGUI
{
    public partial class MainForm : Form
    {
        static private string lang = CultureInfo.CurrentUICulture.Name ?? "";

        public MainForm()
        {
            InitializeComponent();
        }

        private static JArray[] ReadListViewItem(ListView lv)
        {
            JArray[] jArray = [new(), new()];
            foreach (ListViewItem item in lv.CheckedItems)
            {
                JObject jObject = new JObject();
                string packId = item.SubItems[3].Text;
                string[] versions = item.SubItems[2].Text.ToString().Split(".");
                string type = item.SubItems[1].Text;
                JArray version = new JArray();
                foreach (string ver in versions)
                {
                    version.Add(int.Parse(ver));
                }
                jObject.Add("pack_id", packId);
                jObject.Add("version", version);
                if (type.Equals("行为包") || type.Equals("Behavior"))
                {
                    jArray[0].Add(jObject);
                }
                else
                {
                    jArray[1].Add(jObject);
                }
            }
            return jArray;
        }

        private static ListViewItem? GetListViewItem(JObject data)
        {
            ListViewItem item = new ListViewItem();
            if (data != null)
            {
                JObject header = (JObject)data["header"];
                JArray modules = (JArray)data["modules"];
                JObject module = (JObject)modules[0];
                if (header == null || module == null)
                {
                    return null;
                }
                string name = (string)header["name"];
                string type = GetLangString("str_" + (string)module["type"]);
                JArray version = (JArray)header["version"];
                string uuid = (string)header["uuid"];
                string description = (string)header["description"];
                if (name == null || type == null || version == null || uuid == null || description == null)
                {
                    return null;
                }
                string versionStr = (string)version[0] + "." + (string)version[1] + "." + (string)version[2];
                item.Text = name;
                item.SubItems.Add(type);
                item.SubItems.Add(versionStr);
                item.SubItems.Add(uuid);
                item.SubItems.Add(description);
                item.Checked = true;
            }
            return item;
        }

        // type = true = 行为包
        private static void WriteFile(string path, string data, bool type)
        {
            Regex regex = new Regex("(\\behavior_packs|\\resource_packs).*");
            string newPath = regex.Replace(path, "") + (type ? "\\world_behavior_packs.json" : "\\world_resource_packs.json");
            StreamWriter sw = new StreamWriter(newPath);
            sw.Write(data);
            sw.Close();
        }

        private static string ReadFile(string path)
        {
            try
            {
                // 读取文本文件
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }

        private static string GetLangString(string name)
        {
            ResourceManager rm = new ResourceManager("AddonsLoadHelperGUI.mainForm", typeof(MainForm).Assembly);
            return rm.GetString(name, new CultureInfo(lang)) ?? "";
        }

        public void LoadLanguage(Form targetForm, string targetLang)
        {
            lang = targetLang;
            if (targetForm != null)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(targetLang);
                ComponentResourceManager resources = new ComponentResourceManager(targetForm.GetType());
                resources.ApplyResources(targetForm, "$this");
                LoadControls(targetForm, resources);
            }
        }

        private void LoadControls(Control targetControl, ComponentResourceManager targetResources)
        {
            if (targetControl is ToolStrip strip)
            {
                targetResources.ApplyResources(targetControl, targetControl.Name);
                ToolStrip tool = strip;
                if (tool.Items.Count > 0)
                {
                    foreach (ToolStripItem item in tool.Items)
                    {
                        targetResources.ApplyResources(item, item.Name ?? "");
                    }
                }
            }

            if (targetControl is ListView view)
            {
                targetResources.ApplyResources(targetControl, targetControl.Name);
                ListView list = view;
                if (list.Columns.Count > 0)
                {
                    for (int i = 0; i < list.Columns.Count; i++)
                    {
                        targetResources.ApplyResources(list.Columns[i], "columnHeader" + (i + 1).ToString());
                    }
                }
            }

            foreach (Control ctrl in targetControl.Controls)
            {
                targetResources.ApplyResources(ctrl, ctrl.Name);
                LoadControls(ctrl, targetResources);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            lang = CultureInfo.CurrentUICulture.Name;
            if (CultureInfo.CurrentUICulture.Name.Equals("zh-CN"))
            {
                btn_language_chinese.Checked = true;
            }
            else
            {
                btn_language_english.Checked = true;
            }
        }

        private void btn_language_chinese_Click(object sender, EventArgs e)
        {
            if (!btn_language_chinese.Checked)
            {
                btn_language_chinese.Checked = true;
                btn_language_english.Checked = false;
                LoadLanguage(this, "zh-CN");
            }
        }

        private void btn_language_english_Click(object sender, EventArgs e)
        {
            if (!btn_language_english.Checked)
            {
                btn_language_chinese.Checked = false;
                btn_language_english.Checked = true;
                LoadLanguage(this, "en-US");
            }
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            if (tb_location.Text.Length > 0) folderBrowserDialog.SelectedPath = tb_location.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tb_location.Text = folderBrowserDialog.SelectedPath;
            }

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            lv_addons.Items.Clear();
            pb_read.Value = 0;
            if (tb_location.Text.Length > 0)
            {
                string addons_location = tb_location.Text;
                string[] files = Directory.GetFiles(addons_location, "manifest.json", SearchOption.AllDirectories);
                if (files.Length > 0)
                {
                    pb_read.Maximum = files.Length;
                    foreach (string item in files)
                    {
                        string jsonStr = ReadFile(item);
                        JObject jsonObject = JObject.Parse(jsonStr);
                        ListViewItem lvi = GetListViewItem(jsonObject);
                        if (lvi != null) { lv_addons.Items.Add(lvi); }
                        pb_read.Value += 1;
                    }
                    MessageBox.Show(GetLangString("str_searchfinish_text0") + files.Length + GetLangString("str_searchfinish_text1"), GetLangString("str_searchfinish_title"));
                }
                else
                {
                    MessageBox.Show(GetLangString("str_notfound_text"), GetLangString("str_notfound_title"));
                }
            }
            else
            {
                MessageBox.Show(GetLangString("str_unselectfolder_text"), GetLangString("str_unselectfolder_title"));
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            if (lv_addons.CheckedItems.Count > 0)
            {
                JArray[] jsons = ReadListViewItem(lv_addons);
                WriteFile(tb_location.Text, jsons[0].ToString(), true);
                WriteFile(tb_location.Text, jsons[1].ToString(), false);
                MessageBox.Show(GetLangString("str_writefinish_text"), GetLangString("str_writefinish_title"));
            }
            else
            {
                MessageBox.Show(GetLangString("str_unselectaddons_text"), GetLangString("str_unselectaddons_title"));
            }
        }
    }
}
