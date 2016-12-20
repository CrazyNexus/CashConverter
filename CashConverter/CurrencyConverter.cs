//
// CurrencyConverter.cs
//
// Created by Thomas Dubiel on 19.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;
namespace CashConverter
{
	public class CurrencyConverter
	{
		string input;

		public CurrencyConverter(string input)
		{
			this.input = input;
		}

		public string ConvertCurrency()
		{
			var output = "";

			if (input.Length < 1)
			{
				output = "Please enter something";
			}
			else {
				try
				{
					var result = Convert.ToDouble(input) * 0.69;
					output = "$" + input + " = £" + result;
				}
				catch (Exception e)
				{
					output = "Please enter something";
					Console.WriteLine("Error in convertion: " + e.Message);
				}
			}

			return output;
		}
	}
}
