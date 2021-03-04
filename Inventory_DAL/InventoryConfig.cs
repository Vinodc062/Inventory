using Microsoft.Extensions.Configuration;
using System;

namespace Inventory_DAL
{
    public class InventoryConfig : IInventoryConfig
    {
     
        private readonly IConfiguration _configuration;

        public string SQLConnection
        {
            get
            {
                return this._configuration["ConnectionStrings:InventoryConnectionString"];
            }
        }

        public InventoryConfig(IConfiguration configuration)
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
