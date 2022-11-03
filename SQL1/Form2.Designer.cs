namespace SQL1
{
    partial class Students
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
            System.Windows.Forms.Label no_zkLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label grLabel;
            System.Windows.Forms.Label biogrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.label1 = new System.Windows.Forms.Label();
            this.education_AlekseevaDataSet = new SQL1.Education_AlekseevaDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new SQL1.Education_AlekseevaDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new SQL1.Education_AlekseevaDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_zkTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            this.grTextBox = new System.Windows.Forms.TextBox();
            this.biogrTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            no_zkLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            grLabel = new System.Windows.Forms.Label();
            biogrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_AlekseevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_zkLabel
            // 
            no_zkLabel.AutoSize = true;
            no_zkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            no_zkLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            no_zkLabel.Location = new System.Drawing.Point(13, 86);
            no_zkLabel.Name = "no_zkLabel";
            no_zkLabel.Size = new System.Drawing.Size(97, 20);
            no_zkLabel.TabIndex = 2;
            no_zkLabel.Text = "Номер ЗК:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            famLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            famLabel.Location = new System.Drawing.Point(13, 121);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(92, 20);
            famLabel.TabIndex = 4;
            famLabel.Text = "Фамилия:";
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            imLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            imLabel.Location = new System.Drawing.Point(13, 161);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(47, 20);
            imLabel.TabIndex = 6;
            imLabel.Text = "Имя:";
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            otLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            otLabel.Location = new System.Drawing.Point(13, 201);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(96, 20);
            otLabel.TabIndex = 8;
            otLabel.Text = "Отчество:";
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            specLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            specLabel.Location = new System.Drawing.Point(13, 241);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(145, 20);
            specLabel.TabIndex = 10;
            specLabel.Text = "Специальность:";
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            kursLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            kursLabel.Location = new System.Drawing.Point(13, 281);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(52, 20);
            kursLabel.TabIndex = 12;
            kursLabel.Text = "Курс:";
            // 
            // grLabel
            // 
            grLabel.AutoSize = true;
            grLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            grLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            grLabel.Location = new System.Drawing.Point(13, 321);
            grLabel.Name = "grLabel";
            grLabel.Size = new System.Drawing.Size(72, 20);
            grLabel.TabIndex = 14;
            grLabel.Text = "Группа:";
            // 
            // biogrLabel
            // 
            biogrLabel.AutoSize = true;
            biogrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            biogrLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            biogrLabel.Location = new System.Drawing.Point(13, 361);
            biogrLabel.Name = "biogrLabel";
            biogrLabel.Size = new System.Drawing.Size(110, 20);
            biogrLabel.TabIndex = 16;
            biogrLabel.Text = "Биография:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            // 
            // education_AlekseevaDataSet
            // 
            this.education_AlekseevaDataSet.DataSetName = "Education_AlekseevaDataSet";
            this.education_AlekseevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SQL1.Education_AlekseevaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UspevTableAdapter = null;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(350, 27);
            this.studentBindingNavigator.TabIndex = 1;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.studentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // no_zkTextBox
            // 
            this.no_zkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "no_zk", true));
            this.no_zkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.no_zkTextBox.Location = new System.Drawing.Point(176, 83);
            this.no_zkTextBox.Name = "no_zkTextBox";
            this.no_zkTextBox.Size = new System.Drawing.Size(100, 23);
            this.no_zkTextBox.TabIndex = 3;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(176, 121);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(100, 22);
            this.famTextBox.TabIndex = 5;
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "im", true));
            this.imTextBox.Location = new System.Drawing.Point(176, 161);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(100, 22);
            this.imTextBox.TabIndex = 7;
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ot", true));
            this.otTextBox.Location = new System.Drawing.Point(176, 201);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(100, 22);
            this.otTextBox.TabIndex = 9;
            // 
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(176, 241);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(100, 22);
            this.specTextBox.TabIndex = 11;
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "kurs", true));
            this.kursTextBox.Location = new System.Drawing.Point(176, 281);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(100, 22);
            this.kursTextBox.TabIndex = 13;
            // 
            // grTextBox
            // 
            this.grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gr", true));
            this.grTextBox.Location = new System.Drawing.Point(176, 321);
            this.grTextBox.Name = "grTextBox";
            this.grTextBox.Size = new System.Drawing.Size(100, 22);
            this.grTextBox.TabIndex = 15;
            // 
            // biogrTextBox
            // 
            this.biogrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "biogr", true));
            this.biogrTextBox.Location = new System.Drawing.Point(176, 361);
            this.biogrTextBox.Name = "biogrTextBox";
            this.biogrTextBox.Size = new System.Drawing.Size(100, 22);
            this.biogrTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(17, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(biogrLabel);
            this.Controls.Add(this.biogrTextBox);
            this.Controls.Add(grLabel);
            this.Controls.Add(this.grTextBox);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursTextBox);
            this.Controls.Add(specLabel);
            this.Controls.Add(this.specTextBox);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(no_zkLabel);
            this.Controls.Add(this.no_zkTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Students";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_AlekseevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_AlekseevaDataSet education_AlekseevaDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Education_AlekseevaDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Education_AlekseevaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_zkTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
        private System.Windows.Forms.TextBox grTextBox;
        private System.Windows.Forms.TextBox biogrTextBox;
        private System.Windows.Forms.Button button1;
    }
}