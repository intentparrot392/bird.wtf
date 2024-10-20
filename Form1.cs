using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScintillaNET;
using System.Windows.Forms;
using SynapseZAPI;
using System.IO;

namespace bird.wtf_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SynapseZAPI.SynapseZAPI synapseZAPI = new SynapseZAPI.SynapseZAPI();

        private void button1_Click(object sender, EventArgs e)
        {
            synapseZAPI.Execute(Directory.GetCurrentDirectory(), scintilla1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            synapseZAPI.Inject(Directory.GetCurrentDirectory() /*<- MainPath*/);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            scintilla1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string scriptToExecute = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source\"))()";
            int result = synapseZAPI.Execute(System.IO.Directory.GetCurrentDirectory(), scriptToExecute);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string scriptToExecute = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/Babyhamsta/RBLX_Scripts/main/Universal/BypassedDarkDexV3.lua\", true))()";
            int result = synapseZAPI.Execute(System.IO.Directory.GetCurrentDirectory(), scriptToExecute);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string scriptToExecute = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/exxtremestuffs/SimpleSpySource/refs/heads/master/SimpleSpy.lua\"))()";
            int result = synapseZAPI.Execute(System.IO.Directory.GetCurrentDirectory(), scriptToExecute);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string scriptToExecute = "loadstring(game:HttpGet'https://raw.githubusercontent.com/cracklua/cracks/m/UserCreation')'25ms owns you'";
            int result = synapseZAPI.Execute(System.IO.Directory.GetCurrentDirectory(), scriptToExecute);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string scriptToExecute = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/unified-naming-convention/NamingStandard/refs/heads/main/UNCCheckEnv.lua\"))()";
            int result = synapseZAPI.Execute(System.IO.Directory.GetCurrentDirectory(), scriptToExecute);
        }
    }
}
