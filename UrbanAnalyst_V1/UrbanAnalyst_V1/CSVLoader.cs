using UrbanMobilityAnalyzer.Models;

namespace UrbanMobilityAnalyzer.Services;

public class CsvLoader
{
    public List<GpsPoint> Load(string path)
    {
        var points = new List<GpsPoint>();

        var lines = File.ReadAllLines(path);


        for (int i = 1; i < lines.Length; i++)
        {
            var cols = lines[i].Split(',');

            var point = new GpsPoint
            {
                Timestamp = DateTime.Parse(cols[0]),
                Latitude = double.Parse(cols[1]),
                Longitude = double.Parse(cols[2])
            };

            points.Add(point);
        }

        return points;
    }
}