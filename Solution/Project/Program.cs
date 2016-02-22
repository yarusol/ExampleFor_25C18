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

			double dVal;
			string input;
			do
			{
				Console.WriteLine( "Enter double value, please : " );
				input = Console.ReadLine();
			} while( ! Double.TryParse( input, out dVal ) );
			Console.WriteLine( "\nYou've entered {0}. It is good double.\nThank you! ", dVal );

			Console.WriteLine( "\n\n\n" );

			int iVal;
			do
			{
				Console.WriteLine( "Enter integer value, please : " );
				input = Console.ReadLine();
			} while ( !Int32.TryParse( input, out iVal ) );
			Console.WriteLine( "\nYou've entered {0}. It is good integer.\nThank you! ", iVal );

			Console.WriteLine( "\n\n\n" );
		}
	}
}
