using System;
using System.Windows.Forms;
using NCoreClientCore.NetStandard;
using NCoreClientCore.Winforms.NetCore;

namespace NCoreClientCore.WinForms.Framework
{
    public partial class Form1 : Form
    {
        Oms _oms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NCoreOptions options = HardCodedSettings.GetNCoreOptions();
            NCoreOptions options = Program.GetNCoreOptions();
            var factory = new NCoreFactory(options);
            var ephorteContext = factory.Create();
            _oms = new Oms((s) => textBox1.Text += Environment.NewLine + s, factory);
        }

        private void BtnFetchFunctions_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            _oms.LogSupportedFunctions();
        }

        private void BtnFetchCases_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            _oms.LogCases();
        }

        private void BtnFetchDocumentSize_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            if(int.TryParse(txtRegistryEntryId.Text, out int registryEntryId)) { 
                _oms.FetchDocument(registryEntryId);
            } else
            {
                textBox1.Text = "RegistryEntry-id is not numeric";
            }

        }
    }
}
