using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Collections
{
	public static class StackExample
	{
		public static void Test()
		{
			Stack<int> foo = new Stack<int>();
			foo.Push(1);
			foo.Push(2);
			foo.Push(3);
			foo.Push(4);
			foo.Push(5);
			while(foo.Count > 0)
			{
				Console.WriteLine(foo.Pop());
			}

			foo.Push(1);
			foo.Push(2);
			foo.Push(3);
			Console.WriteLine(foo.Pop());
			foo.Push(4);

			while (foo.Count > 0)
			{
				Console.WriteLine(foo.Pop());
			}
		}
	}
}
