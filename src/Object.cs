using System;
using System.IO;
using System.Reflection;
using Raylib_cs;

namespace CornSnake {
	public class Object {
#region Attributes
		
		// TODO: Make obj_id not overrideable
		public uint				obj_id;					// The ID of the object in question

		public System.Type		my_type;				// The type to cast the object to

		public int				x = 0,					// X position
								y = 0;					// Y position
		
		public int				sprite_index = 0;

		public Sprite			sprite;					// The default sprite variable for the object 

		public bool				is_global = false;		// If set to true, the object won't be deleted when going between rooms.
														// These objects may only be created at before the game runs.

		public int				depth = 0;				// The smaller the later it draws.
#endregion

#region Events
		// Create
		public void onCreate(ref Game game)		{}
		
		// Destroy
		public void onDestroy(ref Game game)	{}
		
		// Update
		public void beforeUpdate(ref Game game)	{}
		public void onUpdate(ref Game game)		{}
		public void afterUpdate(ref Game game)	{}
		
		// Render
		public void onRender(ref Game game)	 {
			if (!Object.Equals(sprite, default(Sprite)))
				renderDrawSelf(ref game);
		}
#endregion

		// Constructor and destructor
		public Object() {
			my_type = GetType();
		}

		~Object() {
			sprite = null;
		}

#region Other functions
		public void renderDrawSelf(ref Game game) {
			game.renderDrawSprite(x, y, sprite, sprite_index);
		}
#endregion
	}
}
