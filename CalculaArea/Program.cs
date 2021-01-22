using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaArea
{
    class Program
    {
		static void Main(string[] args)
		{
			//EXEC 1:
			/*  float chocolate = PrecoFinal(30);
				float refrigerante = PrecoFinal(50);
				float bolo = PrecoFinal(45);
				float sorvete = PrecoFinal(60);
				float pao = PrecoFinal(15);

				Console.WriteLine("Chocolate: " + chocolate);
				Console.WriteLine("Refrigerante: " + refrigerante);
				Console.WriteLine("Bolo: " + bolo);
				Console.WriteLine("Sorvete: " + sorvete);
				Console.WriteLine("Pão: " + pao);
				Console.ReadLine();
			*/

			//EXEC2:
			/*
			Console.WriteLine("Informe a Área: ");
			string leitura = Console.ReadLine();
			double Valor = Convert.ToDouble(leitura);
			double AreaFinal = Area(Valor);
			Console.WriteLine("A área da circunferência é: " + Math.Round(AreaFinal, 2));
			Console.ReadLine();
			*/

			Console.WriteLine("Informe a Base: ");
			string BaseTri = Console.ReadLine();
			double BT = double.Parse(BaseTri);
			Console.WriteLine("Informe a Altura: ");
			string AlturaTri = Console.ReadLine();
			double AT = double.Parse(AlturaTri);
			double AreaFinal = Triangulo(BT,AT);
			Console.WriteLine("A área do triângulo é: " + Math.Round(AreaFinal, 2));
			Console.ReadLine();
		}

		//EXEC 1:
		/* static float PrecoFinal(float Preco)
		{
			Preco *= 1.25f;
			return Preco;
		}
		*/

		//EXEC 2:
	    /*  static double Area(double raio)
		{
			double Area = Math.Pow(raio, 2) * Math.PI;
			return Area;
		}
     	*/

		//EXEC3:
		static double Triangulo(double Base, double Altura)
        {
			double Area = (Base * Altura) / 2;
			return Area;
        }

	}
}