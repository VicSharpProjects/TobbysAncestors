using System;
using System.Collections;
using System.Text;

namespace TobbysAncestorsApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tobby’s Ancestors Game");
			Console.WriteLine("Input");
			string string1 = Console.ReadLine();
			string string2 = Console.ReadLine();
			StringBuilder stringCombined = new StringBuilder();
			int currentCountMatch = 0, countMatch = 0, optimalPosition = 0;
			var stringArrays = new ArrayList();
			int k;
			for (int i = 0; i < string1.Length; i++)
			{
				k = i;
				stringCombined.Append(string1);
				for (int j = 0; j < string2.Length; j++, k++)
				{
					if (k >= string1.Length)
					{
						stringCombined.Append(string2[j]);
					}
					else
					{
						if (stringCombined[k] != string2[j])
						{
							stringCombined[k] = 'X';
						}
						else
						{
							currentCountMatch++;
						}
					}
				}
				if (currentCountMatch >= countMatch)
				{
					optimalPosition = i;
					countMatch = currentCountMatch;
				}
				stringArrays.Add(stringCombined.ToString());
				stringCombined.Clear();
				currentCountMatch = 0;
			}
			if (countMatch == 0)
			{
				Console.WriteLine("Output\n{0}\n{1}", countMatch, "No matches");
			}
			else
			{
				Console.WriteLine("Output\n{0}\n{1}", countMatch, stringArrays[optimalPosition]);
			}
			Console.ReadKey();
		}
	}
}
