using System.Configuration;

namespace Repository
{
    public sealed class Config
    {
        public static string LabConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Lab"].ConnectionString;
            }
        }
    }
}