using System;
using KarmasikSayi;
namespace dll_makale
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Complex x = new Complex(1,3);
			Complex y = new Complex(-2,4);
			
			Complex z = new Complex();
			z = x/y;
			z.Yazdir();
		}
	}
}
