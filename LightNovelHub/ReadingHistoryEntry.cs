using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightNovelHub
{
    public class ReadingHistoryEntry
    {
        public string FilePath { get; set; } = string.Empty;
        public int LastReadChapter { get; set; }
        public Image? CoverImage { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
