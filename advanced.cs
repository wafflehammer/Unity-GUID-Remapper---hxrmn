using System;
using System.Windows.Forms;
using System.IO;


namespace Unity_GUID_Remapper_hxrmn
{
    public partial class advanced : Form
    {

        public string gamePath;
        public string badGUID = "";
        public string goodGUID = "";

        int prefabCount = 0;
        int prefabFixedCount = 0;
        int sceneCount = 0;
        int sceneFixedCount = 0;
        int scriptableObjectCount = 0;
        int scriptableObjectFixedCount = 0;

        public advanced()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = gamePath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string badGUIDfilename = dlg.FileName;
                string[] classMetaFile = File.ReadAllLines(badGUIDfilename + @".meta");
                if (classMetaFile[1].Contains("guid: "))
                {
                    string badGUIDTextLine = classMetaFile[1];
                    
                    badGUID = badGUIDTextLine.Substring(6);
                    badGUIDTextBox.Text = badGUID;
                }
                else
                {
                    MessageBox.Show("GUID line not found on second line of text in meta file...Try entering GUID manaully after finding GUID using text editor");

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = gamePath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string goodGUIDfilename = dlg.FileName;
                string[] classMetaFile = File.ReadAllLines(goodGUIDfilename + @".meta");
                if (classMetaFile[1].Contains("guid: "))
                {
                    string goodGUIDTextLine = classMetaFile[1];
                 
                    goodGUID = goodGUIDTextLine.Substring(6);
                    goodGUIDTextBox.Text = goodGUID;
                }
                else
                {
                    MessageBox.Show("GUID line not found on second line of text in meta file...Try entering GUID manaully after finding GUID using text editor");

                }
            }
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                badGUID = badGUIDTextBox.Text;
                goodGUID = goodGUIDTextBox.Text;
                gamePath = gamePathTextBox.Text;
            }
            catch(Exception prematureExceptulation)
            {
                MessageBox.Show("something went wrong pulling game path, bad GUID, or good GUID (or all 3 if you're really a fuckin athlete here) from the text boxes....figure it out");
                MessageBox.Show(prematureExceptulation.ToString());
                return;
            }
                
                try
            {

                if (checkbox_fixPrefabs.Checked)
                {
                    prefabCount = 0;
                    richTextBox1.AppendText("Fixing Prefabs!" + "\n");
                    foreach (string file in Directory.EnumerateFiles(gamePath, "*.prefab", SearchOption.AllDirectories))
                    {
                        richTextBox1.AppendText("Found: " + file + "\n");
                        string prefab = File.ReadAllText(file);
                        if (prefab.Contains(badGUID))
                        {
                            prefab = prefab.Replace(badGUID, goodGUID);
                            richTextBox1.AppendText("Replaced shitty GUID: " + badGUID + " with good GUID: " + goodGUID + "\n");
                            File.WriteAllText(file, prefab);
                            richTextBox1.AppendText("Wrote File back to disk" + "\n");
                            prefabFixedCount++;

                            if (checkbox_DeleteMetaFiles.Checked)
                            {
                                File.Delete(file + ".meta");
                                richTextBox1.AppendText("Deleted Meta File: " + file + ".meta" + "\n");
                            }
                        }
                        else
                        {
                            richTextBox1.AppendText("File: " + file + " Did not contain any references to the bad GUID!" + "\n");

                        }
                        prefabCount++;
                    }
                }

                if (checkbox_fixScenes.Checked)
                {
                    sceneCount = 0;
                    richTextBox1.AppendText("Fixing Scenes!" + "\n");
                    foreach (string file in Directory.EnumerateFiles(gamePath, "*.unity", SearchOption.AllDirectories))
                    {
                        richTextBox1.AppendText("Found: " + file + "\n");
                        string scene = File.ReadAllText(file);
                        if (scene.Contains(badGUID))
                        {
                            scene = scene.Replace(badGUID, goodGUID);
                            richTextBox1.AppendText("Replaced shitty GUID: " + badGUID + " with good GUID: " + goodGUID + "\n");
                            File.WriteAllText(file, scene);
                            richTextBox1.AppendText("Wrote File back to disk" + "\n");
                            sceneFixedCount++;


                            if (checkbox_DeleteMetaFiles.Checked)
                            {
                                File.Delete(file + ".meta");
                                richTextBox1.AppendText("Deleted Meta File: " + file + ".meta" + "\n");
                            }
                        }
                        else
                        {
                            richTextBox1.AppendText("File: " + file + " Did not contain any references to the bad GUID!" + "\n");

                        }
                        sceneCount++;
                    }
                }

                if (checkbox_FixScriptableObjects.Checked)
                {
                    scriptableObjectCount = 0;
                    richTextBox1.AppendText("Fixing Scriptable Objects!" + "\n");
                    foreach (string file in Directory.EnumerateFiles(gamePath, "*.asset", SearchOption.AllDirectories))
                    {
                        richTextBox1.AppendText("Found: " + file + "\n");
                        string scriptableObj = File.ReadAllText(file);
                        if (scriptableObj.Contains(badGUID))
                        {
                            scriptableObj = scriptableObj.Replace(badGUID, goodGUID);
                            richTextBox1.AppendText("Replaced shitty GUID: " + badGUID + " with good GUID: " + goodGUID + "\n");
                            File.WriteAllText(file, scriptableObj);
                            richTextBox1.AppendText("Wrote File back to disk" + "\n");
                            scriptableObjectFixedCount++;

                            if (checkbox_DeleteMetaFiles.Checked)
                            {
                                File.Delete(file + ".meta");
                                richTextBox1.AppendText("Deleted Meta File: " + file + ".meta" + "\n");
                            }

                        }
                        else
                        {
                            richTextBox1.AppendText("File: " + file + " Did not contain any references to the bad GUID!" + "\n");

                        }


                      
                        scriptableObjectCount++;
                    }
                }


                richTextBox1.AppendText("GUID remapping completed successfully, probably, maybe" + "\n");
                richTextBox1.AppendText("Summary Results:" + "\n");
                richTextBox1.AppendText("           Prefabs Fixed: " + prefabFixedCount.ToString() + " out of " + prefabCount.ToString() +  "\n");
                richTextBox1.AppendText("            Scenes Fixed: " + sceneFixedCount.ToString() + " out of " + sceneCount.ToString() + "\n");
                richTextBox1.AppendText("Scriptable Objects Fixed: " + scriptableObjectFixedCount.ToString() + " out of " + scriptableObjectCount.ToString() + "\n");
                MessageBox.Show("GUID Remapping completed, might even have worked!");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString(), "Something fucky happened");
            }
        }

  

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the ROOT directory for the ripped Unity Project";
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowser.ShowDialog();
            if (Directory.Exists(folderBrowser.SelectedPath))
            {
                gamePath = folderBrowser.SelectedPath;
                gamePathTextBox.Text = gamePath;

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (badGUIDTextBox.TextLength == 32 && goodGUIDTextBox.TextLength == 32)
            {
                button3.Enabled = true;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (badGUIDTextBox.TextLength == 32 && goodGUIDTextBox.TextLength == 32)
            {
                button3.Enabled = true;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(gamePathTextBox.Text))
            {
                button1.Enabled = true;
                button2.Enabled = true;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void advanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            
        }
    }
}
