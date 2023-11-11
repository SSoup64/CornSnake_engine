using System;
using System.IO;
using Raylib_cs;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CornSnake
{
	public class Sprite
	{
		#region Attributes
		public List<Texture2D> frames = new List<Texture2D>();
		public Hitbox hitbox;

		private int org_x = 0, org_y = 0;
		#endregion

		// Constructor
		public Sprite(ref Game game, string folder_path)
		{

			// Throw an error if the directory does not exist
			if (!Directory.Exists(folder_path))
				throw new Exception($"Directory {folder_path} does not exist!");

			string path = Path.Combine(Directory.GetCurrentDirectory(), $"{folder_path}/sprite.json");

			if (!File.Exists(path))
				throw new Exception($"The file {path} does not exist!");

			// Load the Json file
			string	json_text = File.ReadAllText(Path.Combine(path));
			var		sprite_json = JsonConvert.DeserializeObject<dynamic>(json_text);
			
			// Set the origin
			org_x = sprite_json.org_x;
			org_y = sprite_json.org_y;

			// Load the frames
			int i;

			for (i = 0; i < (int) sprite_json.frames; i++)
				frames.Add(Raylib.LoadTexture($"{folder_path}/img_{i}.png"));
			
			// Create the hitbox
			switch (sprite_json.hitbox.type) {
				case "rectangle":
					hitbox = new Hitbox(HitboxType.rectangle, sprite_json.hitbox.x, sprite_json.hitbox.y, sprite_json.hitbox.width, sprite_json.hitbox.height);
					break;
			}


			// Throw an error if the initial frame was not loaded
			if (i == 0)
				throw new Exception($"Could not find the intial frame in {folder_path}");
		}

		#region Other functions
		public int getWidth()
		{
			return frames[0].Width;
		}

		public int getHeight()
		{
			return frames[0].Height;
		}

		public int getOrgX()
		{
			return org_x;
		}

		public int getOrgY()
		{
			return org_y;
		}
		#endregion
	}
}
