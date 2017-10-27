using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUpdater
{
    public partial class FormMain : Form
    {
        private string programVersion = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "Main v" + programVersion;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClassCombine combine = new ClassCombine();

            var itemInput = txInput.Text;

            combine.SetItem(itemInput);

            listOutput.Items.Add(combine.GetName() + " " + combine.GetLevel());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();
        }

        private async void txtInString_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(0);
            ClassHash c = new ClassHash();
            var txt = txtInString.Text;
            var tOut = c.sha256_hash(txt);
            txtOutString.Text = tOut;

            txtOut512.Text = c.sha512(txt);
        }
    }
}
