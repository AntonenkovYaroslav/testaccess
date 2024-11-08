namespace testaccess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.treeViewVideo = new System.Windows.Forms.TreeView();
            this.treeViewText = new System.Windows.Forms.TreeView();
            this.videoDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonVideoDirectory = new System.Windows.Forms.Button();
            this.buttonTextDirectory = new System.Windows.Forms.Button();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog_Video = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_Text = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTipVideo = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarVideo = new System.Windows.Forms.ProgressBar();
            this.progressBarText = new System.Windows.Forms.ProgressBar();
            this.buttonLoadVidDir = new System.Windows.Forms.Button();
            this.buttonLoadText = new System.Windows.Forms.Button();
            this.toolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 826);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "открыть видео";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 826);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "выбрать текст сюжета";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(703, 421);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(17, 399);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 421);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(756, 399);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 421);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 826);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "очистить форму";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1283, 826);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "отправить на сервер";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // treeViewVideo
            // 
            this.treeViewVideo.Location = new System.Drawing.Point(17, 47);
            this.treeViewVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewVideo.Name = "treeViewVideo";
            this.treeViewVideo.Size = new System.Drawing.Size(732, 323);
            this.treeViewVideo.TabIndex = 9;
            this.treeViewVideo.Click += new System.EventHandler(this.treeViewVideo_Click);
            // 
            // treeViewText
            // 
            this.treeViewText.Location = new System.Drawing.Point(759, 47);
            this.treeViewText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewText.Name = "treeViewText";
            this.treeViewText.Size = new System.Drawing.Size(699, 323);
            this.treeViewText.TabIndex = 10;
           // this.treeViewText.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewText_AfterSelect);
            this.treeViewText.Click += new System.EventHandler(this.treeViewText_Click);
            // 
            // videoDirectoryPath
            // 
            this.videoDirectoryPath.Location = new System.Drawing.Point(17, 15);
            this.videoDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoDirectoryPath.Name = "videoDirectoryPath";
            this.videoDirectoryPath.Size = new System.Drawing.Size(352, 22);
            this.videoDirectoryPath.TabIndex = 11;
            // 
            // buttonVideoDirectory
            // 
            this.buttonVideoDirectory.Location = new System.Drawing.Point(379, 15);
            this.buttonVideoDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVideoDirectory.Name = "buttonVideoDirectory";
            this.buttonVideoDirectory.Size = new System.Drawing.Size(187, 25);
            this.buttonVideoDirectory.TabIndex = 12;
            this.buttonVideoDirectory.Text = "Открыть папку";
            this.buttonVideoDirectory.UseVisualStyleBackColor = true;
            this.buttonVideoDirectory.Click += new System.EventHandler(this.buttonVideoDirectory_Click);
            // 
            // buttonTextDirectory
            // 
            this.buttonTextDirectory.Location = new System.Drawing.Point(1137, 14);
            this.buttonTextDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTextDirectory.Name = "buttonTextDirectory";
            this.buttonTextDirectory.Size = new System.Drawing.Size(151, 25);
            this.buttonTextDirectory.TabIndex = 14;
            this.buttonTextDirectory.Text = "Открыть папку";
            this.buttonTextDirectory.UseVisualStyleBackColor = true;
            this.buttonTextDirectory.Click += new System.EventHandler(this.buttonTextDirectory_Click);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(759, 15);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(369, 22);
            this.txtDirectoryPath.TabIndex = 13;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // progressBarVideo
            // 
            this.progressBarVideo.Location = new System.Drawing.Point(17, 378);
            this.progressBarVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarVideo.Name = "progressBarVideo";
            this.progressBarVideo.Size = new System.Drawing.Size(733, 15);
            this.progressBarVideo.TabIndex = 15;
            // 
            // progressBarText
            // 
            this.progressBarText.Location = new System.Drawing.Point(759, 378);
            this.progressBarText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarText.Name = "progressBarText";
            this.progressBarText.Size = new System.Drawing.Size(700, 15);
            this.progressBarText.TabIndex = 16;
            // 
            // buttonLoadVidDir
            // 
            this.buttonLoadVidDir.Location = new System.Drawing.Point(573, 15);
            this.buttonLoadVidDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadVidDir.Name = "buttonLoadVidDir";
            this.buttonLoadVidDir.Size = new System.Drawing.Size(177, 25);
            this.buttonLoadVidDir.TabIndex = 17;
            this.buttonLoadVidDir.Text = "Загрузит папку";
            this.buttonLoadVidDir.UseVisualStyleBackColor = true;
            this.buttonLoadVidDir.Click += new System.EventHandler(this.buttonLoadVidDir_Click);
            // 
            // buttonLoadText
            // 
            this.buttonLoadText.Location = new System.Drawing.Point(1296, 14);
            this.buttonLoadText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadText.Name = "buttonLoadText";
            this.buttonLoadText.Size = new System.Drawing.Size(163, 25);
            this.buttonLoadText.TabIndex = 18;
            this.buttonLoadText.Text = "Загрузит папку";
            this.buttonLoadText.UseVisualStyleBackColor = true;
            this.buttonLoadText.Click += new System.EventHandler(this.buttonLoadText_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(733, 421);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1469, 908);
            this.Controls.Add(this.buttonLoadText);
            this.Controls.Add(this.buttonLoadVidDir);
            this.Controls.Add(this.progressBarText);
            this.Controls.Add(this.progressBarVideo);
            this.Controls.Add(this.buttonTextDirectory);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.buttonVideoDirectory);
            this.Controls.Add(this.videoDirectoryPath);
            this.Controls.Add(this.treeViewText);
            this.Controls.Add(this.treeViewVideo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TreeView treeViewVideo;
        private System.Windows.Forms.TreeView treeViewText;
        private System.Windows.Forms.TextBox videoDirectoryPath;
        private System.Windows.Forms.Button buttonVideoDirectory;
        private System.Windows.Forms.Button buttonTextDirectory;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Video;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Text;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTipVideo;
        private System.Windows.Forms.ProgressBar progressBarVideo;
        private System.Windows.Forms.ProgressBar progressBarText;
        private System.Windows.Forms.Button buttonLoadVidDir;
        private System.Windows.Forms.Button buttonLoadText;
        private System.Windows.Forms.ToolTip toolTipText;
    }
}

