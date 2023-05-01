using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using VTS.Core;
/*using VTS.Models.Impl;
using VTS.Networking;
using VTS.Networking.Impl;*/

namespace VTS_Kinect
{
    /*class VTSHandler : VTSPlugin
    {
        public VTSHandler()
        {
            this._pluginAuthor = "Ryo";
            this._pluginName = "KinectVTS";
            this.Initialize(
                new VTSWebSocket(),
                new WebSocketImpl(),
                new JsonUtilityImpl(),
                new TokenStorageImpl(),
                () => { },
                () => { },
                () => { });
        }

        public void Close()
        {
            this.Socket.Close();
        }
    }*/

    class VTSHandler
    {
        CoreVTSPlugin plugin;
        public VTSHandler()
        {
            IVTSLogger logger = new ConsoleVTSLoggerImpl();
            plugin = new CoreVTSPlugin(logger,10,"KinectVTS","Ryo",null);
            plugin.Initialize(new WebSocketSharpImpl(logger), new NewtonsoftJsonUtilityImpl(), new TokenStorageImpl(Application.LocalUserAppDataPath), 
                () => { },
                () => { },
                onError);
        }
        private void onError(VTSErrorData error)
        {

        }

        public void Close()
        {
            plugin.Dispose();
        }
    }
}
