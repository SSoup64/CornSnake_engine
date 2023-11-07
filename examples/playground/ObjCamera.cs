using System;
using CornSnake;

namespace Program {
	class ObjCamera : CornSnake.Object {
		CornSnake.Object follow;
		int smoothness = 4;

		public override void onCreate(ref Game game) {
			follow = (CornSnake.Object) game.instanceFind<ObjPlayer>();

			this.x = game.cameraGetX();
			this.y = game.cameraGetY();
		}

		public override void endUpdate(ref Game game) {
			// Calculate the camera_x_to and camera_y_to variables 
			int camera_x_to = Math.Max(0, follow.x - game.cameraGetWidth()/2);
			int camera_y_to = Math.Max(0, follow.y - game.cameraGetHeight()/2);
			
			// Calculate new X and Y
			this.x += (camera_x_to - game.cameraGetX())/this.smoothness;
			this.y += (camera_y_to - game.cameraGetY())/this.smoothness;

			// Set the camera's position
			game.cameraSetPos(this.x, this.y);
		}
	}
}
