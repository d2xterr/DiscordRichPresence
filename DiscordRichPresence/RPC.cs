using System;
using System.Media;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;

namespace RPCTUTORIAL
{
    internal class RPC
    {
        private static DiscordRpcClient client;
        private static string currentClientId = "1245772424415281223";

        public static void Init(Label l, PictureBox pic, Label lab)
        {
            client = new DiscordRpcClient(currentClientId, autoEvents: true);
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.OnReady += (sender, e) =>
            {
                l.BeginInvoke((Action)(() => {
                    l.Text = e.User.Username;
                    l.ForeColor = Color.LimeGreen;
                }));

                lab.BeginInvoke((Action)(() => {
                    lab.Text = "Logged in as " + e.User.Username;
                    lab.ForeColor = Color.LimeGreen;
                }));

                string avatarUrl = (!string.IsNullOrEmpty(e.User.Avatar) && e.User.Avatar.StartsWith("a_"))
                    ? e.User.GetAvatarURL(User.AvatarFormat.GIF)
                    : e.User.GetAvatarURL(User.AvatarFormat.PNG);

                pic.BeginInvoke((Action)(() =>
                {
                    try
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            string tempPath = System.IO.Path.GetTempFileName();
                            webClient.DownloadFile(avatarUrl, tempPath);

                            if (pic.Image != null)
                            {
                                var oldImage = pic.Image;
                                pic.Image = null;
                                oldImage.Dispose();
                            }

                            pic.ImageLocation = tempPath;
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load Discord avatar.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            };

            client.OnError += (object sender, ErrorMessage e) =>
            {
                MessageBox.Show("Please open Discord for this to work!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SystemSounds.Exclamation.Play();
            };

            client.OnConnectionFailed += (sender, e) =>
            {
                MessageBox.Show("Please open Discord for this to work!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SystemSounds.Exclamation.Play();
            };

            client.Initialize();
        }

        public static void SetClientId(string clientId)
        {
            currentClientId = clientId;
            if (client != null && client.IsInitialized)
            {
                client.Deinitialize();
                client.Dispose();
                client = new DiscordRpcClient(currentClientId, autoEvents: true);
                client.Initialize();
            }
        }

        public static void SetState(
            string state,
            string details,
            string largeImageKey,
            string largeImageText,
            bool showButtons,
            string button1Label = "",
            string button1Url = "",
            string button2Label = "",
            string button2Url = "")
        {
            if (client == null || !client.IsInitialized) return;

            var presence = new RichPresence()
            {
                Details = details,
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText
                }
            };

            if (showButtons)
            {
                var buttons = new System.Collections.Generic.List<DiscordRPC.Button>();

                if (!string.IsNullOrEmpty(button1Label) && !string.IsNullOrEmpty(button1Url))
                {
                    buttons.Add(new DiscordRPC.Button()
                    {
                        Label = button1Label,
                        Url = button1Url
                    });
                }

                if (!string.IsNullOrEmpty(button2Label) && !string.IsNullOrEmpty(button2Url))
                {
                    buttons.Add(new DiscordRPC.Button()
                    {
                        Label = button2Label,
                        Url = button2Url
                    });
                }

                // This ensures buttons appear on both desktop and browser
                if (buttons.Count > 0)
                {
                    presence.Buttons = buttons.ToArray();
                }
            }

            client.SetPresence(presence);
        }

        public static void Shutdown()
        {
            if (client != null && client.IsInitialized)
            {
                client.ClearPresence();
                client.Deinitialize();
                client.Dispose();
            }
        }
    }
}