using LogicAPI.Server;
using System.Reflection;

namespace TooManyComponents.Server
{
    public class TooManyComponents_ServerMod : ServerMod
    {
        protected override void Initialize()
        {
            Logger.Info("TooManyComponents Initialized");
        }
    }
}
