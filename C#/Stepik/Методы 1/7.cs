static void VasyaStyle(int n)
{
	{
		List<int> nums = new List<int>();
		List<int> useda = new List<int>();
		bool used = false;
		
		nums.Add(2); nums.Add(3); nums.Add(7);
		List<int> list = Create237(nums, n);
		
		for (int a = 0; a < list.Count; a++)
		{
			for (int b = 0; b < list.Count; b++)
			{
				foreach (int i in useda)
					if (i == list[b])
						used = true;
				
				for (int c = 0; c < list.Count; c++)
				{
					if (n == list[a] * list[b] + list[c] && !used)
					{
						Console.WriteLine($"{n} = {list[a]} * {list[b]} + {list[c]}");
						useda.Add(list[a]);
					}
					if (used)
					{
						used = false;
						break;
					}
				}
			}
		}
	}
}

static List<int> Create237(List<int> nums, int END)
{
	int addnum = 0;
	for(int i = 0; true; i++)
	{
		addnum = Convert.ToInt32(Convert.ToString(nums[i]) + '2');
		if (addnum >= END) break;
		nums.Add(addnum);

		addnum = Convert.ToInt32(Convert.ToString(nums[i]) + '3');
		if (addnum >= END) break;
		nums.Add(addnum);

		addnum = Convert.ToInt32(Convert.ToString(nums[i]) + '7');
		if (addnum >= END) break;
		nums.Add(addnum);
	}
	return nums;
}