using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;

namespace Snake
{
	public static class LogoDrawData
	{
		public static ReadOnlyDictionary<int, Vector2[]> ScoreNumberLocations = new ReadOnlyDictionary<int, Vector2[]>(new Dictionary<int, Vector2[]> {
			[1] = new[] {
				new Vector2(4, 3),
				new Vector2(9, 15),
				new Vector2(9, 10),
				new Vector2(9, 5),
				new Vector2(9, 0)
			},
			[2] = new[] {
				new Vector2(15, 15),
				new Vector2(10, 15),
				new Vector2(5, 15),
				new Vector2(0, 15),
				new Vector2(0, 10),
				new Vector2(5, 7),
				new Vector2(10, 7),
				new Vector2(15, 4),
				new Vector2(10, 0),
				new Vector2(5, 0),
				new Vector2(0, 0),
			},
			[3] = new[] {
				new Vector2(0, 12),
				new Vector2(5, 15),
				new Vector2(10, 15),
				new Vector2(15, 12),
				new Vector2(10, 8),
				new Vector2(15, 4),
				new Vector2(10, 0),
				new Vector2(0, 3),
				new Vector2(5, 0),
			},
			[4] = new[] {
				new Vector2(0, 5),
				new Vector2(5, 7),
				new Vector2(10, 7),
				new Vector2(15, 15),
				new Vector2(15, 10),
				new Vector2(15, 5),
				new Vector2(15, 0),
				new Vector2(0, 0),
			},
			[5] = new[] {
				new Vector2(0, 15),
				new Vector2(5, 15),
				new Vector2(10, 15),
				new Vector2(15, 11),
				new Vector2(10, 7),
				new Vector2(5, 7),
				new Vector2(0, 5),
				new Vector2(15, 0),
				new Vector2(10, 0),
				new Vector2(5, 0),
				new Vector2(0, 0),
			},
			[6] = new[] {
				new Vector2(5, 15),
				new Vector2(10, 15),
				new Vector2(15, 11),
				new Vector2(10, 7),
				new Vector2(5, 7),
				new Vector2(0, 12),
				new Vector2(0, 7),
				new Vector2(0, 2),
				new Vector2(5, 0),
				new Vector2(10, 0),
				new Vector2(15, 0),
			},
			[7] = new[] {
				new Vector2(5, 10),
				new Vector2(5, 15),
				new Vector2(10, 8),
				new Vector2(15, 5),
				new Vector2(15, 0),
				new Vector2(10, 0),
				new Vector2(5, 0),
				new Vector2(0, 0),
			},
			[8] = new[] {
				new Vector2(10, 15),
				new Vector2(5, 15),
				new Vector2(0, 11),
				new Vector2(15, 11),
				new Vector2(10, 7),
				new Vector2(5, 7),
				new Vector2(0, 3),
				new Vector2(15, 3),
				new Vector2(10, 0),
				new Vector2(5, 0),
			},
			[9] = new[] {
				new Vector2(15, 13),
				new Vector2(10, 8),
				new Vector2(5, 8),
				new Vector2(0, 4),
				new Vector2(5, 0),
				new Vector2(10, 0),
				new Vector2(0, 15),
				new Vector2(5, 15),
				new Vector2(10, 15),
				new Vector2(15, 8),
				new Vector2(15, 3),
			},
			[0] = new[] {
				new Vector2(0, 8),
				new Vector2(0, 13),
				new Vector2(15, 8),
				new Vector2(15, 13),
				new Vector2(10, 15),
				new Vector2(5, 15),
				new Vector2(0, 3),
				new Vector2(15, 3),
				new Vector2(10, 0),
				new Vector2(5, 0),
			}
		});

