using System.Security.Cryptography.X509Certificates;

class Pouch<T>
{
    private List<T> items;

    public Pouch()
    {
        items = new List<T>();
    }

    public void Store(T item)
    {
        items.Add(item);
    }

    public void Retrieve(T item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            Console.WriteLine("Item not found in the pouch.");
        }
    }

    public int GetCount()
    {
        return items.Count;
    }
}
