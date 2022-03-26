using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204090
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SayaTubeUser user = new SayaTubeUser("Fathan");

			SayaTubeVideo v1 = new SayaTubeVideo("Review Film - Wanderer Knight oleh Fathan");
			SayaTubeVideo v2 = new SayaTubeVideo("Review Film - Enderman oleh Fathan");
			SayaTubeVideo v3 = new SayaTubeVideo("Review Film - Tukang Bubur Naik Motor oleh Fathan");
			SayaTubeVideo v4 = new SayaTubeVideo("Review Film - Sparta oleh Fathan");
			SayaTubeVideo v5 = new SayaTubeVideo("Review Film - War of Kirov oleh Fathan");
			SayaTubeVideo v6 = new SayaTubeVideo("Review Film - Pirate of Kambing oleh Fathan");
			SayaTubeVideo v7 = new SayaTubeVideo("Review Film - Kremlin oleh Fathan");
			SayaTubeVideo v8 = new SayaTubeVideo("Review Film - The Social Media oleh Fathan");
			SayaTubeVideo v9 = new SayaTubeVideo("Review Film - Dynamic of Nature oleh Fathan");
			SayaTubeVideo v10 = new SayaTubeVideo("Review Film - Mirror oleh Fathan");

			user.AddVideo(v1);
			user.AddVideo(v2);
			user.AddVideo(v3);
			user.AddVideo(v4);
			user.AddVideo(v5);
			user.AddVideo(v6);
			user.AddVideo(v7);
			user.AddVideo(v8);
			user.AddVideo(v9);
			user.AddVideo(v10);

			user.PrintAllVideoPlayCount();
		}
	}
}