		public static readonly Vector2[] PausedLogoLocations = {
			// P
			new Vector2(273, 230),
			new Vector2(283, 230),
			new Vector2(293, 230),
			new Vector2(263, 250),
			new Vector2(263, 240),
			new Vector2(263, 230),
			new Vector2(263, 220),
			new Vector2(263, 210),
			new Vector2(273, 210),
			new Vector2(283, 210),
			new Vector2(293, 210),
			new Vector2(303, 220),
			// A
			new Vector2(319, 250),
			new Vector2(319, 240),
			new Vector2(359, 250),
			new Vector2(359, 240),
			new Vector2(359, 230),
			new Vector2(359, 220),
			new Vector2(349, 230),
			new Vector2(339, 230),
			new Vector2(329, 230),
			new Vector2(319, 230),
			new Vector2(319, 220),
			new Vector2(349, 210),
			new Vector2(339, 210),
			new Vector2(329, 210),
			// U
			new Vector2(412, 210),
			new Vector2(412, 220),
			new Vector2(412, 230),
			new Vector2(412, 240),
			new Vector2(404, 250),
			new Vector2(394, 250),
			new Vector2(384, 250),
			new Vector2(376, 240),
			new Vector2(376, 230),
			new Vector2(376, 220),
			new Vector2(376, 210),
			// S
			new Vector2(430, 250),
			new Vector2(440, 250),
			new Vector2(450, 250),
			new Vector2(460, 250),
			new Vector2(469, 240),
			new Vector2(460, 230),
			new Vector2(450, 230),
			new Vector2(440, 230),
			new Vector2(430, 220),
			new Vector2(439, 210),
			new Vector2(449, 210),
			new Vector2(459, 210),
			new Vector2(469, 210),
			// E
			new Vector2(516, 230),
			new Vector2(506, 230),
			new Vector2(496, 230),
			new Vector2(526, 250),
			new Vector2(516, 250),
			new Vector2(506, 250),
			new Vector2(496, 250),
			new Vector2(486, 250),
			new Vector2(486, 240),
			new Vector2(486, 230),
			new Vector2(486, 220),
			new Vector2(526, 210),
			new Vector2(516, 210),
			new Vector2(506, 210),
			new Vector2(496, 210),
			new Vector2(486, 210),
			// D
			new Vector2(552, 250),
			new Vector2(562, 250),
			new Vector2(572, 250),
			new Vector2(582, 240),
			new Vector2(582, 230),
			new Vector2(582, 220),
			new Vector2(572, 210),
			new Vector2(562, 210),
			new Vector2(552, 210),
			new Vector2(542, 250),
			new Vector2(542, 240),
			new Vector2(542, 230),
			new Vector2(542, 220),
			new Vector2(542, 210),
		};

		public static readonly Vector2[] SnakeLogoLocations = {
			// S
			new Vector2(0, 64),
			new Vector2(16, 64),
			new Vector2(32, 64),
			new Vector2(48, 64),
			new Vector2(64, 48),
			new Vector2(48, 32),
			new Vector2(32, 32),
			new Vector2(64, 0),
			new Vector2(16, 32),
			new Vector2(16, 32),
			new Vector2(0, 16),
			new Vector2(16, 0),
			new Vector2(32, 0),
			new Vector2(48, 0),
			// N
			new Vector2(165, 64),
			new Vector2(165, 0),
			new Vector2(165, 16),
			new Vector2(165, 32),
			new Vector2(165, 48),
			new Vector2(149, 48),
			new Vector2(133, 32),
			new Vector2(117, 16),
			new Vector2(101, 0),
			new Vector2(101, 16),
			new Vector2(101, 32),
			new Vector2(101, 48),
			new Vector2(101, 64),
			// A
			new Vector2(266, 64),
			new Vector2(266, 48),
			new Vector2(266, 32),
			new Vector2(250, 32),
			new Vector2(234, 32),
			new Vector2(218, 32),
			new Vector2(266, 16),
			new Vector2(250, 0),
			new Vector2(234, 0),
			new Vector2(218, 0),
			new Vector2(202, 16),
			new Vector2(202, 32),
			new Vector2(202, 48),
			new Vector2(202, 64),
			// K
			new Vector2(367, 64),
			new Vector2(351, 48),
			new Vector2(367, 0),
			new Vector2(351, 16),
			new Vector2(335, 32),
			new Vector2(319, 32),
			new Vector2(303, 0),
			new Vector2(303, 16),
			new Vector2(303, 32),
			new Vector2(303, 48),
			new Vector2(303, 64),
			// E
			new Vector2(468, 64),
			new Vector2(452, 64),
			new Vector2(436, 64),
			new Vector2(420, 64),
			new Vector2(452, 32),
			new Vector2(436, 32),
			new Vector2(420, 32),
			new Vector2(468, 0),
			new Vector2(452, 0),
			new Vector2(436, 0),
			new Vector2(420, 0),
			new Vector2(404, 0),
			new Vector2(404, 16),
			new Vector2(404, 32),
			new Vector2(404, 48),
			new Vector2(404, 64),
		};
	}
}
