using System;
using System.IO;
using SDL2;

namespace CornSnake {
	public class Object {
		// Attributes
		public double	x = 0,					// X position
						y = 0;					// Y position

		public Sprite	sprite;					// The default sprite variable for the object 

		public bool		is_global = false;		// If set to true, the object won't be deleted when going between rooms.
												// These objects may only be created at before the game runs.

		// Events
		public void onCreate(ref Game game)		{}
		public void onUpdate(ref Game game)		{}
		public void onDestroy(ref Game game)	{}
		public void onRender(ref Game game)		{}

		// Constructor and destructor
		public Object(ref Game game) {
			onCreate(ref game);
		}

		~Object() {
			sprite = null;
		}
	}
}
