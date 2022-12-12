using LogicAPI.Server;
using System.Reflection;

namespace HMM.Server
{
    public class HMM_ServerMod : ServerMod
    {
        protected override void Initialize()
        {
            Logger.Info("HMM Initialized");
        }
    }
}
