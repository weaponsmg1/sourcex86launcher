using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Source_Engine_x86_Games_Launcher
{
    public partial class Form1 : Form
    {
        private string settingsFilePath = Path.Combine(Application.StartupPath, "sourcex86launcher.txt");

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(128, 128, 128);

            if (!File.Exists(settingsFilePath))
            {
                AskForGamePaths();
            }
            else
            {
                LoadGamePaths();
            }
        }

        private void AskForGamePaths()
        {
            string hl2mpPath = PromptForPath("Please specify the path to Half-Life 2 Deathmatch (hl2mp.exe):");
            string tf2Path = PromptForPath("Please specify the path to Team Fortress 2 (tf.exe):");
            string cssPath = PromptForPath("Please specify the path to Counter-Strike: Source (cstrike.exe):");
            string dodPath = PromptForPath("Please specify the path to Day Of Defeat Source (dod.exe):");

            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.WriteLine(hl2mpPath);
                writer.WriteLine(tf2Path);
                writer.WriteLine(cssPath);
                writer.WriteLine(dodPath);
            }
        }

        private string PromptForPath(string prompt)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = prompt;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderDialog.SelectedPath;
                }
                else
                {
                    return "";
                }
            }
        }

        private void LoadGamePaths()
        {
            using (StreamReader reader = new StreamReader(settingsFilePath))
            {
                string hl2mpPath = reader.ReadLine();
                string tf2Path = reader.ReadLine();
                string cssPath = reader.ReadLine();
                string dodPath = reader.ReadLine();

                if (string.IsNullOrEmpty(hl2mpPath) || string.IsNullOrEmpty(tf2Path) || string.IsNullOrEmpty(cssPath) || string.IsNullOrEmpty(dodPath))
                {
                }
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Source Engine x86 Games Launcher\nVersion: 1.0\nBy weapon_smg1", "About");
        }

        private void button_hl2mp_Click(object sender, EventArgs e)
        {
            string hl2mpPath = GetGamePath("Half-Life 2 Deathmatch");

            if (!string.IsNullOrEmpty(hl2mpPath) && File.Exists(Path.Combine(hl2mpPath, "hl2mp.exe")))
            {
                string programPath = Path.Combine(hl2mpPath, "hl2mp.exe");
                string arguments = "-steam -force32bit";

                Process.Start(programPath, arguments);
            }
        }

        private void button_tf2_Click(object sender, EventArgs e)
        {
            string tf2Path = GetGamePath("Team Fortress 2");

            if (!string.IsNullOrEmpty(tf2Path) && File.Exists(Path.Combine(tf2Path, "tf.exe")))
            {
                string programPath = Path.Combine(tf2Path, "tf.exe");
                string arguments = "-steam -force32bit";

                Process.Start(programPath, arguments);
            }
        }

        private void button_css_Click(object sender, EventArgs e)
        {
            string cssPath = GetGamePath("Counter-Strike: Source");

            if (!string.IsNullOrEmpty(cssPath) && File.Exists(Path.Combine(cssPath, "cstrike.exe")))
            {
                string programPath = Path.Combine(cssPath, "cstrike.exe");
                string arguments = "-steam -force32bit";

                Process.Start(programPath, arguments);
            }
        }

        private void button_dod_Click(object sender, EventArgs e)
        {
            string dodPath = GetGamePath("Day Of Defeat Source");

            if (!string.IsNullOrEmpty(dodPath) && File.Exists(Path.Combine(dodPath, "dod.exe")))
            {
                string programPath = Path.Combine(dodPath, "dod.exe");
                string arguments = "-steam -force32bit";

                Process.Start(programPath, arguments);
            }
        }

        private string GetGamePath(string gameName)
        {
            string path = string.Empty;

            using (StreamReader reader = new StreamReader(settingsFilePath))
            {
                if (gameName == "Half-Life 2 Deathmatch")
                {
                    path = reader.ReadLine();
                }
                else if (gameName == "Team Fortress 2")
                {
                    reader.ReadLine();
                    path = reader.ReadLine();
                }
                else if (gameName == "Counter-Strike: Source")
                {
                    reader.ReadLine();
                    reader.ReadLine();
                    path = reader.ReadLine();
                }
                else if (gameName == "Day Of Defeat Source")
                {
                    reader.ReadLine();
                    reader.ReadLine();
                    reader.ReadLine();
                    path = reader.ReadLine();
                }
            }

            return path;
        }
    }
}
