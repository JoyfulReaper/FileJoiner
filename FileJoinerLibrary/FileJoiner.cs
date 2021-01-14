/*
MIT License

Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileJoinerLibrary
{
    public static class FileJoiner
    {
        /// <summary>
        /// Joins Files
        /// </summary>
        /// <param name="files">List of files to join</param>
        /// <param name="outputFile">Output file path</param>
        public static void JoinFiles(List<FileInfo> files, string outputFile)
        {
            FileInfo output = new FileInfo(outputFile);
            FileStream fsOut = output.Create();

            foreach(FileInfo inputFile in files)
            {
                var fsIn = inputFile.Open(FileMode.Open);
                fsIn.CopyTo(fsOut);

                fsIn.Close();
            }

            fsOut.Close();
        }

        /// <summary>
        /// Joins Text Files
        /// </summary>
        /// <param name="files">Text files to join</param>
        /// <param name="numNewLines">Number of new lines to insert between files</param>
        /// <param name="outputFile">Output file path</param>
        public static void JoinTextFiles(List<FileInfo> files, int numNewLines, string outputFile)
        {
            FileInfo output = new FileInfo(outputFile);
            StreamWriter swOut = output.CreateText();

            foreach (FileInfo inputfile in files)
            {
                var srIn = inputfile.OpenText();
                swOut.Write(srIn.ReadToEnd());

                if(numNewLines >= 0)
                {
                    swOut.Write(string.Concat(Enumerable.Repeat(Environment.NewLine, 2)));
                }

                srIn.Close();
            }

            swOut.Close();
        }
    }
}
