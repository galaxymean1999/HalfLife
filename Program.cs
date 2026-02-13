using Raylib_cs;
using System.Numerics;

class Program {
	public const int i_WindowWidth = 1280;
	public const int i_WindowHeight = 720;

	public static Player player = new Player(new Vector3(10, 3, 10));

	public static Levels lvl = new Levels();

	public static void Main() {
		Raylib.InitWindow(i_WindowWidth, i_WindowHeight, "FPS");

		Raylib.SetTargetFPS(60);

		Raylib.DisableCursor();

		while (!Raylib.WindowShouldClose()) {

			player.Update();

			Raylib.BeginDrawing();
			Raylib.ClearBackground(Color.Black);
			Raylib.BeginMode3D(player.camera);

			lvl.drawLevel();

			Raylib.EndMode3D();

			Raylib.DrawText($"X:{player.position.X} Y:{player.position.Y} Z:{player.position.Z}", 0, 0, 20, Color.White);

			Raylib.EndDrawing();
		}

		Raylib.CloseWindow();
	}
}