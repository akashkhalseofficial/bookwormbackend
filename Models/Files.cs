namespace bookwormbackend.Models
{
    public class Files
    {
        public int Id { get; set; }

        public int bid { get; set; }
        public string FileName { get; set; }

        public string FileType { get; set; }

        public string ContentType { get; set; }

        public byte[] Content { get; set; }
    }
}
