using System;
using KarmasikSayi;

namespace KarmasikSayi
{
	public class Complex
	{
		private double re;
		private double im;
		
		public double Reel
		{
			get{return re;}
			set{re = value;}
		}
		public double Sanal
		{
			get{return im;}
			set{im = value;}
		}
		
		public Complex()
		{
			Reel=0;
			Sanal = 0;
		}

		public Complex(double r,double s)
		{
			Reel=r;
			Sanal = s;
		}

		public Complex Topla(Complex Operand)
		{
			double reel_toplam = Reel + Operand.Reel;
			double sanal_toplam = Sanal + Operand.Sanal;
			Complex toplam = new Complex(reel_toplam,sanal_toplam);
			return toplam;
		}

		public static Complex operator+(Complex Operand1,Complex Operand2)
		{
			double reel_toplam = Operand1.Reel+Operand2.Reel;
			double sanal_toplam = Operand1.Sanal+Operand2.Sanal;			
			Complex toplam = new Complex(reel_toplam,sanal_toplam);
			return toplam;
		}

		public Complex Cikar(Complex Operand)
		{
			double reel_fark = Reel - Operand.Reel;
			double sanal_fark = Sanal - Operand.Sanal;
			Complex sonuc = new Complex(reel_fark,sanal_fark);
			return sonuc;
		}

		public static Complex operator-(Complex Operand1,Complex Operand2)
		{
			double reel_fark = Operand1.Reel - Operand2.Reel;
			double sanal_fark = Operand1.Sanal - Operand2.Sanal;			
			Complex sonuc = new Complex(reel_fark,sanal_fark);
			return sonuc;
		}

		public Complex Carp(Complex Operand)
		{
			double yeni_reel = Reel*Operand.Reel  - Sanal*Operand.Sanal;
			double yeni_sanal = Reel * Operand.Sanal + Sanal*Operand.Reel;
			Complex carpim = new Complex(yeni_reel,yeni_sanal);
			return carpim;
		}

		public static Complex operator*(Complex Operand1,Complex Operand2)
		{
			double yeni_reel = Operand1.Reel*Operand2.Reel  - Operand1.Sanal * Operand2.Sanal;
			double yeni_sanal = Operand1.Reel * Operand2.Sanal + Operand1.Sanal * Operand2.Reel;
			Complex carpim = new Complex(yeni_reel,yeni_sanal);
			return carpim;
		}

		public Complex Bol(Complex operand)
		{
			double Payda;
			Payda = operand.Reel*operand.Reel + operand.Sanal*operand.Sanal;

			Complex pay = new Complex();
			pay = this*operand;
			double yeni_reel = pay.Reel / Payda ;
			double yeni_sanal = pay.Sanal / Payda ;
			Complex sonuc = new Complex(yeni_reel,yeni_sanal);
			return sonuc;
		}

		public static Complex operator/(Complex operand1,Complex operand2)
		{
			double Payda;
			Payda = operand2.Reel*operand2.Reel + operand2.Sanal*operand2.Sanal;

			Complex pay = new Complex();
			pay = operand1*operand2;
			double yeni_reel = pay.Reel / Payda ;
			double yeni_sanal = pay.Sanal / Payda ;
			Complex sonuc = new Complex(yeni_reel,yeni_sanal);
			return sonuc;
		}

		public void Yazdir()
		{
			if (Sanal > 0)
				Console.WriteLine("{0} + j{1}",Reel,Sanal);
			else if (Sanal < 0)
			{
				double yeni_sanal = -Sanal;
				Console.WriteLine("{0} - j{1}",Reel,yeni_sanal);
			}
			else
				Console.WriteLine("{0}",Reel);
		}
		
		
	}

	
}



