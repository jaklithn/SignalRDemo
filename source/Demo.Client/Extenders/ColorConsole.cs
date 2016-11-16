using System;

namespace Demo.Client.Extenders
{
	public static class ColorConsole
	{
		public static void WriteLine(ConsoleColor color, string format, params object[] arguments)
		{
			Write(string.Format(format, arguments) + Environment.NewLine, color);
		}

		public static void Write(ConsoleColor color, string format, params object[] arguments)
		{
			Write(string.Format(format, arguments) , color);
		}

		public static void WriteLine(string value, ConsoleColor color = ConsoleColor.White)
		{
			Write(value + Environment.NewLine, color);
		}

		public static void Write(string value, ConsoleColor color = ConsoleColor.White)
		{
			var currentColor = Console.ForegroundColor;

			Console.ForegroundColor = color;
			Console.Write(value);

			Console.ForegroundColor = currentColor;
		}

		public static ConsoleKeyInfo ReadKey(bool intercept)
		{
			return Console.ReadKey(intercept);
		}
	}
}