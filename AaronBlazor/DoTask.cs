using AaronBlazor.Components;
namespace AaronBlazor
{
    public class DoTask
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }

        public DateTime? ExpiryDate { get; set; } = DateTime.Today;
        public bool IsCompleted { get; set; } = false;


        public DoTask(string? title, string? description, string? category, DateTime? expiryDate, bool isCompleted)
        {
            Title = title;
            Description = description;
            ExpiryDate = expiryDate;
            IsCompleted = isCompleted;
            Category = category;
        }
        public DoTask(string title)
        {

            Title = title;
        }
        public DoTask() { }

        
    }
}
