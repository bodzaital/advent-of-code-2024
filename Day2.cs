public static class Day2
{
	public static string Part1()
	{
		string input = File.ReadAllText("data/day2.txt").Trim();

		List<List<int>> reports = [];

		input.Split(Environment.NewLine).ToList().ForEach((line) =>
		{
			List<int> levels = [.. line.Split(" ").Select((x) => int.Parse(x))];
			
			reports.Add(levels);
		});

		List<bool> reportSafety = [];

		reports.ForEach((levels) =>
		{
			int lastSign = 0;
			bool isOk = true;

			for (int i = 0; i < levels.Count - 1; i++)
			{
				int sign = Math.Sign(levels[i] - levels[i + 1]);

				if (lastSign != 0 && lastSign != sign) isOk = false;

				lastSign = sign;

				int distance = Math.Abs(levels[i] - levels[i + 1]);

				if (distance is < 1 or > 3) isOk = false;
			}

			reportSafety.Add(isOk);
		});
		
		return reportSafety.Count((x) => x).ToString();
	}

	public static string Part2()
	{
		string input = File.ReadAllText("data/day2.txt").Trim();

		List<List<int>> reports = [];

		input.Split(Environment.NewLine).ToList().ForEach((line) =>
		{
			List<int> levels = [.. line.Split(" ").Select((x) => int.Parse(x))];
			
			reports.Add(levels);
		});

		List<bool> reportSafety = [];

		reports.ForEach((levels) =>
		{
			int lastSign = 0;
			bool isOk = true;

			for (int i = 0; i < levels.Count - 1; i++)
			{
				int sign = Math.Sign(levels[i] - levels[i + 1]);

				if (lastSign != 0 && lastSign != sign) isOk = false;

				lastSign = sign;

				int distance = Math.Abs(levels[i] - levels[i + 1]);

				if (distance is < 1 or > 3) isOk = false;
			}

			if (!isOk)
			{
				for (int x = 0; x < levels.Count; x++)
				{
					lastSign = 0;
					isOk = true;

					List<int> tempLevels = [.. levels.Where((_, i) => i != x)];

					for (int i = 0; i < tempLevels.Count - 1; i++)
					{
						int sign = Math.Sign(tempLevels[i] - tempLevels[i + 1]);

						if (lastSign != 0 && lastSign != sign) isOk = false;

						lastSign = sign;

						int distance = Math.Abs(tempLevels[i] - tempLevels[i + 1]);

						if (distance is < 1 or > 3) isOk = false;
					}

					if (isOk) break;
				}
			}

			reportSafety.Add(isOk);
		});
		
		return reportSafety.Count((x) => x).ToString();
	}
}