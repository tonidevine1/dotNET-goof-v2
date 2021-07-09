using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace dotNETGoofV2.Website
{
    public class ZipSlip
    {
        public void ExtractEntry(IEnumerator<ZipArchiveEntry> entriesEnumerator, string directory)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            string password = "ioefiuhsf8791234n";
            var entry = entriesEnumerator.Current;
            var path = Path.Combine(directory, entry.FullName);
            entry.ExtractToFile(path);
        }
    }
}
