using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

struct Cube {
	public Vector3 position;
	public Vector3 size;
	public Color color;
}

class Levels {
	public Levels() {
		currentLevel = new List<Cube>();

		currentLevel = load(0);
	}

	public List<Cube> currentLevel;

	public List<Cube> load(int level) {
		List<Cube> world = new List<Cube>();

		switch (level) {
			case 0:
				world.Add(new Cube() {
					position = new Vector3(0, 0, 0),
					size = new Vector3(20, 0.5f, 20),
					color = new Color(100, 100, 100)
				});
				break;
		}

		return world;
	}

	public void drawLevel() {
		for (int i = 0; i < currentLevel.Count; i++) {
			Raylib.DrawCube(currentLevel[i].position, currentLevel[i].size.X, currentLevel[i].size.Y, currentLevel[i].size.Z, currentLevel[i].color);
		}
	}
}
