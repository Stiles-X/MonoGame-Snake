using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoEngine;
using Snake.Entities.UI;
using Snake.Enums;
using Snake.Rooms;

namespace Snake.Entities.Controls
{
	public class MainMenuUI : Entity
	{
		private Rolodex[] Rolodexes = new Rolodex[3];
		private int Index = 1;
		private VirtualButton ButtonLeft = new VirtualButton();
		private VirtualButton ButtonRight = new VirtualButton();
		private VirtualButton ButtonUp = new VirtualButton();
		private VirtualButton ButtonDown = new VirtualButton();
		private VirtualButton ButtonSelect = new VirtualButton();

		public MainMenuUI() {
			int rolodex_y = Engine.Game.CanvasHeight / 2 + 20;
			var themes = new RolodexEntry[] {
				new RolodexEntry(new ButtonTheme(0), 180, rolodex_y, 1, 0),
				new RolodexEntry(new ButtonTheme(1), 180, rolodex_y + 90, 0.5f, 1),
				new RolodexEntry(new ButtonTheme(2), 180, rolodex_y + 70, 0.4f, 2),
				new RolodexEntry(new ButtonTheme(3), 180, rolodex_y + 44, 0.3f, 3),
				new RolodexEntry(new ButtonTheme(4), 180, rolodex_y + 26, 0.2f, 4),
				// new RolodexEntry(new ButtonTheme(0), 180, rolodex_y + 0, 0.1f, 5),
				new RolodexEntry(new ButtonTheme(5), 180, rolodex_y - 26, 0.2f, 4),
				new RolodexEntry(new ButtonTheme(6), 180, rolodex_y - 44, 0.3f, 3),
				new RolodexEntry(new ButtonTheme(7), 180, rolodex_y - 70, 0.4f, 2),
				new RolodexEntry(new ButtonTheme(8), 180, rolodex_y - 90, 0.5f, 1),
			};
			foreach (var entry in themes) {
				Engine.SpawnInstance(entry.Button);
			}
			this.Rolodexes[0] = new Rolodex(themes);
			this.Rolodexes[0].Collapse(0);

			var game_modes = new RolodexEntry[] {
				new RolodexEntry(new ButtonClassic(), Engine.Game.CanvasWidth / 2, rolodex_y, 1, 0),
				new RolodexEntry(new ButtonOpen(), Engine.Game.CanvasWidth / 2, rolodex_y + 100, 0.5f, 1),
				new RolodexEntry(new ButtonLevels(), Engine.Game.CanvasWidth / 2, rolodex_y - 100, 0.5f, 1),
			};
			foreach (var rolodex_entry in game_modes) {
				Engine.SpawnInstance(rolodex_entry.Button);
			}
			int game_mode_index;
			if (Settings.CurrentGameRoom == GameRooms.Classic)
				game_mode_index = 0;
			else if (Settings.CurrentGameRoom == GameRooms.Open)
				game_mode_index = 1;
			else
				game_mode_index = 2;
			this.Rolodexes[1] = new Rolodex(game_modes, game_mode_index);

			var speeds = new RolodexEntry[] {
				new RolodexEntry(new ButtonMedium(), Engine.Game.CanvasWidth - 180, rolodex_y, 1, 0),
				new RolodexEntry(new ButtonFast(), Engine.Game.CanvasWidth - 180, rolodex_y + 80, 0.5125f, 1),
				new RolodexEntry(new ButtonSlow(), Engine.Game.CanvasWidth - 180, rolodex_y - 80, 0.5125f, 1),
			};
			foreach (var entry in speeds) {
				Engine.SpawnInstance(entry.Button);
			}
			int speed_index;
			if (Settings.CurrentGameplaySpeed == GameplaySpeeds.Slow)
				speed_index = 2;
			else if (Settings.CurrentGameplaySpeed == GameplaySpeeds.Fast)
				speed_index = 1;
			else
				speed_index = 0;
			this.Rolodexes[2] = new Rolodex(speeds, speed_index);
			this.Rolodexes[2].Collapse(0);

			this.ButtonLeft.AddKey(Keys.Left);
			this.ButtonLeft.AddKey(Keys.A);
			this.ButtonLeft.AddButton(Buttons.DPadLeft);
			this.ButtonLeft.AddButton(Buttons.LeftThumbstickLeft);

			this.ButtonRight.AddKey(Keys.Right);
			this.ButtonRight.AddKey(Keys.D);
			this.ButtonRight.AddButton(Buttons.DPadRight);
			this.ButtonRight.AddButton(Buttons.LeftThumbstickRight);

			this.ButtonUp.AddKey(Keys.Up);
			this.ButtonUp.AddKey(Keys.W);
			this.ButtonUp.AddButton(Buttons.DPadUp);
			this.ButtonUp.AddButton(Buttons.LeftThumbstickUp);

			this.ButtonDown.AddKey(Keys.Down);
			this.ButtonDown.AddKey(Keys.S);
			this.ButtonDown.AddButton(Buttons.DPadDown);
			this.ButtonDown.AddButton(Buttons.LeftThumbstickDown);

			this.ButtonSelect.AddKey(Keys.Space);
			this.ButtonSelect.AddKey(Keys.Enter);
			this.ButtonSelect.AddButton(Buttons.A);
			this.ButtonSelect.AddButton(Buttons.Start);
		}

