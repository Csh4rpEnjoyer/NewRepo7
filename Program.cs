// 2 variant
Random r = new Random();
Random s = new Random();
int k = 0;
int n = s.Next(10,20);
int[] A = new int[n];
for (int i = 0; i < n; i++)
    A[i] = r.Next(20);
for (int j = 1; j < n; j++)
    if (A[j] > A[j - 1] && A[j] > A[j + 1])
        k += 1;
for (int i = 0; i < n; i++)
    Console.WriteLine(A[i]);
Console.WriteLine("Количество чисел, которые больше соседей:");
Console.WriteLine(k);