using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public partial class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
