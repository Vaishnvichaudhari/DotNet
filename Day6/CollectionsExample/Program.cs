using System.Collections;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add("Vaishnavi");
            objArrayList.Add(1.2345);
            objArrayList.Add(true);

            ArrayList objArrayList2 = new ArrayList();
            objArrayList2.Add(10);

            objArrayList.AddRange(objArrayList2);

            objArrayList.Insert(0, "new");
            objArrayList.InsertRange(0, objArrayList2);

            Console.WriteLine(objArrayList.Count);

            objArrayList.Remove(10); //object to remove
            objArrayList.RemoveAt(0); //index
            objArrayList.RemoveRange(0, 2);

            ArrayList o2 = objArrayList.GetRange(0, 3);

            //objArrayList.SetRange(0, o2);
            //Console.WriteLine(objArrayList.this[0]);
            Console.WriteLine(objArrayList[0]);



            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }
        }

        static void Main2()
        {
            ArrayList objArrayList = new ArrayList();
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.TrimToSize();

            //objArrayList.Add(10);
            Console.WriteLine($"after Trim - count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");


        }

        static void Main()
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(10, "Vaishnavi");
            objDictionary.Add(2, "Manali");
            objDictionary.Add(3, "Pranav");
            objDictionary.Add(30, "Shweta");

            objDictionary[5] = "new value";
            objDictionary[2] = "changed value"; //changed the value of that index

            //objDictionary.Remove(key);
            //objDictionary.RemoveAt(index);

            //
            //bool retval =objDictionary.ContainsKey(key)

            IList keyList = objDictionary.GetKeyList();
            //objDictionary.GetValueList

            ICollection keys = objDictionary.Keys;
            //objDictionary.Values;

            foreach (DictionaryEntry item in objDictionary)
            {
                Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            }

        }
        static void Main3()
        {
            Stack s = new Stack();
            s.Push(1);
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(1);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
        }
    }
}