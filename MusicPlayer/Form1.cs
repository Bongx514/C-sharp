using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        int volume = 100;
        private readonly List<string> _mp3Files = new List<string>();
        private int _currentTrackIndex = -1;
        private readonly IWavePlayer _wavePlayer;
        private AudioFileReader _audioFileReader;
        private string selectedFilePath;
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();

            var folderPath = @"C:\Users\bonga\Music\New music";
            //load all mp3 files from the specified folder
            _mp3Files.AddRange(Directory.GetFiles(folderPath, "*.mp3"));
            //initialize the wave payer
            _wavePlayer = new WaveOut();
        }

        private void PlayTrack(string filePath)
        {
            //stop the current track if theres any playing
            _wavePlayer.Pause();

            //Update the label with the name of the track playing
            var trackName = Path.GetFileNameWithoutExtension(filePath);
            label1.Text = "Now Playing: " + trackName;
            
            //Load the new track using the wave player
            _audioFileReader = new AudioFileReader(filePath);

            //Playe the new track using the wave player
            _wavePlayer.Init(_audioFileReader);
            _wavePlayer.Play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _wavePlayer.Volume = volume/100f;
            if (_mp3Files.Any())
            {
                if (_currentTrackIndex == -1)
                {
                    //start playing the first track
                    _currentTrackIndex = 0;
                    PlayTrack(_mp3Files[_currentTrackIndex]);
                }
                else
                {
                    //resume plaing the current track
                    _wavePlayer.Play();
                }
            }
            btnPause.Visible = true;
            btnPlay.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _wavePlayer.Pause();
            btnPause.Visible = false;
            btnPlay.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_mp3Files.Any())
            {
                _wavePlayer.Pause();
                //move to the next track
                _currentTrackIndex = (_currentTrackIndex + 1) % _mp3Files.Count;
                //play the next track
                PlayTrack(_mp3Files[_currentTrackIndex]);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_mp3Files.Any())
            {
                //stop current track
                _wavePlayer.Pause();

                //move to previous track
                _currentTrackIndex--;

                if (_currentTrackIndex < 0)
                {
                    _currentTrackIndex = _mp3Files.Count - 1;
                }

                //Play the previous track
                PlayTrack(_mp3Files[_currentTrackIndex]);
            }
        }

       
    }
}
