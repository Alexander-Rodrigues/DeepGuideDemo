using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DeepGuideDemo
{
    public abstract class Generator
    {
        public Vector2 rangeYaw;
        public Vector2 rangePitch;
        public Vector2 rangeDistane;
        public Random rand;
        public abstract Vector3 Generate();

        public string name;
    }

    public class DiscreteGeneratorX : Generator
    {
        float lr;
        float du;

        public DiscreteGeneratorX(float leftRight, float downUp)
        {
            lr = leftRight;
            du = downUp;
            name = "Discrete";
            rand = new Random();
        }

        public override Vector3 Generate()
        {
            return new Vector3(
                rand.Next(-1, 2) * lr,
                rand.Next(-1, 2) * du,
                -2f
                );
        }
    }

    public class ContinuousGeneratorX : Generator
    {
        float lr;
        float du;
        public ContinuousGeneratorX(float leftRight, float downUp)
        {
            lr = leftRight;
            du = downUp;
            name = "Continuous";
            rand = new Random();
        }

        public override Vector3 Generate()
        {
            return new Vector3(
                (float)(rand.NextDouble() - 0.5) * 2 * lr,
                (float)(rand.NextDouble() - 0.5) * 2 * du,

                - 2f
                ); ;
        }
    }

    public class DiscreteGenerator : Generator
    {   
        int div;

        float yawInterval;
        float pitchInterval;
        public DiscreteGenerator(float rangeYawX, float rangeYawY, float rangePitchX, float rangePitchY, float distance, int div = 3)
        {
            this.rangeYaw = new Vector2(rangeYawX, rangeYawY);
            this.rangePitch = new Vector2(rangePitchX, rangePitchY);
            this.rangeDistane = new Vector2(distance);
            rand = new Random();
            this.div = div;
            yawInterval = (rangeYaw.Y - rangeYaw.X) / (div - 1);
            pitchInterval = (rangePitch.Y - rangePitch.X) / (div - 1);
            this.name = "Discrete";
        }

        public override Vector3 Generate()
        {
            return new Vector3(
                rand.Next(0, div) * yawInterval + rangeYaw.X,
                rand.Next(0, div) * pitchInterval + rangePitch.X,
                rangeDistane.X//; * (rangeDistane.Y - rangeDistane.X) + rangeDistane.X
                );
        }
    }

    public class ContinuousGenerator : Generator
    {  
        public ContinuousGenerator(Vector2 rangeYaw, Vector2 rangePitch, Vector2 rangeDistance)
        {
            this.rangeYaw = rangeYaw;
            this.rangePitch = rangePitch;
            this.rangeDistane = rangeDistance;
            rand = new Random();
        }
        public ContinuousGenerator(Vector2 rangeYaw, Vector2 rangePitch, float distance)
        {
            this.rangeYaw = rangeYaw;
            this.rangePitch = rangePitch;
            this.rangeDistane = new Vector2(distance);
            rand = new Random();
        }
        public ContinuousGenerator(Tuple<float,float> rangeYaw, Tuple<float,float> rangePitch, float distance)
        {
            this.rangeYaw = new Vector2(rangeYaw.Item1, rangeYaw.Item2);
            this.rangePitch = new Vector2(rangePitch.Item1, rangePitch.Item2);
            this.rangeDistane = new Vector2(distance);
            rand = new Random();
        }
        public ContinuousGenerator(float rangeYawX, float rangeYawY, float rangePitchX, float rangePitchY, float distance)
        {
            this.rangeYaw = new Vector2(rangeYawX, rangeYawY);
            this.rangePitch = new Vector2(rangePitchX, rangePitchY);
            this.rangeDistane = new Vector2(distance);
            rand = new Random();
            this.name = "Continuous";
        }

        public override Vector3 Generate()
        {
            return new Vector3(
                (float)rand.NextDouble() * (rangeYaw.Y - rangeYaw.X) + rangeYaw.X,
                (float)rand.NextDouble() * (rangePitch.Y - rangePitch.X) + rangePitch.X,
                (float)rand.NextDouble() * (rangeDistane.Y - rangeDistane.X) + rangeDistane.X
                );
        }

    }
}
