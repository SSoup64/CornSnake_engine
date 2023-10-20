using System;
using System.IO;
using System.Reflection;
using SDL2;

namespace CornSnake {
	public class Object {
		// Attributes
		public System.Type		my_type;				// The type to cast the object to

		public int				x = 0,					// X position
								y = 0;					// Y position
		
		public int				sprite_index = 0;

		public Sprite			sprite;					// The default sprite variable for the object 

		public bool				is_global = false;		// If set to true, the object won't be deleted when going between rooms.
														// These objects may only be created at before the game runs.

		// Events
		public void onCreate(ref Game game)		{}
		public void onUpdate(ref Game game)		{}
		public void onDestroy(ref Game game)	{}
		
		public void onRender(ref Game game)	 {
			renderDrawSelf(ref game);
		}

		// Constructor and destructor
		public Object() {
			Console.WriteLine("Created an object");
			my_type = GetType();
		}

		~Object() {
			sprite = null;
		}

		// Sealed functions
		private void renderDrawSelf(ref Game game) {
			game.renderDrawSprite(x, y, sprite, sprite_index);
		}
	}
}
