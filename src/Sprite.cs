using System;
using System.IO;
using SDL2;

namespace CornSnake {
	public class Sprite {
		public List<IntPtr> frames = new List<IntPtr>();

		public Sprite(ref Game game, string folder_path) {
			if (!Directory.Exists(folder_path))
				throw new Exception($"Directory {folder_path} does not exist!");

			int i;
			
			for (i = 0; File.Exists($"{folder_path}/img_{i}.png"); i++) {
				frames.Add(SDL_image.IMG_Load($"{folder_path}/img_{i}.png"));
			}

			if (i == 0)
				throw new Exception($"Could not find the intial frame in {folder_path}");
		}
	}
}
