/*
 * Created by SharpDevelop.
 * User: Азриэль
 * Date: 07.12.2021
 * Time: 16:40
 */
namespace ImageProcessing
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox TB_FileName;
		private System.Windows.Forms.Button BnLoad;
		private System.Windows.Forms.CheckBox CheckBW;
		private System.Windows.Forms.Button BnLoadDlg;
		private System.Windows.Forms.PictureBox PicMain;
		private System.Windows.Forms.SplitContainer splitContainer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.TB_FileName = new System.Windows.Forms.TextBox();
			this.BnLoad = new System.Windows.Forms.Button();
			this.CheckBW = new System.Windows.Forms.CheckBox();
			this.BnLoadDlg = new System.Windows.Forms.Button();
			this.PicMain = new System.Windows.Forms.PictureBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.PicMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TB_FileName
			// 
			this.TB_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TB_FileName.Location = new System.Drawing.Point(2, 2);
			this.TB_FileName.Margin = new System.Windows.Forms.Padding(2);
			this.TB_FileName.Name = "TB_FileName";
			this.TB_FileName.Size = new System.Drawing.Size(357, 20);
			this.TB_FileName.TabIndex = 1;
			// 
			// BnLoad
			// 
			this.BnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BnLoad.Location = new System.Drawing.Point(423, 2);
			this.BnLoad.Margin = new System.Windows.Forms.Padding(2);
			this.BnLoad.Name = "BnLoad";
			this.BnLoad.Size = new System.Drawing.Size(72, 20);
			this.BnLoad.TabIndex = 2;
			this.BnLoad.Text = "Загрузить";
			this.BnLoad.UseVisualStyleBackColor = true;
			this.BnLoad.Click += new System.EventHandler(this.BnLoadClick);
			// 
			// CheckBW
			// 
			this.CheckBW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckBW.Appearance = System.Windows.Forms.Appearance.Button;
			this.CheckBW.Location = new System.Drawing.Point(499, 2);
			this.CheckBW.Margin = new System.Windows.Forms.Padding(2);
			this.CheckBW.Name = "CheckBW";
			this.CheckBW.Size = new System.Drawing.Size(96, 20);
			this.CheckBW.TabIndex = 3;
			this.CheckBW.Text = "Чёрно-белый";
			this.CheckBW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CheckBW.UseVisualStyleBackColor = true;
			this.CheckBW.CheckedChanged += new System.EventHandler(this.CheckBWCheckedChanged);
			// 
			// BnLoadDlg
			// 
			this.BnLoadDlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BnLoadDlg.Location = new System.Drawing.Point(363, 2);
			this.BnLoadDlg.Margin = new System.Windows.Forms.Padding(2);
			this.BnLoadDlg.Name = "BnLoadDlg";
			this.BnLoadDlg.Size = new System.Drawing.Size(56, 20);
			this.BnLoadDlg.TabIndex = 2;
			this.BnLoadDlg.Text = "Обзор...";
			this.BnLoadDlg.UseVisualStyleBackColor = true;
			this.BnLoadDlg.Click += new System.EventHandler(this.BnLoadDlgClick);
			// 
			// PicMain
			// 
			this.PicMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PicMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PicMain.Location = new System.Drawing.Point(0, 0);
			this.PicMain.Margin = new System.Windows.Forms.Padding(2);
			this.PicMain.Name = "PicMain";
			this.PicMain.Size = new System.Drawing.Size(597, 395);
			this.PicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicMain.TabIndex = 4;
			this.PicMain.TabStop = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.PicMain);
			this.splitContainer1.Panel1MinSize = 24;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.TB_FileName);
			this.splitContainer1.Panel2.Controls.Add(this.BnLoadDlg);
			this.splitContainer1.Panel2.Controls.Add(this.CheckBW);
			this.splitContainer1.Panel2.Controls.Add(this.BnLoad);
			this.splitContainer1.Panel2MinSize = 24;
			this.splitContainer1.Size = new System.Drawing.Size(597, 422);
			this.splitContainer1.SplitterDistance = 395;
			this.splitContainer1.SplitterWidth = 2;
			this.splitContainer1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 422);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "ImageProcessing";
			((System.ComponentModel.ISupportInitialize)(this.PicMain)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
