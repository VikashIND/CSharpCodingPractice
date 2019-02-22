using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var loggger = new Logger();
            var migrator = new DbMigrator(loggger);
            var installer = new Installer(loggger);

            migrator.Migrate();
            installer.Install();
            System.Console.ReadKey();
        }
    }
}
