using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO;
namespace Shubhamcreation
{
   
    public partial class ttosp : MetroFramework.Forms.MetroForm
    {
        private SpeechSynthesizer reader = new SpeechSynthesizer();

        public ttosp()
        {
            InitializeComponent();


        }

        private void ttosp_Load(object sender, EventArgs e)
        {
            metroComboBox2.Text = "MALE";
            foreach (var v in reader.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",v.Description, v.Gender, v.Age);
            }
            foreach (InstalledVoice voice in reader.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                metroComboBox1.Items.Add(info.Description);
            }
        }
        private void speach_bt_Click(object sender, EventArgs e)
        {
            try
            { 
                // select male senior (if it exists)
                
                //select audio device
                //reader.SetOutputToDefaultAudioDevice();
                //build and speak a prompt
                //PromptBuilder builder = new PromptBuilder();
                //builder.AppendText("Found this on Stack Overflow.");
                //reader.Speak(builder);
                if (metroComboBox2.Text == "MALE")
                {
                    reader.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
                }
                else
                {
                    reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                }
                reader.SetOutputToDefaultAudioDevice();
                reader.Speak(text_tx.Text);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pause_bt_Click(object sender, EventArgs e)
        {
            try
            {
                reader.Pause();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resume_bt_Click(object sender, EventArgs e)
        {
            try
            {
                reader.Resume();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Wav files(.wav)|.wav";
                    sfd.Title = "save to a wave file";
                    if(sfd.ShowDialog()==DialogResult.OK)
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        reader.SetOutputToWaveStream(fs);
                        reader.Speak(text_tx.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // here we are setting the voices for each selected item in the combobox

        }

        private void calcle_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
