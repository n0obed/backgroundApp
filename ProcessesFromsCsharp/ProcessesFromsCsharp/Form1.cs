using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessesFromsCsharp
{
    public partial class Form1 : Form
    {
        public Form2 form2 = new Form2();
        public bool form1Toggle = true;
        public bool form2Toggle = false;

        public Process[] processList;
        public Form1()
        {
            form2.Show();

            InitializeComponent();
            // Process.Start("cmd.exe", "/k ECHO hello Nikhil!");
            this.ShowInTaskbar = false;
            this.Text = "Processes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderProcessesOnListView();
            processesInNotifyIcon(processList);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshEvent();
        }

        // Note: This function is not mine, find it here
        // https://ourcodeworld.com/articles/read/439/how-to-list-all-windows-processes-and-their-attributes-task-manager-like-with-c-in-winforms
        public void renderProcessesOnListView()
        {
            listView1.Items.Clear();
            BgFunctions bgfunctions = new BgFunctions();
            // Create an array to store the processes
            processList = Process.GetProcesses();

            // Create an Imagelist that will store the icons of every process
            ImageList Imagelist = new ImageList();
            TimeSpan runtime = new TimeSpan(11, 12, 52); // H M S


            // Loop through the array of processes to show information of every process in your console
            foreach (Process process in processList)
            {
                if (bgfunctions.inProcesses(process.ProcessName))
                {
                    // Define the status from a boolean to a simple string
                    string status = (process.Responding == true ? "Responding" : "Not responding");
                    if (process.ProcessName == "chrome" && process.MainWindowTitle.Length < 5) { continue; } // remove duplicates of chrome
                    if (process.ProcessName == "Teams" && process.MainWindowTitle.Length < 5) { continue; } // remove duplicates of Teams
                    try
                    {
                        runtime = DateTime.Now - process.StartTime;
                    }
                    // catching error if any, mainly access denied
                    catch (Win32Exception ex)
                    {
                        // Ignore processes that give "access denied" error.
                        if (ex.NativeErrorCode == 5)
                            continue;
                        throw;
                    }
                    catch (InvalidOperationException )
                    {
                        continue;
                    }
                    // Create an array of string that will store the information to display in our 
                    string[] row = {
                        // 1 Process name
                        process.ProcessName,
                        // 2 Process Time
                        $"{runtime:hh\\:mm\\:ss}",
                        // 3 Process status
                        status,
                        // 4 Memory usage
                        BytesToReadableValue(process.PrivateMemorySize64),
                        // 5 Process ID
                        process.Id.ToString(),
                    };

                    //
                    // As not every process has an icon then, prevent the app from crash
                    try
                    {
                        Imagelist.Images.Add(
                            // Add an unique Key as identifier for the icon (same as the ID of the process)
                            process.Id.ToString(),
                            // Add Icon to the List 
                            Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                        );
                    }
                    catch { }

                    // Create a new Item to add into the list view that expects the row of information as first argument
                    ListViewItem item = new ListViewItem(row)
                    {
                        // Set the ImageIndex of the item as the same defined in the previous try-catch
                        ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                    };

                    // Add the Item
                    listView1.Items.Add(item);
                }

            }

            // Set the imagelist of your list view the previous created list :)
            listView1.LargeImageList = Imagelist;
            listView1.SmallImageList = Imagelist;
        }

        // Method that converts bytes to its human readable value
        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

        // Click events
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (form1Toggle)
            {
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                form1Toggle = !form1Toggle;
            }
            else
            {
                this.Show();
                form1Toggle = !form1Toggle;
            }
            
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Exited");
            Application.Exit();
            quitToolStripMenuItem.Visible = false;
        }
        private void chromeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.ProcessName == "chrome") { process.Kill(); Console.WriteLine("Killed chrome"); chromeToolStripMenuItem.Visible = false; }
            }
        }
        private void csgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.ProcessName == "csgo")
                {
                    process.Kill(); Console.WriteLine("Killed csgo"); csgoToolStripMenuItem.Visible = false;
                }
            }
        }
        private void CitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.ProcessName == "Cities") { process.Kill(); Console.WriteLine("Killed Cities"); CitiesToolStripMenuItem.Visible = false; }
            }
        }
        private void BannerlordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.ProcessName == "Bannerlord") { process.Kill(); Console.WriteLine("Killed Bannerlord"); BannerlordToolStripMenuItem.Visible = false; }
            }
        }
        private void steamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.ProcessName == "steam") { process.Kill(); Console.WriteLine("Killed steam"); steamToolStripMenuItem.Visible = false; }
            }
        }
        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.ProcessName == "Teams") { process.Kill(); Console.WriteLine("Killed Teams"); teamsToolStripMenuItem.Visible = false; }
            }
        }

        // making menustripitem visible if the process exists
        public int processesInNotifyIcon(Process[] processList)
        {
            foreach (Process process in processList)
            {
                switch (process.ProcessName)
                {
                    case "chrome":
                        chromeToolStripMenuItem.Visible = true;
                        break;
                    case "csgo":
                        csgoToolStripMenuItem.Visible = true;
                        break;
                    case "Cities":
                        CitiesToolStripMenuItem.Visible = true;
                        break;
                    case "Bannerlord":
                        BannerlordToolStripMenuItem.Visible = true;
                        break;
                    case "steam":
                        steamToolStripMenuItem.Visible = true;
                        break;
                    case "Teams":
                        teamsToolStripMenuItem.Visible = true;
                        break;
                }
            }
            return 0;
        }

        public int refreshEvent()
        {
            renderProcessesOnListView();
            processesInNotifyIcon(processList);
            return 0;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2Toggle)
            {
                form2.Show();
                infoToolStripMenuItem.Text = "Info|Hide";
                form2Toggle = !form2Toggle;
            }
            else
            {
                form2.Hide();
                infoToolStripMenuItem.Text = "Info|Unhide";
                form2Toggle = !form2Toggle;
            }
            
        }
    }
}