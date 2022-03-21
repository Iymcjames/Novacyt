namespace NovacytMapIntegration.Models
{
    public class Location
    {
        public string Title { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public Location(string title, double lat, double longi)
        {
            Title = title;
            Lat = lat;
            Long = longi;
        }
    }
}
