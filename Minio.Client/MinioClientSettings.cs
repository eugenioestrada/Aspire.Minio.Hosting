namespace Minio.Client;

public sealed class MinioClientSettings
{
	public string Endpoint { get; set; }
	public string PrimaryEndpoint { get; set; }
	public string ConnectionString { get; set; }
}