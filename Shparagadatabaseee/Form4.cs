﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shparagadatabaseee
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database21DataSet._MAKE_UP__БРОВИ". При необходимости она может быть перемещена или удалена.
            this.mAKE_UP__БРОВИTableAdapter.Fill(this.database21DataSet._MAKE_UP__БРОВИ);

        }
    }
}
