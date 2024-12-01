public static class Day1
{
	public static string Part1()
	{
		string input = File.ReadAllText("data/day1.txt").Trim();

		List<int> list1 = [];
		List<int> list2 = [];

		input.Split(Environment.NewLine).ToList().ForEach((line) =>
		{
			List<string> values = line.Split(" ").Select((x) => x.Trim()).ToList();

			list1.Add(int.Parse(values.First()));
			list2.Add(int.Parse(values.Last()));
		});

		list1.Sort();
		list2.Sort();

		List<int> distances = [];

		for (int i = 0; i < list1.Count; i++)
		{
			int distance = Math.Abs(list1[i] - list2[i]);
			distances.Add(distance);
		}
		
		string totalDistance = distances.Sum().ToString();

		return totalDistance;
	}

	public static string Part2()
	{
		string input = File.ReadAllText("data/day1.txt").Trim();

		List<int> list1 = [];
		List<int> list2 = [];

		input.Split(Environment.NewLine).ToList().ForEach((line) =>
		{
			List<string> values = line.Split(" ").Select((x) => x.Trim()).ToList();

			list1.Add(int.Parse(values.First()));
			list2.Add(int.Parse(values.Last()));
		});

		List<int> similarities = [];

		list1.ForEach((x) =>
		{
			int occurence = list2.Count((y) => y == x);
			int similarity = x * occurence;

			similarities.Add(similarity);
		});
		
		string totalSimilarity = similarities.Sum().ToString();

		return totalSimilarity;
	}
}