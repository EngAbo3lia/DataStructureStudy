

int[] TwoSum()
{
    int[] nums = new[] { 2, 7, 11, 15 };
    int target = 9;

    int arrayLength = nums.Length;
    if (nums == null || arrayLength < 2)
    {
        return Array.Empty<int>();
    }
    for (int i = 0; i < arrayLength; i++)
    {
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (nums[i] + nums[j] == target) return new int[] {
                i,
                j
            };
        }
    }
    return Array.Empty<int>();
}

Console.WriteLine(TwoSum());