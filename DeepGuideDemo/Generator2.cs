using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
 Axis Legends
x -> frontBack
y -> downUp
z -> 
 */

namespace DeepGuideDemo
{
    enum axis
    {
        LR,
        DU,
        FB
    }
    class Generator2
    {
        

        float distance;
        float radius;
        axis axis;
        string output;
        static readonly float root = 0.707106f;

        List<Vector3> points = new List<Vector3>();

        public Generator2(float distance, float radius, axis a, string output="sounds/default/")
        {
            this.distance = distance;
            this.radius = radius;
            this.axis = a;
            this.output = output;

                        
        }

        public static void create(float distance, float radius, axis a, string output = "sounds/default/")
        {
            List<Vector3> list = new List<Vector3>();
            switch ( a ){
                case axis.LR:
                    list = axisLR(distance, radius);
                    break;
                case axis.DU:
                    list = axisDU(distance, radius);
                    break;
                case axis.FB:
                    list = axisFB(distance, radius);
                    break;
            }

            bool exists = System.IO.Directory.Exists(output);
            if (!exists)
                System.IO.Directory.CreateDirectory(output);

            Globals g = Globals.load();
            steamAudio.settings(g.input, g.output, g.hrtf);
            steamAudio.init();

            int i = 0;
            foreach (Vector3 v in list)
            {
                string name = output + i + ".wav";
                steamAudio.ogCreateX(v.X, v.Y, v.Z, name);
                i++;
            }
        }

        //Not done
        public static List<Vector3> axisLR(float d, float r)
        {
            List<Vector3> points = new List<Vector3>();
            points.Add(new Vector3(d, 0, 0));

             return points;
        }

        public static List<Vector3> axisDU(float d, float r)
        {
            float R = root * r;
            List<Vector3> points = new List<Vector3>();
            points.Add(new Vector3(-R, d, -R));
            points.Add(new Vector3(0, d, -r));
            points.Add(new Vector3(R, d, -R));
            points.Add(new Vector3(-r, d, 0));
            points.Add(new Vector3(0, d, 0));
            points.Add(new Vector3(r, d, 0));
            points.Add(new Vector3(-R, d, R));
            points.Add(new Vector3(0, d, r));
            points.Add(new Vector3(R, d, R));


            return points;
        }

        public static List<Vector3> axisFB(float d, float r)
        {
            float R = root * r;
            List<Vector3> points = new List<Vector3>();
            points.Add(new Vector3(-R, R, d));
            points.Add(new Vector3(0, r, d));
            points.Add(new Vector3(R, R, d));
            points.Add(new Vector3(-r, 0, d));
            points.Add(new Vector3(0, 0, d));
            points.Add(new Vector3(r, 0, d));
            points.Add(new Vector3(-R, -R, d));
            points.Add(new Vector3(0, -r, d));
            points.Add(new Vector3(R, -R, d));

            return points;
        }
    }
}
