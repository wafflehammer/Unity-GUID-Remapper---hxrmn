using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Unity_GUID_Remapper_hxrmn
{
 
    public partial class Main : Form
    {
        [DllImport("kernel32")]
        static extern int AllocConsole();

        public string gamePath;
        public string badGUID = "5dad5f9bb6e488d4f903ead617483c85";
        public string goodGUID = "f4688fdb7df04437aeb418b961361dc5";
        public string relativeBadTMPpath = @"\Assets\Scripts\Unity.TextMeshPro\TMPro\TextMeshProUGUI.cs.meta";
        public string relativeGoodTMPpath = @"\Library\PackageCache\com.unity.textmeshpro@3.0.1\Scripts\Runtime";
        public Main()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the ROOT directory for the ripped Unity Project";
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowser.ShowDialog();
            if (Directory.Exists(folderBrowser.SelectedPath))
            {

                try
                {
                    string tempGamePath = folderBrowser.SelectedPath;
                    
             
                    if (File.Exists(tempGamePath + relativeBadTMPpath))
                    {
                       
                        MessageBox.Show("found shitty bad guid");
                        gamePath = tempGamePath;
                        string[] tmpGUImetafile = File.ReadAllLines(gamePath + relativeBadTMPpath);
                        if (tmpGUImetafile[1].Contains("guid: "))
                        {
                            MessageBox.Show("Found shitty tmpro ugui meta file!");
                            tmpGUImetafile[1].Replace("guid: ", "");
                            badGUID = tmpGUImetafile[1];
                            label2.Text = gamePath;
                            label4.Text = badGUID;
                            button2.Enabled = true;

                        }
                        

             
                    }
                    


                }

                catch(Exception excp)
                {
                    MessageBox.Show("You fucked up somehow, probably didn't select ROOT game directory (the one with assets etc folders in it)");


                }

         
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AllocConsole();



            if (checkbox_fixPrefabs.Checked)
            {
                Console.WriteLine("replacing shitty GUID " + badGUID + "with " + goodGUID);
                foreach (string file in Directory.EnumerateFiles(gamePath, "*.prefab", SearchOption.AllDirectories))
                {
                    Console.WriteLine("Found: " + file);
                    string prefab = File.ReadAllText(file);
                    prefab = prefab.Replace(badGUID, goodGUID);
                    Console.WriteLine("Replaced shitty TMP UGUI GUIDs");
                    File.WriteAllText(file, prefab);
                    Console.WriteLine("Wrote File back to disk");

                    if (checkbox_DeleteMetaFiles.Checked)
                    {
                        File.Delete(file + ".meta");
                        Console.WriteLine("Associated Meta File Deleted...Moving to Next...");
                    }
                }
            }

            if (checkbox_fixPrefabs.Checked)
            {
                Console.WriteLine("replacing shitty GUID " + badGUID + "with " + goodGUID);
                foreach (string file in Directory.EnumerateFiles(gamePath, "*.unity", SearchOption.AllDirectories))
                {
                    Console.WriteLine("Found: " + file);
                    string prefab = File.ReadAllText(file);
                    prefab = prefab.Replace(badGUID, goodGUID);
                    Console.WriteLine("Replaced shitty TMP UGUI GUIDs");
                    File.WriteAllText(file, prefab);
                    Console.WriteLine("Wrote File back to disk");

                    if (checkbox_DeleteMetaFiles.Checked)
                    {
                        File.Delete(file + ".meta");
                        Console.WriteLine("Associated Meta File Deleted...Moving to Next...");
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            advanced advanced = new advanced();
            advanced.Show();
        
        }
    }
}
