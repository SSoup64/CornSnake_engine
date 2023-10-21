using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SDL2;

namespace CornSnake {
	public class Game {
		// Attributes
		private List<object>	objects;
		private List<int>		index_render_order;
			
		private int window_width, window_height;
		private IntPtr window;
		
		// Renderer variables
		private SDL.SDL_Rect renderer_rect;
		private IntPtr renderer;
		
		// Camera variables
		SDL.SDL_Rect camera_rect;
		private IntPtr camera_surface;
		private IntPtr camera_tex;

		private bool initialized = false;
		private bool rendering = false;

		private uint fps = 60;

		private uint cur_game_frame = 0;
		
		// Input handling
		public Input input;

		// Constructor
		public Game(uint fps) {
			this.fps = fps;

			objects				= new List<object>();
			index_render_order	= new List<int>();
			input				= new Input();
		}
		
		// Init function
		public void init(int window_width, int window_height) {
			// Set window height and width
			this.window_width	= window_width;
			this.window_height	= window_height;

			renderer_rect	= new SDL.SDL_Rect() { x = 0, y = 0, w = window_width, h = window_height };
			camera_rect		= new SDL.SDL_Rect() { x = 0, y = 0, w = window_width, h = window_height };

			// Initialize SDL2
			if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
				throw new Exception("SDL could not be initialized");
			
			// Initialize SDL2_Image
			if (SDL_image.IMG_Init(SDL_image.IMG_InitFlags.IMG_INIT_PNG) == 0)
				throw new Exception("SDL image could not be initialized");
			
			// Create the window
			window = SDL.SDL_CreateWindow(	"Title",	
											SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
											window_width, window_height,
											0);
			
			// Create camera surface
			camera_surface = SDL.SDL_CreateRGBSurface(	0,
														camera_rect.w, camera_rect.h,
														32, 0, 0, 0, 0);

			// Create the renderer
			renderer = SDL.SDL_CreateRenderer(window, -1, 0);

			// Set the initialize variable to true
			initialized = true;
		}

		// Run function
		public void run() {
			// Check if initialized the game object
			if (!this.initialized)
				throw new Exception("Game object was not initialized.");
			
			// Variable decleration
			bool end = false;
			SDL.SDL_Event ev;

			UInt32 frame_start;
			uint frame_time;
			uint frame_delay = 1000/this.fps;
			var me = this;

			int a;

			// Enter the loop
			while (!end) {
				// Get the start time of the frame
				frame_start = SDL.SDL_GetTicks();
				
				// Poll the events
				while (SDL.SDL_PollEvent(out ev) != 0) {
					switch (ev.type) {
						case SDL.SDL_EventType.SDL_QUIT:
							end = true;
							break;
					}
				}

				// Update the input
				input.update();
				
				// Run the update function on all the objects
				foreach (var i in index_render_order) {
					var update_func = objects[i].GetType().GetMethod("onUpdate");
					update_func.Invoke(objects[i], new object[] {me});
				}
				
				// Clear the renderer
				SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 0);
				SDL.SDL_RenderClear(this.renderer);

				// Render
				SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
				SDL.SDL_RenderDrawLine(renderer, 0, 0, 100, 100);
				this.render();

				// Present the renderer
				SDL.SDL_RenderPresent(this.renderer);
				
				// Find out how much to delay in order to get a consistant fps
				frame_time = SDL.SDL_GetTicks() - frame_start;

				if (frame_time < frame_delay)
					SDL.SDL_Delay(frame_delay - frame_time);

				// Increment frame count
				cur_game_frame++;
			}

			SDL.SDL_DestroyWindow(window);

			SDL.SDL_Quit();
		}

		// Render function
		private void render() {
			this.rendering = true;

			// Clear the screen
			SDL.SDL_FillRect(this.camera_surface, ref camera_rect, 0x00000000);
			
			// Render the objects
			this.renderObjects();

			// Make the surface into a texture
			this.camera_tex = SDL.SDL_CreateTextureFromSurface(this.renderer, this.camera_surface);

			// Copy to the renderer
			SDL.SDL_RenderCopy(this.renderer, this.camera_tex, ref camera_rect, ref renderer_rect);
			
			SDL.SDL_DestroyTexture(this.camera_tex);

			this.rendering = false;
		}
		
		
		private void renderObjects() {
			// Check if there are any objects to draw
			if (objects.Count <= 0)
				return;
			
			index_render_order.Clear();
			index_render_order = Enumerable.Range(0, objects.Count).ToList();
			
			// TODO: Sort the index_render_order list using the depth of the corresponding object.


			// Render the objects
			var me = this;

			foreach (var i in index_render_order) {
				var render_func = objects[i].GetType().GetMethod("onRender");
				render_func.Invoke(objects[i], new object[] {me});
			}
		}



		// Other functions
		// Functions that deal with the rendering
		public void renderSetColor(byte red, byte green, byte blue, byte alpha=255) {	// Sets the renderer's color
			SDL.SDL_SetRenderDrawColor(renderer, red, green, blue, alpha);
		}
		
		public void renderDrawSprite(int _x, int _y, Sprite sprite, int index = 0) {		// Draws a specific frame of a sprite at (x, y) scene coordinates
			SDL.SDL_Rect src_rect = new SDL.SDL_Rect() { x = 0, y = 0 };
			SDL.SDL_Rect dst_rect = new SDL.SDL_Rect() { x = _x, y = _y };
			

			src_rect.w = dst_rect.h = sprite.getWidth();
			src_rect.h = dst_rect.h = sprite.getHeight();

			SDL.SDL_BlitSurface(sprite.frames[index], ref src_rect, this.camera_surface, ref dst_rect);
		}


		// TODO: Implement this later
		//public void renderDrawRect(int x1, int y1, int x2, int y2) {
		//
		// }

		// Functions that deal with objects
		public void newObject<T>(int x, int y) where T : Object, new() {
			var me = this;

			T obj = new T();

			((dynamic) obj).onCreate(ref me);

			obj.x = x;
			obj.y = y;

			objects.Add((Object) obj);
		}
	
		// Functions that deal with the camera
		public void cameraResize(int w, int h) {
			this.camera_rect.w = w;
			this.camera_rect.h = h;
			
			SDL.SDL_FreeSurface(this.camera_surface);

			
			camera_surface = SDL.SDL_CreateRGBSurface(	0,
														camera_rect.w, camera_rect.h,
														32, 0, 0, 0, 0);
		}

		public int cameraGetWidth() {
			return this.camera_rect.w;
		}

		public int cameraGetHeight() {
			return this.camera_rect.h;
		}
	}
}

