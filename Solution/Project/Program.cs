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

			int val;
			string input;
			do
			{
				Console.WriteLine( "Enter integer value, please : " );
				input = Console.ReadLine();
			} while ( !Int32.TryParse( input, out val ) );
			Console.WriteLine( "\nYou've entered {0}. It is good integer.\nThank you! ", val );

			Console.WriteLine( "\n\n\n" );
		}
	}
}
