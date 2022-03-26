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
			// Cek jika parameter negatif
			if (inc < 0) return;

			// Cek jika parameter lebih dari 25.000.000
			if (inc > 25000000) return;

			// Lakukan try-catch agar mencegah playCount lebih dari maksimal tipe data
			try {
				playCount = checked(playCount + inc);
			}catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		// Tampilkan video details
		public void PrintVideoDetails()
		{
			Console.WriteLine("(" + this.id + ") " + this.title + " - " + this.playCount + " play(s)");
		}

		public void SetTitle(string title)
		{
			// Cek jika judul adalah null
			if (title == null) return;

			// Cek jika jumlah karakter judul lebih dari 0 dan kurang dari 200
			if (title.Length == 0) return;
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
