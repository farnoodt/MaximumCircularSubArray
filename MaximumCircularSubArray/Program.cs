// See https://aka.ms/new-console-template for more information
int[] A = { -3, 1, -3, 4, -1, 2, 1, -5, 4 };
MaxSubArray(A);

static void MaxSubArray(int[] A)
{
    int Max = 0;
    for (int j = 0; j < A.Length - 1; j++)
    {
        int tmp = A[A.Length - 1];
        for (int i = A.Length - 2; i >= 0; i--)
        {
            A[i + 1] = A[i];
        }
        A[0] = tmp;
        Max = Math.Max(Max, Kadanes(A));
    }


    Console.WriteLine(Max);
}

static int Kadanes(int[] A)
{
    int MaxToHere = 0;
    int Sofar = 0;
    int sum = 0;

    foreach (int item in A)
    {
        sum += item;

        MaxToHere = Math.Max(0, sum);

        Sofar = Math.Max(Sofar, MaxToHere);
    }
    return Sofar;
}
