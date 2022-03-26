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
			if (username == null) return;
			if (username.Length == 0) return;
			if (username.Length > 100) return;

			this.username = username;
		}

		public int GetTotalVideoPlayCount()
		{
			int count = 0;

			foreach (SayaTubeVideo video in this.uploadedVideos)
			{
				count += video.GetPlayCount();
			}

			return count;
		}

		public void AddVideo(SayaTubeVideo video)
		{
			if (video == null) return;
			
			if (video.GetPlayCount() < int.MaxValue) {
				this.uploadedVideos.Add(video);
			}
		}

		public void PrintAllVideoPlayCount()
		{
			int index = 1;
			Console.WriteLine("User: " + this.username);
			foreach (SayaTubeVideo video in this.uploadedVideos)
			{
				if (index > 8) break;

				Console.WriteLine("Video " + index + ": " + video.GetTitle());
				index++;
			}
		}

	}
}
