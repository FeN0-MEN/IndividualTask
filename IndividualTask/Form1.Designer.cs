namespace IndividualTask
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WidthFoundationTextBox = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.HeightFoundationTextBox = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.WidthRoofTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxRoofType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelHeightRoof = new System.Windows.Forms.Label();
            this.Foundation = new System.Windows.Forms.GroupBox();
            this.Roof = new System.Windows.Forms.GroupBox();
            this.textBoxCountWindows = new System.Windows.Forms.TextBox();
            this.AddWindow = new System.Windows.Forms.Button();
            this.labelCountWindow = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.WindowGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxHeightWindow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWidthWindow = new System.Windows.Forms.Label();
            this.textBoxWidthWindow = new System.Windows.Forms.TextBox();
            this.DoorGroupBox = new System.Windows.Forms.GroupBox();
            this.labelHeightDoor = new System.Windows.Forms.Label();
            this.textBoxHeightDoor = new System.Windows.Forms.TextBox();
            this.AddDoor = new System.Windows.Forms.Button();
            this.labelWidthDoors = new System.Windows.Forms.Label();
            this.textBoxWidthDoor = new System.Windows.Forms.TextBox();
            this.textBoxCountDoors = new System.Windows.Forms.TextBox();
            this.CountDoorlabel = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo2 = new System.Windows.Forms.GroupBox();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonChooseHouseColor = new System.Windows.Forms.Button();
            this.buttonChooseRoofColor = new System.Windows.Forms.Button();
            this.comboBoxLineStyleWindow = new System.Windows.Forms.ComboBox();
            this.comboBoxLineStyleFoundation = new System.Windows.Forms.ComboBox();
            this.comboBoxLineStyleRoof = new System.Windows.Forms.ComboBox();
            this.comboBoxLineStyleDoor = new System.Windows.Forms.ComboBox();
            this.LineTypeLabelFoundation = new System.Windows.Forms.Label();
            this.LineTypeLabelRoof = new System.Windows.Forms.Label();
            this.LineTypeLabelWindow = new System.Windows.Forms.Label();
            this.LineTypeLabelDoor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.Foundation.SuspendLayout();
            this.Roof.SuspendLayout();
            this.WindowGroupBox.SuspendLayout();
            this.DoorGroupBox.SuspendLayout();
            this.Info.SuspendLayout();
            this.groupBoxInfo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(6, 188);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1515, 615);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DrawClick);
            // 
            // WidthFoundationTextBox
            // 
            this.WidthFoundationTextBox.Location = new System.Drawing.Point(87, 49);
            this.WidthFoundationTextBox.Name = "WidthFoundationTextBox";
            this.WidthFoundationTextBox.Size = new System.Drawing.Size(121, 22);
            this.WidthFoundationTextBox.TabIndex = 2;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 50);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(58, 16);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Ширина";
            // 
            // HeightFoundationTextBox
            // 
            this.HeightFoundationTextBox.Location = new System.Drawing.Point(87, 21);
            this.HeightFoundationTextBox.Name = "HeightFoundationTextBox";
            this.HeightFoundationTextBox.Size = new System.Drawing.Size(121, 22);
            this.HeightFoundationTextBox.TabIndex = 4;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 21);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(55, 16);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Высота";
            // 
            // WidthRoofTextBox
            // 
            this.WidthRoofTextBox.Location = new System.Drawing.Point(90, 49);
            this.WidthRoofTextBox.Name = "WidthRoofTextBox";
            this.WidthRoofTextBox.Size = new System.Drawing.Size(118, 22);
            this.WidthRoofTextBox.TabIndex = 6;
            // 
            // comboBoxRoofType
            // 
            this.comboBoxRoofType.FormattingEnabled = true;
            this.comboBoxRoofType.Location = new System.Drawing.Point(90, 21);
            this.comboBoxRoofType.Name = "comboBoxRoofType";
            this.comboBoxRoofType.Size = new System.Drawing.Size(118, 24);
            this.comboBoxRoofType.TabIndex = 7;
            this.comboBoxRoofType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoofType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(6, 24);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(32, 16);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип";
            // 
            // labelHeightRoof
            // 
            this.labelHeightRoof.AutoSize = true;
            this.labelHeightRoof.Location = new System.Drawing.Point(6, 52);
            this.labelHeightRoof.Name = "labelHeightRoof";
            this.labelHeightRoof.Size = new System.Drawing.Size(55, 16);
            this.labelHeightRoof.TabIndex = 9;
            this.labelHeightRoof.Text = "Высота";
            // 
            // Foundation
            // 
            this.Foundation.Controls.Add(this.LineTypeLabelFoundation);
            this.Foundation.Controls.Add(this.comboBoxLineStyleFoundation);
            this.Foundation.Controls.Add(this.buttonChooseHouseColor);
            this.Foundation.Controls.Add(this.labelHeight);
            this.Foundation.Controls.Add(this.labelWidth);
            this.Foundation.Controls.Add(this.HeightFoundationTextBox);
            this.Foundation.Controls.Add(this.WidthFoundationTextBox);
            this.Foundation.Location = new System.Drawing.Point(12, 12);
            this.Foundation.Name = "Foundation";
            this.Foundation.Size = new System.Drawing.Size(214, 136);
            this.Foundation.TabIndex = 10;
            this.Foundation.TabStop = false;
            this.Foundation.Text = "Основание дома";
            // 
            // Roof
            // 
            this.Roof.Controls.Add(this.LineTypeLabelRoof);
            this.Roof.Controls.Add(this.comboBoxLineStyleRoof);
            this.Roof.Controls.Add(this.buttonChooseRoofColor);
            this.Roof.Controls.Add(this.labelType);
            this.Roof.Controls.Add(this.labelHeightRoof);
            this.Roof.Controls.Add(this.WidthRoofTextBox);
            this.Roof.Controls.Add(this.comboBoxRoofType);
            this.Roof.Location = new System.Drawing.Point(236, 15);
            this.Roof.Name = "Roof";
            this.Roof.Size = new System.Drawing.Size(214, 133);
            this.Roof.TabIndex = 11;
            this.Roof.TabStop = false;
            this.Roof.Text = "Крыша дома";
            // 
            // textBoxCountWindows
            // 
            this.textBoxCountWindows.Location = new System.Drawing.Point(306, 15);
            this.textBoxCountWindows.Name = "textBoxCountWindows";
            this.textBoxCountWindows.Size = new System.Drawing.Size(36, 22);
            this.textBoxCountWindows.TabIndex = 12;
            // 
            // AddWindow
            // 
            this.AddWindow.Location = new System.Drawing.Point(9, 133);
            this.AddWindow.Name = "AddWindow";
            this.AddWindow.Size = new System.Drawing.Size(333, 30);
            this.AddWindow.TabIndex = 13;
            this.AddWindow.Text = "Добавить";
            this.AddWindow.UseVisualStyleBackColor = true;
            this.AddWindow.Click += new System.EventHandler(this.AddWindow_Click);
            // 
            // labelCountWindow
            // 
            this.labelCountWindow.Location = new System.Drawing.Point(9, 18);
            this.labelCountWindow.Name = "labelCountWindow";
            this.labelCountWindow.Size = new System.Drawing.Size(280, 25);
            this.labelCountWindow.TabIndex = 14;
            this.labelCountWindow.Text = "Количество окон, которое нужно создать";
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(6, 24);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(137, 139);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "Вы можете перемещать окна и двери с помощью курсора мыши, просто зажав их и потян" +
    "ув";
            // 
            // WindowGroupBox
            // 
            this.WindowGroupBox.Controls.Add(this.LineTypeLabelWindow);
            this.WindowGroupBox.Controls.Add(this.comboBoxLineStyleWindow);
            this.WindowGroupBox.Controls.Add(this.textBoxHeightWindow);
            this.WindowGroupBox.Controls.Add(this.label2);
            this.WindowGroupBox.Controls.Add(this.labelWidthWindow);
            this.WindowGroupBox.Controls.Add(this.textBoxWidthWindow);
            this.WindowGroupBox.Controls.Add(this.labelCountWindow);
            this.WindowGroupBox.Controls.Add(this.textBoxCountWindows);
            this.WindowGroupBox.Controls.Add(this.AddWindow);
            this.WindowGroupBox.Location = new System.Drawing.Point(612, 12);
            this.WindowGroupBox.Name = "WindowGroupBox";
            this.WindowGroupBox.Size = new System.Drawing.Size(354, 170);
            this.WindowGroupBox.TabIndex = 16;
            this.WindowGroupBox.TabStop = false;
            this.WindowGroupBox.Text = "Окна";
            // 
            // textBoxHeightWindow
            // 
            this.textBoxHeightWindow.Location = new System.Drawing.Point(120, 47);
            this.textBoxHeightWindow.Name = "textBoxHeightWindow";
            this.textBoxHeightWindow.Size = new System.Drawing.Size(222, 22);
            this.textBoxHeightWindow.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Высота";
            // 
            // labelWidthWindow
            // 
            this.labelWidthWindow.AutoSize = true;
            this.labelWidthWindow.Location = new System.Drawing.Point(9, 77);
            this.labelWidthWindow.Name = "labelWidthWindow";
            this.labelWidthWindow.Size = new System.Drawing.Size(58, 16);
            this.labelWidthWindow.TabIndex = 16;
            this.labelWidthWindow.Text = "Ширина";
            // 
            // textBoxWidthWindow
            // 
            this.textBoxWidthWindow.Location = new System.Drawing.Point(121, 74);
            this.textBoxWidthWindow.Name = "textBoxWidthWindow";
            this.textBoxWidthWindow.Size = new System.Drawing.Size(222, 22);
            this.textBoxWidthWindow.TabIndex = 15;
            // 
            // DoorGroupBox
            // 
            this.DoorGroupBox.Controls.Add(this.LineTypeLabelDoor);
            this.DoorGroupBox.Controls.Add(this.comboBoxLineStyleDoor);
            this.DoorGroupBox.Controls.Add(this.labelHeightDoor);
            this.DoorGroupBox.Controls.Add(this.textBoxHeightDoor);
            this.DoorGroupBox.Controls.Add(this.AddDoor);
            this.DoorGroupBox.Controls.Add(this.labelWidthDoors);
            this.DoorGroupBox.Controls.Add(this.textBoxWidthDoor);
            this.DoorGroupBox.Controls.Add(this.textBoxCountDoors);
            this.DoorGroupBox.Controls.Add(this.CountDoorlabel);
            this.DoorGroupBox.Location = new System.Drawing.Point(1098, 12);
            this.DoorGroupBox.Name = "DoorGroupBox";
            this.DoorGroupBox.Size = new System.Drawing.Size(423, 169);
            this.DoorGroupBox.TabIndex = 17;
            this.DoorGroupBox.TabStop = false;
            this.DoorGroupBox.Text = "Двери";
            // 
            // labelHeightDoor
            // 
            this.labelHeightDoor.AutoSize = true;
            this.labelHeightDoor.Location = new System.Drawing.Point(16, 53);
            this.labelHeightDoor.Name = "labelHeightDoor";
            this.labelHeightDoor.Size = new System.Drawing.Size(55, 16);
            this.labelHeightDoor.TabIndex = 24;
            this.labelHeightDoor.Text = "Высота";
            // 
            // textBoxHeightDoor
            // 
            this.textBoxHeightDoor.Location = new System.Drawing.Point(170, 47);
            this.textBoxHeightDoor.Name = "textBoxHeightDoor";
            this.textBoxHeightDoor.Size = new System.Drawing.Size(222, 22);
            this.textBoxHeightDoor.TabIndex = 23;
            // 
            // AddDoor
            // 
            this.AddDoor.Location = new System.Drawing.Point(19, 134);
            this.AddDoor.Name = "AddDoor";
            this.AddDoor.Size = new System.Drawing.Size(373, 29);
            this.AddDoor.TabIndex = 22;
            this.AddDoor.Text = "Добавить";
            this.AddDoor.UseVisualStyleBackColor = true;
            // 
            // labelWidthDoors
            // 
            this.labelWidthDoors.AutoSize = true;
            this.labelWidthDoors.Location = new System.Drawing.Point(16, 83);
            this.labelWidthDoors.Name = "labelWidthDoors";
            this.labelWidthDoors.Size = new System.Drawing.Size(58, 16);
            this.labelWidthDoors.TabIndex = 21;
            this.labelWidthDoors.Text = "Ширина";
            // 
            // textBoxWidthDoor
            // 
            this.textBoxWidthDoor.Location = new System.Drawing.Point(170, 77);
            this.textBoxWidthDoor.Name = "textBoxWidthDoor";
            this.textBoxWidthDoor.Size = new System.Drawing.Size(222, 22);
            this.textBoxWidthDoor.TabIndex = 20;
            // 
            // textBoxCountDoors
            // 
            this.textBoxCountDoors.Location = new System.Drawing.Point(356, 18);
            this.textBoxCountDoors.Name = "textBoxCountDoors";
            this.textBoxCountDoors.Size = new System.Drawing.Size(36, 22);
            this.textBoxCountDoors.TabIndex = 19;
            // 
            // CountDoorlabel
            // 
            this.CountDoorlabel.AutoSize = true;
            this.CountDoorlabel.Location = new System.Drawing.Point(16, 23);
            this.CountDoorlabel.Name = "CountDoorlabel";
            this.CountDoorlabel.Size = new System.Drawing.Size(334, 16);
            this.CountDoorlabel.TabIndex = 0;
            this.CountDoorlabel.Text = "Количестве дверей, которое необходимо создать";
            // 
            // Info
            // 
            this.Info.Controls.Add(this.labelInfo);
            this.Info.Location = new System.Drawing.Point(456, 15);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(150, 166);
            this.Info.TabIndex = 18;
            this.Info.TabStop = false;
            this.Info.Text = "Информация";
            // 
            // groupBoxInfo2
            // 
            this.groupBoxInfo2.Controls.Add(this.labelInfo2);
            this.groupBoxInfo2.Location = new System.Drawing.Point(972, 15);
            this.groupBoxInfo2.Name = "groupBoxInfo2";
            this.groupBoxInfo2.Size = new System.Drawing.Size(120, 166);
            this.groupBoxInfo2.TabIndex = 19;
            this.groupBoxInfo2.TabStop = false;
            this.groupBoxInfo2.Text = "Информация";
            // 
            // labelInfo2
            // 
            this.labelInfo2.Location = new System.Drawing.Point(0, 24);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(114, 139);
            this.labelInfo2.TabIndex = 0;
            this.labelInfo2.Text = "Вы можете кликнуть по окну или двери правой кнопкой мыши и они удалятся";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(245, 152);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(199, 30);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Очистить полотно";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChooseHouseColor
            // 
            this.buttonChooseHouseColor.Location = new System.Drawing.Point(9, 76);
            this.buttonChooseHouseColor.Name = "buttonChooseHouseColor";
            this.buttonChooseHouseColor.Size = new System.Drawing.Size(199, 27);
            this.buttonChooseHouseColor.TabIndex = 21;
            this.buttonChooseHouseColor.Text = "Выбрать цвет";
            this.buttonChooseHouseColor.UseVisualStyleBackColor = true;
            // 
            // buttonChooseRoofColor
            // 
            this.buttonChooseRoofColor.Location = new System.Drawing.Point(9, 76);
            this.buttonChooseRoofColor.Name = "buttonChooseRoofColor";
            this.buttonChooseRoofColor.Size = new System.Drawing.Size(199, 27);
            this.buttonChooseRoofColor.TabIndex = 21;
            this.buttonChooseRoofColor.Text = "Выбрать цвет";
            this.buttonChooseRoofColor.UseVisualStyleBackColor = true;
            // 
            // comboBoxLineStyleWindow
            // 
            this.comboBoxLineStyleWindow.FormattingEnabled = true;
            this.comboBoxLineStyleWindow.Location = new System.Drawing.Point(120, 103);
            this.comboBoxLineStyleWindow.Name = "comboBoxLineStyleWindow";
            this.comboBoxLineStyleWindow.Size = new System.Drawing.Size(222, 24);
            this.comboBoxLineStyleWindow.TabIndex = 19;
            this.comboBoxLineStyleWindow.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineStyleWindow_SelectedIndexChanged);
            // 
            // comboBoxLineStyleFoundation
            // 
            this.comboBoxLineStyleFoundation.FormattingEnabled = true;
            this.comboBoxLineStyleFoundation.Location = new System.Drawing.Point(87, 106);
            this.comboBoxLineStyleFoundation.Name = "comboBoxLineStyleFoundation";
            this.comboBoxLineStyleFoundation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLineStyleFoundation.TabIndex = 22;
            this.comboBoxLineStyleFoundation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineStyleFoundation_SelectedIndexChanged);
            // 
            // comboBoxLineStyleRoof
            // 
            this.comboBoxLineStyleRoof.FormattingEnabled = true;
            this.comboBoxLineStyleRoof.Location = new System.Drawing.Point(90, 105);
            this.comboBoxLineStyleRoof.Name = "comboBoxLineStyleRoof";
            this.comboBoxLineStyleRoof.Size = new System.Drawing.Size(118, 24);
            this.comboBoxLineStyleRoof.TabIndex = 22;
            this.comboBoxLineStyleRoof.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineStyleRoof_SelectedIndexChanged);
            // 
            // comboBoxLineStyleDoor
            // 
            this.comboBoxLineStyleDoor.FormattingEnabled = true;
            this.comboBoxLineStyleDoor.Location = new System.Drawing.Point(170, 107);
            this.comboBoxLineStyleDoor.Name = "comboBoxLineStyleDoor";
            this.comboBoxLineStyleDoor.Size = new System.Drawing.Size(222, 24);
            this.comboBoxLineStyleDoor.TabIndex = 25;
            this.comboBoxLineStyleDoor.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineStyleDoor_SelectedIndexChanged);
            // 
            // LineTypeLabelFoundation
            // 
            this.LineTypeLabelFoundation.AutoSize = true;
            this.LineTypeLabelFoundation.Location = new System.Drawing.Point(6, 111);
            this.LineTypeLabelFoundation.Name = "LineTypeLabelFoundation";
            this.LineTypeLabelFoundation.Size = new System.Drawing.Size(75, 16);
            this.LineTypeLabelFoundation.TabIndex = 23;
            this.LineTypeLabelFoundation.Text = "Тип линии";
            // 
            // LineTypeLabelRoof
            // 
            this.LineTypeLabelRoof.AutoSize = true;
            this.LineTypeLabelRoof.Location = new System.Drawing.Point(9, 111);
            this.LineTypeLabelRoof.Name = "LineTypeLabelRoof";
            this.LineTypeLabelRoof.Size = new System.Drawing.Size(75, 16);
            this.LineTypeLabelRoof.TabIndex = 23;
            this.LineTypeLabelRoof.Text = "Тип линии";
            // 
            // LineTypeLabelWindow
            // 
            this.LineTypeLabelWindow.AutoSize = true;
            this.LineTypeLabelWindow.Location = new System.Drawing.Point(12, 110);
            this.LineTypeLabelWindow.Name = "LineTypeLabelWindow";
            this.LineTypeLabelWindow.Size = new System.Drawing.Size(75, 16);
            this.LineTypeLabelWindow.TabIndex = 20;
            this.LineTypeLabelWindow.Text = "Тип линии";
            // 
            // LineTypeLabelDoor
            // 
            this.LineTypeLabelDoor.AutoSize = true;
            this.LineTypeLabelDoor.Location = new System.Drawing.Point(19, 110);
            this.LineTypeLabelDoor.Name = "LineTypeLabelDoor";
            this.LineTypeLabelDoor.Size = new System.Drawing.Size(75, 16);
            this.LineTypeLabelDoor.TabIndex = 26;
            this.LineTypeLabelDoor.Text = "Тип линии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 811);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxInfo2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.DoorGroupBox);
            this.Controls.Add(this.WindowGroupBox);
            this.Controls.Add(this.Roof);
            this.Controls.Add(this.Foundation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Индивидуальное задание \"Строительство дома\" Вариант 22 Мишунин Никита";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.Foundation.ResumeLayout(false);
            this.Foundation.PerformLayout();
            this.Roof.ResumeLayout(false);
            this.Roof.PerformLayout();
            this.WindowGroupBox.ResumeLayout(false);
            this.WindowGroupBox.PerformLayout();
            this.DoorGroupBox.ResumeLayout(false);
            this.DoorGroupBox.PerformLayout();
            this.Info.ResumeLayout(false);
            this.groupBoxInfo2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WidthFoundationTextBox;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox HeightFoundationTextBox;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox WidthRoofTextBox;
        private System.Windows.Forms.ComboBox comboBoxRoofType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelHeightRoof;
        private System.Windows.Forms.GroupBox Foundation;
        private System.Windows.Forms.GroupBox Roof;
        private System.Windows.Forms.TextBox textBoxCountWindows;
        private System.Windows.Forms.Button AddWindow;
        private System.Windows.Forms.Label labelCountWindow;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox WindowGroupBox;
        private System.Windows.Forms.TextBox textBoxHeightWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWidthWindow;
        private System.Windows.Forms.TextBox textBoxWidthWindow;
        private System.Windows.Forms.GroupBox DoorGroupBox;
        private System.Windows.Forms.Label labelHeightDoor;
        private System.Windows.Forms.TextBox textBoxHeightDoor;
        private System.Windows.Forms.Button AddDoor;
        private System.Windows.Forms.Label labelWidthDoors;
        private System.Windows.Forms.TextBox textBoxWidthDoor;
        private System.Windows.Forms.TextBox textBoxCountDoors;
        private System.Windows.Forms.Label CountDoorlabel;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.GroupBox groupBoxInfo2;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonChooseHouseColor;
        private System.Windows.Forms.Button buttonChooseRoofColor;
        private System.Windows.Forms.ComboBox comboBoxLineStyleFoundation;
        private System.Windows.Forms.ComboBox comboBoxLineStyleRoof;
        private System.Windows.Forms.ComboBox comboBoxLineStyleWindow;
        private System.Windows.Forms.ComboBox comboBoxLineStyleDoor;
        private System.Windows.Forms.Label LineTypeLabelFoundation;
        private System.Windows.Forms.Label LineTypeLabelRoof;
        private System.Windows.Forms.Label LineTypeLabelWindow;
        private System.Windows.Forms.Label LineTypeLabelDoor;
    }
}

