using System.IO;
using System.Reflection;

using log4net;
using log4net.Config;

namespace Log4NetEmbeddedConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream configStream = assembly.GetManifestResourceStream("Log4NetEmbeddedConfig.Config.log.xml"))
            {
                XmlConfigurator.Configure(configStream);
            }

            ILog logger = LogManager.GetLogger(typeof(Program));
            logger.Debug("Hello World");
        }
    }
}
