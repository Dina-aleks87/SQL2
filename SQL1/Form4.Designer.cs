namespace SQL1
{
    partial class Uspev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentLabel;
            System.Windows.Forms.Label predmetLabel;
            System.Windows.Forms.Label ocenkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uspev));
            this.label1 = new System.Windows.Forms.Label();
            this.education_AlekseevaDataSet = new SQL1.Education_AlekseevaDataSet();
            this.uspevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspevTableAdapter = new SQL1.Education_AlekseevaDataSetTableAdapters.UspevTableAdapter();
            this.tableAdapterManager = new SQL1.Education_AlekseevaDataSetTableAdapters.TableAdapterManager();
            this.uspevBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uspevBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ocenkaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new SQL1.Education_AlekseevaDataSetTableAdapters.SubjectsTableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new SQL1.Education_AlekseevaDataSetTableAdapters.StudentTableAdapter();
            this.famComboBox = new System.Windows.Forms.ComboBox();
            studentLabel = new System.Windows.Forms.Label();
            predmetLabel = new System.Windows.Forms.Label();
            ocenkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_AlekseevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevBindingNavigator)).BeginInit();
            this.uspevBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            studentLabel.Location = new System.Drawing.Point(13, 112);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(86, 20);
            studentLabel.TabIndex = 2;
            studentLabel.Text = "Студент:";
            // 
            // predmetLabel
            // 
            predmetLabel.AutoSize = true;
            predmetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            predmetLabel.Location = new System.Drawing.Point(13, 149);
            predmetLabel.Name = "predmetLabel";
            predmetLabel.Size = new System.Drawing.Size(116, 20);
            predmetLabel.TabIndex = 4;
            predmetLabel.Text = "Дисциплина:";
            // 
            // ocenkaLabel
            // 
            ocenkaLabel.AutoSize = true;
            ocenkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            ocenkaLabel.Location = new System.Drawing.Point(13, 184);
            ocenkaLabel.Name = "ocenkaLabel";
            ocenkaLabel.Size = new System.Drawing.Size(76, 20);
            ocenkaLabel.TabIndex = 6;
            ocenkaLabel.Text = "Оценка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Успеваемость";
            // 
            // education_AlekseevaDataSet
            // 
            this.education_AlekseevaDataSet.DataSetName = "Education_AlekseevaDataSet";
            this.education_AlekseevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspevBindingSource
            // 
            this.uspevBindingSource.DataMember = "Uspev";
            this.uspevBindingSource.DataSource = this.education_AlekseevaDataSet;
            // 
            // uspevTableAdapter
            // 
            this.uspevTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SQL1.Education_AlekseevaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UspevTableAdapter = this.uspevTableAdapter;
            // 
            // uspevBindingNavigator
            // 
            this.uspevBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uspevBindingNavigator.BindingSource = this.uspevBindingSource;
            this.uspevBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uspevBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uspevBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uspevBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uspevBindingNavigatorSaveItem});
            this.uspevBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspevBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uspevBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uspevBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uspevBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uspevBindingNavigator.Name = "uspevBindingNavigator";
            this.uspevBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uspevBindingNavigator.Size = new System.Drawing.Size(533, 27);
            this.uspevBindingNavigator.TabIndex = 1;
            this.uspevBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // uspevBindingNavigatorSaveItem
            // 
            this.uspevBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uspevBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uspevBindingNavigatorSaveItem.Image")));
            this.uspevBindingNavigatorSaveItem.Name = "uspevBindingNavigatorSaveItem";
            this.uspevBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.uspevBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.uspevBindingNavigatorSaveItem.Click += new System.EventHandler(this.uspevBindingNavigatorSaveItem_Click);
            // 
            // ocenkaMaskedTextBox
            // 
            this.ocenkaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspevBindingSource, "ocenka", true));
            this.ocenkaMaskedTextBox.Location = new System.Drawing.Point(140, 184);
            this.ocenkaMaskedTextBox.Name = "ocenkaMaskedTextBox";
            this.ocenkaMaskedTextBox.Size = new System.Drawing.Size(305, 34);
            this.ocenkaMaskedTextBox.TabIndex = 8;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.education_AlekseevaDataSet;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjectsBindingSource, "name", true));
            this.nameComboBox.DataSource = this.subjectsBindingSource;
            this.nameComboBox.DisplayMember = "name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(140, 141);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(305, 37);
            this.nameComboBox.TabIndex = 9;
            this.nameComboBox.ValueMember = "name";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.education_AlekseevaDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // famComboBox
            // 
            this.famComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "fam", true));
            this.famComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "fam", true));
            this.famComboBox.DataSource = this.studentBindingSource;
            this.famComboBox.DisplayMember = "fam";
            this.famComboBox.FormattingEnabled = true;
            this.famComboBox.Location = new System.Drawing.Point(140, 98);
            this.famComboBox.Name = "famComboBox";
            this.famComboBox.Size = new System.Drawing.Size(305, 37);
            this.famComboBox.TabIndex = 10;
            this.famComboBox.ValueMember = "fam";
            // 
            // Uspev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 255);
            this.Controls.Add(this.famComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.ocenkaMaskedTextBox);
            this.Controls.Add(ocenkaLabel);
            this.Controls.Add(predmetLabel);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.uspevBindingNavigator);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Uspev";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.Uspev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_AlekseevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevBindingNavigator)).EndInit();
            this.uspevBindingNavigator.ResumeLayout(false);
            this.uspevBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_AlekseevaDataSet education_AlekseevaDataSet;
        private System.Windows.Forms.BindingSource uspevBindingSource;
        private Education_AlekseevaDataSetTableAdapters.UspevTableAdapter uspevTableAdapter;
        private Education_AlekseevaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uspevBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uspevBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox ocenkaMaskedTextBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private Education_AlekseevaDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Education_AlekseevaDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox famComboBox;
    }
}