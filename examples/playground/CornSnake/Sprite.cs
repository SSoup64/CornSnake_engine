using System;
using System.IO;
using Raylib_cs;

namespace CornSnake {
	public class Sprite {
#region Attributes
		public List<Texture2D> frames = new List<Texture2D>();

		private int org_x = 0, org_y = 0;
#endregion
		
		// Constructor
		// TODO: Create a file format that tells the game where is the sprite origin point and how many frames there are.
		public Sprite(ref Game game, string folder_path) {
			// Throw an error if the directory does not exist
			if (!Directory.Exists(folder_path))
				throw new Exception($"Directory {folder_path} does not exist!");
			
			// Load the frames
			int i;
			
			for (i = 0; File.Exists($"{folder_path}/img_{i}.png"); i++) {
				frames.Add(Raylib.LoadTexture($"{folder_path}/img_{i}.png"));
			}
			
			// Throw an error if the initial frame was not loaded
			if (i == 0)
				throw new Exception($"Could not find the intial frame in {folder_path}");

			// Set the origin to be the middle center of the sprite
			org_x = frames[0].Width/2;
			org_y = frames[0].Height/2;
		}

#region Other functions
		public int getWidth() {
			return frames[0].Width;
		}

		public int getHeight() {
			return frames[0].Height;
		}

		public int getOrgX() {
			return org_x;
		}

		public int getOrgY() {
			return org_y;
		}
#endregion
	}
}
