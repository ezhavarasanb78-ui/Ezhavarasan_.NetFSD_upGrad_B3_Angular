namespace day24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "C:\\Users\\EZHAVARASAN\\OneDrive\\Desktop\\sample.txt";
            try
            {
                Console.WriteLine("Enter Message :");
                string str = Console.ReadLine();
                using (FileStream fs = new FileStream(s, FileMode.Append, FileAccess.Write))
                using(StreamWriter writer=new StreamWriter(fs))
                {
                    writer.WriteLine(str);
                }
                Console.WriteLine("message saved");
            }
            catch(Exception ex)
            {
                Console.WriteLine("error");
            }
        }
    }
}
