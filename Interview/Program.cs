using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
	class Program
	{
		public static string[] GetResult(int a, string[] b)
		{
			for(int i = 0; i < b.Length / 2; i++)
			{
				var t = b[a - 1];
				b[a - 1] = b[i];
				b[i] = t;
				a--;
			}

			return b;
		}

		static void Main(string[] args)
		{
			var b = new[] { "Loki", "Ultron", "Thanos", "Doctor Doom", "Magneto", "Green Goblin" };

			var c = GetResult(b.Length, b);

			string o = "";
			for (int i = 0; i < c.Length; i++)
			{
				o += b[i] + ((i == b.Length - 1) ? "" : ",");
			}

			Console.WriteLine(o);
			Console.ReadKey();
		}
	}
}
