using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace аащща
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Переключение между октавами F1-F7");
			Console.WriteLine("Клавиша Z соответсвует ноте C");
			Console.WriteLine("Клавиша S соответсвует ноте C#");
			Console.WriteLine("Клавиша X соответсвует ноте D");
			Console.WriteLine("Клавиша D соответсвует ноте Eb");
			Console.WriteLine("Клавиша C соответсвует ноте E");
			Console.WriteLine("Клавиша V соответсвует ноте F");
			Console.WriteLine("Клавиша G соответсвует ноте F#");
			Console.WriteLine("Клавиша B соответсвует ноте G");
			Console.WriteLine("Клавиша H соответсвует ноте G#");
			Console.WriteLine("Клавиша N соответсвует ноте А");
			Console.WriteLine("Клавиша J соответсвует ноте Bb");
			Console.WriteLine("Клавиша M соответсвует ноте B");
			int[] nowOctave = new int[12];
			do
			{
				ConsoleKeyInfo key = Console.ReadKey();
				if ((key.Key == ConsoleKey.F1) ||
					(key.Key == ConsoleKey.F2) ||
					(key.Key == ConsoleKey.F3) ||
					(key.Key == ConsoleKey.F4) ||
					(key.Key == ConsoleKey.F5) ||
					(key.Key == ConsoleKey.F6) ||
					(key.Key == ConsoleKey.F7))
				nowOctave = Octaves(key);
				if ((key.Key == ConsoleKey.Z) ||
					(key.Key == ConsoleKey.S) ||
					(key.Key == ConsoleKey.X) ||
					(key.Key == ConsoleKey.D) ||
					(key.Key == ConsoleKey.C) ||
					(key.Key == ConsoleKey.V) ||
					(key.Key == ConsoleKey.G) ||
					(key.Key == ConsoleKey.B) ||
					(key.Key == ConsoleKey.H) ||
					(key.Key == ConsoleKey.N) ||
					(key.Key == ConsoleKey.J) ||
					(key.Key == ConsoleKey.M))
					SoundOutput(key, nowOctave);
			}
			while (true);
			static void SoundOutput(ConsoleKeyInfo key, int[] nowOctave)
			{
				if (key.Key == ConsoleKey.Z)
				Console.Beep(nowOctave[0], 300);
				else if (key.Key == ConsoleKey.S)
				Console.Beep(nowOctave[1], 300);
				else if (key.Key == ConsoleKey.X)
				Console.Beep(nowOctave[2], 300);
	            else if (key.Key == ConsoleKey.D)
				Console.Beep(nowOctave[3], 300);
				else if (key.Key == ConsoleKey.C)
				Console.Beep(nowOctave[4], 300);
				else if (key.Key == ConsoleKey.V)
				Console.Beep(nowOctave[5], 300);
				else if (key.Key == ConsoleKey.G)
				Console.Beep(nowOctave[6], 300);
				else if (key.Key == ConsoleKey.B)
				Console.Beep(nowOctave[7], 300);
				else if (key.Key == ConsoleKey.H)
				Console.Beep(nowOctave[8], 300);
				else if (key.Key == ConsoleKey.N)
				Console.Beep(nowOctave[9], 300);
				else if (key.Key == ConsoleKey.J)
				Console.Beep(nowOctave[10], 300);
				else if (key.Key == ConsoleKey.M)
				Console.Beep(nowOctave[11], 300);
				Console.Clear();
			}
			static int[] Octaves(ConsoleKeyInfo key)
			{
				int[] Null = new int[1];
				int[] twoOctave = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 103, 110, 117, 124 };
				int[] threeOctave = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
				int[] fourOctave = new int[12] { 267, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
				int[] fiveOctave = new int[12] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
				int[] sixOctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
				int[] sevenOctave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
				int[] ateOctave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
				if (key.Key == ConsoleKey.F1)
				{
					Console.WriteLine("Вторая октава");
					return twoOctave;
				}
				else if (key.Key == ConsoleKey.F2)
				{
					Console.WriteLine("Третья октава");
					return threeOctave;
				}
				else if (key.Key == ConsoleKey.F3)
				{
					Console.WriteLine("Четвёртая октава");
					return fourOctave;
				}
				else if (key.Key == ConsoleKey.F4)
				{
					Console.WriteLine("Пятая октава");
					return fiveOctave;
				}
				else if (key.Key == ConsoleKey.F5)
				{
					Console.WriteLine("Шестая октава");
					return sixOctave;
				}
				else if (key.Key == ConsoleKey.F6)
				{
					Console.WriteLine("Седьмая октава");
					return sevenOctave;
				}
				else if (key.Key == ConsoleKey.F7)
				{
					Console.WriteLine("Восьмая октава");
					return ateOctave;
				}
				return Null;
			}
		}
	}
}
