using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Raylib_cs;
using static Raylib_cs.ConfigFlags;

namespace CornSnake
{
	public class Game
	{
#region Attributes
		private List<object> objects;
		private List<object> objects_render;
		private uint cur_obj_id;

		private IDictionary<string, Sprite> sprites;

		// Window dimensions
		private int window_width, window_height;

		// Camera variables
		Camera2D camera;
		int camera_x, camera_y;
		float camera_zoom;

		private bool initialized = false;
		private bool rendering = false;
		private bool running = false;

		// Render variables
		private Color render_color;

		private int cur_game_frame = 0;
#endregion

		// Constructor
		public Game()
		{
			objects = new List<object>();
			objects_render = new List<object>();

			sprites = new Dictionary<string, Sprite>();

			cur_obj_id = 0;

			camera_x = camera_y = 0;
			camera_zoom = 1;
		}

		// I don't really know how to call these functions.
		// Guess I could call them 'functions that should never be called by objects'
		private void renderListSort()
		{
			for (int i = 1; i < objects_render.Count; i++)
			{
				var key = objects_render[i];
				var flag = 0;

				for (int j = i - 1; j >= 0 && flag != 1;)
				{
					if (((dynamic)key).depth > ((dynamic)objects_render[j]).depth)
					{
						objects_render[j + 1] = objects_render[j];
						j--;
						objects_render[j + 1] = key;
					}
					else
						flag = 1;
				}
			}
		}

		// Init function
		public void init(int window_width, int window_height, string title, int fps)
		{
			// Set window height and width
			this.window_width = window_width;
			this.window_height = window_height;

			// Set trace level
			Raylib.SetTraceLogLevel(TraceLogLevel.LOG_ERROR);

			// Create the window
			Raylib.InitWindow(window_width, window_height, title);

			// Set default color
			renderSetColor(0, 0, 0, 0);

			// Set target FPS
			Raylib.SetTargetFPS(fps);

			// Set the exit key to no key
			Raylib.SetExitKey(KeyboardKey.KEY_NULL);

			// Create the camera
			camera = new Camera2D();
			camera.Zoom = camera_zoom;
			camera.Target = new Vector2(camera_x, camera_y);

			// Set the initialize variable to true
			initialized = true;

			// Set running to true
			running = true;
		}

		// Run function
		public void run()
		{
			// Check if initialized the game object
			if (!initialized)
				throw new Exception("Game object was not initialized.");

			// Variable decleration
			var me = this;

			// Enter the loop
			while (running)
			{
				// Run the beforeUpdate function on all the objects
				for (int i = 0; i < objects.Count; i++)
				{
					if (objects[i] == null)
					{
						objects.RemoveAt(i);
						break;
					}

					((dynamic) objects[i]).beginUpdate(ref me);
				}

				// Run the onUpdate function on all the objects
				for (int i = 0; i < objects.Count; i++)
				{
					if (objects[i] == null)
					{
						objects.RemoveAt(i);
						break;
					}

					((dynamic) objects[i]).onUpdate(ref me);
				}

				// Run the afterUpdate function on all the objects
				for (int i = 0; i < objects.Count; i++)
				{
					if (objects[i] == null)
					{
						objects.RemoveAt(i);
						break;
					}

					((dynamic) objects[i]).endUpdate(ref me);
				}

				// Update the camera variables
				camera.Target = new Vector2(camera_x, camera_y);
				camera.Zoom = camera_zoom;

				// Begin drawing
				Raylib.BeginDrawing();
				Raylib.BeginMode2D(camera);

				// Render
				render();

				// End drawing
				Raylib.EndMode2D();
				Raylib.EndDrawing();

				// Increment frame count
				cur_game_frame++;

				// Check if the window should close
				if (Raylib.WindowShouldClose())
					running = false;
			}

			Raylib.CloseWindow();
		}

		// Render function
		private void render()
		{
			rendering = true;

			// Clear the renderer
			Raylib.ClearBackground(Color.BLACK);

			// Render the objects
			renderObjects();

			rendering = false;
		}


