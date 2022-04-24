namespace ImagineMusic.Data
{
    public class MusicStreamerService
    {
        public Task<List<Track>> GetMusic()
        {
            return Task.FromResult(new List<Track>()
            {
                new Track() {Artist = "Syd Imagine", Title = "One Too Many Times", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Tell It Like It Is", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Coyote Moon", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Baby Doesn't Cry (For Me)", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Lonesome On My Mind", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Road Of Life", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Give Me Love", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "Beauty & Rust", Summary = ""},
                new Track() {Artist = "Syd Imagine", Title = "What Is This Love", Summary = ""}
            });
        }
    }
}