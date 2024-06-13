
int[] nums1 = { 2, 7, 11, 15 };
int target1 = 9;
int[] result1 = TwoSum(nums1, target1);

int[] TwoSum(int[] nums1, int target1)
{
   Dictionary<int,int> maps = new Dictionary<int,int>();
    for(int i = 0; i < nums1.Length; i++)
    {
        int suR = target1- nums1[i];
        if (maps.ContainsKey(suR))
        {
            return new int[] { maps[suR], i };
        }
        maps[nums1[i]] = i;  
    }
    return new int[] { };
}

Console.WriteLine($"Result for nums1: [{result1[0]}, {result1[1]}]");
