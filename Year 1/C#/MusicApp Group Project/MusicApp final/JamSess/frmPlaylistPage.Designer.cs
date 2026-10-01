namespace JamSess
{
    partial class frmPlaylistPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaylistPage));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblTrackCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.btnUpdateCover = new System.Windows.Forms.Button();
            this.pbxCover = new System.Windows.Forms.PictureBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.MintCream;
            this.btnBack.Location = new System.Drawing.Point(8, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back To Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(24, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Song";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.MintCream;
            this.btnPlay.Location = new System.Drawing.Point(230, 168);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 27);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.MintCream;
            this.btnSort.Location = new System.Drawing.Point(24, 99);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(149, 27);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "Sort ";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSong.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.ForeColor = System.Drawing.Color.MintCream;
            this.btnDeleteSong.Location = new System.Drawing.Point(24, 59);
            this.btnDeleteSong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(149, 27);
            this.btnDeleteSong.TabIndex = 19;
            this.btnDeleteSong.Text = "Delete Song";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnDeletePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePlaylist.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlaylist.ForeColor = System.Drawing.Color.MintCream;
            this.btnDeletePlaylist.Location = new System.Drawing.Point(24, 137);
            this.btnDeletePlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(149, 27);
            this.btnDeletePlaylist.TabIndex = 20;
            this.btnDeletePlaylist.Text = "Delete Playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = false;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPlaylistName);
            this.panel1.Controls.Add(this.lblTrackCount);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblCreationDate);
            this.panel1.Controls.Add(this.btnUpdateCover);
            this.panel1.Controls.Add(this.pbxCover);
            this.panel1.Location = new System.Drawing.Point(8, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 219);
            this.panel1.TabIndex = 21;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistName.Location = new System.Drawing.Point(226, 24);
            this.lblPlaylistName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(145, 24);
            this.lblPlaylistName.TabIndex = 28;
            this.lblPlaylistName.Text = "Playlist Name";
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.AutoSize = true;
            this.lblTrackCount.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrackCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTrackCount.Location = new System.Drawing.Point(226, 89);
            this.lblTrackCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(67, 25);
            this.lblTrackCount.TabIndex = 27;
            this.lblTrackCount.Text = "0 Tracks";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnSort);
            this.panel3.Controls.Add(this.btnDeleteSong);
            this.panel3.Controls.Add(this.btnDeletePlaylist);
            this.panel3.Location = new System.Drawing.Point(384, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 188);
            this.panel3.TabIndex = 25;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreationDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCreationDate.Location = new System.Drawing.Point(226, 66);
            this.lblCreationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(104, 25);
            this.lblCreationDate.TabIndex = 23;
            this.lblCreationDate.Text = "Creation Date";
            this.lblCreationDate.Click += new System.EventHandler(this.lblCreationDate_Click);
            // 
            // btnUpdateCover
            // 
            this.btnUpdateCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(62)))));
            this.btnUpdateCover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCover.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCover.ForeColor = System.Drawing.Color.MintCream;
            this.btnUpdateCover.Location = new System.Drawing.Point(230, 138);
            this.btnUpdateCover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCover.Name = "btnUpdateCover";
            this.btnUpdateCover.Size = new System.Drawing.Size(123, 27);
            this.btnUpdateCover.TabIndex = 22;
            this.btnUpdateCover.Text = "Update Cover";
            this.btnUpdateCover.UseVisualStyleBackColor = false;
            this.btnUpdateCover.Click += new System.EventHandler(this.btnUpdateCover_Click);
            // 
            // pbxCover
            // 
            this.pbxCover.Image = global::JamSess.Properties.Resources.no_cover;
            this.pbxCover.Location = new System.Drawing.Point(13, 17);
            this.pbxCover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCover.Name = "pbxCover";
            this.pbxCover.Size = new System.Drawing.Size(200, 185);
            this.pbxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCover.TabIndex = 21;
            this.pbxCover.TabStop = false;
            this.pbxCover.Click += new System.EventHandler(this.pbxPlaylistCover_Click);
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.GridColor = System.Drawing.Color.Cornsilk;
            this.dgvSongs.Location = new System.Drawing.Point(2, 55);
            this.dgvSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersWidth = 62;
            this.dgvSongs.RowTemplate.Height = 28;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(603, 203);
            this.dgvSongs.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.flowLayoutPanel1.Controls.Add(this.dgvSongs);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 262);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 244);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 2);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(603, 49);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // frmPlaylistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(643, 523);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPlaylistPage";
            this.Text = "frmPlaylistPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateCover;
        private System.Windows.Forms.PictureBox pbxCover;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTrackCount;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}