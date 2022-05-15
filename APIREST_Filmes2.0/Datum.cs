namespace QuickType
{
    public partial class Datum
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public Datum[] Data { get; set; }
    }
}

