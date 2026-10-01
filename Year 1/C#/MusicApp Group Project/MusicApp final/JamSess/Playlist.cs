using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JamSess
{
    [Serializable]
    public class Playlist
    {
        private string mName;
        private DateTime mCreationDate;
        private string mCoverPath;
        private List<Song> mSongs;
        private int mFavouriteSlot;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public DateTime CreationDate
        {
            get { return mCreationDate; }
            set { mCreationDate = value; }
        }

        public string CoverPath
        {
            get { return mCoverPath; }
            set { mCoverPath = value; }
        }

        public List<Song> Songs
        {
            get { return mSongs; }
            set { mSongs = value; }
        }

        // 0 = not favourite, 1-3 = favourite position
        public int FavouriteSlot
        {
            get { return mFavouriteSlot; }
            set { mFavouriteSlot = value; }
        }

        public int TrackCount
        {
            get { return mSongs.Count; }
        }

        public Playlist()
        {
            mName = "";
            mCreationDate = DateTime.Now;
            mCoverPath = "";
            mSongs = new List<Song>();
            mFavouriteSlot = 0;
        }

        public Playlist(string name)
        {
            mName = name;
            mCreationDate = DateTime.Now;
            mCoverPath = "";
            mSongs = new List<Song>();
            mFavouriteSlot = 0;
        }
    }
}