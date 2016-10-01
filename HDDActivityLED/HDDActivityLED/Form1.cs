using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Collections.Specialized;
using System.Threading;

namespace HDDActivityLED
{
    public partial class Form1 : Form
    {
        NotifyIcon HDDLEDIcon;
        Icon activeIcon;
        Icon IdleIcon;
        Thread HDDLEDWorker;

        public Form1()
        {
            //Hide the form
            InitializeComponent();
            activeIcon = new Icon("HDD_Busy.ico");
            IdleIcon = new Icon("HDD_Idle.ico");
            HDDLEDIcon = new NotifyIcon
            HDDLEDIcon.Icon = IdleIcon;
            HDDLEDIcon.Visible = true;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
    }
}
