using System.IO;
using DiscUtils;
using DiscUtils.Udf;

// TODO: Do more interesting things here...

namespace BDInfo
{
    public class TSInterleavedFile
    {
        public DiscFileInfo DFileInfo = null;
        public UdfReader CdReader = null;

        public FileInfo FileInfo = null;
        public string Name = null;

        public TSInterleavedFile(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
            DFileInfo = null;
            CdReader = null;
            Name = fileInfo.Name.ToUpper();
        }

        public TSInterleavedFile(DiscFileInfo fileInfo,
            UdfReader reader)
        {
            DFileInfo = fileInfo;
            FileInfo = null;
            CdReader = reader;
            Name = fileInfo.Name.ToUpper();
        }
    }
}
