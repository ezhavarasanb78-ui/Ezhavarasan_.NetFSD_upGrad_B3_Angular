namespace day23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> task = new List<string>();
            while(true)
            {
                Console.WriteLine("1.Add task");
                Console.WriteLine("2.view task");
                Console.WriteLine("3.remove task");
                Console.WriteLine("4.exits");
                Console.WriteLine("Enter the option");
                string str = Console.ReadLine();
                switch(str)
                {
                    case "1":
                        addtask(task);
                        break;
                    case "2":
                        viewtask(task);
                        break;
                    case "3":
                        removetask(task);
                        break;
                    case "4":
                        Console.WriteLine("exiting");
                        break;
                }
            }
        }
        static void addtask(List<string> task)
        {
            Console.WriteLine("enter task");
            string ta = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(ta))
            {
                task.Add(ta);
                Console.WriteLine("task added successfully");
            }
            else
            {
                Console.WriteLine("task cannot be empty");
            }
        }
        static void viewtask(List<string> task)
        {
            if(task.Count==0)
            {
                Console.WriteLine("no tasks available");
            }
            else
            {
                Console.Write("tasks");
                for(int i=0;i<task.Count;i++)
                {
                    Console.WriteLine($"{i+1}.{task[i]}");
                }
            }
        }
        static void removetask(List<string> task)
        {
            if(task.Count==0)
            {
                Console.WriteLine("no task to remove");
                return;
            }
            Console.WriteLine("enter task to remove");
            string inp = Console.ReadLine();
            if(int.TryParse(inp,out int tn))
            {
                if(tn>=1 && tn<=task.Count)
                {
                    string rt = task[tn - 1];
                    task.RemoveAt(tn - 1);
                    Console.WriteLine($"removed task {rt}");
                }
                else
                {
                    Console.WriteLine("Invalid task");
                }
            }
            else
            {
                Console.WriteLine("Enter correct task number");
            }

        }
    }
}
