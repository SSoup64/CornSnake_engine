using System;
using System.IO;
using SDL2;

namespace CornSnake {
	public class Sprite {
		List<IntPtr> frames = new List<IntPtr>();

		public Sprite(Game game, string folder_path) {
			if (!Directory.Exists(folder_path))
				throw new Exception($"Directory {folder_path} does not exist!");
			
			for (int i = 0; File.Exists($"{folder_path}/img_{i}"); i++) {
				frames.Add(SDL_image.IMG_LoadTexture(game.renderer, $"{folder_path}/img_{i}"));
			}
		}

		~Sprite() {
			frames = null;
		}
	}
}
