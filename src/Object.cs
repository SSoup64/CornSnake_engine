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

		public Sprite			sprite;					// The default sprite variable for the object 

		public bool				is_global = false;		// If set to true, the object won't be deleted when going between rooms.
														// These objects may only be created at before the game runs.

		// Events
		public void onCreate(ref Game game)		{ Console.WriteLine("Fuck me"); }
		public void onUpdate(ref Game game)		{}
		public void onDestroy(ref Game game)	{}
		public void onRender(ref Game game)		{}

		// Constructor and destructor
		public Object() {
			Console.WriteLine("Created an object");
			my_type = GetType();
		}

		~Object() {
			sprite = null;
		}
	}
}
