namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string filePath = Console.ReadLine();
            
            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int separator = filePath.LastIndexOf('\\');
            int extensionIndex = filePath.LastIndexOf('.');

            if (separator != -1 &&
                extensionIndex != -1 &&
                extensionIndex > separator)
            {
                fileName = filePath.Substring(separator + 1, 
                    extensionIndex - separator - 1);
                fileExtension = filePath.Substring(extensionIndex + 1);
                
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}