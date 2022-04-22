public class MergeSort {
    public int[] Sort(int[] array) {
        if(array.Length == 1) return array;

        int[] result = new int[0];
        int middle = array.Length / 2;

        int[] firstHalf = Sort(array[..middle]);
        int[] secondHalf = Sort(array[middle..]);

        result = result.Concat(firstHalf).Concat(secondHalf).ToArray();

        return Merge(result, 0, middle, array.Length);
    }

    private int[] Merge(int[] array, int start, int middle, int finish) {
        int[] result = new int[finish - start];

        int current1 = start;
        int current2 = middle;
        int currentResult = 0;

        while(current1 < middle && current2 < finish) {
            if(array[current1] < array[current2]) {
                result[currentResult] = array[current1];
                current1++;
            }
            else {
                result[currentResult] = array[current2];
                current2++;
            }
            currentResult++;
        }

        while(current1 < middle) {
            result[currentResult++] = array[current1++];
        }

        while(current2 < finish) {
            result[currentResult++] = array[current2++];
        }

        return result;
    }
}