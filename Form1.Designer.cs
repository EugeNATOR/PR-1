namespace Практическая_работа_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxСharacteristic = new System.Windows.Forms.GroupBox();
            this.buttonCreateWaterVehicle = new System.Windows.Forms.Button();
            this.progressBarMovementProcess = new System.Windows.Forms.ProgressBar();
            this.comboBoxTypeOfCargo = new System.Windows.Forms.ComboBox();
            this.textBoxTonnage = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxСharacteristic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(760, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // groupBoxСharacteristic
            // 
            this.groupBoxСharacteristic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxСharacteristic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxСharacteristic.Controls.Add(this.buttonCreateWaterVehicle);
            this.groupBoxСharacteristic.Controls.Add(this.progressBarMovementProcess);
            this.groupBoxСharacteristic.Controls.Add(this.comboBoxTypeOfCargo);
            this.groupBoxСharacteristic.Controls.Add(this.textBoxTonnage);
            this.groupBoxСharacteristic.Controls.Add(this.textBoxLength);
            this.groupBoxСharacteristic.Controls.Add(this.textBoxSpeed);
            this.groupBoxСharacteristic.Controls.Add(this.comboBoxType);
            this.groupBoxСharacteristic.Controls.Add(this.textBoxTitle);
            this.groupBoxСharacteristic.Controls.Add(this.label7);
            this.groupBoxСharacteristic.Controls.Add(this.label6);
            this.groupBoxСharacteristic.Controls.Add(this.label5);
            this.groupBoxСharacteristic.Controls.Add(this.label4);
            this.groupBoxСharacteristic.Controls.Add(this.label3);
            this.groupBoxСharacteristic.Controls.Add(this.label2);
            this.groupBoxСharacteristic.Controls.Add(this.label1);
            this.groupBoxСharacteristic.Location = new System.Drawing.Point(12, 223);
            this.groupBoxСharacteristic.Name = "groupBoxСharacteristic";
            this.groupBoxСharacteristic.Size = new System.Drawing.Size(759, 270);
            this.groupBoxСharacteristic.TabIndex = 2;
            this.groupBoxСharacteristic.TabStop = false;
            this.groupBoxСharacteristic.Text = "Характеристика водного транспортного средства";
            // 
            // buttonCreateWaterVehicle
            // 
            this.buttonCreateWaterVehicle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCreateWaterVehicle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateWaterVehicle.Location = new System.Drawing.Point(403, 211);
            this.buttonCreateWaterVehicle.Name = "buttonCreateWaterVehicle";
            this.buttonCreateWaterVehicle.Size = new System.Drawing.Size(310, 44);
            this.buttonCreateWaterVehicle.TabIndex = 14;
            this.buttonCreateWaterVehicle.Text = "Создать";
            this.buttonCreateWaterVehicle.UseVisualStyleBackColor = false;
            this.buttonCreateWaterVehicle.Click += new System.EventHandler(this.buttonCreateWaterVehicle_Click);
            // 
            // progressBarMovementProcess
            // 
            this.progressBarMovementProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMovementProcess.Location = new System.Drawing.Point(523, 40);
            this.progressBarMovementProcess.Name = "progressBarMovementProcess";
            this.progressBarMovementProcess.Size = new System.Drawing.Size(191, 23);
            this.progressBarMovementProcess.TabIndex = 13;
            // 
            // comboBoxTypeOfCargo
            // 
            this.comboBoxTypeOfCargo.FormattingEnabled = true;
            this.comboBoxTypeOfCargo.Location = new System.Drawing.Point(73, 188);
            this.comboBoxTypeOfCargo.Name = "comboBoxTypeOfCargo";
            this.comboBoxTypeOfCargo.Size = new System.Drawing.Size(195, 21);
            this.comboBoxTypeOfCargo.TabIndex = 12;
            // 
            // textBoxTonnage
            // 
            this.textBoxTonnage.Location = new System.Drawing.Point(120, 236);
            this.textBoxTonnage.Name = "textBoxTonnage";
            this.textBoxTonnage.Size = new System.Drawing.Size(148, 20);
            this.textBoxTonnage.TabIndex = 11;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(120, 143);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(148, 20);
            this.textBoxLength.TabIndex = 10;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(120, 99);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(148, 20);
            this.textBoxSpeed.TabIndex = 9;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(47, 60);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(221, 21);
            this.comboBoxType.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(77, 27);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(191, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Процесс доставки груза";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Водоизмещение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип груза";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Длина (в метрах)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость (в узлах)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Практическая_работа_1.Properties.Resources.море;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxСharacteristic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Мое приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxСharacteristic.ResumeLayout(false);
            this.groupBoxСharacteristic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxСharacteristic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxTypeOfCargo;
        private System.Windows.Forms.TextBox textBoxTonnage;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ProgressBar progressBarMovementProcess;
        private System.Windows.Forms.Button buttonCreateWaterVehicle;
    }
}

