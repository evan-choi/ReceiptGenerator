// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="최진용">
//
// {one line to give the program's name and a brief idea of what it does.}
// Copyright (C) 2016 최진용
//
// This program is free software: you can redistribute it and/or modify
// it under the +terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
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

using SWMaestro;

using System;
using System.Windows.Forms;

namespace ReceiptGenerator_App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var date = new DateTime(2016,12,1).ToLastDate();

            var result = ReceiptGenerator.Generate(
                tbName.Text, 
                tbAddr.Text, 
                tbRReg.Text, 
                date);

            using (var vw = new ViewWindow(result, date))
            {
                vw.ShowDialog();
            }
        }
    }
}
