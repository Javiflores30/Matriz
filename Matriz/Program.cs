using System;
					
public class Program
{
	public static void Main()
	{
		
		int[,] matriz = new int[10,10];
		
		for (int filas = 1; filas< matriz.GetLength(0); filas++)
		{
			Console.WriteLine("");
			for (int col = 1; col < matriz.GetLength(1); col++)
			{
				matriz[filas,col]  = filas*col;
				Console.Write(matriz[filas,col]);
	
				Console.Write("  ");
			}
			
		}
//------------------------------
	}
}
