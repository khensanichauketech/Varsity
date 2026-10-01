using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace JamSess
{
    public partial class frmUploadSong : Form
    {
        string playlistFolder;
        string selectedSongPath = "";
        string songName = "";

        string currentPlaylistName = "";
        bool currentPlaylistOnly = false;

        // Constructor used when opened from Homepage
        public frmUploadSong(string folder)
        {
            InitializeComponent();

            playlistFolder = folder;
            currentPlaylistOnly = false;

            LoadPlaylistChoices();
        }

        // Constructor used when opened from a specific Playlist Page
        public frmUploadSong(string folder, string playlistName)
        {
            InitializeComponent();

            playlistFolder = folder;
            currentPlaylistName = playlistName;
            currentPlaylistOnly = true;

            LoadPlaylistChoices();
        }

        // Loads playlist choices into the CheckedListBox
        private void LoadPlaylistChoices()
        {
            try
            {
                clbPlaylists.Items.Clear();

                // If opened from Playlist Page, only show that playlist
                if (currentPlaylistOnly == true)
                {
                    int index = clbPlaylists.Items.Add(currentPlaylistName);
                    clbPlaylists.SetItemChecked(index, true);

                    return;
                }

                // If opened from Homepage, show all playlists for current user
                if (!Directory.Exists(playlistFolder))
                {
                    MessageBox.Show("Playlist folder could not be found.");
                    return;
                }

                string[] files = Directory.GetFiles(playlistFolder, "*.ser");

                for (int i = 0; i < files.Length; i++)
                {
                    string playlistName = Path.GetFileNameWithoutExtension(files[i]);

                    clbPlaylists.Items.Add(playlistName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load playlists: " + ex.Message);
            }
        }

        // Allows the user to choose an existing music file
        private void btnChooseSong_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openSong = new OpenFileDialog();

                openSong.Title = "Select Song";
                openSong.Filter = "Audio Files|*.mp3;*.wav;*.m4a;*.aac";

                if (openSong.ShowDialog() == DialogResult.OK)
                {
                    selectedSongPath = openSong.FileName;

                    songName = Path.GetFileNameWithoutExtension(selectedSongPath);

                    lblSongName.Text = songName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not select song: " + ex.Message);
            }
        }

        // Typed method checks that a song has been selected
        private bool ValidateSongSelected()
        {
            if (selectedSongPath == "")
            {
                MessageBox.Show("Please select a song first.");

                return false;
            }

            return true;
        }

        // Typed method checks that Artist, Album and Genre were entered
        private bool ValidateSongDetails()
        {
            if (txtArtist.Text.Trim() == "" ||
                txtAlbum.Text.Trim() == "" ||
                txtGenre.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the artist, album and genre.");

                return false;
            }

            return true;
        }

        // Creates a Song object and adds it to all checked playlists
        private void btnUploadSong_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateSongSelected() == false)
                {
                    return;
                }

                if (ValidateSongDetails() == false)
                {
                    return;
                }

                if (clbPlaylists.CheckedIndices.Count == 0)
                {
                    MessageBox.Show("Please select at least one playlist.");

                    return;
                }

                Song newSong = new Song(
                    songName,
                    txtArtist.Text.Trim(),
                    txtAlbum.Text.Trim(),
                    txtGenre.Text.Trim(),
                    selectedSongPath);

                for (int i = 0; i < clbPlaylists.CheckedIndices.Count; i++)
                {
                    string playlistName = clbPlaylists.Items[clbPlaylists.CheckedIndices[i]].ToString();

                    string filePath = Path.Combine(playlistFolder, playlistName + ".ser");

                    if (File.Exists(filePath))
                    {
                        Playlist playlist = PlaylistData.LoadPlaylist(filePath);

                        if (playlist != null)
                        {
                            bool songExists = false;

                            // Prevents the same song being added twice to the same playlist
                            for (int j = 0; j < playlist.Songs.Count; j++)
                            {
                                if (playlist.Songs[j].FilePath == selectedSongPath)
                                {
                                    songExists = true;
                                    break;
                                }
                            }

                            if (songExists == false)
                            {
                                playlist.Songs.Add(newSong);

                                PlaylistData.SavePlaylist(playlist, filePath);
                            }
                        }
                    }
                }

                MessageBox.Show("Song uploaded successfully.");

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Song could not be uploaded: " + ex.Message);
            }
        }

        // Clears all song information after upload
        private void ClearForm()
        {
            selectedSongPath = "";
            songName = "";

            lblSongName.Text = "No song selected";

            txtArtist.Clear();
            txtAlbum.Clear();
            txtGenre.Clear();

            // If opened from Homepage, uncheck all playlists
            if (currentPlaylistOnly == false)
            {
                for (int i = 0; i < clbPlaylists.Items.Count; i++)
                {
                    clbPlaylists.SetItemChecked(i, false);
                }
            }

            // If opened from Playlist Page, keep current playlist checked
            if (currentPlaylistOnly == true && clbPlaylists.Items.Count > 0)
            {
                clbPlaylists.SetItemChecked(0, true);
            }

            clbPlaylists.ClearSelected();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}