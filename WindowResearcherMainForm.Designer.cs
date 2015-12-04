namespace WindowResearcher
{
    partial class WindowResearcherMainForm
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxWindowPositionY = new System.Windows.Forms.TextBox();
            this.textBoxWindowPositionX = new System.Windows.Forms.TextBox();
            this.labelWindowPositionY = new System.Windows.Forms.Label();
            this.labelWindowPositionX = new System.Windows.Forms.Label();
            this.labelWindowPosition = new System.Windows.Forms.Label();
            this.textBoxWindowHeight = new System.Windows.Forms.TextBox();
            this.textBoxWindowWidth = new System.Windows.Forms.TextBox();
            this.labelWindowHeight = new System.Windows.Forms.Label();
            this.labelWindowWidth = new System.Windows.Forms.Label();
            this.labelWindowSize = new System.Windows.Forms.Label();
            this.labelWindowStyles = new System.Windows.Forms.Label();
            this.labelWindowCaption = new System.Windows.Forms.Label();
            this.textBoxWindowStyles = new System.Windows.Forms.TextBox();
            this.textBoxWindowCaption = new System.Windows.Forms.TextBox();
            this.textBoxWindowClass = new System.Windows.Forms.TextBox();
            this.textBoxWindowHandle = new System.Windows.Forms.TextBox();
            this.labelWindowClass = new System.Windows.Forms.Label();
            this.labelWindowHandle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelXMousePosition = new System.Windows.Forms.Label();
            this.labelYMousePosition = new System.Windows.Forms.Label();
            this.timerSearch = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxWindowPositionY);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowPositionX);
            this.groupBoxInfo.Controls.Add(this.labelWindowPositionY);
            this.groupBoxInfo.Controls.Add(this.labelWindowPositionX);
            this.groupBoxInfo.Controls.Add(this.labelWindowPosition);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowHeight);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowWidth);
            this.groupBoxInfo.Controls.Add(this.labelWindowHeight);
            this.groupBoxInfo.Controls.Add(this.labelWindowWidth);
            this.groupBoxInfo.Controls.Add(this.labelWindowSize);
            this.groupBoxInfo.Controls.Add(this.labelWindowStyles);
            this.groupBoxInfo.Controls.Add(this.labelWindowCaption);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowStyles);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowCaption);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowClass);
            this.groupBoxInfo.Controls.Add(this.textBoxWindowHandle);
            this.groupBoxInfo.Controls.Add(this.labelWindowClass);
            this.groupBoxInfo.Controls.Add(this.labelWindowHandle);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 82);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(351, 278);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // textBoxWindowPositionY
            // 
            this.textBoxWindowPositionY.BackColor = System.Drawing.Color.White;
            this.textBoxWindowPositionY.Location = new System.Drawing.Point(274, 217);
            this.textBoxWindowPositionY.Name = "textBoxWindowPositionY";
            this.textBoxWindowPositionY.ReadOnly = true;
            this.textBoxWindowPositionY.Size = new System.Drawing.Size(71, 20);
            this.textBoxWindowPositionY.TabIndex = 14;
            // 
            // textBoxWindowPositionX
            // 
            this.textBoxWindowPositionX.BackColor = System.Drawing.Color.White;
            this.textBoxWindowPositionX.Location = new System.Drawing.Point(274, 188);
            this.textBoxWindowPositionX.Name = "textBoxWindowPositionX";
            this.textBoxWindowPositionX.ReadOnly = true;
            this.textBoxWindowPositionX.Size = new System.Drawing.Size(71, 20);
            this.textBoxWindowPositionX.TabIndex = 13;
            // 
            // labelWindowPositionY
            // 
            this.labelWindowPositionY.AutoSize = true;
            this.labelWindowPositionY.Location = new System.Drawing.Point(251, 220);
            this.labelWindowPositionY.Name = "labelWindowPositionY";
            this.labelWindowPositionY.Size = new System.Drawing.Size(17, 13);
            this.labelWindowPositionY.TabIndex = 12;
            this.labelWindowPositionY.Text = "Y:";
            // 
            // labelWindowPositionX
            // 
            this.labelWindowPositionX.AutoSize = true;
            this.labelWindowPositionX.Location = new System.Drawing.Point(253, 191);
            this.labelWindowPositionX.Name = "labelWindowPositionX";
            this.labelWindowPositionX.Size = new System.Drawing.Size(17, 13);
            this.labelWindowPositionX.TabIndex = 11;
            this.labelWindowPositionX.Text = "X:";
            // 
            // labelWindowPosition
            // 
            this.labelWindowPosition.AutoSize = true;
            this.labelWindowPosition.Location = new System.Drawing.Point(80, 205);
            this.labelWindowPosition.Name = "labelWindowPosition";
            this.labelWindowPosition.Size = new System.Drawing.Size(112, 13);
            this.labelWindowPosition.TabIndex = 10;
            this.labelWindowPosition.Text = "Расположение окна:";
            // 
            // textBoxWindowHeight
            // 
            this.textBoxWindowHeight.BackColor = System.Drawing.Color.White;
            this.textBoxWindowHeight.Location = new System.Drawing.Point(274, 155);
            this.textBoxWindowHeight.Name = "textBoxWindowHeight";
            this.textBoxWindowHeight.ReadOnly = true;
            this.textBoxWindowHeight.Size = new System.Drawing.Size(71, 20);
            this.textBoxWindowHeight.TabIndex = 9;
            // 
            // textBoxWindowWidth
            // 
            this.textBoxWindowWidth.BackColor = System.Drawing.Color.White;
            this.textBoxWindowWidth.Location = new System.Drawing.Point(274, 126);
            this.textBoxWindowWidth.Name = "textBoxWindowWidth";
            this.textBoxWindowWidth.ReadOnly = true;
            this.textBoxWindowWidth.Size = new System.Drawing.Size(71, 20);
            this.textBoxWindowWidth.TabIndex = 8;
            // 
            // labelWindowHeight
            // 
            this.labelWindowHeight.AutoSize = true;
            this.labelWindowHeight.Location = new System.Drawing.Point(220, 158);
            this.labelWindowHeight.Name = "labelWindowHeight";
            this.labelWindowHeight.Size = new System.Drawing.Size(48, 13);
            this.labelWindowHeight.TabIndex = 7;
            this.labelWindowHeight.Text = "Высота:";
            // 
            // labelWindowWidth
            // 
            this.labelWindowWidth.AutoSize = true;
            this.labelWindowWidth.Location = new System.Drawing.Point(222, 129);
            this.labelWindowWidth.Name = "labelWindowWidth";
            this.labelWindowWidth.Size = new System.Drawing.Size(49, 13);
            this.labelWindowWidth.TabIndex = 6;
            this.labelWindowWidth.Text = "Ширина:";
            // 
            // labelWindowSize
            // 
            this.labelWindowSize.AutoSize = true;
            this.labelWindowSize.Location = new System.Drawing.Point(108, 143);
            this.labelWindowSize.Name = "labelWindowSize";
            this.labelWindowSize.Size = new System.Drawing.Size(84, 13);
            this.labelWindowSize.TabIndex = 5;
            this.labelWindowSize.Text = "Размеры окна:";
            // 
            // labelWindowStyles
            // 
            this.labelWindowStyles.AutoSize = true;
            this.labelWindowStyles.Location = new System.Drawing.Point(37, 103);
            this.labelWindowStyles.Name = "labelWindowStyles";
            this.labelWindowStyles.Size = new System.Drawing.Size(67, 13);
            this.labelWindowStyles.TabIndex = 4;
            this.labelWindowStyles.Text = "Стили окна:";
            // 
            // labelWindowCaption
            // 
            this.labelWindowCaption.AutoSize = true;
            this.labelWindowCaption.Location = new System.Drawing.Point(14, 77);
            this.labelWindowCaption.Name = "labelWindowCaption";
            this.labelWindowCaption.Size = new System.Drawing.Size(91, 13);
            this.labelWindowCaption.TabIndex = 4;
            this.labelWindowCaption.Text = "Заголовок окна:";
            // 
            // textBoxWindowStyles
            // 
            this.textBoxWindowStyles.BackColor = System.Drawing.Color.White;
            this.textBoxWindowStyles.Location = new System.Drawing.Point(111, 100);
            this.textBoxWindowStyles.Name = "textBoxWindowStyles";
            this.textBoxWindowStyles.ReadOnly = true;
            this.textBoxWindowStyles.Size = new System.Drawing.Size(234, 20);
            this.textBoxWindowStyles.TabIndex = 3;
            // 
            // textBoxWindowCaption
            // 
            this.textBoxWindowCaption.BackColor = System.Drawing.Color.White;
            this.textBoxWindowCaption.Location = new System.Drawing.Point(111, 74);
            this.textBoxWindowCaption.Name = "textBoxWindowCaption";
            this.textBoxWindowCaption.ReadOnly = true;
            this.textBoxWindowCaption.Size = new System.Drawing.Size(234, 20);
            this.textBoxWindowCaption.TabIndex = 3;
            // 
            // textBoxWindowClass
            // 
            this.textBoxWindowClass.BackColor = System.Drawing.Color.White;
            this.textBoxWindowClass.Location = new System.Drawing.Point(111, 48);
            this.textBoxWindowClass.Name = "textBoxWindowClass";
            this.textBoxWindowClass.ReadOnly = true;
            this.textBoxWindowClass.Size = new System.Drawing.Size(234, 20);
            this.textBoxWindowClass.TabIndex = 2;
            // 
            // textBoxWindowHandle
            // 
            this.textBoxWindowHandle.BackColor = System.Drawing.Color.White;
            this.textBoxWindowHandle.Location = new System.Drawing.Point(111, 22);
            this.textBoxWindowHandle.Name = "textBoxWindowHandle";
            this.textBoxWindowHandle.ReadOnly = true;
            this.textBoxWindowHandle.Size = new System.Drawing.Size(234, 20);
            this.textBoxWindowHandle.TabIndex = 2;
            // 
            // labelWindowClass
            // 
            this.labelWindowClass.AutoSize = true;
            this.labelWindowClass.Location = new System.Drawing.Point(37, 51);
            this.labelWindowClass.Name = "labelWindowClass";
            this.labelWindowClass.Size = new System.Drawing.Size(68, 13);
            this.labelWindowClass.TabIndex = 1;
            this.labelWindowClass.Text = "Класс окна:";
            // 
            // labelWindowHandle
            // 
            this.labelWindowHandle.AutoSize = true;
            this.labelWindowHandle.Location = new System.Drawing.Point(6, 25);
            this.labelWindowHandle.Name = "labelWindowHandle";
            this.labelWindowHandle.Size = new System.Drawing.Size(99, 13);
            this.labelWindowHandle.TabIndex = 0;
            this.labelWindowHandle.Text = "Дескриптор окна:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(282, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelXMousePosition
            // 
            this.labelXMousePosition.AutoSize = true;
            this.labelXMousePosition.Location = new System.Drawing.Point(48, 19);
            this.labelXMousePosition.Name = "labelXMousePosition";
            this.labelXMousePosition.Size = new System.Drawing.Size(17, 13);
            this.labelXMousePosition.TabIndex = 3;
            this.labelXMousePosition.Text = "X:";
            // 
            // labelYMousePosition
            // 
            this.labelYMousePosition.AutoSize = true;
            this.labelYMousePosition.Location = new System.Drawing.Point(48, 38);
            this.labelYMousePosition.Name = "labelYMousePosition";
            this.labelYMousePosition.Size = new System.Drawing.Size(17, 13);
            this.labelYMousePosition.TabIndex = 4;
            this.labelYMousePosition.Text = "Y:";
            // 
            // timerSearch
            // 
            this.timerSearch.Interval = 70;
            this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.Color.White;
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Image = global::WindowResearcher.Properties.Resources.SearchStop;
            this.pictureBoxSearch.Location = new System.Drawing.Point(172, 12);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSearch.TabIndex = 2;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSearch_MouseDown);
            this.pictureBoxSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSearch_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelYMousePosition);
            this.groupBox1.Controls.Add(this.labelXMousePosition);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координаты курсора";
            // 
            // WindowResearcherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowResearcherMainForm";
            this.Text = "WindowResearcher";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label labelXMousePosition;
        private System.Windows.Forms.Label labelYMousePosition;
        private System.Windows.Forms.Timer timerSearch;
        private System.Windows.Forms.Label labelWindowHandle;
        private System.Windows.Forms.Label labelWindowClass;
        private System.Windows.Forms.TextBox textBoxWindowClass;
        private System.Windows.Forms.TextBox textBoxWindowHandle;
        private System.Windows.Forms.Label labelWindowCaption;
        private System.Windows.Forms.TextBox textBoxWindowCaption;
        private System.Windows.Forms.Label labelWindowSize;
        private System.Windows.Forms.TextBox textBoxWindowHeight;
        private System.Windows.Forms.TextBox textBoxWindowWidth;
        private System.Windows.Forms.Label labelWindowHeight;
        private System.Windows.Forms.Label labelWindowWidth;
        private System.Windows.Forms.TextBox textBoxWindowPositionY;
        private System.Windows.Forms.TextBox textBoxWindowPositionX;
        private System.Windows.Forms.Label labelWindowPositionY;
        private System.Windows.Forms.Label labelWindowPositionX;
        private System.Windows.Forms.Label labelWindowPosition;
        private System.Windows.Forms.Label labelWindowStyles;
        private System.Windows.Forms.TextBox textBoxWindowStyles;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

