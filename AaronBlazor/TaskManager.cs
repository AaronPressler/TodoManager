using AaronBlazor.Components;
namespace AaronBlazor
{
    public class TaskManager
    {

        public List<ToDoList> ToDoList { get; set; }
        ToDoList listmanager = new ToDoList();

        public TaskManager()
        {
            ToDoList = new List<ToDoList>();
        }

        public List<ToDoList> GetToDoLists()
        {
            return ToDoList;
        }

        public void AddToDoList(string title)
        {           
                ToDoList.Add(new ToDoList(title));
        }

        public void TestTask()
        {


            
            DoTask task1 = new DoTask("test", "test", "test", DateTime.Now, false);
            DoTask task2 = new DoTask("test", "test", "test", DateTime.Now, false);

            AddTaskToList(new ToDoList("list1"), task1);
            AddTaskToList(GetToDoLists()[0], task2);
        }

        public void AddTaskToList(ToDoList list, DoTask task)
        {
            list.AddTask(task);
        }
    }
}
