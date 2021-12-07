/*
 * Created by SharpDevelop.
 * User: Азриэль
 * Date: 07.12.2021
 * Time: 16:40
 */
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Bitmap bmp;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BnLoadClick(object sender, EventArgs e)
		{
			if (!TB_FileName.Text.Contains(".bmp") && !TB_FileName.Text.Contains(".png")) {
				System.Media.SystemSounds.Beep.Play();
				return;
			}
			
			bmp = new Bitmap(TB_FileName.Text);
			CheckBWCheckedChanged(sender, e);
		}
		
		void BnLoadDlgClick(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog {
				FileName = TB_FileName.Text,
				Filter = "Точечные изображения (BMP, PNG)|*.bmp;*.png|Все файлы|*.*",
				Multiselect = false
			};
			if (dlg.ShowDialog() == DialogResult.OK)
				TB_FileName.Text = dlg.FileName;
			BnLoadClick(sender, e);
		}
		
		void CheckBWCheckedChanged(object sender, EventArgs e)
		{
			if (bmp == null) {
				System.Media.SystemSounds.Beep.Play();
				return;
			}
			if (!TB_FileName.Text.Contains(".bmp") && !TB_FileName.Text.Contains(".png")) {
				System.Media.SystemSounds.Beep.Play();
				return;
			}
			if (!CheckBW.Checked) {
				PicMain.Image = bmp;
				return;
			}
			
			byte[] bmpdata = ImageProcessing.GetBitmapData(bmp);
			int width = bmp.Width, height = bmp.Height;
			int depth = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
			int stride = bmpdata.Length / height;
			var bwfunc = ImageProcessing.SelectPixelFunc(depth, stride);
			
			byte[] resultdata = new byte[width * height * 4];
			Parallel.For(0, height, j => {
				Parallel.For(0, width, i => {
			   		byte bw = (byte)bwfunc(i, j, bmpdata);
			   		int k = 4 * (j * width + i);
			   		resultdata[k] = resultdata[k + 1] = resultdata[k + 2] = bw;
			   		resultdata[k + 3] = 255;
			    });
			});
			
			PicMain.Image = ImageProcessing.CreateBitmap(resultdata, width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		}
	}
}
