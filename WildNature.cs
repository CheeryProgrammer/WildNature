using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildNature.Common;
using WildNature.Properties;

namespace WildNature
{
	public partial class WildNature : Form
	{
		private Graphics _backgroundGraphics;
		private Bitmap _backImage = new Bitmap(1024, 768);
		private Bitmap _frameImage = new Bitmap(640, 480);
		private Point _frameShift = new Point(0, 0);
		private Graphics _frameGraphics;
		private Rectangle _frameRectangle = new Rectangle(0, 0, 640, 480);
		private Rectangle _backgroundRectangle;
		private static bool _shouldMoveFrame;
		private static bool _inMoving = false;
		private static Action _redrawAction;

		public WildNature()
		{
			InitializeComponent();
			_backgroundGraphics = Graphics.FromImage(_backImage);
			_backgroundGraphics.Clear(Color.Aqua);
			_frameGraphics = Graphics.FromImage(_frameImage);
			_backgroundRectangle = new Rectangle(_frameShift, new Size(640, 480));
			_redrawAction = RedrawFrame;
		}

		private void WildNature_Load(object sender, EventArgs e)
		{
			LoadAnimals();
			RedrawFrame();
		}

		private void LoadAnimals()
		{
			_backgroundGraphics.DrawImage(Resources.med, new Point(500, 500));
			_backgroundGraphics.DrawImage(Resources.wolf, new Point(420, 500));
			_backgroundGraphics.DrawImage(Resources.snake, new Point(500, 420));
		}

		private void WildNature_KeyDown(object sender, KeyEventArgs e)
		{
			if (_inMoving)
				return;

			var movingDirection = Direction.Down;
			if (e.KeyCode == Keys.Up)
				movingDirection = Direction.Up;
			if (e.KeyCode == Keys.Left)
				movingDirection = Direction.Left;
			if (e.KeyCode == Keys.Right)
				movingDirection = Direction.Right;

			_shouldMoveFrame = true;

			Task.Run(() =>
				{
					_inMoving = true;
					MoveFrame(movingDirection);
				})
				.ContinueWith(r => _inMoving = false);
		}

		private void MoveFrame(Direction direction)
		{
			while (_shouldMoveFrame)
			{
				switch (direction)
				{
					case Direction.Up:
						_frameShift.Y++;
						break;
					case Direction.Down:
						_frameShift.Y--;
						break;
					case Direction.Left:
						_frameShift.X++;
						break;
					case Direction.Right:
						_frameShift.X--;
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
				}

				_backgroundRectangle.Location = _frameShift;
				pbField.Invoke(_redrawAction);
				Thread.Sleep(5);
			}
		}

		private void RedrawFrame()
		{
			_frameGraphics.DrawImage(_backImage, _frameRectangle, _backgroundRectangle, GraphicsUnit.Pixel);
			pbField.Image = _frameImage;
		}

		private void WildNature_KeyUp(object sender, KeyEventArgs e)
		{
			_shouldMoveFrame = false;
		}
	}
}
