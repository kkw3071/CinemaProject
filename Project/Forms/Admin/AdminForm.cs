﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Database.Model;
using Project.Contents;
using Project.Contents.Admin;

namespace Project
{
    public partial class AdminForm : Form
    {
        Member_tbl memberTbl;
        MainContent mainContent;
        AdminMovieContent movieContent;
    

        public AdminForm()
        {
            InitializeComponent();
            mainContent = new MainContent();
            movieContent = new AdminMovieContent();
            MainCheck_Change();
        }
        public AdminForm(Member_tbl memberTbl)
        {
            InitializeComponent();
            this.memberTbl = memberTbl;
        }


        private void MainCheck_Change()
        {
            mainContent.TopLevel = false;
            mainContent.TopMost = true;
            mainContent.Parent = this;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(mainContent);
            mainContent.Show();
        }

        private void MovieCheck_Change()
        {
            movieContent.TopLevel = false;
            movieContent.TopMost = true;
            movieContent.Parent = this;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(movieContent);
            movieContent.Show();
        }
        

        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            if (MainCheck.Checked)
            {
                MainCheck_Change();
            }else if (MovieCheck.Checked)
            {
                MovieCheck_Change();
            }
        }
    }
}
