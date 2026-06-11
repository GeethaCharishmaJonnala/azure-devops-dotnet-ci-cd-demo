namespace CiCdDemo.Api.Models;

public class DeploymentInfo
{
    public string ApplicationName { get; set; } = "";
    public string Environment { get; set; } = "";
    public string Version { get; set; } = "";
    public DateTime DeploymentDate { get; set; }
}