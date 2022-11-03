using System;
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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_AlekseevaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_AlekseevaDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.education_AlekseevaDataSet.Subjects);

        }
    }
}