		private void renderObjects()
		{
			// Check if there are any objects to draw
			if (objects.Count <= 0)
				return;

			// Sort the render list
			renderListSort();

			// Render the objects
			var me = this;

			// 
			foreach (var i in objects_render)
				((dynamic) i).beginRender(ref me);

			foreach (var i in objects_render)
				((dynamic) i).onRender(ref me);

			foreach (var i in objects_render)
				((dynamic) i).endRender(ref me);
		}


#region Functions that deal with the rendering
		public void renderSetColor(byte red, byte green, byte blue, byte alpha = 255)
		{   // Sets the renderer's color
			if (!rendering)
				return;

			render_color = new Color(red, green, blue, alpha);
		}


		public void renderDrawSprite(int _x, int _y, Sprite sprite, int index = 0, float x_scale = 1, float y_scale = 1, float rotation = 0)
		{
			if (!rendering)
				return;
			//	Image frame = sprite.frames[index];
			//	Raylib.ImageResize(ref frame, (int) x_scale * frame.Width, (int) y_scale * frame.Height);
			Rectangle	source = new Rectangle {	X = 0, Y = 0,
													Width = Math.Sign(x_scale) * sprite.frames[index].Width, Height = Math.Sign(y_scale) * sprite.frames[index].Height },
						dest = new Rectangle {	X = _x, Y = _y,
												Width = Math.Abs(sprite.frames[index].Width * x_scale), Height = Math.Abs(sprite.frames[index].Height * y_scale) };

			Vector2 origin = new Vector2((x_scale > 0) ? sprite.getOrgX() * x_scale : (sprite.frames[index].Width - sprite.getOrgX()) * Math.Abs(x_scale),
											(y_scale > 0) ? sprite.getOrgY() * y_scale : (sprite.frames[index].Height - sprite.getOrgY()) * Math.Abs(y_scale));

			Raylib.DrawTexturePro(sprite.frames[index], source, dest, origin, rotation, Color.WHITE);
		}

		public void renderDrawRect(int x1, int y1, int x2, int y2, bool outline = false)
		{
			int x, y, width, height;

			x = Math.Min(x1, x2);
			y = Math.Min(y1, y2);

			width = Math.Max(x1 - x, x2 - x);
			height = Math.Max(y1 - y, y2 - y);

			if (outline)
				Raylib.DrawRectangleLines(x, y, width, height, render_color);
			else
				Raylib.DrawRectangle(x, y, width, height, render_color);
		}

		public void renderDrawCircle(int x, int y, double radius, bool outline = false)
		{
			if (outline)
				Raylib.DrawCircleLines(x, y, (float) radius, render_color);
			else
				Raylib.DrawCircle(x, y, (float) radius, render_color);
		}

		public void renderDrawLine(int x1, int y1, int x2, int y2, double thickness = 1)
		{
			Vector2	vec_start	= new Vector2(x1, y1),
					vec_end		= new Vector2(x2, y2);

			Raylib.DrawLineEx(vec_start, vec_end, (float) thickness, render_color);
		}
#endregion

#region Functions that deal with objects
		public void instanceCreate<T>(int x, int y) where T : Object, new()
		{
			var me = this;

			// T obj = (T) Activator.CreateInstance(typeof(T), 1);
			T obj = new T();

			((dynamic)obj).onCreate(ref me);
			((dynamic)obj).obj_id = cur_obj_id;

			obj.x = x;
			obj.y = y;

			objects.Add(obj);
			objects_render.Add(objects[objects.Count - 1]);

			cur_obj_id++;
		}

		// This function finds and returns a refrence to the index-th object of type T where the objects are numbered from newest to oldest
		public ref object instanceFind<T>(int index = 0)
		{
			int found = -1;
			int ind = 0;

			foreach (var i in objects)
			{
				if (typeof(T) == i.GetType())
					found++;

				if (found == index)
				{
					var listSpan = CollectionsMarshal.AsSpan(objects);
					return ref listSpan[ind];
				}

				ind++;
			}

			throw new Exception("Tried to find an object with an invalid index.");
		}

