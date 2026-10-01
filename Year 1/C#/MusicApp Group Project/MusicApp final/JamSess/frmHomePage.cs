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
    public partial class frmHomePage : Form
    {
        // Stores logged-in user's details
        string currentName;
        string currentUsername;

        // Each user has their own playlist folder
        string playlistFolder;

        // Activity text file
        string activityFile;

        // Folder where profile pictures are stored
        string userImageFolder = Path.Combine(Application.StartupPath, "UserImages");

        // Stores all Playlist objects
        List<Playlist> playlists = new List<Playlist>();

        private const int MaxGenres = 50;

        public frmHomePage(string name, string username)
        {
            InitializeComponent();

            currentName = name;
            currentUsername = username;

            playlistFolder = Path.Combine(Application.StartupPath, "Playlists", currentUsername);
            activityFile = Path.Combine(playlistFolder, "ActivityLog.txt");

            lblWelcome.Text = "Welcome, " + currentUsername + "!";
            lblName.Text = currentName;
            lblUsername.Text = currentUsername;
        }

        
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            try
            {
                bool newUserFolder = false;

                if (!Directory.Exists(playlistFolder))
                {
                    Directory.CreateDirectory(playlistFolder);
                    newUserFolder = true;
                }

                if (!Directory.Exists(userImageFolder))
                {
                    Directory.CreateDirectory(userImageFolder);
                }

                // Default playlists are created only once for a new account
                if (newUserFolder == true)
                {
                    CreateDefaultPlaylists();
                }

                LoadProfilePicture();
                LoadPlaylists();
                DisplayPlaylistCovers();
                DisplayStatistics();

                WriteActivity(currentUsername + " logged in.");
                string previousActivity = ReadActivity();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load homepage: " + ex.Message);
            }
        }

        // Writes activity to a text file
        private void WriteActivity(string activity)
        {
            try
            {
                StreamWriter writer = new StreamWriter(activityFile, true);
                writer.WriteLine(activity);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Activity could not be saved: " + ex.Message);
            }
        }

        // Reads activity from a text file
        private string ReadActivity()
        {
            try
            {
                if (File.Exists(activityFile))
                {
                    StreamReader reader = new StreamReader(activityFile);
                    string activity = reader.ReadToEnd();
                    reader.Close();

                    return activity;
                }

                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        // Creates the three default playlists
        private void CreateDefaultPlaylists()
        {
            try
            {
                string[] defaultPlaylists = { "Chill Mix", "Study Music", "Rock Classics" };

                for (int i = 0; i < defaultPlaylists.Length; i++)
                {
                    string filePath = Path.Combine(playlistFolder, defaultPlaylists[i] + ".ser");

                    if (!File.Exists(filePath))
                    {
                        Playlist newPlaylist = new Playlist(defaultPlaylists[i]);
                        SavePlaylist(newPlaylist);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Default playlists could not be created: " + ex.Message);
            }
        }

        // Saves a Playlist object
        private void SavePlaylist(Playlist playlist)
        {
            try
            {
                string filePath = Path.Combine(playlistFolder, playlist.Name + ".ser");

                FileStream outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(outFile, playlist);

                outFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Playlist could not be saved: " + ex.Message);
            }
        }

        // Reads a Playlist object
        private Playlist ReadPlaylist(string filePath)
        {
            try
            {
                FileStream inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();

                Playlist playlist = (Playlist)formatter.Deserialize(inFile);

                inFile.Close();

                return playlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Playlist could not be opened: " + ex.Message);
                return null;
            }
        }

        // Loads all playlists belonging to current user
        private void LoadPlaylists()
        {
            try
            {
                playlists.Clear();

                string[] files = Directory.GetFiles(playlistFolder, "*.ser");

                for (int i = 0; i < files.Length; i++)
                {
                    Playlist playlist = ReadPlaylist(files[i]);

                    if (playlist != null)
                    {
                        playlists.Add(playlist);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Playlists could not be loaded: " + ex.Message);
            }
        }

        // Returns the correct default image for each playlist
        
        private Image GetDefaultCover(string playlistName)
        {
            Image coverImage = null;

            if (playlistName == "Chill Mix")
            {
                coverImage = Properties.Resources.ResourceManager.GetObject("chill music cover") as Image;
            }
            else if (playlistName == "Study Music")
            {
                coverImage = Properties.Resources.ResourceManager.GetObject("study music cover") as Image;
            }
            else if (playlistName == "Rock Classics")
            {
                coverImage = Properties.Resources.ResourceManager.GetObject("rock music cover") as Image;
            }
            else
            {
                coverImage = Properties.Resources.ResourceManager.GetObject("no_cover") as Image;
            }

            if (coverImage == null)
            {
                coverImage = Properties.Resources.ResourceManager.GetObject("no_cover") as Image;
            }

            return coverImage;
        }
        // Displays playlist covers in the FlowLayoutPanel
        private void DisplayPlaylistCovers()
        {
            try
            {
                flpRecents.Controls.Clear();

                string coverFolder = Path.Combine(playlistFolder, "Covers");

                if (!Directory.Exists(coverFolder))
                {
                    Directory.CreateDirectory(coverFolder);
                }

                for (int i = 0; i < playlists.Count; i++)
                {
                    PictureBox pbxPlaylist = new PictureBox();

                    pbxPlaylist.Width = 190;
                    pbxPlaylist.Height = 170;
                    pbxPlaylist.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxPlaylist.BorderStyle = BorderStyle.FixedSingle;
                    pbxPlaylist.Margin = new Padding(5);
                    pbxPlaylist.Cursor = Cursors.Hand;
                    pbxPlaylist.Tag = playlists[i].Name;

                    string coverPath = Path.Combine(
                        coverFolder,
                        playlists[i].Name + ".png"
                    );

                    // A user-selected cover always takes priority
                    if (File.Exists(coverPath))
                    {
                        using (Image tempImage = Image.FromFile(coverPath))
                        {
                            pbxPlaylist.Image = new Bitmap(tempImage);
                        }
                    }
                    else
                    {
                        // Otherwise use the correct default image
                        Image defaultCover = GetDefaultCover(playlists[i].Name);

                        if (defaultCover != null)
                        {
                            pbxPlaylist.Image = new Bitmap(defaultCover);
                        }
                    }

                    pbxPlaylist.Click += PlaylistCover_Click;

                    flpRecents.Controls.Add(pbxPlaylist);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not display playlist covers: " + ex.Message);
            }
        }

        // Opens the playlist represented by the clicked cover
        private void PlaylistCover_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox selectedCover = (PictureBox)sender;

                string playlistName = selectedCover.Tag.ToString();

                OpenPlaylistByName(playlistName, selectedCover.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open playlist: " + ex.Message);
            }
        }

        // Checks if a playlist already exists
        private bool PlaylistExists(string playlistName)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (playlists[i].Name.ToLower() == playlistName.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        // Creates a new playlist
        private void btnCreatePlaylist_Click_1(object sender, EventArgs e)
        {
            try
            {
                string playlistName = txtPlaylistName.Text.Trim();

                if (playlistName == "")
                {
                    MessageBox.Show("Please enter a playlist name.");
                    return;
                }

                if (playlistName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    MessageBox.Show("The playlist name contains invalid characters.");
                    return;
                }

                if (PlaylistExists(playlistName))
                {
                    MessageBox.Show("A playlist with this name already exists.");
                    return;
                }

                Playlist newPlaylist = new Playlist(playlistName);

                playlists.Add(newPlaylist);

                SavePlaylist(newPlaylist);

                WriteActivity("Playlist created: " + playlistName);

                // User-created playlists will use no_cover
                DisplayPlaylistCovers();
                DisplayStatistics();

                txtPlaylistName.Clear();

                MessageBox.Show("Playlist created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Playlist could not be created: " + ex.Message);
            }
        }

        // Opens a playlist by name
        private void OpenPlaylistByName(string playlistName, Image coverImage)
        {
            try
            {
                string filePath = Path.Combine(playlistFolder, playlistName + ".ser");

                if (File.Exists(filePath))
                {
                    frmPlaylistPage playlist = new frmPlaylistPage(
                        playlistName,
                        filePath,
                        coverImage
                    );

                    playlist.ShowDialog();

                    // Refresh Homepage after returning
                    LoadPlaylists();
                    DisplayPlaylistCovers();
                    DisplayStatistics();
                }
                else
                {
                    MessageBox.Show("Playlist not found.");

                    LoadPlaylists();
                    DisplayPlaylistCovers();
                    DisplayStatistics();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open playlist: " + ex.Message);
            }
        }

        // Browse current user's playlists
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openPlaylist = new OpenFileDialog();

                openPlaylist.Title = "Select Playlist";
                openPlaylist.InitialDirectory = playlistFolder;
                openPlaylist.Filter = "Playlist Files|*.ser";

                if (openPlaylist.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = Path.GetDirectoryName(openPlaylist.FileName);

                    // Prevent another user's playlist being opened
                    if (selectedFolder != playlistFolder)
                    {
                        MessageBox.Show("Please select one of your own playlists.");
                        return;
                    }

                    Playlist selectedPlaylist = ReadPlaylist(openPlaylist.FileName);

                    if (selectedPlaylist != null)
                    {
                        Image coverImage = GetPlaylistCover(selectedPlaylist.Name);

                        frmPlaylistPage playlist = new frmPlaylistPage(
                            selectedPlaylist.Name,
                            openPlaylist.FileName,
                            coverImage
                        );

                        playlist.ShowDialog();

                        LoadPlaylists();
                        DisplayPlaylistCovers();
                        DisplayStatistics();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open playlist: " + ex.Message);
            }
        }

        // Gets either a custom cover or the correct default cover
        private Image GetPlaylistCover(string playlistName)
        {
            try
            {
                string coverFolder = Path.Combine(playlistFolder, "Covers");
                string coverPath = Path.Combine(coverFolder, playlistName + ".png");

                if (File.Exists(coverPath))
                {
                    using (Image tempImage = Image.FromFile(coverPath))
                    {
                        return new Bitmap(tempImage);
                    }
                }

                Image defaultCover = GetDefaultCover(playlistName);

                if (defaultCover != null)
                {
                    return new Bitmap(defaultCover);
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Logs user out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo
            );

            if (answer == DialogResult.Yes)
            {
                WriteActivity(currentUsername + " logged out.");

                frmLoginPage login = new frmLoginPage();

                login.Show();

                this.Close();
            }
        }

        // Loads saved profile picture
        private void LoadProfilePicture()
        {
            try
            {
                string imagePath = Path.Combine(
                    userImageFolder,
                    currentUsername + ".png"
                );

                if (File.Exists(imagePath))
                {
                    using (Image tempImage = Image.FromFile(imagePath))
                    {
                        pbxUser.Image = new Bitmap(tempImage);
                    }

                    pbxUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile picture could not be loaded: " + ex.Message);
            }
        }

        // Changes and saves profile picture
        private void btnChangeIcon_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openImage = new OpenFileDialog();

                openImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    using (Image tempImage = Image.FromFile(openImage.FileName))
                    {
                        pbxUser.Image = new Bitmap(tempImage);
                    }

                    pbxUser.SizeMode = PictureBoxSizeMode.StretchImage;

                    string imagePath = Path.Combine(
                        userImageFolder,
                        currentUsername + ".png"
                    );

                    pbxUser.Image.Save(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image could not be saved: " + ex.Message);
            }
        }

        // Calculates and displays Homepage statistics
        private void DisplayStatistics()
        {
            try
            {
                string[,] genreStats = new string[MaxGenres, 2];

                int genreCount = 0;
                int totalTracks = 0;

                for (int i = 0; i < playlists.Count; i++)
                {
                    for (int j = 0; j < playlists[i].Songs.Count; j++)
                    {
                        totalTracks++;

                        string genre = playlists[i].Songs[j].Genre.Trim();

                        if (genre == "")
                        {
                            genre = "Unknown";
                        }

                        bool found = false;

                        for (int g = 0; g < genreCount; g++)
                        {
                            if (genreStats[g, 0] == genre)
                            {
                                int currentCount = Convert.ToInt32(genreStats[g, 1]);

                                currentCount++;

                                genreStats[g, 1] = currentCount.ToString();

                                found = true;

                                break;
                            }
                        }

                        if (found == false && genreCount < MaxGenres)
                        {
                            genreStats[genreCount, 0] = genre;
                            genreStats[genreCount, 1] = "1";

                            genreCount++;
                        }
                    }
                }

                string topGenre = "N/A";
                int topCount = 0;

                for (int g = 0; g < genreCount; g++)
                {
                    int count = Convert.ToInt32(genreStats[g, 1]);

                    if (count > topCount)
                    {
                        topCount = count;
                        topGenre = genreStats[g, 0];
                    }
                }

                lblLists.Text = playlists.Count.ToString();
                lblTracks.Text = totalTracks.ToString();
                lblTopGenre.Text = topGenre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not calculate statistics: " + ex.Message);
            }
        }

        // Opens Upload Song form
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlists.Count == 0)
                {
                    MessageBox.Show("Please create a playlist first.");
                    return;
                }

                frmUploadSong uploadSong = new frmUploadSong(playlistFolder);

                uploadSong.ShowDialog();

                WriteActivity("Upload Song page opened.");

                LoadPlaylists();
                DisplayPlaylistCovers();
                DisplayStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload page could not be opened: " + ex.Message);
            }
        }

        
        private void pbxChillMix_Click(object sender, EventArgs e)
        {

        }

        private void pbxStudyMusic_Click_1(object sender, EventArgs e)
        {

        }

        private void pbxRockClassics_Click(object sender, EventArgs e)
        {

        }
    }
}