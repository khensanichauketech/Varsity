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

namespace JamSess
{
    public partial class frmPlaylistPage : Form
    {
        string currentPlaylistName;
        string currentFilePath;
        Image currentCoverImage;
        string coverFolder;

        // Stores songs belonging to current playlist
        List<Song> songs = new List<Song>();

        bool sortedAscending = true;

        Playlist currentPlaylist;

        // Constructor
        public frmPlaylistPage(string playlistName, string filePath, Image coverImage)
        {
            InitializeComponent();

            currentPlaylistName = playlistName;
            currentFilePath = filePath;
            currentCoverImage = coverImage;

            // Stores covers inside current user's playlist folder
            coverFolder = Path.Combine(Path.GetDirectoryName(currentFilePath), "Covers");

            // Prevents Windows Media Player from automatically starting
            axWindowsMediaPlayer1.settings.autoStart = false;

            // Stops music if the form is closed using X
            this.FormClosing += frmPlaylistPage_FormClosing;

            SetupDataGridView();
            LoadPlaylist();
            LoadSavedCover();
            DisplaySongs();
        }

        // Creates DataGridView columns
        private void SetupDataGridView()
        {
            dgvSongs.Columns.Clear();
            dgvSongs.AutoGenerateColumns = false;
            dgvSongs.AllowUserToAddRows = false;
            dgvSongs.ReadOnly = true;
            dgvSongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSongs.MultiSelect = false;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();

            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Width = 150;

            DataGridViewTextBoxColumn artistColumn = new DataGridViewTextBoxColumn();

            artistColumn.Name = "Artist";
            artistColumn.HeaderText = "Artist";
            artistColumn.Width = 150;

            DataGridViewTextBoxColumn albumColumn = new DataGridViewTextBoxColumn();

            albumColumn.Name = "Album";
            albumColumn.HeaderText = "Album";
            albumColumn.Width = 150;

            DataGridViewTextBoxColumn genreColumn = new DataGridViewTextBoxColumn();

            genreColumn.Name = "Genre";
            genreColumn.HeaderText = "Genre";
            genreColumn.Width = 120;

            dgvSongs.Columns.Add(nameColumn);
            dgvSongs.Columns.Add(artistColumn);
            dgvSongs.Columns.Add(albumColumn);
            dgvSongs.Columns.Add(genreColumn);
        }

