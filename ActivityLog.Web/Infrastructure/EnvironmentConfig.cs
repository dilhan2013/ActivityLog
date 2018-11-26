namespace ActivityLog.Web.Infrastructure
{
    public class EnvironmentConfig
    {
        public string SqlConnection { get; set; }
        public string S3BucketName { get; set; }
        public int HotStorageMaxRecordsPerObject { get; set; } = 20;
    }
}
