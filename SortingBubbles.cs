int[] UnsortedNumbers = { 5, 10, 3, 2, 4 };

Console.WriteLine("Sorting: {0}", string.Join(", ", UnsortedNumbers));

bool swapped;

do
{
    swapped = false;

    for (int i = 0; i < UnsortedNumbers.Length - 1; i++)
    {
        if (UnsortedNumbers[i] > UnsortedNumbers[i + 1])
        {
            int Temp = UnsortedNumbers[i + 1];
            UnsortedNumbers[i + 1] = UnsortedNumbers[i];
            UnsortedNumbers[i] = Temp;
            swapped = true;
        }
    }
} while (swapped == true);

Console.WriteLine("Result: {0}", string.Join(", ", UnsortedNumbers));