		public bool instanceExists(Object obj)
		{
			return (obj != null);
		}

		public void instanceDestroy(uint obj_id)
		{
			if (rendering)
				throw new Exception("Tried to destroy an object while rendering");

			for (int i = 0; i < objects.Count; i++)
			{
				if (((dynamic)objects[i]).obj_id == obj_id)
					objects[i] = null;
			}
		}
#endregion

#region Functions that deal with the camera
		public void cameraResize(float zoom)
		{
			camera_zoom = zoom;
		}

		public float cameraGetZoom()
		{
			return camera_zoom;
		}

		public int cameraGetWidth()
		{
			return window_width / Convert.ToInt32(camera_zoom);
		}

		public int cameraGetHeight()
		{
			return window_height / Convert.ToInt32(camera_zoom);
		}

		public void cameraSetPos(int x, int y)
		{
			camera_x = x;
			camera_y = y;
		}

		public void cameraSetX(int x)
		{
			camera_x = x;
		}

		public void cameraSetY(int y)
		{
			camera_y = y;
		}

		public int cameraGetX()
		{
			return camera_x;
		}

		public int cameraGetY()
		{
			return camera_y;
		}

#endregion

#region Functions that deal with sprites
		public void spriteLoad(string name)
		{
			var me = this;
			sprites.Add(name, new Sprite(ref me, $"Sprites/{name}"));
		}

		public Sprite spriteGet(string name)
		{
			if (!sprites.ContainsKey(name))
				throw new Exception("Tried to get a sprite that is not loaded.");

			return sprites[name];
		}
#endregion

#region Input
		// Mouse
		public int inputMouseGetX()
		{
			return Convert.ToInt32(Raylib.GetMouseX()/camera_zoom) + camera_x;
		}

		public int inputMouseGetY()
		{
			return Convert.ToInt32(Raylib.GetMouseY()/camera_zoom) + camera_y;
		}

		public bool inputMouseIsHeld(Mouse button)
		{
			return Raylib.IsMouseButtonDown((Raylib_cs.MouseButton) button);
		}

		public bool inputMouseIsPressed(Mouse button)
		{
			return Raylib.IsMouseButtonPressed((Raylib_cs.MouseButton) button);
		}

		public bool inputMouseIsReleased(Mouse button)
		{
			return Raylib.IsMouseButtonReleased((Raylib_cs.MouseButton) button);
		}

		// keyboard
		public bool inputKeyboardIsHeld(Keyboard key)
		{
			return Raylib.IsKeyDown((Raylib_cs.KeyboardKey) key);
		}

		public bool inputKeyboardIsPressed(Keyboard key)
		{
			return Raylib.IsKeyPressed((Raylib_cs.KeyboardKey) key);
		}

		public bool inputKeyboardIsReleased(Keyboard key)
		{
			return Raylib.IsKeyReleased((Raylib_cs.KeyboardKey) key);
		}

		// Gamepad
		public bool inputGamepadExists(int gamepad = 0)
		{
			return Raylib.IsGamepadAvailable(gamepad);
		}

		public bool inputGamepadIsHeld(GamepadButton btn, int gamepad = 0)
		{
			return Raylib.IsGamepadButtonDown(gamepad, (Raylib_cs.GamepadButton) btn);
		}

		public bool inputGamepadIsPressed(GamepadButton btn, int gamepad = 0)
		{
			return Raylib.IsGamepadButtonPressed(gamepad, (Raylib_cs.GamepadButton) btn);
		}

		public bool inputGamepadIsReleased(GamepadButton btn, int gamepad = 0)
		{
			return Raylib.IsGamepadButtonReleased(gamepad, (Raylib_cs.GamepadButton) btn);
		}

		public float GetGamepadAxis(GamepadAxis axis, int gamepad = 0)
		{
			return Raylib.GetGamepadAxisMovement(gamepad, ((Raylib_cs.GamepadAxis) axis));
		}
#endregion

		public int getCurFrame()
		{
			return cur_game_frame;
		}
	}
}