        // Loads current Playlist object
        private void LoadPlaylist()
        {
            try
            {
                if (!File.Exists(currentFilePath))
                {
                    MessageBox.Show("Playlist file could not be found.");
                    return;
                }

                currentPlaylist = PlaylistData.LoadPlaylist(currentFilePath);

                if (currentPlaylist != null)
                {
                    currentPlaylistName = currentPlaylist.Name;
                    songs = currentPlaylist.Songs;

                    lblPlaylistName.Text = currentPlaylist.Name;
                    lblCreationDate.Text = currentPlaylist.CreationDate.ToString("dd/MM/yyyy");

                    UpdateTrackCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load playlist: " + ex.Message);
            }
        }

        // Saves current playlist
        private void SavePlaylist()
        {
            try
            {
                currentPlaylist.Songs = songs;

                PlaylistData.SavePlaylist(currentPlaylist, currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save playlist: " + ex.Message);
            }
        }

        // Displays songs in DataGridView
        private void DisplaySongs()
        {
            dgvSongs.Rows.Clear();

            // 2D array stores song information
            string[,] songArray = new string[songs.Count, 4];

            for (int i = 0; i < songs.Count; i++)
            {
                songArray[i, 0] = songs[i].Name;
                songArray[i, 1] = songs[i].Artist;
                songArray[i, 2] = songs[i].Album;
                songArray[i, 3] = songs[i].Genre;
            }

            for (int row = 0; row < songArray.GetLength(0); row++)
            {
                dgvSongs.Rows.Add(songArray[row, 0], songArray[row, 1], songArray[row, 2], songArray[row, 3]);
            }

            UpdateTrackCount();
        }

        // Updates number of tracks displayed
        private void UpdateTrackCount()
        {
            lblTrackCount.Text = "Tracks: " + songs.Count.ToString();
        }

        // Adds an existing song to the currently open playlist
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openSong = new OpenFileDialog();

                openSong.Filter = "Audio Files|*.mp3;*.wav;*.wma";

                if (openSong.ShowDialog() == DialogResult.OK)
                {
                    Song foundSong = FindExistingSong(openSong.FileName);

                    if (foundSong != null)
                    {
                        bool alreadyExists = false;

                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (songs[i].FilePath == foundSong.FilePath)
                            {
                                alreadyExists = true;
                                break;
                            }
                        }

                        if (alreadyExists)
                        {
                            MessageBox.Show("This song is already in the playlist.");
                            return;
                        }

                        songs.Add(foundSong);

                        SavePlaylist();
                        DisplaySongs();

                        MessageBox.Show(foundSong.Name + " added to " + currentPlaylistName + ".");
                    }
                    else
                    {
                        MessageBox.Show("This song has not been uploaded before. Please enter its information first.");

                        string playlistFolder = Path.GetDirectoryName(currentFilePath);

                        frmUploadSong uploadSong = new frmUploadSong(playlistFolder, currentPlaylistName);

                        uploadSong.ShowDialog();

                        LoadPlaylist();
                        DisplaySongs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add song: " + ex.Message);
            }
        }

        // Searches user's playlists for existing Song object
        private Song FindExistingSong(string selectedFilePath)
        {
            string playlistFolder = Path.GetDirectoryName(currentFilePath);

            string[] playlistFiles = Directory.GetFiles(playlistFolder, "*.ser");

            for (int i = 0; i < playlistFiles.Length; i++)
            {
                try
                {
                    Playlist playlist = PlaylistData.LoadPlaylist(playlistFiles[i]);

                    for (int j = 0; j < playlist.Songs.Count; j++)
                    {
                        if (playlist.Songs[j].FilePath == selectedFilePath)
                        {
                            return playlist.Songs[j];
                        }
                    }
                }
                catch (Exception)
                {

                }
            }

            return null;
        }

        // Gets correct default cover image
        private Image GetDefaultCover()
        {
            Image image = null;

            if (currentPlaylistName == "Chill Mix")
            {
                image = Properties.Resources.ResourceManager.GetObject("chill_mix") as Image;
            }
            else if (currentPlaylistName == "Study Music")
            {
                image = Properties.Resources.ResourceManager.GetObject("study_music") as Image;
            }
            else if (currentPlaylistName == "Rock Classics")
            {
                image = Properties.Resources.ResourceManager.GetObject("rock_classics") as Image;
            }
            else
            {
                image = Properties.Resources.ResourceManager.GetObject("no_cover") as Image;
            }

            if (image == null)
            {
                image = Properties.Resources.ResourceManager.GetObject("no_cover") as Image;
            }

            return image;
        }

        // Plays selected song
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSongs.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a song first.");
                    return;
                }

                int selectedIndex = dgvSongs.SelectedRows[0].Index;

                if (selectedIndex < 0 || selectedIndex >= songs.Count)
                {
                    return;
                }

                Song selectedSong = songs[selectedIndex];

                if (!File.Exists(selectedSong.FilePath))
                {
                    MessageBox.Show("The music file could not be found:\n" + selectedSong.FilePath);
                    return;
                }

                // Stop previous song before playing another
                axWindowsMediaPlayer1.Ctlcontrols.stop();

                axWindowsMediaPlayer1.URL = "";

