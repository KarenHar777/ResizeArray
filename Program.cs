class Program
{
    static void Resize(ref int[] array, int value, int index)
    {
        int[] newArray = new int[array.Length + 1];

        newArray[index] = value;

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = index; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }
        array = newArray;
    }
    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4 };

        Resize(ref myArray, 5, 2);
    }
}