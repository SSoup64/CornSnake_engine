using System;
using SDL2;

namespace CornSnake {
	public class Game {
		// Attributes
		private List<Object> objects;
		
		public IntPtr renderer;
		public IntPtr window;

		private bool initialized = false;

		public uint fps = 60;
		
		// Constructor
		public Game(uint fps) {
			this.fps = fps;
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

			UInt32 frame_start;
			uint frame_time;
			uint frame_delay = 1000/this.fps;

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
				
				// Find out how much to delay in order to get a consistant fps
				frame_time = SDL.SDL_GetTicks() - frame_start;
				
				if (frame_time < frame_delay)
					SDL.SDL_Delay(frame_delay - frame_time);

				Console.WriteLine("Finished a frame");
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

