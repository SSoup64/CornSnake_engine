using System;
using CornSnake;

namespace Program {
	class ObjCamera : CornSnake.Object {
		CornSnake.Object follow;

		float smoothness = 0.25f;
		float camera_x = 0, camera_y = 0;

		public override void onCreate(ref Game game) {
			follow = (CornSnake.Object) game.instanceFind<ObjPlayer>();

			this.x = game.cameraGetX();
			this.y = game.cameraGetY();
		}

		public override void endUpdate(ref Game game) {
			// Calculate the camera_x_to and camera_y_to variables 
			float camera_x_to = Math.Max(0, follow.x - game.cameraGetWidth()/2);
			float camera_y_to = Math.Max(0, follow.y - game.cameraGetHeight()/2);
			
			// Calculate new X and Y
			camera_x += (camera_x_to - game.cameraGetX()) * this.smoothness;
			camera_y += (camera_y_to - game.cameraGetY()) * this.smoothness;

			this.x = Convert.ToInt32(camera_x);
			this.y = Convert.ToInt32(camera_y);

			// Set the camera's position
			game.cameraSetPos(this.x, this.y);
		}
	}
}
