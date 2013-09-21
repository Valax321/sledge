using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Sledge.DataStructures.Geometric;

namespace Sledge.Providers
{
    public static class BinaryExtensions
    {
        public static string ReadFixedLengthString(this BinaryReader br, Encoding encoding, int length)
        {
            var bstr = br.ReadBytes(length).TakeWhile(b => b != 0).ToArray();
            return encoding.GetString(bstr);
        }

        public static void WriteFixedLengthString(this BinaryWriter bw, Encoding encoding, int length, string str)
        {
            var arr = new byte[length];
            encoding.GetBytes(str, 0, str.Length, arr, 0);
            bw.Write(arr, 0, length);
        }

        public static byte[] ReadByteArray(this BinaryReader br, int num)
        {
            var arr = new byte[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadByte();
            return arr;
        }

        public static short[] ReadShortArray(this BinaryReader br, int num)
        {
            var arr = new short[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadInt16();
            return arr;
        }

        public static int[] ReadIntArray(this BinaryReader br, int num)
        {
            var arr = new int[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadInt32();
            return arr;
        }

        public static decimal[] ReadSingleArrayAsDecimal(this BinaryReader br, int num)
        {
            var arr = new decimal[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadSingleAsDecimal();
            return arr;
        }

        public static float[] ReadSingleArray(this BinaryReader br, int num)
        {
            var arr = new float[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadSingle();
            return arr;
        }

        public static Coordinate[] ReadCoordinateArray(this BinaryReader br, int num)
        {
            var arr = new Coordinate[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadCoordinate();
            return arr;
        }

        public static CoordinateF[] ReadCoordinateFArray(this BinaryReader br, int num)
        {
            var arr = new CoordinateF[num];
            for (var i = 0; i < num; i++) arr[i] = br.ReadCoordinateF();
            return arr;
        }

        public static string ReadVariableLengthString(this BinaryReader br)
        {
            return br.ReadString().Trim('\0');
        }

        const int MaxVariableStringLength = 248;

        public static void WriteVariableLengthString(this BinaryWriter bw, string str)
        {
            // RMF strings can't be more than Byte.MaxValue characters long (including the null terminator).
            // Though Hammer crashes at 250 characters, so it must be doing something odd.
            if (str == null) str = "";
            if (str.Length > MaxVariableStringLength) str = str.Substring(0, MaxVariableStringLength);
            bw.Write(str + '\0');
        }


        public static decimal ReadSingleAsDecimal(this BinaryReader br)
        {
            return (decimal) br.ReadSingle();
        }

        public static void WriteDecimalAsSingle(this BinaryWriter bw, decimal dec)
        {
            bw.Write((float) dec);
        }

        public static Coordinate ReadCoordinate(this BinaryReader br)
        {
            return new Coordinate(
                br.ReadSingleAsDecimal(),
                br.ReadSingleAsDecimal(),
                br.ReadSingleAsDecimal()
                );
        }

        public static CoordinateF ReadCoordinateF(this BinaryReader br)
        {
            return new CoordinateF(
                br.ReadSingle(),
                br.ReadSingle(),
                br.ReadSingle()
                );
        }

        public static void WriteCoordinate(this BinaryWriter bw, Coordinate c)
        {
            bw.WriteDecimalAsSingle(c.X);
            bw.WriteDecimalAsSingle(c.Y);
            bw.WriteDecimalAsSingle(c.Z);
        }

        public static void WriteCoordinateF(this BinaryWriter bw, CoordinateF c)
        {
            bw.Write(c.X);
            bw.Write(c.Y);
            bw.Write(c.Z);
        }

        public static Plane ReadPlane(this BinaryReader br)
        {
            return new Plane(
                ReadCoordinate(br),
                ReadCoordinate(br),
                ReadCoordinate(br)
                );
        }

        public static void WritePlane(this BinaryWriter bw, Coordinate[] coords)
        {
            WriteCoordinate(bw, coords[0]);
            WriteCoordinate(bw, coords[1]);
            WriteCoordinate(bw, coords[2]);
        }

        public static Color ReadRGBColour(this BinaryReader br)
        {
            return Color.FromArgb(255, br.ReadByte(), br.ReadByte(), br.ReadByte());
        }

        public static void WriteRGBColour(this BinaryWriter bw, Color c)
        {
            bw.Write(c.R);
            bw.Write(c.G);
            bw.Write(c.B);
        }

        public static Color ReadRGBAColour(this BinaryReader br)
        {
            var r = br.ReadByte();
            var g = br.ReadByte();
            var b = br.ReadByte();
            var a = br.ReadByte();
            return Color.FromArgb(a, r, g, b);
        }

        public static void WriteRGBAColour(this BinaryWriter bw, Color c)
        {
            bw.Write(c.R);
            bw.Write(c.G);
            bw.Write(c.B);
            bw.Write(c.A);
        }
    }
}