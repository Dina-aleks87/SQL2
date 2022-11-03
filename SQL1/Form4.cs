﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL1
{
    public partial class Uspev : Form
    {
        public Uspev()
        {
            InitializeComponent();
        }

        private void uspevBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uspevBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_AlekseevaDataSet);

        }

        private void Uspev_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_AlekseevaDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.education_AlekseevaDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_AlekseevaDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.education_AlekseevaDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_AlekseevaDataSet.Uspev". При необходимости она может быть перемещена или удалена.
            this.uspevTableAdapter.Fill(this.education_AlekseevaDataSet.Uspev);

        }
    }
}
