using System;

namespace Typo_PoP
{
	public class MyRandom
	{
		/*
		 * This method randomizes a specific amount of integer numbers
		 * in specific intervals, thus for an interval of 7 you would 
		 * get an array for wich the first 7 elemens would be from 0 - 6, 
		 * the 2nd from 7 - 13 and so forth until the amount is reached.
		 */
		public static int[] randomize ( int amount, int interval )
		{
			Random rnd = new Random ( DateTime.Now.Second );
			int[] b = new int[amount];
			for ( int i = 0; i < b.Length; i++ )
				b[i] = -1;

			int final = b.Length - ( b.Length % interval );
			int pos = 0;
			int start = -1 * ( interval );
			int end = 0;
			do
			{
				start += interval;
				end += interval;
				int number;
				for ( int pass = start; pass < end; pass++ ) 
				{
					if ( pass >= final )
					{
						final = -1;
						break;
					}
					bool same;
					do
					{
						same = false;
						number = rnd.Next ( interval ) + start;
						for ( int i = 0; i < pass; i++ )
							if ( number == b[i] )
							{
								same = true;
								break;
							}
					} while ( same );
					b[pass] = number;
					pos++;
				}
			} while ( final > 0 );
			
			final = b.Length - ( b.Length % interval );
			for ( int i = final; i < b.Length; i++ )
				b[i] = i;

			for ( int i = 0; i < b.Length; i++ )
				Console.WriteLine ( b[i] );

			return b;
		}
	}
}
