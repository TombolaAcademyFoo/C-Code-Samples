using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Collections
{
	public static class QueueExample
	{
		public static void Test()
		{
			Queue<int> foo = new Queue<int>();
			foo.Enqueue(1);
			foo.Enqueue(2);
			foo.Enqueue(3);
			foo.Enqueue(4);
			foo.Enqueue(5);
			while(foo.Count > 0)
			{
				Console.WriteLine(foo.Dequeue());
			}

			foo.Enqueue(1);
			foo.Enqueue(2);
			foo.Enqueue(3);
			Console.WriteLine(foo.Dequeue());
			foo.Enqueue(4);

			while (foo.Count > 0)
			{
				Console.WriteLine(foo.Dequeue());
			}
		}
	}
}
