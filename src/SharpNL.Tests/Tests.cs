﻿using System.IO;
using System.Reflection;

namespace SharpNL.Tests {

    internal static class Tests {

        private static string resourcesPath = @"../../../../resources/";

        public static FileStream OpenSample(string fileName) {

            string path = Directory.GetCurrentDirectory();

            path = Path.Combine(path, resourcesPath, fileName.TrimStart('\\', '/'));
            path = Path.GetFullPath(path);
            
            if (!File.Exists(path)) {
                throw new FileNotFoundException("File not found :(", path);
            }

            return new FileStream(path, FileMode.Open, FileAccess.Read);
        }

    }
}
