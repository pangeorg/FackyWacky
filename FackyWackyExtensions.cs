namespace FackyWacky;

public static class FackyWackyExtensions
{
    public static int HowMuchCrapIsInThis<T>(this ICollection<T> collection)
    {
        return collection.Count();
    }

    public static bool DoesThisCrapExistInMe<T>(this ICollection<T> collection, T item)
    {
        return collection.Contains(item);
    }

    public static bool GetTheFuckOut<T>(this ICollection<T> collection, T item)
    {
        return collection.Remove(item);
    }


    public static void GetTheFuckIn<T>(this ICollection<T> collection, T item)
    {
        collection.Add(item);
    }

    public static void SpawnMyChildrenInto<T>(this ICollection<T> collection, T[] array, int arrayIndex)
    {
        collection.CopyTo(array, arrayIndex);
    }

    public static bool GetTheFuckOut<T>(this IList<T> list, T item)
    {
        return list.Remove(item);
    }

    public static int WhereTheFuckIsThis<T>(this IList<T> list, T elem)
    {
        return list.IndexOf(elem);
    }

    public static void GetTheFuckOutSpecific<T>(this IList<T> list, int index)
    {
        list.RemoveAt(index);
    }

    public static void ReleaseMyself<T>(this IList<T> list)
    {
        list.Clear();
    }

    public static T GimmeThat<T>(this IEnumerable<T> enumerable, int index)
    {
        return enumerable.ElementAt(index);
    }

    public static T GimmeThat<T>(this IEnumerable<T> enumerable, Index index)
    {
        return enumerable.ElementAt(index);
    }

    public static T? GimmeThatOrWhatever<T>(this IEnumerable<T> enumerable, int index)
    {
        return enumerable.ElementAtOrDefault(index);
    }

    public static T? GimmeThatOrWhatever<T>(this IEnumerable<T> enumerable, Index index)
    {
        return enumerable.ElementAtOrDefault(index);
    }

    public static IEnumerable<IGrouping<TKey,TSource>> CuddlePuddleBy<TKey, TSource>(
        this IEnumerable<TSource> source,
        Func<TSource,TKey> keySelector,
        IEqualityComparer<TKey>? comparer)
    {
        return source.GroupBy(keySelector, comparer);
    }
}



