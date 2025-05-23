﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpineViewer.Spine.Implementations.AltasConvertor
{
    public class AtlasConverter4X : SpineViewer.Spine.AtlasConverter
    {
        public override void ToFile(string path, List<Dictionary<string, Object>> images)
        {
            TextWriter writer = new StreamWriter(path);
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            foreach (var image in images)
            {
                string imgName = image.GetValueOrDefault("head") as string;
                writer.WriteLine(imgName);

                Dictionary<string, string> pages = image.GetValueOrDefault("pages") as Dictionary<string, string>;
                foreach (var i in pages)
                {
                    WriteElement(writer, i);
                }

                List<Dictionary<string, string>> regions = image.GetValueOrDefault("regions") as List<Dictionary<string, string>>;
                foreach (var i in regions)
                {
                    writer.WriteLine(i["name"]);
                    WriteElements(writer, i);
                }
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}
