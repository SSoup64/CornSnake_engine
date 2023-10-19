using System;
using SDL2;

namespace CornSnake {
	public class Game {
		// Attributes
		private List<Object> objects;
		
		public IntPtr renderer;
		public IntPtr window;

		private bool initialized = false;
		
		// Constructor
		public Game() {
			objects = new List<Object>();
		}
		
		// Init function
		public void init() {
			// Initialize SDL2
			if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
				throw new Exception("SDL could not be initialized");
			
			// Initialize SDL2_Image
			if (SDL_image.IMG_Init(SDL_image.IMG_InitFlags.IMG_INIT_PNG) == 0)
				throw new Exception("SDL image could not be initialized");
			
			// Create the window
			window = SDL.SDL_CreateWindow("Title", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, 1024, 768, 0);

			// Create the renderer
			renderer = SDL.SDL_CreateRenderer(window, -1, 0);

			// Set the initialize variable to true
			initialized = true;
		}

		// Run function
		public void run() {
			// Initialize if not iniitalized yet
			if (!this.initialized)
				this.init();
			
			// Variable decleration
			bool end = false;
			SDL.SDL_Event ev;

			// Enter the loop
			while (!end) {
				while (SDL.SDL_PollEvent(out ev) != 0) {
					switch (ev.type) {
						case SDL.SDL_EventType.SDL_QUIT:
							end = true;
							break;
					}
				}
			}

			SDL.SDL_DestroyWindow(window);

			SDL.SDL_Quit();
		}

		// Other functions
		public void newObject<T>(double x, double y) {
			var me = this;

			Object base_obj = new Object(ref me);

			base_obj.x = x;
			base_obj.y = y;

			// T obj = (T) (Convert.ChangeType(base_obj, typeof(T)));

			objects.Add((Object) (Convert.ChangeType(base_obj, typeof(T))));
		}
	}
}

