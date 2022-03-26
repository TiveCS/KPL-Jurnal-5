using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204090
{
	internal class SayaTubeVideo
	{

		private int id;
		private string title;
		private int playCount;

		public SayaTubeVideo(string title)
		{
			this.title = title;
			this.id = new Random().Next(10000, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int inc)
		{
			playCount += inc;
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("(" + this.id + ") " + this.title + " - " + this.playCount + " play(s)");
		}

		public int GetPlayCount()
		{
			return playCount;
		}

		public int GetId()
		{
			return id;
		}

		public string GetTitle()
		{
			return title;
		}

	}
}
