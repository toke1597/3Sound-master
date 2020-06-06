
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _3Sound
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enumerable.Range(0, 101).Select(e => new ListItem(e.ToString())).ToArray());
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

            switch (defaultPlaybackDevice.Volume) {
                case 4:
                    comboBox1.SelectedIndex = 100;
                    defaultPlaybackDevice.Volume = 100;
                    label2.Text = "Current Volume:" + defaultPlaybackDevice.Volume;

                    break;
                case 100:
                    comboBox1.SelectedIndex = 4;
                    defaultPlaybackDevice.Volume = 4;
                    label2.Text = "Current Volume:" + defaultPlaybackDevice.Volume;

                    break;
                default:
                    comboBox1.SelectedIndex = 100;
                    defaultPlaybackDevice.Volume = 100;
                    label2.Text = "Current Volume:" + defaultPlaybackDevice.Volume;
                    break;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int volume1 = comboBox1.SelectedIndex;

            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Volume = volume1;
            label2.Text = "Current Volume:" + defaultPlaybackDevice.Volume;
            
            
        }

        

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
