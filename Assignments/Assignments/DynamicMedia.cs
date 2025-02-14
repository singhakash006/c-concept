using System;
using static Assignments.PodcastPlayer;

namespace Assignments
{
    // Interface definition
    public interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        string GetMediaInfo();
    }

    // Class implementing the interface
    public class MusicPlayer : IMediaPlayer
    {
        private string songName;
        private string artistName;

        // Constructor to initialize song name
        public MusicPlayer(string song, string artist)
        {
            this.songName = song;
            this.artistName = artist;
        }

        // Implementing interface methods
        public void Play()
        {
            Console.WriteLine($"Playing: {songName} by {artistName} ");
        }

        public void Pause()
        {
            Console.WriteLine($"Paused: {songName} by {artistName}");

        }

        public void Stop()
        {
            Console.WriteLine($"Stopped playing: {songName} by {artistName}");
        }

        public string GetMediaInfo()
        {
            return $"Current Song: {songName} by {artistName}";
        }
    }

    // Class implementing the interface
    public class VideoPlayer : IMediaPlayer
    {
        private string video_name;
        private string video_artist;


        // Constructor to initialize video name
        public VideoPlayer(string video_name, string video_artist)
        {
            this.video_name = video_name;
            this.video_artist = video_artist;
        }

        public void Play()
        {
            Console.WriteLine($"Playing Video: {video_name} by {video_artist}");
        }

        public void Pause()
        {
            Console.WriteLine($"Paused: {video_name} by {video_artist}");

        }

        public void Stop()
        {
            Console.WriteLine($"Stopped playing: {video_name} by {video_artist}");
        }

        public string GetMediaInfo()
        {
            return $"Current Video: {video_name} by {video_artist}";
        }

    }

    // class implementing the interface
    public class PodcastPlayer : IMediaPlayer
    {
        private string podcast_name;
        private string podcast_artist;


        // Constructor to initialize Podcast name
        public PodcastPlayer(string podcast_name, string podcast_artist)
        {
            this.podcast_name = podcast_name;
            this.podcast_artist = podcast_artist;
        }

        public void Play()
        {
            Console.WriteLine($"Playing Podcast: {podcast_name} by {podcast_artist}");
        }

        public void Pause()
        {
            Console.WriteLine($"Paused: {podcast_name} by {podcast_artist}");

        }

        public void Stop()
        {
            Console.WriteLine($"Stopped playing: {podcast_name} by {podcast_artist}");
        }

        public string GetMediaInfo()
        {
            return $"Current Podcast: {podcast_name} by {podcast_artist}";
        }
    }


    public class PlaylistManager
    {
        //Array Implementation to run all the platforms
        public void PlayAll(IMediaPlayer[] mediaPlayers)
        {

            foreach (var player in mediaPlayers)
            {
                player.Play();
            }
        }
            public void PauseAll(IMediaPlayer[] mediaPlayers)
        {

            foreach (var player in mediaPlayers)
            {
                player.Pause();
            }
        }
        public void StopAll(IMediaPlayer[] mediaPlayers)
        {

            foreach (var player in mediaPlayers)
            {
                player.Stop();
            }
        }
        public void GetMediaInfoAll(IMediaPlayer[] mediaPlayers)
        {

            foreach (var player in mediaPlayers)
            {
                player.GetMediaInfo();
            }
        }
    }
    



    internal class DynamicMedia
    {
        public static void Main(string[] args)
        {
            /*IMediaPlayer[] mediaPlayer = {new MusicPlayer("Shape of You", "Ed Sheeran"),
                new VideoPlayer("Inception", "Warner Bros"),
                new PodcastPlayer("Tech Trends", "2025") };
            PlaylistManager caller = new PlaylistManager();
            caller.Playing(mediaPlayer);
            */
            IMediaPlayer[] mediaPlayers =
            {
                new MusicPlayer("Shape of You", "Ed Sheeran"),
                new VideoPlayer("Inception", "Christopher Nolan"),
                new PodcastPlayer("Tech Trends", "John Doe")
            };

            PlaylistManager manager = new PlaylistManager();

            // Play all media
            manager.PlayAll(mediaPlayers);
            Console.WriteLine();


        }
    }




}

