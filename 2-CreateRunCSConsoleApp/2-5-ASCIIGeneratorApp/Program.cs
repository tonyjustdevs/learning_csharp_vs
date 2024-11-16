// See https://github.com/tonyjustdevs/learning_csharp_vs/issues/129
Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--- Welcome to Tony's ASCII-Generator App ---");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");

// 2-5-129-Create loop from 0-127 from 65 (A) #130
// 129-1 for loop 0-127 offset by 65

// int ascii_offset    = 65; //for A
// int ascii_offset    = 0; //for A
// int ascii_value;
// int ascii_range     = 128;
// char ascii_char;
int valid_ascii_chars = 126-33;
  // first 32 asciis are not real chars but some weird things
  // 33-126 seem like characters
  // REFERENCE: https://www.rapidtables.com/code/text/ascii-table.html

// System.Console.WriteLine(valid_ascii_chars);
// char[] ascii_array = new char[valid_ascii_chars];

// for (int i = 0; i < ascii_range; i++)
// for (int i = 0; i < ascii_array.Length; i++)
// for (int i = 33; i < 127; i++)
// for (int i = 33; i < ascii_array.Length; i++)
for (int i = 33; i <= 126; i++)
{
  // ascii_value = i + ascii_offset; // Expected 65 to 192 (65+127)
  // System.Console.Write(i);  
  // ascii_value = i; // Expected 65 to 192 (65+127)
  char ascii_char = Convert.ToChar(i); 

  // ascii_array[i] = ascii_char;

  System.Console.Write($"[{i}:'");
  System.Console.Write($"{ascii_char}']");
}

// System.Console.WriteLine(ascii_array[0]);
// // 2-5-129-Output each ASCII Char #131

// foreach (char chr in ascii_array)
// {
//   System.Console.Write(chr);
// }


Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--- Leaving Tony's ASCII-Generator App ------");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");