using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JamSess
{
    public class PlaylistData
    {// Save playlist to file
        public static void SavePlaylist(Playlist playlist, string filePath)
        {
            FileStream outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(outFile, playlist);

            outFile.Close();
        }

        // Load playlist from file
        public static Playlist LoadPlaylist(string filePath)
        {
            FileStream inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            BinaryFormatter formatter = new BinaryFormatter();

            Playlist playlist = (Playlist)formatter.Deserialize(inFile);

            inFile.Close();

            return playlist;
        }
    }
}