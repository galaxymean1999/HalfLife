using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Player {
	public Player(Vector3 pos) {
		position = pos;

		camera = new Camera3D();
		camera.Position = position;
		camera.FovY = 90;
		camera.Projection = CameraProjection.Perspective;
		camera.Target = new Vector3(0, 0, 0);
		camera.Up = new Vector3(0, 1, 0);
	}

	const float g = 0.1f;

	public Vector3 velocity;
	public Vector3 position;

	public Camera3D camera;

	public void Update() {
		Raylib.UpdateCamera(ref camera, CameraMode.FirstPerson);

		
	}
}
