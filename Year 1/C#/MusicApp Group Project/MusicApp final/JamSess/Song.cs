using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JamSess
{
    [Serializable]
    public class Song
    {
        private string mName;
        private string mArtist;
        private string mAlbum;
        private string mGenre;
        private string mFilePath;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Artist
        {
            get { return mArtist; }
            set { mArtist = value; }
        }

        public string Album
        {
            get { return mAlbum; }
            set { mAlbum = value; }
        }

        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }

        public string FilePath
        {
            get { return mFilePath; }
            set { mFilePath = value; }
        }

        public Song()
        {
            mName = "";
            mArtist = "";
            mAlbum = "";
            mGenre = "";
            mFilePath = "";
        }

        public Song(string name, string artist, string album,
                    string genre, string filePath)
        {
            mName = name;
            mArtist = artist;
            mAlbum = album;
            mGenre = genre;
            mFilePath = filePath;
        }
    }
}