using System.Collections.Generic;
using System.Linq;
using Interfaces;

namespace MemoryClass
{
    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T? Get(int id)
        {
            if(items.Count == 0)
            {
                display("No items found.");
                return default;
            }
            return items.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            if (items.Count == 0)
            {
                display("No items found.");
            }
            return items;
        }

        public void Update(T item)
        {
            if (item == null)
            {
                display("Item cannot be null.");
                return;
            }
            if(items.Count == 0)
            {
                display("No items to update.");
                return;
            }
            var existing = items.FirstOrDefault(x => x.Id == item.Id);

            if (existing != null)
            {
                int index = items.IndexOf(existing);
                items[index] = item;
                display($"Item {item.Id} updated successfully.");
            }
        }

        public void Delete(int id)
        {
            if(items.Count == 0)
            {
                display("No items to delete.");
                return;
            }
            var item = items.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                items.Remove(item);
                display($"Item {item.Id} deleted successfully.");
            }
        }

        public void display(String message)
        {
            Console.WriteLine(message);
        }
    }
}