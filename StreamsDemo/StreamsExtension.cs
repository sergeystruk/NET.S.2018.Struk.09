using System;
using System.IO;
using System.Text;

namespace StreamsDemo
{
    // C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015
    // Chapter 15: Streams and I/O
    // Chapter 6: Framework Fundamentals - Text Encodings and Unicode
    // https://msdn.microsoft.com/ru-ru/library/system.text.encoding(v=vs.110).aspx

    public static class StreamsExtension
    {

        #region Public members

        #region TODO: Implement by byte copy logic using class FileStream as a backing store stream .

        public static int ByByteCopy(string sourcePath, string destinationPath)
        {
            FileStream inFileStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            FileStream outFileStream = new FileStream(destinationPath, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(inFileStream);
            BinaryWriter bw = new BinaryWriter(outFileStream);

            byte[] buffer = new byte[(int)inFileStream.Length];
            int count = br.Read(buffer, 0, (int) inFileStream.Length);
            bw.Write(buffer);
            outFileStream.Close();

            return count;
        }

        #endregion

        #region TODO: Implement by byte copy logic using class MemoryStream as a backing store stream.

        public static int InMemoryByByteCopy(string sourcePath, string destinationPath)
        {
            FileStream inFileStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFileStream);

            string s = reader.ReadToEnd();
            Encoding unicode = Encoding.Unicode;
            byte[] array = unicode.GetBytes(s);
            MemoryStream memoryStream = new MemoryStream(array);
            byte[] newArray = memoryStream.ToArray();
            char[] newCharArray = unicode.GetChars(newArray);
            FileStream outFileStream = new FileStream(destinationPath, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(outFileStream);
            writer.Write(newCharArray);
            outFileStream.Close();

            return newCharArray.Length;
        }

        #endregion

        #region TODO: Implement by block copy logic using FileStream buffer.

        public static int ByBlockCopy(string sourcePath, string destinationPath)
        {
            FileStream inFileStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFileStream);
            StreamWriter writer = new StreamWriter(destinationPath);

            char[] symbols = new char[(int)inFileStream.Length];
            int count = reader.ReadBlock(symbols, 0, (int) inFileStream.Length);
            writer.Write(symbols, 0, (int)inFileStream.Length);
            writer.Close();

            return count;
        }

        #endregion

        #region TODO: Implement by block copy logic using MemoryStream.

        public static int InMemoryByBlockCopy(string sourcePath, string destinationPath)
        {
            // TODO: Use InMemoryByByteCopy method's approach
            throw new NotImplementedException();
        }

        #endregion

        #region TODO: Implement by block copy logic using class-decorator BufferedStream.

        public static int BufferedCopy(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region TODO: Implement by line copy logic using FileStream and classes text-adapters StreamReader/StreamWriter

        public static int ByLineCopy(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region TODO: Implement content comparison logic of two files 

        public static bool IsContentEquals(string sourcePath, string destinationPath)
        {
            FileInfo first = new FileInfo(sourcePath);
            FileInfo second=new FileInfo(destinationPath);

            if (first.Length != second.Length)
            {
                return false;
            }

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (fs1.ReadByte() != fs2.ReadByte())
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion

        #endregion

        #region Private members

        #region TODO: Implement validation logic

        private static void InputValidation(string sourcePath, string destinationPath)
        {
            if (!File.Exists(sourcePath))
            {
                throw new FileNotFoundException();
            }
        }

        #endregion

        #endregion

    }
}