                axWindowsMediaPlayer1.URL = selectedSong.FilePath;

                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not play song: " + ex.Message);
            }
        }

        // Deletes selected song only from current playlist
        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSongs.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a song first.");
                    return;
                }

                int selectedIndex = dgvSongs.SelectedRows[0].Index;

                if (selectedIndex < 0 || selectedIndex >= songs.Count)
                {
                    return;
                }

                Song selectedSong = songs[selectedIndex];

                DialogResult result = MessageBox.Show("Remove \"" + selectedSong.Name + "\" from this playlist?", "Delete Song", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "";

                    songs.RemoveAt(selectedIndex);

                    SavePlaylist();
                    DisplaySongs();

                    MessageBox.Show("Song removed from the playlist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete song: " + ex.Message);
            }
        }

        // Sorts songs alphabetically by Name
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (songs.Count == 0)
                {
                    MessageBox.Show("There are no songs to sort.");
                    return;
                }

                if (sortedAscending)
                {
                    for (int i = 0; i < songs.Count - 1; i++)
                    {
                        for (int j = 0; j < songs.Count - 1 - i; j++)
                        {
                            if (string.Compare(songs[j].Name, songs[j + 1].Name) > 0)
                            {
                                Song tempSong = songs[j];
                                songs[j] = songs[j + 1];
                                songs[j + 1] = tempSong;
                            }
                        }
                    }

                    sortedAscending = false;
                }
                else
                {
                    for (int i = 0; i < songs.Count - 1; i++)
                    {
                        for (int j = 0; j < songs.Count - 1 - i; j++)
                        {
                            if (string.Compare(songs[j].Name, songs[j + 1].Name) < 0)
                            {
                                Song tempSong = songs[j];
                                songs[j] = songs[j + 1];
                                songs[j + 1] = tempSong;
                            }
                        }
                    }

                    sortedAscending = true;
                }

                SavePlaylist();
                DisplaySongs();

                MessageBox.Show("Songs sorted by name.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not sort songs: " + ex.Message);
            }
        }

        // Deletes current playlist
        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the playlist \"" + currentPlaylistName + "\"?", "Delete Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Stop music before deleting playlist
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "";

                    if (File.Exists(currentFilePath))
                    {
                        File.Delete(currentFilePath);
                    }

                    string coverPath = Path.Combine(coverFolder, currentPlaylistName + ".png");

                    if (File.Exists(coverPath))
                    {
                        File.Delete(coverPath);
                    }

                    songs.Clear();

                    dgvSongs.Rows.Clear();

                    lblPlaylistName.Text = "";
                    lblCreationDate.Text = "";
                    lblTrackCount.Text = "";

                    pbxCover.Image = null;

                    MessageBox.Show("Playlist deleted.");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete playlist: " + ex.Message);
            }
        }

        // Loads saved custom cover or correct default cover
        private void LoadSavedCover()
        {
            try
            {
                if (!Directory.Exists(coverFolder))
                {
                    Directory.CreateDirectory(coverFolder);
                }

                string coverPath = Path.Combine(coverFolder, currentPlaylistName + ".png");

                // Custom cover selected by user
                if (File.Exists(coverPath))
                {
                    using (Image tempImage = Image.FromFile(coverPath))
                    {
                        pbxCover.Image = new Bitmap(tempImage);
                    }

                    pbxCover.SizeMode = PictureBoxSizeMode.StretchImage;

                    currentPlaylist.CoverPath = coverPath;

                    SavePlaylist();
                }
                else
                {
                    // Correct default cover
                    Image defaultImage = GetDefaultCover();

                    if (defaultImage != null)
                    {
                        pbxCover.Image = new Bitmap(defaultImage);
                    }

                    pbxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Playlist cover could not be loaded: " + ex.Message);
            }
        }

        // Allows user to replace playlist cover
        private void btnUpdateCover_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(coverFolder))
                {
                    Directory.CreateDirectory(coverFolder);
                }

                OpenFileDialog openCover = new OpenFileDialog();

                openCover.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openCover.ShowDialog() == DialogResult.OK)
                {
                    using (Image tempImage = Image.FromFile(openCover.FileName))
                    {
                        pbxCover.Image = new Bitmap(tempImage);
                    }

                    pbxCover.SizeMode = PictureBoxSizeMode.StretchImage;

                    string coverPath = Path.Combine(coverFolder, currentPlaylistName + ".png");

                    // Save user's custom cover
                    pbxCover.Image.Save(coverPath);

                    currentPlaylist.CoverPath = coverPath;

                    SavePlaylist();

                    MessageBox.Show("Playlist cover updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cover image could not be saved: " + ex.Message);
            }
        }

        // Returns to Homepage and stops music
        private void btnBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = "";

            this.Close();
        }

        // Stops music if form is closed using X
        private void frmPlaylistPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = "";
            }
            catch (Exception)
            {

            }
        }

        
        private void pbxPlaylistCover_Click(object sender, EventArgs e)
        {

        }

        private void lblCreationDate_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}