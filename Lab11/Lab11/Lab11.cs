using System.IO;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }
            char charBase = (char)input.ReadByte();
            char charCheck;
            int count = 1;
           
            for (int i = 1; i < input.Length; i++)
            {
                charCheck = (char)input.ReadByte();
                if (charCheck == charBase && count != 255 && i != input.Length - 1)
                {
                    count++;
                }
                else
                {
                    if (i == input.Length - 1)
                    {
                        if (charCheck == charBase && count != 255)
                        {
                            count++;
                        }
                        else
                        {
                            output.WriteByte((byte)count);
                            output.WriteByte((byte)charBase);
                            charBase = charCheck;
                            count = 1;
                        }
                    }
                    output.WriteByte((byte)count);
                    output.WriteByte((byte)charBase);
                    charBase = charCheck;
                    count = 1;
                }
            }
            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);
            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                int count = (int)input.ReadByte();
                char charRead = (char)input.ReadByte();

                for (int j = 0; j < count; j++)
                {
                    output.WriteByte((byte)charRead);
                }
            }
            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);
            return true;
        }

    }
}