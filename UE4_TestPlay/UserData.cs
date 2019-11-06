using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_TestPlay
{
    public class UserData
    {
        public string DataName { get; set; } = "";

        public DirectryInfo ClientInfo { get; set; } = new DirectryInfo();

        public DirectryInfo ServerInfo { get; set; } = new DirectryInfo();

        public string MapInfo { get; set; } = "";

        public SettingOption Option { get; set; } = new SettingOption ();

    }

    public class SettingOption
    {
        public string IP { get; set; } = "";
        public int Port { get; set; } = 7777;
        public int ServerCount { get; set; } = 0;
        public int ClientCount { get; set; } = 0;
        public int WindowSizeX { get; set; } = 800;
        public int WindowSizeY { get; set; } = 600;
        public bool Log { get; set; } = true;
        public bool Cooked { get; set; } = false;
    }

    public class DirectryInfo
    {
        public string Name { get; set; } = "";
        public string Dir { get; set; } = "";
    }







}
