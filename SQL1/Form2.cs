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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_AlekseevaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_AlekseevaDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.education_AlekseevaDataSet.Student);

        }
        private StudentsTable studentstable;
        private void button1_Click(object sender, EventArgs e)
        {
            studentstable = new StudentsTable();
            studentstable.Visible = true;
        }
    }
}
