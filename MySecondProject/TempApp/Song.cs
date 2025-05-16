using System;

namespace StaticClassAttributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        // This is a constructor
        // Anything a song instance/object gets created,
        // this constructor gets called:
        // That's a garanteed.
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}