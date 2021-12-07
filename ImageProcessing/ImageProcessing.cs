/*
 * Created by SharpDevelop.
 * User: Азриэль
 * Date: 07.12.2021
 * Time: 17:02
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageProcessing
{
	public static class ImageProcessing
	{
		public static Func<int, int, byte[], int> SelectPixelFunc(int depth, int stride)
		{
			
			Func<int, int, byte[], int> pixelfunc = null;
			switch (depth) {
				case 1:
					pixelfunc = (i, j, v) => v[i * depth + j * stride];
					break;
				case 3:
					pixelfunc = (i, j, v) => (int)(0.114 * v[i * depth + j * stride] + 0.587 * v[i * depth + j * stride + 1] + 0.299 * v[i * depth + j * stride + 2]);
					break;
				case 4:
					pixelfunc = (i, j, v) => {
						double y = 0.114 * v[i * depth + j * stride] + 0.587 * v[i * depth + j * stride + 1] + 0.299 * v[i * depth + j * stride + 2];
						if (v[i * depth + j * stride + 3] < 255)
							y = y * v[i * depth + j * stride + 3] / 255.0 + (255 - v[i * depth + j * stride + 3]);
						return (byte)y;
					};
					break;
				default: throw new FormatException();
			}
			return pixelfunc;
		}
		
		public static byte[] GetBitmapData(Bitmap Source)
		{
			int width = Source.Width, height = Source.Height;
			int depth = Image.GetPixelFormatSize(Source.PixelFormat) / 8;
			var pixeldata = Source.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, Source.PixelFormat);
			int stride = pixeldata.Stride;
			
			var buffer = new byte[height * stride];
			Marshal.Copy(pixeldata.Scan0, buffer, 0, buffer.Length);
			Source.UnlockBits(pixeldata);
			return buffer;
		}
		
		public static Bitmap CreateBitmap(byte[] data, int width, int height, PixelFormat format)
		{
			var Result = new Bitmap(width, height, format);
			var resultdata = Result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, format);
			
			Marshal.Copy(data, 0, resultdata.Scan0, data.Length);
			Result.UnlockBits(resultdata);
			return Result;
		}
	}
}
