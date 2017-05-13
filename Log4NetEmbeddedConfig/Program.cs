using log4net;
using log4net.Config;

using System.Reflection;

namespace Log4NetEmbeddedConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            XmlConfigurator.Configure(
                assembly.GetManifestResourceStream("Log4NetEmbeddedConfig.Config.log.xml")
            );

            ILog logger = LogManager.GetLogger(typeof(Program));
            logger.Debug("Hello World");
        }
    }
}
