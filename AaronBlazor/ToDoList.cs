namespace AaronBlazor
{
    public class ToDoList
    {
        public string? Title { get; set; }
        public List<DoTask> TaskList { get; set; } = new List<DoTask>();

        public ToDoList() { }

        public ToDoList(string title, List<DoTask> taskList)
        {
            Title = title;
            TaskList = taskList;
        }
        public void AddTask(DoTask task)
        {
            TaskList.Add(task);
        }
        public ToDoList(string title)
        { 
            Title = title;}
        }
}
