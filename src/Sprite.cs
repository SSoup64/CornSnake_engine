using System;
using System.IO;
using SDL2;

namespace CornSnake {
	public class Sprite {
		public List<IntPtr> frames = new List<IntPtr>();

		private int width = 0, height = 0;
		private int org_x = 0, org_y = 0;

		private bool exists = false;

		// TODO: Create a file format that tells the game where is the sprite origin point and how many frames there are.
		public Sprite(ref Game game, string folder_path) {
			// Throw an error if the directory does not exist
			if (!Directory.Exists(folder_path))
				throw new Exception($"Directory {folder_path} does not exist!");
			
			// Load the frames
			int i;
			
			for (i = 0; File.Exists($"{folder_path}/img_{i}.png"); i++) {
				frames.Add(SDL_image.IMG_Load($"{folder_path}/img_{i}.png"));
			}
			
			// Throw an error if the initial frame was not loaded
			if (i == 0)
				throw new Exception($"Could not find the intial frame in {folder_path}");

			// Calculate sprite dimensions
			unsafe {
				SDL.SDL_Surface *sur = (SDL.SDL_Surface *) this.frames[0]; 

				this.width	= sur->w;
				this.height	= sur->h;
			}

			// Set the origin to be the middle center of the sprite
			this.org_x = this.width/2;
			this.org_y = this.height/2;
			
			// Set exists to true
			exists = true;
		}

		public bool getExists() {
			return exists;
		}

		public int getWidth() {
			return width;
		}

		public int getHeight() {
			return height;
		}

		public int getOrgX() {
			return org_x;
		}

		public int getOrgY() {
			return org_y;
		}
	}
}
