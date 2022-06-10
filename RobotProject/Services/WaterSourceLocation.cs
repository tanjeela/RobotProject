namespace RobotProject.Services
{
    public class Rootobject
{
    public WaterSourceLocation[] Property1 { get; set; }
}
public class WaterSourceLocation
{
    public int place_id { get; set; }
    public string licence { get; set; }
    public string osm_type { get; set; }
    public int osm_id { get; set; }
    public string[] boundingbox { get; set; }
    public string lat { get; set; }
    public string lon { get; set; }
    public string display_name { get; set; }
    public int place_rank { get; set; }
    public string category { get; set; }
    public string type { get; set; }
    public float importance { get; set; }
    public Geojson geojson { get; set; }

}
public class Geojson
{
    public string type { get; set; }
    public float[][][] coordinates { get; set; }
}

}
