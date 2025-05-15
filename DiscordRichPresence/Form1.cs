using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace RPCTUTORIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyDarkTheme();
            SetDefaultValues();
        }
        private void btnSetClientId_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientId.Text))
            {
                RPC.SetClientId(txtClientId.Text);
                MessageBox.Show("Client ID updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid Client ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyDarkTheme()
        {
   
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;


            foreach (Control control in this.Controls)
            {
                ApplyDarkThemeToControl(control);
            }
        }

        private void ApplyDarkThemeToControl(Control control)
        {
            if (control is Button button)
            {
                button.BackColor = Color.FromArgb(60, 60, 60);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = Color.FromArgb(50, 50, 50);
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.ForeColor = Color.White;
            }
            else if (control is Label label)
            {
                label.ForeColor = Color.White;
            }
            else if (control is CheckBox checkBox)
            {
                checkBox.ForeColor = Color.White;
            }
            else if (control is GroupBox groupBox)
            {
                groupBox.ForeColor = Color.White;
                foreach (Control subControl in groupBox.Controls)
                {
                    ApplyDarkThemeToControl(subControl);
                }
            }
            else if (control is Panel panel)
            {
                panel.BackColor = Color.FromArgb(40, 40, 40);
                foreach (Control subControl in panel.Controls)
                {
                    ApplyDarkThemeToControl(subControl);
                }
            }
        }

        private void SetDefaultValues()
        {
            txtClientId.Text = "1245772424415281223";
            txtDetails.Text = "Using RPC Control Panel";
            txtState.Text = "Customizing Presence";
            txtLargeImageKey.Text = "profile";
            txtLargeImageText.Text = "RPC Control";
            chkShowButtons.Checked = true;
            txtButton1Label.Text = "Whatever";
            txtButton1Url.Text = "https://whateveruwant.com";
            txtButton2Label.Text = "Whatever";
            txtButton2Url.Text = "https://whateveruwant.com";
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            RPC.SetClientId(txtClientId.Text);


            RPC.Init(labelUsername, pictureBoxAvatar, labelStatus);

   
            UpdatePresence();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePresence();
        }

        private void UpdatePresence()
        {
            bool showButtons = chkShowButtons.Checked;
            RPC.SetState(
                txtState.Text,
                txtDetails.Text,
                txtLargeImageKey.Text,
                txtLargeImageText.Text,
                showButtons,
                showButtons ? txtButton1Label.Text : "",
                showButtons ? txtButton1Url.Text : "",
                showButtons ? txtButton2Label.Text : "",
                showButtons ? txtButton2Url.Text : ""
            );
        }

        private void chkShowButtons_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkShowButtons.Checked;
            txtButton1Label.Enabled = enabled;
            txtButton1Url.Enabled = enabled;
            txtButton2Label.Enabled = enabled;
            txtButton2Url.Enabled = enabled;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RPC.Shutdown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}