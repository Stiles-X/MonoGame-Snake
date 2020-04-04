using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoEngine;

namespace Snake.Entities
{
	public class Scoreboard : Entity
	{
		private const int Width = 380;
		private const int Height = 80;
		private const float SnakePartSize = 5;
		private readonly Region BackgroundRegion;
		private readonly Region SnakeRegion;

		public Scoreboard() {
			this.Depth = -100;
			this.Position = new Vector2(Engine.Game.CanvasWidth / 2 - Scoreboard.Width / 2, 30 + 30 + 20);

			this.BackgroundRegion = new Region(ContentHolder.Get(Settings.CurrentBackground), (int)this.Position.X, (int)this.Position.Y, Scoreboard.Width, Scoreboard.Height, 0, 0);
			this.SnakeRegion = new Region(ContentHolder.Get(Settings.CurrentSnake));
		}

		public override void onDraw(SpriteBatch sprite_batch) {
			base.onDraw(sprite_batch);

			var scale = new Vector2(Scoreboard.SnakePartSize / this.SnakeRegion.GetWidth());

			sprite_batch.Draw(this.BackgroundRegion, this.Position + new Vector2(0, 0), Color.White);
			for (int x = 0; x < 76; x++) {
				sprite_batch.Draw(this.SnakeRegion, this.Position + new Vector2(x * Scoreboard.SnakePartSize, 0), Color.White, 0, scale);
				sprite_batch.Draw(this.SnakeRegion, this.Position + new Vector2(x * Scoreboard.SnakePartSize, Scoreboard.Height - Scoreboard.SnakePartSize), Color.White, 0, scale);
			}

			for (int y = 0; y < 16; y++) {
				sprite_batch.Draw(this.SnakeRegion, this.Position + new Vector2(0, y * Scoreboard.SnakePartSize), Color.White, 0, scale);
				sprite_batch.Draw(this.SnakeRegion, this.Position + new Vector2(Scoreboard.Width / 2 - Scoreboard.SnakePartSize / 2, y * Scoreboard.SnakePartSize), Color.White, 0, scale);
				sprite_batch.Draw(this.SnakeRegion, this.Position + new Vector2(Scoreboard.Width - Scoreboard.SnakePartSize, y * Scoreboard.SnakePartSize), Color.White, 0, scale);
			}

			for (int i = 0; i < Scoreboard.LetterLocations.Length; i++) {
				sprite_batch.Draw(this.SnakeRegion, this.Position + Scoreboard.LetterLocations[i], Color.White, 0, scale);
			}
		}

		private static Vector2[] LetterLocations = {
			// Current
			new Vector2(166, 30),
			new Vector2(166, 25),
			new Vector2(166, 20),
			new Vector2(173, 15),
			new Vector2(168, 15),
			new Vector2(163, 15),
			new Vector2(158, 15),
			new Vector2(150, 15),
			new Vector2(150, 30),
			new Vector2(150, 20),
			new Vector2(150, 25),
			new Vector2(145, 25),
			new Vector2(140, 20),
			new Vector2(135, 15),
			new Vector2(135, 20),
			new Vector2(135, 25),
			new Vector2(135, 30),
			new Vector2(121, 22),
			new Vector2(116, 22),
			new Vector2(126, 30),
			new Vector2(121, 30),
			new Vector2(116, 30),
			new Vector2(111, 30),
			new Vector2(111, 25),
			new Vector2(111, 20),
			new Vector2(126, 15),
			new Vector2(121, 15),
			new Vector2(116, 15),
			new Vector2(111, 15),
			new Vector2(102, 30),
			new Vector2(102, 25),
			new Vector2(102, 18),
			new Vector2(97, 23),
			new Vector2(92, 23),
			new Vector2(97, 15),
			new Vector2(92, 15),
			new Vector2(87, 30),
			new Vector2(87, 25),
			new Vector2(87, 20),
			new Vector2(87, 15),
			new Vector2(78, 30),
			new Vector2(78, 25),
			new Vector2(78, 18),
			new Vector2(73, 23),
			new Vector2(68, 23),
			new Vector2(73, 15),
			new Vector2(68, 15),
			new Vector2(63, 30),
			new Vector2(63, 25),
			new Vector2(63, 20),
			new Vector2(63, 15),
			new Vector2(55, 15),
			new Vector2(55, 20),
			new Vector2(55, 25),
			new Vector2(52, 30),
			new Vector2(47, 30),
			new Vector2(42, 30),
			new Vector2(39, 25),
			new Vector2(39, 20),
			new Vector2(39, 15),
			new Vector2(16, 20),
			new Vector2(16, 25),
			new Vector2(21, 30),
			new Vector2(26, 30),
			new Vector2(31, 27),
			new Vector2(31, 18),
			new Vector2(26, 15),
			new Vector2(21, 15),
			// Best
			new Vector2(319, 30),
			new Vector2(319, 25),
			new Vector2(319, 20),
			new Vector2(326, 15),
			new Vector2(321, 15),
			new Vector2(316, 15),
			new Vector2(311, 15),
			new Vector2(297, 22),
			new Vector2(292, 22),
			new Vector2(287, 19),
			new Vector2(292, 15),
			new Vector2(297, 15),
			new Vector2(302, 15),
			new Vector2(302, 26),
			new Vector2(297, 30),
			new Vector2(292, 30),
			new Vector2(287, 30),
			new Vector2(273, 22),
			new Vector2(268, 22),
			new Vector2(278, 30),
			new Vector2(273, 30),
			new Vector2(268, 30),
			new Vector2(263, 30),
			new Vector2(263, 25),
			new Vector2(263, 20),
			new Vector2(278, 15),
			new Vector2(273, 15),
			new Vector2(268, 15),
			new Vector2(263, 15),
			new Vector2(254, 26),
			new Vector2(254, 18),
			new Vector2(249, 22),
			new Vector2(244, 22),
			new Vector2(249, 30),
			new Vector2(244, 30),
			new Vector2(249, 15),
			new Vector2(244, 15),
			new Vector2(239, 30),
			new Vector2(239, 25),
			new Vector2(239, 20),
			new Vector2(239, 15)
		};
	}
}
