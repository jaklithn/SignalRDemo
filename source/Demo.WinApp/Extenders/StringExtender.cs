using System;
using System.Text.RegularExpressions;

namespace Demo.WinApp.Extenders
{
	public static class StringExtender
	{
		/// <summary>
		/// Simple shortcut for !IsNullOrEmpty.
		/// </summary>
		public static bool IsSpecified(this string value)
		{
			return !value.IsNullOrEmpty();
		}

		/// <summary>
		/// Same as String.IsNullOrEmpty()
		/// </summary>
		public static bool IsNullOrEmpty(this string value)
		{
			return string.IsNullOrEmpty(value);
		}

		/// <summary>
		/// Remove all occurrences of specified chars.
		/// </summary>
		public static string Remove(this string value, char[] charArray)
		{
			foreach (var c in charArray)
			{
				value = value.Replace(c.ToString(), string.Empty);
			}
			return value;
		}

		/// <summary>
		/// Parse string into specified enum type and make sure it matches a valid enum value.
		/// </summary>
		public static T ToEnum<T>(this string value)
		{
			if (!Enum.IsDefined(typeof(T), value))
			{
				throw new Exception($"String value='{value}' can not be interpreted as valid enum of type {typeof(T).Name}");
			}

			return (T)Enum.Parse(typeof(T), value);
		}

		/// <summary>
		/// Capitalize first letter of each word.
		/// </summary>
		public static string ToUpperFirst(this string value)
		{
			value = value.Trim().ToLower();
			var matches = Regex.Matches(value, "\\b\\w");
			foreach (Match match in matches)
			{
				value = value.Remove(match.Index, 1).Insert(match.Index, match.Value.ToUpper());
			}

			return value;
		}
	}
}