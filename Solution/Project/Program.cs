using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "\n\n\nHello Git ! \n\n" );
			Console.WriteLine( "I willing to learn it." );
			Console.WriteLine( "\n\n\n" );

			Console.WriteLine( "Some useful features will be after this. \n\n\n" );

			double val;
			string input;
			do
			{
				Console.WriteLine( "Enter double value, please : " );
				input = Console.ReadLine();
			} while( ! Double.TryParse( input, out val ) );
			Console.WriteLine( "\nYou've entered {0}. It is good double.\nThank you! ", val );

			Console.WriteLine( "\n\n\n" );

		}
	}
}
