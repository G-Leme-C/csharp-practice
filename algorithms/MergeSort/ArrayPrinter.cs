public class ArrayPrinter {

    public static void Print(int[] array) {
        if(array == null) return;

        Console.Write("[ ");

        for(int i = 0; i < array.Length; i++) {
            Console.Write($"{array[i]} ");
        }

        Console.Write("]\n");
    }
}