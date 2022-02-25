
namespace LeaningCsharp
{
    class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Item(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
