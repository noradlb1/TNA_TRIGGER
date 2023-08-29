using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Aimbot
{
	// Token: 0x0200001D RID: 29
	internal class aimbot
	{
		// Token: 0x0600012C RID: 300 RVA: 0x000024C5 File Offset: 0x000006C5
		public static void Main(string[] args)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008DA0 File Offset: 0x00006FA0
		public unsafe static void Update()
		{
			DateTime dateTime_ = Delegate102.smethod_0();
			for (;;)
			{
				Delegate11.smethod_0(1);
				Point[] array = aimbot.PixelSearch(Delegate304.smethod_0(0, 490, 1920, 100), Delegate226.smethod_0(11480751), 20);
				if (array.Length != 0)
				{
					Point[] array2 = (from t in array
					orderby Delegate65.smethod_0(&t)
					select t).ToArray<Point>();
					List<Vector2> list = new List<Vector2>();
					for (int i = 0; i < array2.Length; i++)
					{
						Vector2 current = Delegate184.smethod_0((float)Delegate195.smethod_0(&array2[i]), (float)Delegate65.smethod_0(&array2[i]));
						if (list.Where(delegate(Vector2 t)
						{
							Vector2 vector2 = Delegate260.smethod_0(t, current);
							return (double)Delegate185.smethod_0(&vector2) < 60.0 || (double)Delegate51.smethod_0(t.X - current.X) < 60.0;
						}).Count<Vector2>() < 1)
						{
							list.Add(current);
							if (list.Count > 5)
							{
								break;
							}
						}
					}
					bool pressDown = false;
					Vector2 vector = Delegate215.smethod_0((from t in list
					select Delegate260.smethod_0(t, Delegate184.smethod_0(960f, 540f)) into t
					orderby Delegate185.smethod_0(&t)
					select t).ElementAt(0), Delegate184.smethod_0(1f, 1f));
					if (Delegate185.smethod_0(&vector) < 10f)
					{
						DateTime dateTime = Delegate102.smethod_0();
						TimeSpan timeSpan = Delegate96.smethod_0(&dateTime, dateTime_);
						if (Delegate92.smethod_0(&timeSpan) > 200.0)
						{
							dateTime_ = Delegate102.smethod_0();
							pressDown = true;
						}
					}
					aimbot.Move((int)(vector.X * 1.2f), (int)(vector.Y * 1.2f), pressDown);
				}
			}
		}

		// Token: 0x0600012E RID: 302
		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x0600012F RID: 303 RVA: 0x00002CAD File Offset: 0x00000EAD
		public static void Move(int xDelta, int yDelta, bool pressDown = false)
		{
			aimbot.mouse_event(pressDown ? 6 : 1, xDelta, yDelta, 0U, UIntPtr.Zero);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00008F54 File Offset: 0x00007154
		public unsafe static Point[] PixelSearch(Rectangle rect, Color Pixel_Color, int Shade_Variation)
		{
			ArrayList object_ = Delegate89.smethod_0();
			Bitmap bitmap = Delegate227.smethod_0(Delegate345.smethod_0(&rect), Delegate40.smethod_0(&rect), PixelFormat.Format24bppRgb);
			using (Graphics graphics = Delegate35.smethod_0(bitmap))
			{
				Delegate169.smethod_0(graphics, Delegate123.smethod_0(&rect), Delegate261.smethod_0(&rect), 0, 0, Delegate330.smethod_0(&rect), CopyPixelOperation.SourceCopy);
			}
			BitmapData object_2 = Delegate158.smethod_0(bitmap, Delegate304.smethod_0(0, 0, Delegate201.smethod_0(bitmap), Delegate180.smethod_0(bitmap)), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int[] array = new int[]
			{
				(int)Delegate263.smethod_0(&Pixel_Color),
				(int)Delegate162.smethod_0(&Pixel_Color),
				(int)Delegate39.smethod_0(&Pixel_Color)
			};
			for (int i = 0; i < Delegate319.smethod_0(object_2); i++)
			{
				byte* ptr = (byte*)Delegate229.smethod_0(Delegate315.smethod_0(object_2)) + i * Delegate190.smethod_0(object_2);
				for (int j = 0; j < Delegate309.smethod_0(object_2); j++)
				{
					if (((int)ptr[j * 3] >= array[0] - Shade_Variation & (int)ptr[j * 3] <= array[0] + Shade_Variation) && ((int)ptr[j * 3 + 1] >= array[1] - Shade_Variation & (int)ptr[j * 3 + 1] <= array[1] + Shade_Variation) && ((int)ptr[j * 3 + 2] >= array[2] - Shade_Variation & (int)ptr[j * 3 + 2] <= array[2] + Shade_Variation))
					{
						Delegate80.smethod_0(object_, Delegate136.smethod_0(j + Delegate123.smethod_0(&rect), i + Delegate261.smethod_0(&rect)));
					}
				}
			}
			Delegate292.smethod_0(bitmap);
			return (Point[])Delegate30.smethod_0(object_, Delegate340.smethod_0(typeof(Point).TypeHandle));
		}

		// Token: 0x040000B7 RID: 183
		private const int xSize = 1920;

		// Token: 0x040000B8 RID: 184
		private const int ySize = 1080;

		// Token: 0x040000B9 RID: 185
		private const int maxX = 1920;

		// Token: 0x040000BA RID: 186
		private const int maxY = 100;

		// Token: 0x040000BB RID: 187
		private const float speed = 1.2f;

		// Token: 0x040000BC RID: 188
		private const int msBetweenShots = 200;

		// Token: 0x040000BD RID: 189
		private const int closeSize = 10;

		// Token: 0x040000BE RID: 190
		private const bool canShoot = true;

		// Token: 0x040000BF RID: 191
		private const int color = 11480751;

		// Token: 0x040000C0 RID: 192
		private const int colorVariation = 20;

		// Token: 0x040000C1 RID: 193
		private const double size = 60.0;

		// Token: 0x040000C2 RID: 194
		private const int maxCount = 5;

		// Token: 0x040000C3 RID: 195
		private const int MOUSEEVENTF_LEFTDOWN = 2;

		// Token: 0x040000C4 RID: 196
		private const int MOUSEEVENTF_LEFTUP = 4;

		// Token: 0x040000C5 RID: 197
		private const int MOUSEEVENTF_RIGHTDOWN = 8;

		// Token: 0x040000C6 RID: 198
		private const int MOUSEEVENTF_RIGHTUP = 16;
	}
}
