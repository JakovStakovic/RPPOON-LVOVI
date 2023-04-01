namespace RPPONLV3
{
    public class Logger
    {
        private static Logger instance;
        private string filePath;

        private Logger()
        {
            this.filePath = @"\C: temp.txt";
        }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }


        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(message);
            }
        }

        public void SetFilePath(string path)
        {
            filePath = path;
        }
    }
}
