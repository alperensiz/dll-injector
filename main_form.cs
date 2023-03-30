using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Injector
{
    public partial class mainForm : Form
    {
        //let's import all required methods from kernel32.dll
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        //required privileges
        const int PROCESS_CREATE_THREAD     = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION      = 0x0008;
        const int PROCESS_VM_WRITE          = 0x0020;
        const int PROCESS_VM_READ           = 0x0010;

        const uint MEM_COMMIT               = 0x00001000;
        const uint MEM_RESERVE              = 0x00002000;
        const uint PAGE_READWRITE           = 4;

        public mainForm()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click1(object sender, EventArgs e)
        {
            OpenFileDialog dllLocationDialog = new OpenFileDialog();

            dllLocationDialog.Title = "Select DLL file";

            //alow the user to only select DLL files
            dllLocationDialog.Filter = "DLL Files (*.dll) | *.dll";

            //show the user a file dialog and get selected file
            if (dllLocationDialog.ShowDialog() == DialogResult.OK)
            {
                dllTxtBox.Text = dllLocationDialog.FileName;
            }

            //re-enable inject button
            injectBtn.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //once the application loads
            //get a list of all current running processes
            //show list in control appListBox

            //get all running processes
            Process[] allProcesses = Process.GetProcesses();

            ImageList appIcons = new ImageList();
            Icon appIcon;

            appListView.SmallImageList = appIcons;

            // Add processes to appListBox
            foreach (Process process in allProcesses)
            {
                //get the icon of the process
                //get the critical info from the process such as name
                //add to appListView
                try
                {
                    appIcon = Icon.ExtractAssociatedIcon(process.MainModule.FileName);

                    appIcons.Images.Add(appIcon.GetHashCode().ToString(), appIcon.ToBitmap());

                    string[] row = 
                    {
                        process.ProcessName,
                        process.Id.ToString(),
                        process.MainModule.FileName
                    };

                    ListViewItem item = new ListViewItem(row)
                    {
                        ImageKey = appIcon.GetHashCode().ToString()
                    };

                    appListView.Items.Add(item);
                }
                catch { } //access is denied
            }
        }
    
        private void injectBtn_Click(object sender, EventArgs e)
        {

            //get target process handle
            Process targetProcess = Process.GetProcessesByName(appListView.FocusedItem.Text)[0];

            IntPtr processHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_READ | PROCESS_VM_WRITE,
                                   false, targetProcess.Id);

            //get LoadLibraryA method address
            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            string dllLocation = dllTxtBox.Text;

            //allocate memory space into target process
            IntPtr allocatedMemoryAddress = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)((dllLocation.Length + 1) * Marshal.SizeOf(typeof(char))),
                MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

            //write DLL location into allocated memory space
            UIntPtr bytesWritten;
            WriteProcessMemory(processHandle, allocatedMemoryAddress, Encoding.Default.GetBytes(dllLocation), (uint)((dllLocation.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

            //create thread to execute LoadLibraryA with the DLL as a parameter
            CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryAddr, allocatedMemoryAddress, 0, IntPtr.Zero);
        }

        private void dllTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pictureBox1.BackColor = guna2ColorTransition1.Value;
            //injectBtn.BackColor = guna2ColorTransition1.Value;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void selectBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dllLocationDialog = new OpenFileDialog();

            dllLocationDialog.Title = "select dll file";

           
            dllLocationDialog.Filter = "dll files (*.dll) | *.dll";

            
            if (dllLocationDialog.ShowDialog() == DialogResult.OK)
            {
                dllTxtBox.Text = dllLocationDialog.FileName;
            }

            //re-enable inject button
            injectBtn.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void appListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
