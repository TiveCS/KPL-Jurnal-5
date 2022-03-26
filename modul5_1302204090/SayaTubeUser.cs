using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204090
{
	internal class SayaTubeUser
	{

		private int id;
		private List<SayaTubeVideo> uploadedVideos;
		private string username;

		public SayaTubeUser(string username)
		{
			SetUsername(username);
			this.id = new Random().Next(10000, 99999);
			this.uploadedVideos = new List<SayaTubeVideo>();
		}

		public void SetUsername(string username)
		{
			// Cek jika parameter adalah null
			if (username == null) return;

			// Cek jika parameter panjangnya antara 1-100
			if (username.Length == 0) return;
			if (username.Length > 100) return;

			this.username = username;
		}

		public int GetTotalVideoPlayCount()
		{
			int count = 0;

			// Loop tiap objek didalam list, lalu tambahkan ke field count
			foreach (SayaTubeVideo video in this.uploadedVideos)
			{
				try
				{
					count = checked(count + video.GetPlayCount());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					break;
				}
			}

			return count;
		}

		public void AddVideo(SayaTubeVideo video)
		{
			// Cek jika parameter objek video adalah null
			if (video == null) return;
			
			if (video.GetPlayCount() < int.MaxValue) {
				this.uploadedVideos.Add(video);
			}
		}

		public void PrintAllVideoPlayCount()
		{
			int index = 1;
			Console.WriteLine("User: " + this.username);

			// Loop tiap objek dalam list
			foreach (SayaTubeVideo video in this.uploadedVideos)
			{
				// Cek jika index lebih dari 8
				if (index > 8) break;

				// Print saat index kurang dari 8
				Console.WriteLine("Video " + index + ": " + video.GetTitle());
				index++;
			}
		}

	}
}
