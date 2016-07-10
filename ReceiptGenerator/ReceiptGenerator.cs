// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReceiptGenerator.cs" company="최진용">
//
// ReceiptGenerator Lib
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
using System.Text;
using System.Drawing;
using System.Resources;
using System.Globalization;
using System.Collections.Generic;

namespace SWMaestro
{
    public static class ReceiptGenerator
    {
        private static Bitmap baseForm;

        private static Dictionary<string, InputArea[]> inputAreas =
            new Dictionary<string, InputArea[]>()
            {
                { "Date", new InputArea[] {
                    new InputArea(
                        new RectangleF(new Point(391, 559), new Size(106, 22)),
                        ContentAlignment.MiddleCenter, format: "yyyy.MM.dd"),
                    new InputArea(
                        new RectangleF(new Point(748, 768), new Size(170, 18)),
                        ContentAlignment.MiddleRight, format: "yyyy년    M월   d일"),
                    new InputArea(
                        new RectangleF(new Point(748, 864), new Size(170, 18)),
                        ContentAlignment.MiddleRight, format: "yyyy년    M월   d일")
                } },

                { "Name", new InputArea[] {
                    new InputArea(
                        new RectangleF(new Point(248, 299), new Size(227, 37)),
                        ContentAlignment.TopLeft),
                    new InputArea(
                        new RectangleF(new Point(761, 902), new Size(46, 16)),
                        ContentAlignment.MiddleRight,
                        new Font("돋움체", 9.5f))
                } },

                { "Addr", new InputArea[] {
                    new InputArea(
                        new RectangleF(new Point(248, 341), new Size(227, 37)),
                        ContentAlignment.TopLeft)
                } },

                { "RReg", new InputArea[] {
                    new InputArea(
                        new RectangleF(new Point(647, 296), new Size(273, 40)),
                        ContentAlignment.MiddleCenter)
                } }
            };

        static ReceiptGenerator()
        {
            baseForm = ResourceBox.FindResource<Bitmap>("Resources.form.png");
        }

        public static Bitmap Generate(string name, string address, string rreg, DateTime date)
        {
            var gBitmap = new Bitmap(baseForm);

            using (var g = Graphics.FromImage(gBitmap))
            {
                DrawInput(g, "Name", name.ToWrapper());
                DrawInput(g, "Addr", address.ToWrapper());
                DrawInput(g, "RReg", rreg.ToWrapper());
                DrawInput(g, "Date", date);
            }

            return gBitmap;
        }

        private static void DrawInput<T>(Graphics g, string key, T data) where T : IFormattable
        {
            if (!inputAreas.ContainsKey(key))
                throw new ArgumentException();

            foreach (var area in inputAreas[key])
            {
                DrawInput(g, area, data);
            }
        }

        private static void DrawInput<T>(Graphics g, InputArea area, T data) where T : IFormattable
        {
            string wData = data.ToString(area.Format, CultureInfo.CurrentCulture);
            StringFormat format = AlignmentToStringFormat(area.ContentAlignment);

            g.DrawString(wData, area.Font, Brushes.Black, area.Area, format);

#if DEBUG
            g.DrawRectangle(Pens.Red, (int)area.Area.X, (int)area.Area.Y, (int)area.Area.Width, (int)area.Area.Height);
#endif
        }

        private static StringFormat AlignmentToStringFormat(ContentAlignment alignment)
        {
            int caNum = (int)Math.Log((double)alignment, 2);

            return new StringFormat()
            {
                Alignment = (StringAlignment)(caNum % 4),
                LineAlignment = (StringAlignment)(caNum / 4),
                Trimming = StringTrimming.Character
            };
        }
    }
}