		public override void onUpdate(float dt) {
			base.onUpdate(dt);

			if (this.ButtonUp.IsPressed() || this.ButtonDown.IsPressed()) {
				if (this.ButtonUp.IsPressed()) {
					this.Rolodexes[this.Index].RollDown();
				}

				if (this.ButtonDown.IsPressed()) {
					this.Rolodexes[this.Index].RollUp();
				}

				var current_button = this.Rolodexes[this.Index].CurrentButton;
				if (current_button is ButtonFast) {
					Settings.CurrentGameplaySpeed = GameplaySpeeds.Fast;
				} else if (current_button is ButtonMedium) {
					Settings.CurrentGameplaySpeed = GameplaySpeeds.Medium;
				} else if (current_button is ButtonSlow) {
					Settings.CurrentGameplaySpeed = GameplaySpeeds.Slow;
				} else if (current_button is ButtonTheme) {
					Settings.CurrentTheme = ((ButtonTheme)current_button).Theme;
				}
			}

			if (this.ButtonRight.IsPressed()) {
				if (this.Index < this.Rolodexes.Length - 1) {
					this.Index++;
					if (this.Index == 2) {
						this.Rolodexes[2].UnCollapse();
					} else if (this.Index == 1) {
						this.Rolodexes[0].Collapse();
					}
				}
			}

			if (this.ButtonLeft.IsPressed()) {
				if (this.Index > 0) {
					this.Index--;
					if (this.Index == 1) {
						this.Rolodexes[2].Collapse();
					} else if (this.Index == 0) {
						this.Rolodexes[0].UnCollapse();
					}
				}
			}

			if (this.ButtonSelect.IsPressed()) {
				var current_button = this.Rolodexes[this.Index].CurrentButton;
				if (current_button is ButtonOpen) {
					Engine.ChangeRoom<RoomPlay>(new Dictionary<string, object> {
						["mode"] = "open"
					});
				} else if (current_button is ButtonClassic) {
					Engine.ChangeRoom<RoomPlay>(new Dictionary<string, object> {
						["mode"] = "classic"
					});
				} else if (current_button is ButtonLevels) {
					Engine.ChangeRoom<RoomLevels>();
				}
			}
		}

		public override void onDraw(SpriteBatch sprite_batch) {
			base.onDraw(sprite_batch);

			var current_button = this.Rolodexes[this.Index].CurrentButton;
			float width = current_button.BaseWidth;
			float height = current_button.BaseHeight;
			float x = current_button.DestPosition.X - width / 2;
			float y = current_button.DestPosition.Y - height / 2;

			RectangleDrawer.DrawAround(sprite_batch, x, y, width, height, Color.Black * 0.5f, 5);
		}

		internal class Rolodex
		{
			private const int AdjustDuration = 200;
			private const Tween AdjustTween = Tween.SquareEaseOut;
			private readonly float CenterX;
			private readonly float CenterY;
			private readonly int LowestDepth;
			private readonly RolodexEntry[] Entries;
			internal Button CurrentButton => this.Entries[0].Button;

			internal Rolodex(RolodexEntry[] entries, int initialize_to_index = 0) {
				this.Entries = entries;
				this.CenterX = this.Entries[0].X;
				this.CenterY = this.Entries[0].Y;
				this.LowestDepth = this.Entries[0].Depth;
				foreach (var entry in this.Entries) {
					if (entry.Depth > this.LowestDepth)
						this.LowestDepth = entry.Depth;
				}

				for (int i = 0; i < initialize_to_index; i++) {
					this.RollUp();
				}
				this.AdjustAllButtons(0);
			}

			internal void RollDown() {
				var last_button = this.Entries[this.Entries.Length - 1].Button;
				for (int i = this.Entries.Length - 1; i >= 1; i--) {
					this.Entries[i].Button = this.Entries[i - 1].Button;
				}

				this.Entries[0].Button = last_button;
				this.AdjustAllButtons(Rolodex.AdjustDuration);
			}

			internal void RollUp() {
				var first_button = this.Entries[0].Button;
				for (int i = 0; i <= this.Entries.Length - 2; i++) {
					this.Entries[i].Button = this.Entries[i + 1].Button;
				}

				this.Entries[this.Entries.Length - 1].Button = first_button;
				this.AdjustAllButtons(Rolodex.AdjustDuration);
			}

			internal void Collapse(int duration = Rolodex.AdjustDuration) {
				foreach (var entry in this.Entries) {
					entry.Button.Adjust(new Vector2(this.CenterX, this.CenterY), entry.Scale, duration, Rolodex.AdjustTween);
				}
			}

			internal void UnCollapse(int duration = Rolodex.AdjustDuration) {
				this.AdjustAllButtons(duration);
			}

			private void AdjustAllButtons(int duration) {
				foreach (var entry in this.Entries) {
					entry.Button.Adjust(new Vector2(entry.X, entry.Y), entry.Scale, duration, Rolodex.AdjustTween);

					float start_y = entry.Button.StartPosition.Y;
					float dest_y = entry.Button.DestPosition.Y;
					entry.Button.Depth = entry.Depth;
					if (entry.Button.Depth == this.LowestDepth && ((start_y > this.CenterY && dest_y <= this.CenterY) || (start_y < this.CenterY && dest_y >= this.CenterY)))
						entry.Button.Depth += 1;
				}
			}
		}

		internal class RolodexEntry
		{
			internal readonly int X;
			internal readonly int Y;
			internal readonly float Scale;
			internal readonly int Depth;
			internal Button Button;

			internal RolodexEntry(Button button, int x, int y, float scale, int depth) {
				this.Button = button;
				this.X = x;
				this.Y = y;
				this.Scale = scale;
				this.Depth = depth;
			}
		}
	}
}
