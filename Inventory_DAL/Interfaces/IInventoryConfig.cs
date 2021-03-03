using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Inventory_DAL
{
    public interface IInventoryConfig
    {
        String SQLConnection { get; }
        String GetConnectionString(String Connection);
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
