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

}
