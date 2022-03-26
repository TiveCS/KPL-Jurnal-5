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
			this.id = new Random().Next(10000, 99999);
			this.username = username;
			this.uploadedVideos = new List<SayaTubeVideo>();
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
			this.uploadedVideos.Add(video);
		}

		public void PrintAllVideoPlayCount()
		{
			int index = 1;
			Console.WriteLine("User: " + this.username);
			foreach (SayaTubeVideo video in this.uploadedVideos)
			{
				Console.WriteLine("Video " + index + ": " + video.GetTitle());
				index++;
			}
		}

	}
}
