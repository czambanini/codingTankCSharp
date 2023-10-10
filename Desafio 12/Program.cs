internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] vetorB = new int[] {6, 7, 3, 9, 8, 2, 1, 4, 5, 10};
        int[] vetorC = new int[10];

        for (int i = 0; i < 10; i++) {
            vetorC[i] = vetorA[i] + vetorB[9-i];
        }

        Console.WriteLine(string.Join(',', vetorC));
    }
}