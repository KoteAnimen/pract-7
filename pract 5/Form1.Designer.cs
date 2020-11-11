namespace pract_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnlyMark = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnlyCylinders = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMarkPower = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMarkCylinders = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCylindersPower = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Compare = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CompareAutos = new System.Windows.Forms.Button();
            this.secondAuto = new System.Windows.Forms.NumericUpDown();
            this.firstAuto = new System.Windows.Forms.NumericUpDown();
            this.ClearList = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.powerAuto = new System.Windows.Forms.NumericUpDown();
            this.countCylinders = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.markAuto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.ClearAllList = new System.Windows.Forms.Button();
            this.ChangeLorry = new System.Windows.Forms.Button();
            this.DeleteLorry = new System.Windows.Forms.Button();
            this.AddListLorry = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.powerLorry = new System.Windows.Forms.NumericUpDown();
            this.countCylindersLorry = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.markLorry = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxLorry = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Compare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCylinders)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerLorry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCylindersLorry)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutUs,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOnlyMark,
            this.AddOnlyCylinders,
            this.AddMarkPower,
            this.AddMarkCylinders,
            this.AddCylindersPower});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // AddOnlyMark
            // 
            this.AddOnlyMark.Name = "AddOnlyMark";
            this.AddOnlyMark.Size = new System.Drawing.Size(260, 22);
            this.AddOnlyMark.Text = "Добавить только с маркой";
            this.AddOnlyMark.Click += new System.EventHandler(this.AddOnlyMark_Click);
            // 
            // AddOnlyCylinders
            // 
            this.AddOnlyCylinders.Name = "AddOnlyCylinders";
            this.AddOnlyCylinders.Size = new System.Drawing.Size(260, 22);
            this.AddOnlyCylinders.Text = "Добавить только цилиндры";
            this.AddOnlyCylinders.Click += new System.EventHandler(this.AddOnlyCylinders_Click);
            // 
            // AddMarkPower
            // 
            this.AddMarkPower.Name = "AddMarkPower";
            this.AddMarkPower.Size = new System.Drawing.Size(260, 22);
            this.AddMarkPower.Text = "Добавить марку и мощность";
            this.AddMarkPower.Click += new System.EventHandler(this.AddMarkPower_Click);
            // 
            // AddMarkCylinders
            // 
            this.AddMarkCylinders.Name = "AddMarkCylinders";
            this.AddMarkCylinders.Size = new System.Drawing.Size(260, 22);
            this.AddMarkCylinders.Text = "Добавить марку и цилиндры";
            this.AddMarkCylinders.Click += new System.EventHandler(this.AddMarkCylinders_Click);
            // 
            // AddCylindersPower
            // 
            this.AddCylindersPower.Name = "AddCylindersPower";
            this.AddCylindersPower.Size = new System.Drawing.Size(260, 22);
            this.AddCylindersPower.Text = "Добавить цилиндры и мощность ";
            this.AddCylindersPower.Click += new System.EventHandler(this.AddCylindersPower_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(94, 20);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 20);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(600, 69);
            this.listBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автомобили";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Compare);
            this.groupBox2.Controls.Add(this.ClearList);
            this.groupBox2.Controls.Add(this.ChangeButton);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.powerAuto);
            this.groupBox2.Controls.Add(this.countCylinders);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.markAuto);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 407);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры автомобиля";
            // 
            // Compare
            // 
            this.Compare.Controls.Add(this.label5);
            this.Compare.Controls.Add(this.label4);
            this.Compare.Controls.Add(this.CompareAutos);
            this.Compare.Controls.Add(this.secondAuto);
            this.Compare.Controls.Add(this.firstAuto);
            this.Compare.Location = new System.Drawing.Point(9, 175);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(200, 129);
            this.Compare.TabIndex = 10;
            this.Compare.TabStop = false;
            this.Compare.Text = "Сравнить два автомобиля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "№ 2-го автомобиля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "№ 1-го автомобиля";
            // 
            // CompareAutos
            // 
            this.CompareAutos.Location = new System.Drawing.Point(7, 100);
            this.CompareAutos.Name = "CompareAutos";
            this.CompareAutos.Size = new System.Drawing.Size(185, 23);
            this.CompareAutos.TabIndex = 2;
            this.CompareAutos.Text = "Сравнить";
            this.CompareAutos.UseVisualStyleBackColor = true;
            this.CompareAutos.Click += new System.EventHandler(this.CompareAutos_Click);
            // 
            // secondAuto
            // 
            this.secondAuto.Location = new System.Drawing.Point(7, 74);
            this.secondAuto.Name = "secondAuto";
            this.secondAuto.Size = new System.Drawing.Size(185, 20);
            this.secondAuto.TabIndex = 1;
            // 
            // firstAuto
            // 
            this.firstAuto.Location = new System.Drawing.Point(7, 32);
            this.firstAuto.Name = "firstAuto";
            this.firstAuto.Size = new System.Drawing.Size(185, 20);
            this.firstAuto.TabIndex = 0;
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(35, 372);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(166, 25);
            this.ClearList.TabIndex = 9;
            this.ClearList.Text = "Очистить список";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(121, 310);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(80, 25);
            this.ChangeButton.TabIndex = 8;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(35, 341);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(166, 25);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить из списка";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(35, 310);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 25);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Мощность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Число цилиндров";
            // 
            // powerAuto
            // 
            this.powerAuto.Location = new System.Drawing.Point(6, 126);
            this.powerAuto.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.powerAuto.Name = "powerAuto";
            this.powerAuto.Size = new System.Drawing.Size(156, 20);
            this.powerAuto.TabIndex = 3;
            // 
            // countCylinders
            // 
            this.countCylinders.Location = new System.Drawing.Point(6, 84);
            this.countCylinders.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.countCylinders.Name = "countCylinders";
            this.countCylinders.Size = new System.Drawing.Size(156, 20);
            this.countCylinders.TabIndex = 2;
            this.countCylinders.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка автомобиля";
            // 
            // markAuto
            // 
            this.markAuto.Location = new System.Drawing.Point(6, 45);
            this.markAuto.Name = "markAuto";
            this.markAuto.Size = new System.Drawing.Size(156, 20);
            this.markAuto.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.capacity);
            this.groupBox3.Controls.Add(this.ClearAllList);
            this.groupBox3.Controls.Add(this.ChangeLorry);
            this.groupBox3.Controls.Add(this.DeleteLorry);
            this.groupBox3.Controls.Add(this.AddListLorry);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.powerLorry);
            this.groupBox3.Controls.Add(this.countCylindersLorry);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.markLorry);
            this.groupBox3.Location = new System.Drawing.Point(389, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 407);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры грузовика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Грузоподъемность тонны";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(6, 167);
            this.capacity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(156, 20);
            this.capacity.TabIndex = 10;
            // 
            // ClearAllList
            // 
            this.ClearAllList.Location = new System.Drawing.Point(35, 372);
            this.ClearAllList.Name = "ClearAllList";
            this.ClearAllList.Size = new System.Drawing.Size(166, 25);
            this.ClearAllList.TabIndex = 9;
            this.ClearAllList.Text = "Очистить список";
            this.ClearAllList.UseVisualStyleBackColor = true;
            this.ClearAllList.Click += new System.EventHandler(this.ClearAllList_Click);
            // 
            // ChangeLorry
            // 
            this.ChangeLorry.Location = new System.Drawing.Point(121, 310);
            this.ChangeLorry.Name = "ChangeLorry";
            this.ChangeLorry.Size = new System.Drawing.Size(80, 25);
            this.ChangeLorry.TabIndex = 8;
            this.ChangeLorry.Text = "Изменить";
            this.ChangeLorry.UseVisualStyleBackColor = true;
            this.ChangeLorry.Click += new System.EventHandler(this.ChangeLorry_Click);
            // 
            // DeleteLorry
            // 
            this.DeleteLorry.Location = new System.Drawing.Point(35, 341);
            this.DeleteLorry.Name = "DeleteLorry";
            this.DeleteLorry.Size = new System.Drawing.Size(166, 25);
            this.DeleteLorry.TabIndex = 7;
            this.DeleteLorry.Text = "Удалить из списка";
            this.DeleteLorry.UseVisualStyleBackColor = true;
            this.DeleteLorry.Click += new System.EventHandler(this.DeleteLorry_Click);
            // 
            // AddListLorry
            // 
            this.AddListLorry.Location = new System.Drawing.Point(35, 310);
            this.AddListLorry.Name = "AddListLorry";
            this.AddListLorry.Size = new System.Drawing.Size(80, 25);
            this.AddListLorry.TabIndex = 6;
            this.AddListLorry.Text = "Добавить";
            this.AddListLorry.UseVisualStyleBackColor = true;
            this.AddListLorry.Click += new System.EventHandler(this.AddListLorry_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Мощность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Число цилиндров";
            // 
            // powerLorry
            // 
            this.powerLorry.Location = new System.Drawing.Point(6, 126);
            this.powerLorry.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.powerLorry.Name = "powerLorry";
            this.powerLorry.Size = new System.Drawing.Size(156, 20);
            this.powerLorry.TabIndex = 3;
            // 
            // countCylindersLorry
            // 
            this.countCylindersLorry.Location = new System.Drawing.Point(6, 84);
            this.countCylindersLorry.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.countCylindersLorry.Name = "countCylindersLorry";
            this.countCylindersLorry.Size = new System.Drawing.Size(156, 20);
            this.countCylindersLorry.TabIndex = 2;
            this.countCylindersLorry.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Марка грузовика";
            // 
            // markLorry
            // 
            this.markLorry.Location = new System.Drawing.Point(6, 45);
            this.markLorry.Name = "markLorry";
            this.markLorry.Size = new System.Drawing.Size(156, 20);
            this.markLorry.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.listBoxLorry);
            this.groupBox4.Location = new System.Drawing.Point(12, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Грузовики";
            // 
            // listBoxLorry
            // 
            this.listBoxLorry.FormattingEnabled = true;
            this.listBoxLorry.Location = new System.Drawing.Point(6, 19);
            this.listBoxLorry.Name = "listBoxLorry";
            this.listBoxLorry.Size = new System.Drawing.Size(600, 69);
            this.listBoxLorry.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №7";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Compare.ResumeLayout(false);
            this.Compare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCylinders)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerLorry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCylindersLorry)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown powerAuto;
        private System.Windows.Forms.NumericUpDown countCylinders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox markAuto;
        private System.Windows.Forms.ToolStripMenuItem AddOnlyMark;
        private System.Windows.Forms.ToolStripMenuItem AddOnlyCylinders;
        private System.Windows.Forms.ToolStripMenuItem AddMarkPower;
        private System.Windows.Forms.ToolStripMenuItem AddMarkCylinders;
        private System.Windows.Forms.ToolStripMenuItem AddCylindersPower;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.GroupBox Compare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CompareAutos;
        private System.Windows.Forms.NumericUpDown secondAuto;
        private System.Windows.Forms.NumericUpDown firstAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.Button ClearAllList;
        private System.Windows.Forms.Button ChangeLorry;
        private System.Windows.Forms.Button DeleteLorry;
        private System.Windows.Forms.Button AddListLorry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown powerLorry;
        private System.Windows.Forms.NumericUpDown countCylindersLorry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox markLorry;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxLorry;
    }
}

