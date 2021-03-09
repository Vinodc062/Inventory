using Microsoft.Extensions.Configuration;
using System;

namespace ProTracker_DAL
{
    public class ProTrackerConfig : IProTrackerConfig
    {
     
        private readonly IConfiguration _configuration;

        public string SQLConnection
        {
            get
            {
                return this._configuration["ConnectionStrings:ProTrackerConnectionString"];
            }
        }

        public ProTrackerConfig(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        //public string GetConnectionString()
        //{
        //    return this._configuration.GetConnectionString(SQLConnection);
        //}

        public IConfigurationSection GetConfigurationSection(string Key)
        {
            return this._configuration.GetSection(Key);
        }
    }
}
