using System;
using System.Threading;
namespace sds
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] enemy = {[1,3,5],[2,4,6]};
			foreach(int a in enemy) {
				Console.WriteLine(a);
				Thread.Sleep(100);
			}
			Console.ReadKey();
			}			
	}		
}
