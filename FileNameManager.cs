using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCommon
{
    public class FileNameManager
    {
        public String NormalizeFileName (String originalName)
        {
            return originalName
                .Replace ("-[rarbg.to]", "")
                .Replace ("[rarbg]", "");
        }
    }
}
