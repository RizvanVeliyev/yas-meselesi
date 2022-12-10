using System.Security.Cryptography.X509Certificates;

namespace yas_meselesi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//yas meselesi
			int il ,ay ,gun;
			Console.Write("anadan oldugunuz ili daxil edin:");
			il= Convert.ToInt32(Console.ReadLine());
			Console.Write("anadan oldugunuz ayi daxil edin:");
			ay = Convert.ToInt32(Console.ReadLine());
			Console.Write("anadan oldugunuz gunu daxil edin:");
			gun = Convert.ToInt32(Console.ReadLine());

			int il1, ay1, gun1;
			Console.Write("hal hazirdaki ili daxil edin:");
			il1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("hal hazirdaki ayi daxil edin:");
			ay1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("hal hazirdaki gunu daxil edin:");
			gun1 = Convert.ToInt32(Console.ReadLine());

			int yas;
			yas = il1 - il;
			
				Console.Write("sizin yasiniz:");
				Console.WriteLine(yas );
			
			
			




		}
	}
}