namespace SQL1
{
    partial class Subjects
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label hrsLabel;
            System.Windows.Forms.Label deptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.label1 = new System.Windows.Forms.Label();
            this.education_AlekseevaDataSet = new SQL1.Education_AlekseevaDataSet();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new SQL1.Education_AlekseevaDataSetTableAdapters.SubjectsTableAdapter();
            this.tableAdapterManager = new SQL1.Education_AlekseevaDataSetTableAdapters.TableAdapterManager();
            this.subjectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjectsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.hrsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nameLabel = new System.Windows.Forms.Label();
            hrsLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_AlekseevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingNavigator)).BeginInit();
            this.subjectsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            nameLabel.Location = new System.Drawing.Point(18, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(96, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Название:";
            // 
            // hrsLabel
            // 
            hrsLabel.AutoSize = true;
            hrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            hrsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            hrsLabel.Location = new System.Drawing.Point(18, 122);
            hrsLabel.Name = "hrsLabel";
            hrsLabel.Size = new System.Drawing.Size(137, 20);
            hrsLabel.TabIndex = 4;
            hrsLabel.Text = "Объем в часах:";
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            deptLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            deptLabel.Location = new System.Drawing.Point(18, 152);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(93, 20);
            deptLabel.TabIndex = 6;
            deptLabel.Text = "Кафедра:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплины";
            // 
            // education_AlekseevaDataSet
            // 
            this.education_AlekseevaDataSet.DataSetName = "Education_AlekseevaDataSet";
            this.education_AlekseevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SQL1.Education_AlekseevaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UspevTableAdapter = null;
            // 
            // subjectsBindingNavigator
            // 
            this.subjectsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjectsBindingNavigator.BindingSource = this.subjectsBindingSource;
            this.subjectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjectsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjectsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subjectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjectsBindingNavigatorSaveItem});
            this.subjectsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjectsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjectsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjectsBindingNavigator.Name = "subjectsBindingNavigator";
            this.subjectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjectsBindingNavigator.Size = new System.Drawing.Size(493, 27);
            this.subjectsBindingNavigator.TabIndex = 1;
            this.subjectsBindingNavigator.Text = "bindingNavigator1";
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
            // subjectsBindingNavigatorSaveItem
            // 
            this.subjectsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjectsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjectsBindingNavigatorSaveItem.Image")));
            this.subjectsBindingNavigatorSaveItem.Name = "subjectsBindingNavigatorSaveItem";
            this.subjectsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.subjectsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjectsBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjectsBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(163, 92);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // deptTextBox
            // 
            this.deptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "dept", true));
            this.deptTextBox.Location = new System.Drawing.Point(163, 152);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(100, 22);
            this.deptTextBox.TabIndex = 7;
            // 
            // hrsMaskedTextBox
            // 
            this.hrsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "hrs", true));
            this.hrsMaskedTextBox.Location = new System.Drawing.Point(163, 120);
            this.hrsMaskedTextBox.Mask = "999";
            this.hrsMaskedTextBox.Name = "hrsMaskedTextBox";
            this.hrsMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.hrsMaskedTextBox.TabIndex = 8;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 249);
            this.Controls.Add(this.hrsMaskedTextBox);
            this.Controls.Add(deptLabel);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(hrsLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.subjectsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Subjects";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_AlekseevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingNavigator)).EndInit();
            this.subjectsBindingNavigator.ResumeLayout(false);
            this.subjectsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_AlekseevaDataSet education_AlekseevaDataSet;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private Education_AlekseevaDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private Education_AlekseevaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjectsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjectsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.MaskedTextBox hrsMaskedTextBox;
    }
}