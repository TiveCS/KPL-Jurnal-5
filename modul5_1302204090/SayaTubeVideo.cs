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
			SetTitle(title);
			this.id = new Random().Next(10000, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int inc)
		{
			if (inc < 0) return;
			if (inc > 25000000) return;

			try {
				playCount = checked(playCount + inc);
			}catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("(" + this.id + ") " + this.title + " - " + this.playCount + " play(s)");
		}

		public void SetTitle(string title)
		{
			if (title == null) return;
			if (title.Length > 200) return;
			this.title = title;
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
