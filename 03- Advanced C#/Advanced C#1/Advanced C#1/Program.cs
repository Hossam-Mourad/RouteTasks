using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_C_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // What is a generic class? Why use generics?
            // A generic class is a class that can work with any data type. 
            // It allows you to create a class that can be reused for different data types without code duplication.
            #endregion

            #region Q2
            // Q2: Write a generic class Container<T> with Add and Get methods.
            //class Container<T>
            // {
            //     private T item;
            //     public void Add(T item)
            //     {
            //         this.item = item;
            //     }
            //     public T Get()
            //     {
            //         return item;
            //     }
            // }
            #endregion

            #region Q3
            // Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            // Multiple type parameters allow you to define a generic class with more than one type parameter.
            //class Pair<TKey, TValue>
            //{
            //    public TKey Key { get; set; }
            //    public TValue Value { get; set; }
            //    public Pair(TKey key, TValue value)
            //    {
            //        Key = key;
            //        Value = value;
            //    }
            //}
            #endregion

            #region Q4

            //Q4: What is a generic method? Write Swap<T> method.
            // A generic method is a method that can work with any data type.
            //    public static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            #endregion

            #region Q5

            ////Q5: Write a generic method FindMax<T> that finds maximum value
            //    static T FindMax<T>(T a, T b) where T : IComparable<T>
            //    {
            //        return a.CompareTo(b) > 0 ? a : b;
            //    }

            #endregion

            #region Q6

            //Q6: What is a generic interface? Write IRepository<T>. 
            // A generic interface is an interface that can work with any data type.
            //public interface IRepository<T> where T : class
            //{
            //    T? GetById(int id);
            //    IEnumerable<T> GetAll();
            //    void Add(T entity);
            //    void Update(T entity);
            //    void Delete(int id);
            //}
            #endregion

            #region Q7

            //Q7: What is the 'struct' constraint? Write an example.
            // The 'struct' constraint is used to specify that a type parameter must be a value type (struct).
            //public class ValueTypeContainer<T> where T : struct
            //{
            //    private T item;
            //}

            #endregion

            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            // The 'class' constraint is used to specify that a type parameter must be a reference type (class).
            //public class ReferenceTypeContainer<T> where T : class
            //{
            //    private T item;
            //}
            #endregion

            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.
            // The 'new()' constraint is used to specify that a type parameter must have a public parameterless constructor.
            //public class NewableContainer<T> where T : new()
            //{
            //    private T item;
            //}
            #endregion

            #region Q10
            //Q10:  What is the interface constraint? Write an example.
            // The interface constraint is used to specify that a type parameter must implement a specific interface.
            //public class InterfaceContainer<T> where T : IDisposable
            //{
            //    private T item;
            //}
            #endregion

            #region Q11
            //Q11: What is the base class constraint? Write an example.
            // The base class constraint is used to specify that a type parameter must inherit from a specific base class.
            //public class BaseClassContainer<T> where T : Stream
            //{
            //    private T item;
            //}
            #endregion

            #region Q12
            // Q12: How do you apply multiple constraints? Write an example.
            // You can apply multiple constraints by separating them with commas.
            //public class MultipleConstraintsContainer<T> where T : class, IDisposable, new()
            //{
            //    private T item;
            //}
            #endregion

            #region Q13
            // Q13: What does the 'default' keyword do in generics?
            // The 'default' keyword is used to return the default value of a type parameter.
            #endregion

            #region Q14
            // Q14: Write a SafeList<T> that returns default when the index is invalid.
            //    public class SafeList<T>
            //    {
            //        private List<T> items = new List<T>();
            //        public void Add(T item)
            //        {
            //            items.Add(item);
            //        }
            //        public T Get(int index)
            //        {
            //            if (index < 0 || index >= items.Count)
            //            {
            //                return default(T);
            //            }
            //            return items[index];
            //        }
            //}
            #endregion

            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            // Covariance allows you to use a more derived type than originally specified. 
            //The 'out' keyword is used to specify that a type parameter is covariant.
            #endregion

            #region Q16
            // Q16: What is contravariance? Explain the 'in' keyword.
            // Contravariance allows you to use a less derived type than originally specified.
            // The 'in' keyword is used to specify that a type parameter is contravariant.
            #endregion

            #region Q17
            ///Q17: What is the difference between covariance and contravariance?
            // Covariance allows you to use a more derived type than originally specified, while contravariance allows you to use a less derived type than originally specified.
            #endregion

            #region Q18
            // Q18: How do static members work in generic types?
            // Static members in generic types are shared across all instances of the same closed constructed type.
            #endregion

            #region Q19
            //Q19: How can you inherit from a generic class?
            // You can inherit from a generic class by specifying the type arguments in the derived class.
            #endregion

            #region Q20
            //Q20: Complete Exercise -Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
            //public class Cache<TKey, TValue>
            //{
            //    private class CacheItem
            //    {
            //        public TValue Value { get; set; }
            //        public DateTime Expiration { get; set; }
            //    }

            //    private readonly Dictionary<TKey, CacheItem> _cache = new Dictionary<TKey, CacheItem>();

            //    public void Add(TKey key, TValue value, TimeSpan expiration)
            //    {
            //        var cacheItem = new CacheItem
            //        {
            //            Value = value,
            //            Expiration = DateTime.UtcNow.Add(expiration)
            //        };
            //        _cache[key] = cacheItem;
            //    }

            //    public TValue Get(TKey key)
            //    {
            //        if (_cache.TryGetValue(key, out var cacheItem))
            //        {
            //            if (cacheItem.Expiration > DateTime.UtcNow)
            //            {
            //                return cacheItem.Value;
            //            }
            //            _cache.Remove(key);
            //        }
            //        return default;
            //    }

            //    public void Remove(TKey key)
            //    {
            //        _cache.Remove(key);
            //    }

            //    public bool Contains(TKey key)
            //    {
            //        return _cache.ContainsKey(key);
            //    }
            //}

            #endregion
        }
        }
    }       

