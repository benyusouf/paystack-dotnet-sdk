namespace PaystackSDK.Extensions
{
    public static class ObjectsExtensions
    {
        public static byte[] ReadAsBytes(this Stream input)
        {
            byte[] array = new byte[16384];
            using MemoryStream memoryStream = new MemoryStream();
            int count;
            while ((count = input.Read(array, 0, array.Length)) > 0)
            {
                memoryStream.Write(array, 0, count);
            }

            return memoryStream.ToArray();
        }
    }
}
