using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Demos
{
    public static class ReadOnlyMembers
    {
        public static void Demo1()
        {
            var p = new PointV1 { X = 30, Y = 40 };
            Console.WriteLine(p);
        }

        public static void Demo2()
        {
            var p = new PointV2 { X = 30, Y = 40 };
            Console.WriteLine(p);
        }
    }

    /// <summary>
    /// Regular Point struct
    /// </summary>
    public struct PointV1
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X}, {Y} is {Distance} from the origin)";

        public void Translate(int xOffset, int yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }
    }

    /// <summary>
    /// Point struct that enforces Distance and ToString() will not change the state of the struct
    /// </summary>
    public struct PointV2
    {
        public double X { get; set; }
        public double Y { get; set; }
        readonly public double Distance => Math.Sqrt(X * X + Y * Y);

        readonly public override string ToString() => $"({X}, {Y} is {Distance} from the origin)";

        public void Translate(int xOffset, int yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }
    }
}
