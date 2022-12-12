using LogicAPI.Server;
using System.Reflection;

namespace TMC.Server
{
    public class TMC_ServerMod : ServerMod
    {
        protected override void Initialize()
        {
            Logger.Info("TMC Initialized");
        }
    }
}
