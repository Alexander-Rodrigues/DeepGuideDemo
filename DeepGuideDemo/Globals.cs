using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DeepGuideDemo
{
    public class Globals
    {
        private static readonly string configPath = "config.json";

        public string input;
        public string output;
        public string hrtf;

        public Globals()
        {
            input = "sounds/ring3.wav";
            output = "sounds/output.wav";
            hrtf = "hrtf/irc_1037.sofa";
        }
        public Globals(string input, string output, string hrtf)
        {
            this.input = input;
            this.output = output;
            this.hrtf = hrtf;
        }

        public Globals(Globals g)
        {
            this.input = g.input;
            this.output = g.output;
            this.hrtf = g.hrtf;
        }

        public static Globals load()
        {
            string str = File.ReadAllText(configPath);
            try
            {
                Globals inG = JsonConvert.DeserializeObject<Globals>(str);
                return inG;
            }
            catch (Exception)
            {
                new Globals().Save();
            }
            return null;
        }

        public bool Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            try
            {
                File.WriteAllText(configPath, json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
