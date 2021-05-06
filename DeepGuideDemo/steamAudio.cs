using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DeepGuideDemo
{
    public static class steamAudio
    {
        [DllImport("steam.dll")]
        public static extern void info();

        [DllImport("steam.dll")]
        public static extern void settings(string input, string output, string sofa);

        [DllImport("steam.dll")]
        public static extern void init();

        [DllImport("steam.dll")]
        public static extern void create(float yaw, float pitch, float distance);

        [DllImport("steam.dll")]
        public static extern void play();

        [DllImport("steam.dll")]
        public static extern void ogCreate(float leftRight, float downUp, float frontBack);

        [DllImport("steam.dll")]
        public static extern void stop();

        [DllImport("steam.dll")]
        public static extern void clean();

    }
}
