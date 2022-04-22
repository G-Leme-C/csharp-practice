Console.WriteLine("MergeSort implementation sample\n\n");

int[] unsortedArray = new int[10] { 5, 8, 15, 16, 9, 1, 7, 6, 22, 21 };

Console.Write("Unsorted array: ");
ArrayPrinter.Print(unsortedArray);

MergeSort sorter = new MergeSort();
int[] sortedArray = sorter.Sort(unsortedArray);

Console.Write("\nSorted array: ");
ArrayPrinter.Print(sortedArray);

Console.Write("\n\n");