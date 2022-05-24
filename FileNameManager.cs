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

        public bool IsMostlyLatin (String fileName)
        {
            var cc = fileName.ToCharArray ();
            var latinc = 0;

            foreach (char c in cc) {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) {
                    latinc++;
                }
            }

            return ((double) latinc / (double) cc.Length) > 0.5;
        }
    }
}
