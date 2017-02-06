namespace TechLab_IDE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openexItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_codeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.compileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.paramItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.set_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.compile_btn = new System.Windows.Forms.Button();
            this.term_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.board_box = new System.Windows.Forms.ComboBox();
            this.port_box = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.log = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem1,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItem,
            this.toolStripSeparator1,
            this.openItem,
            this.openexItem,
            this.toolStripSeparator2,
            this.saveItem,
            this.save_codeItem,
            this.toolStripSeparator3,
            this.compileItem,
            this.loadItem,
            this.toolStripSeparator4,
            this.paramItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // newItem
            // 
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(195, 22);
            this.newItem.Text = "Новый";
            this.newItem.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(195, 22);
            this.openItem.Text = "Открыть";
            this.openItem.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // openexItem
            // 
            this.openexItem.Name = "openexItem";
            this.openexItem.Size = new System.Drawing.Size(195, 22);
            this.openexItem.Text = "Открыть из примеров";
            this.openexItem.Click += new System.EventHandler(this.openexItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(195, 22);
            this.saveItem.Text = "Сохранить блоки";
            this.saveItem.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // save_codeItem
            // 
            this.save_codeItem.Name = "save_codeItem";
            this.save_codeItem.Size = new System.Drawing.Size(195, 22);
            this.save_codeItem.Text = "Сохранить код";
            this.save_codeItem.Click += new System.EventHandler(this.save_codeItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // compileItem
            // 
            this.compileItem.Name = "compileItem";
            this.compileItem.Size = new System.Drawing.Size(195, 22);
            this.compileItem.Text = "Проверить";
            this.compileItem.Click += new System.EventHandler(this.compile_btn_Click);
            // 
            // loadItem
            // 
            this.loadItem.Name = "loadItem";
            this.loadItem.Size = new System.Drawing.Size(195, 22);
            this.loadItem.Text = "Загрузить";
            this.loadItem.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // paramItem
            // 
            this.paramItem.Name = "paramItem";
            this.paramItem.Size = new System.Drawing.Size(195, 22);
            this.paramItem.Text = "Параметры";
            this.paramItem.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem1
            // 
            this.параметрыToolStripMenuItem1.Name = "параметрыToolStripMenuItem1";
            this.параметрыToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem1.Text = "Параметры";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteItem,
            this.infoItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // siteItem
            // 
            this.siteItem.Name = "siteItem";
            this.siteItem.Size = new System.Drawing.Size(152, 22);
            this.siteItem.Text = "Зайти на сайт";
            this.siteItem.Click += new System.EventHandler(this.siteItem_Click);
            // 
            // infoItem
            // 
            this.infoItem.Name = "infoItem";
            this.infoItem.Size = new System.Drawing.Size(152, 22);
            this.infoItem.Text = "О программе";
            this.infoItem.Click += new System.EventHandler(this.infoItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.term_btn);
            this.panel2.Controls.Add(this.set_btn);
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Controls.Add(this.open_btn);
            this.panel2.Controls.Add(this.new_btn);
            this.panel2.Controls.Add(this.load_btn);
            this.panel2.Controls.Add(this.compile_btn);
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 59);
            this.panel2.TabIndex = 2;
            // 
            // set_btn
            // 
            this.set_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_btn.Image = global::TechLab_IDE.Properties.Resources.cog_24x24;
            this.set_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.set_btn.Location = new System.Drawing.Point(413, 3);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(70, 50);
            this.set_btn.TabIndex = 5;
            this.set_btn.Text = "Настройка";
            this.set_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Image = global::TechLab_IDE.Properties.Resources.download_18x24;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_btn.Location = new System.Drawing.Point(327, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(70, 50);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Сохранить";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_btn.Image = global::TechLab_IDE.Properties.Resources.upload_18x24;
            this.open_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.open_btn.Location = new System.Drawing.Point(251, 3);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(70, 50);
            this.open_btn.TabIndex = 3;
            this.open_btn.Text = "Открыть";
            this.open_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_btn.Image = global::TechLab_IDE.Properties.Resources.document_alt_stroke_18x24;
            this.new_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.new_btn.Location = new System.Drawing.Point(165, 3);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(70, 50);
            this.new_btn.TabIndex = 2;
            this.new_btn.Text = "Новый";
            this.new_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load_btn.Image = global::TechLab_IDE.Properties.Resources.arrow_right_alt1_24x24;
            this.load_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.load_btn.Location = new System.Drawing.Point(79, 3);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(70, 50);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "Загрузить";
            this.load_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // compile_btn
            // 
            this.compile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.compile_btn.Image = global::TechLab_IDE.Properties.Resources.check_alt_24x24;
            this.compile_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.compile_btn.Location = new System.Drawing.Point(3, 3);
            this.compile_btn.Name = "compile_btn";
            this.compile_btn.Size = new System.Drawing.Size(70, 50);
            this.compile_btn.TabIndex = 0;
            this.compile_btn.Text = "Контроль";
            this.compile_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compile_btn.UseVisualStyleBackColor = true;
            this.compile_btn.Click += new System.EventHandler(this.compile_btn_Click);
            // 
            // term_btn
            // 
            this.term_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.term_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.term_btn.Image = global::TechLab_IDE.Properties.Resources.magnifying_glass_24x241;
            this.term_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.term_btn.Location = new System.Drawing.Point(707, 3);
            this.term_btn.Name = "term_btn";
            this.term_btn.Size = new System.Drawing.Size(70, 50);
            this.term_btn.TabIndex = 6;
            this.term_btn.Text = "Терминал";
            this.term_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.term_btn.UseVisualStyleBackColor = true;
            this.term_btn.Click += new System.EventHandler(this.term_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.port_box);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.board_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 33);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechLab_IDE.Properties.Resources.chipmicro_24x241;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // board_box
            // 
            this.board_box.FormattingEnabled = true;
            this.board_box.Items.AddRange(new object[] {
            "arduino:avr:uno",
            "arduino:avr:nano:cpu=atmega328",
            "arduino:avr:mega"});
            this.board_box.Location = new System.Drawing.Point(35, 6);
            this.board_box.Name = "board_box";
            this.board_box.Size = new System.Drawing.Size(121, 21);
            this.board_box.TabIndex = 1;
            this.board_box.Text = "arduino:avr:uno";
            // 
            // port_box
            // 
            this.port_box.FormattingEnabled = true;
            this.port_box.Items.AddRange(new object[] {
            "COM"});
            this.port_box.Location = new System.Drawing.Point(197, 6);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(121, 21);
            this.port_box.TabIndex = 3;
            this.port_box.Text = "Set com port here";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TechLab_IDE.Properties.Resources.usb_24x24;
            this.pictureBox2.Location = new System.Drawing.Point(167, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(6, 124);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(774, 232);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(334, 99);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(35, 13);
            this.log.TabIndex = 5;
            this.log.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.log);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechLab IDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem openexItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem save_codeItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem compileItem;
        private System.Windows.Forms.ToolStripMenuItem loadItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem paramItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteItem;
        private System.Windows.Forms.ToolStripMenuItem infoItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button compile_btn;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button term_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox port_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox board_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label log;
    }
}

