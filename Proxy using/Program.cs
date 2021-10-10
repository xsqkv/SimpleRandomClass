using System;

namespace Proxy_using
{
    class XRandom
    {
        long seed;   

        public XRandom(long Seed = 8999948999999248909)
        {
            seed = Seed;
        }

        #region Methods

        public sbyte SByte()
        {
            seed = (255 * 11) + (seed * 245);
            return (sbyte)seed;
        }
        public sbyte SByte(sbyte max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return (sbyte)(seed % max);
        }
        public sbyte SByte(sbyte min, sbyte max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            if (min < 0 && max < 0)
            {
                min += (sbyte)-1;
                return (sbyte)(-Math.Abs(seed % (min - max)) + max);
            }
            else
            {
                max += 1;
                return (sbyte)(Math.Abs(seed % (max - min)) + min);
            }
            return -1;
        }

        public short Short()
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return (short)seed;
        }
        public short Short(short max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return (short)(seed % max);
        }
        public short Short(short min, short max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            if (min < 0 && max < 0)
            {
                min += -1;
                return (short)(-Math.Abs(seed % (min - max)) + max);
            }
            else
            {
                max += 1;
                return (short)(Math.Abs(seed % (max - min)) + min);
            }
            return -1;
        }

        public int Int()
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return (int)seed;
        }
        public int Int(int max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return (int)(seed % max);
        }
        public int Int(int min, int max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            if (min < 0 && max < 0)
            {
                min += -1;
                return (int)(-Math.Abs(seed % (min - max)) + max);
            }
            else
            {
                max += 1;
                return (int)(Math.Abs(seed % (max - min)) + min);
            }
            return -1;
        }

        public long Long()
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return seed;
        }
        public long Long(long max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return seed % max;
        }
        public long Long(long min, long max)
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            if (min < 0 && max < 0)
            {
                min += -1;
                return -Math.Abs(seed % (min - max)) + max;
            }
            else
            {
                max += 1;
                return Math.Abs(seed % (max - min)) + min;
            }
            return -1;
        }

        public double Double()
        {
            seed = (932344257 * 6181531429) + (seed * 1245244333333);
            return Math.Abs((double)seed / (double)long.MaxValue);
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            sbyte a;
            short b;
            int c;
            long d;
            float e;
            double f;
            decimal g;
            bool h;

            byte aa;
            ushort bb;
            uint cc;
            ulong dd;

            XRandom rnd = new XRandom(63521);
            Random random = new Random();

            for (; ; )
            {
                Console.WriteLine(Math.Round(rnd.Double()));
                Console.ReadKey();
            }
        }
    }
}