// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewWindow.cs" company="최진용">
//
// ReceiptGenerator App
// Copyright (C) 2016 최진용
//
// This program is free software: you can redistribute it and/or modify
// it under the +terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// 1.0 any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// <summary>
// Email: develope_e@naver.com
// XFire and Steam: 최진용
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace ReceiptGenerator_App
{
    public partial class ViewWindow : Form
    {
        public DateTime ReceiptDate { get; }

        public ViewWindow(Bitmap bitmap, DateTime date)
        {
            InitializeComponent();

            ReceiptDate = date;

            if (bitmap != null)
            {
                int fixedWidth = bitmap.Width + SystemInformation.VerticalScrollBarWidth * 2 - 1;

                this.MinimumSize = new Size(fixedWidth, 0);
                this.MaximumSize = new Size(fixedWidth, 214748);

                iBox.Image = bitmap;
            }
        }

        public new DialogResult ShowDialog()
        {
            if (iBox.Image == null)
                return DialogResult.Cancel;

            return base.ShowDialog();
        }

        private void mnSaveAs_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "이미지 파일|*.png";
                sfd.FileName = $"기부금 영수증({ReceiptDate:M월 d일}).png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iBox.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                    catch
                    {
                    }
                }
            }
                
        }

        private void mnPrint_Click(object sender, EventArgs e)
        {
            using (var ppd = new PrintPreviewDialog())
            {
                var screen = Screen.FromPoint(this.Location);

                ppd.Icon = this.Icon;
                ppd.StartPosition = FormStartPosition.CenterScreen;
                ppd.ClientSize = new Size((int)(screen.Bounds.Height * 0.56), (int)(screen.Bounds.Height * 0.8));

                using (ppd.Document = new PrintDocument())
                {
                    ppd.Document.PrintPage += Document_PrintPage;

                    if (ppd.ShowDialog() == DialogResult.OK)
                    {
                        ppd.Document.Print();
                    }

                    ppd.Document.PrintPage -= Document_PrintPage;
                }
            }
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            /* 귀찮아요 캡슐화 안할래요 */

            double units = 100 / 2.54;

            SizeF a4Sz = new SizeF((float)(21 * units), (float)(29.7 * units));
            SizeF tfSz = iBox.Image.Size;

            float factor = Math.Min(a4Sz.Width / tfSz.Width, a4Sz.Height / tfSz.Height);
            tfSz = new SizeF(tfSz.Width * factor, tfSz.Height * factor);

            PointF loc = new PointF((a4Sz.Width - tfSz.Width) / 2, (a4Sz.Height - tfSz.Height) / 2);

            e.Graphics.DrawImage(iBox.Image, loc.X, loc.Y, tfSz.Width, tfSz.Height);
        }
    }
}