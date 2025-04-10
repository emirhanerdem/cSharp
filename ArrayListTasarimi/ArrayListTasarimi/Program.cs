using System;

public class MyArrayList
{
    // İçeride kullanılacak dizi
    private object[] items;
    // Dizi kapasitesinin kontrolü için
    private int capacity;
    // Geçerli öğe sayısı
    private int count;

    // Başlangıç kapasitesi varsayılan olarak 4
    public MyArrayList(int initialCapacity = 4)
    {
        capacity = initialCapacity;
        items = new object[capacity];
        count = 0;
    }

    // Eleman ekleme
    public void Add(object item)
    {
        // Eğer kapasite yeterli değilse, kapasiteyi iki katına çıkarıyoruz
        if (count == capacity)
        {
            IncreaseCapacity();
        }

        items[count] = item;
        count++;
    }

    // Eleman ekleme (belirli bir index'e)
    public void Insert(int index, object item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException("index", "Geçersiz index.");
        }

        // Eğer kapasite yeterli değilse, kapasiteyi artırıyoruz
        if (count == capacity)
        {
            IncreaseCapacity();
        }

        // Sağdaki öğeleri bir kaydırıyoruz
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }

        items[index] = item;
        count++;
    }

    // Eleman silme
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("index", "Geçersiz index.");
        }

        // Öğeyi silmek için bir kaydırma işlemi yapıyoruz
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        // Son öğeyi boş yapıyoruz (opsiyonel ama temizleme için)
        items[count - 1] = null;

        count--;
    }

    // Belirtilen index'teki öğeyi döndürme
    public object Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("index", "Geçersiz index.");
        }

        return items[index];
    }

    // Öğelerin sayısını döndürme
    public int Count
    {
        get { return count; }
    }

    // Listeyi string olarak döndürme
    public override string ToString()
    {
        if (count == 0)
            return "Liste boş";

        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += items[i].ToString();
            if (i < count - 1)
                result += ", ";
        }
        return result;
    }

    // Kapasiteyi artırma fonksiyonu
    private void IncreaseCapacity()
    {
        capacity *= 2;
        object[] newItems = new object[capacity];
        Array.Copy(items, newItems, count);
        items = newItems;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyArrayList list = new MyArrayList();

        // Eleman ekleyelim
        list.Add("Öğrenci 1");
        list.Add("Öğrenci 2");
        list.Add("Öğrenci 3");

        // Listeyi yazdıralım
        Console.WriteLine("Liste: " + list.ToString());

        // Belirli bir index'e öğe ekleyelim
        list.Insert(1, "Öğrenci 4");
        Console.WriteLine("Liste (Insert sonrası): " + list.ToString());

        // Bir öğeyi kaldıralım
        list.RemoveAt(2);
        Console.WriteLine("Liste (Remove sonrası): " + list.ToString());

        // Listeyi kontrol edelim
        Console.WriteLine("2. öğe: " + list.Get(1));

        // Liste eleman sayısını kontrol edelim
        Console.WriteLine("Öğeler Sayısı: " + list.Count);
    }
}

