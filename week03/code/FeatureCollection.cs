public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }

}
// Each feature object contains information about an earthquake
public class Feature
{
    public Properties Properties { get; set; }
}

// Properties of each earthquake, such as location and magnitude
public class Properties
{
    public string Place { get; set; }
    public double? Mag { get; set; } // Nullable to handle missing magnitude values
}