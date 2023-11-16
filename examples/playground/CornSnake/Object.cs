using System;
using System.IO;
using System.Reflection;
using Raylib_cs;

namespace CornSnake
{
	public class Object
	{
		#region Attributes

		// TODO: Make obj_id not overrideable
		public uint obj_id;					// The ID of the object in question

		public System.Type my_type;			// The type to cast the object to

		public int x = 0,					// X position
				   y = 0;					// Y position

		public float x_scale = 1,			// How much to scale the sprite across the x direction
					 y_scale = 1;			// How much to scale the sprite across the y direction

		public float rotation = 0;			// The rotation of the sprite;

		public int sprite_index = 0;

		public Sprite sprite;				// The default sprite variable for the object 

		public bool is_global = false;		// If set to true, the object won't be deleted when going between rooms.
											// These objects may only be created at before the game runs.

		public int depth = 0;				// The smaller the later it draws.
		#endregion

		#region Events
		// Create
		public virtual void onCreate(ref Game game) { }

		// Destroy
		public virtual void onDestroy(ref Game game) { }

		// Update
		public virtual void beginUpdate(ref Game game) { }
		public virtual void onUpdate(ref Game game) { }
		public virtual void endUpdate(ref Game game) { }

		// Render
		public virtual void beginRender(ref Game game) { }
		public virtual void onRender(ref Game game)
		{
			if (!Object.Equals(sprite, default(Sprite)))
				renderDrawSelf(ref game);
		}
		public virtual void endRender(ref Game game) { }
		#endregion

		// Constructor and destructor
		public Object()
		{
			my_type = GetType();
		}

		~Object()
		{
			sprite = null;
		}

		#region Other functions
		public void renderDrawSelf(ref Game game)
		{
			game.renderDrawSprite(x, y, sprite, sprite_index, x_scale, y_scale, rotation);
		}
		#endregion
	}
}
