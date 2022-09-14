using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemPrograming_prjct;
using System.Windows.Forms;

namespace DZ_14092022_wf {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bBIO_Click(object sender, EventArgs e) {
            string[] BIO = { "I'm Max", "Im'16 years old", "I'm from Ukraine", "I am beginner programmer" };
            foreach (var item in BIO) {
                Functions.MessageBox(IntPtr.Zero, item, "BIO", (uint)Functions.MB_OKCANCEL);
            }
        }

        private void CC(object sender, EventArgs e) {
            tbNewCaption.Enabled = rbChange.Checked;
        }

        private void bSubmit_Click(object sender, EventArgs e) {
            if (rbChange.Checked && !string.IsNullOrWhiteSpace(tbCaption.Text) && !string.IsNullOrWhiteSpace(tbNewCaption.Text)) {
                var handle = Functions.FindWindowByCaption(IntPtr.Zero, tbCaption.Text);
                Functions.SendMessage(handle, Functions.WM_SETTEXT, UIntPtr.Zero, new StringBuilder(tbNewCaption.Text));
                tbCaption.Text = tbNewCaption.Text;
                tbNewCaption.Text = string.Empty;
            }
            else if (!string.IsNullOrWhiteSpace(tbCaption.Text)) {
                var handle = Functions.FindWindowByCaption(IntPtr.Zero, tbCaption.Text);
                if (rbClose.Checked)
                    Functions.SendMessage(handle, Functions.WM_CLOSE, UIntPtr.Zero, new StringBuilder());
                else
                    Functions.ShowWindow(handle, Functions.SW_SHOWMAXIMIZED);
            }
        }

        private void bBeeps_Click(object sender, EventArgs e) {
            Functions.MessageBeep((uint)Functions.MB_ICONASTERISK);
            Task.Delay(500).Wait();
            Functions.MessageBeep((uint)Functions.MB_ICONEXCLAMATION);
            Task.Delay(1500).Wait();
            Functions.MessageBeep((uint)Functions.MB_OK);
            Task.Delay(2500).Wait();
            Functions.MessageBeep((uint)Functions.MB_ICONQUESTION);
        }
    }
}
