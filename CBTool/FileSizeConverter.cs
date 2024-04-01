using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBTool
{
    internal class FileSizeConverter
    {
        public enum FileSizeUnit
        {
            Byte,
            KB,
            MB,
            GB,
            TB
        }

        private const double KilobyteToByteFactor = 1024.0;
        private const double MegabyteToByteFactor = KilobyteToByteFactor * 1024.0;
        private const double GigabyteToByteFactor = MegabyteToByteFactor * 1024.0;
        private const double TerabyteToByteFactor = GigabyteToByteFactor * 1024.0;

        public static string ConvertFileSize(long sizeInBytes)
        {
            double convertedSize = sizeInBytes;

            FileSizeUnit unit = FileSizeUnit.Byte;
            if (convertedSize >= TerabyteToByteFactor)
            {
                convertedSize /= TerabyteToByteFactor;
                unit = FileSizeUnit.TB;
            }
            else if (convertedSize >= GigabyteToByteFactor)
            {
                convertedSize /= GigabyteToByteFactor;
                unit = FileSizeUnit.GB;
            }
            else if (convertedSize >= MegabyteToByteFactor)
            {
                convertedSize /= MegabyteToByteFactor;
                unit = FileSizeUnit.MB;
            }
            else if (convertedSize >= KilobyteToByteFactor)
            {
                convertedSize /= KilobyteToByteFactor;
                unit = FileSizeUnit.KB;
            }

            return $"{Math.Round(convertedSize, 2)} {unit.ToString().ToUpper()}";
        }
    }
}
