using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using NPOI.HWPF;
using NPOI.XWPF.UserModel;
using NPOI.HWPF.UserModel; // Для работы с NPOI  
using Word = Microsoft.Office.Interop.Word; // Псевдоним для упрощения доступа 
namespace testaccess
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            // Отображение диалогового окна и проверка результата  
            try
                {
                    // Загрузка выбранного видео в Windows Media Player  
                    axWindowsMediaPlayer1.URL = treeViewVideo.SelectedNode.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(filePath);

                // Чтение текста из документа  
                string text = doc.Content.Text;

                richTextBox1.Text = text;// Отображаем текст в richTextBox1
                // или вы можете вывести в TextBox или другой элемент управления  

                // Закрытие документа  
                doc.Close();
                wordApp.Quit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// то что выше этот код не используется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVideoDirectory_Click(object sender, EventArgs e)
        {
            // Устанавливаем выбранный путь в диалоговом окне для выбора папки  
            folderBrowserDialog_Video.SelectedPath = videoDirectoryPath.Text;

            // Показываем диалог выбора папки и сохраняем результат  
            DialogResult drvResult = folderBrowserDialog_Video.ShowDialog();

            // Если пользователь нажал "ОК"  
            if (drvResult == System.Windows.Forms.DialogResult.OK)
                // Обновляем текстовое поле с путем к выбранной директории  
                videoDirectoryPath.Text = folderBrowserDialog_Video.SelectedPath;
        }

        private void buttonLoadVidDir_Click(object sender, EventArgs e)
        {
            // Устанавливаем начальное значение для полосы прогресса  
            progressBarVideo.Value = 0;

            // Очищаем все узлы в TreeView, если они уже существуют  
            treeViewVideo.Nodes.Clear();

            // Настраиваем отображение всплывающих подсказок  
            toolTipVideo.ShowAlways = true;

            // Проверяем, выбрана ли директория и существует ли она  
            if (!string.IsNullOrEmpty(videoDirectoryPath.Text) && Directory.Exists(videoDirectoryPath.Text))
                LoadDirectoryVid(videoDirectoryPath.Text); // Загружаем видео из выбранной директории  
            else
                // Выводим сообщение об ошибке, если директория не выбрана  
                MessageBox.Show("Директория не выбрана или она не существует");
        }

        public void LoadDirectoryVid(string DirV)
        {
            // Создаем экземпляр DirectoryInfo для выбранной директории  
            DirectoryInfo diV = new DirectoryInfo(DirV);

            // Устанавливаем максимальное значение для полосы прогресса  
            progressBarVideo.Maximum = Directory.GetFiles(DirV, "*.*", SearchOption.AllDirectories).Length +
                                       Directory.GetDirectories(DirV, "**", SearchOption.AllDirectories).Length;

            // Добавляем корневой узел для директории в TreeView  
            TreeNode tdsV = treeViewVideo.Nodes.Add(diV.Name);
            tdsV.Tag = diV.FullName; // Сохраняем полный путь в свойство Tag  
            tdsV.StateImageIndex = 0; // Устанавливаем индекс изображения состояния для самого узла  
            LoadFilesVideo(DirV, tdsV); // Загружаем файлы из директории  
            LoadSubDirectoriesVideo(DirV, tdsV); // Загружаем подпапки  
        }

        private void LoadSubDirectoriesVideo(string dirV, TreeNode tdV)
        {
            // Получаем все подпапки в выбранной директории  
            string[] subdirectoryEntries = Directory.GetDirectories(dirV);

            // Проходим по всем подпапкам  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo diV = new DirectoryInfo(subdirectory); // Создаем DirectoryInfo для подпапки  
                TreeNode tdsV = tdV.Nodes.Add(diV.Name); // Добавляем узел папки  
                tdsV.StateImageIndex = 0; // Устанавливаем индекс изображения состояния для узла  
                tdsV.Tag = diV.FullName; // Сохраняем полный путь в свойство Tag  
                LoadFilesVideo(subdirectory, tdsV); // Загружаем файлы из подпапки  
                LoadSubDirectoriesVideo(subdirectory, tdsV); // Рекурсивно загружаем подпапки  
                UpdateProgressVideo(); // Обновляем прогресс  
            }
        }

        private void LoadFilesVideo(string dirV, TreeNode tdV)
        {
            // Получаем все файлы в директории  
            string[] Files = Directory.GetFiles(dirV, "*.*");

            // Проходим по каждому файлу  
            foreach (string file in Files)
            {
                FileInfo fiV = new FileInfo(file); // Создаем FileInfo для файла  
                TreeNode tdsV = tdV.Nodes.Add(fiV.Name); // Добавляем узел для файла  
                tdsV.Tag = fiV.FullName; // Сохраняем полный путь в свойство Tag  
                tdsV.StateImageIndex = 1; // Устанавливаем индекс изображения состояния для файла  
                UpdateProgressVideo(); // Обновляем прогресс  
            }
        }

        private void UpdateProgressVideo()
        {
            // Проверяем, не достигнуто ли максимальное значение полосы прогресса  
            if (progressBarVideo.Value < progressBarVideo.Maximum)
            {
                progressBarVideo.Value++; // Увеличиваем значение полосы прогресса  

                // Вычисляем процент выполнения  
                int percent = (int)(((double)progressBarVideo.Value / (double)progressBarVideo.Maximum) * 100);

                // Отображаем текстовое представление процента на полосе прогресса  
                progressBarVideo.CreateGraphics().DrawString(percent.ToString() + "%",
                    new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular),
                    Brushes.Black,
                    new PointF(progressBarVideo.Width / 2 - 10, progressBarVideo.Height / 2 - 7));

                System.Windows.Forms.Application.DoEvents(); // Обновляем интерфейс  
            }
        }

        private void treeViewVideo_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли узел в TreeView  
            if (treeViewVideo.SelectedNode != null)
            {
                try
                {
                    // Получаем полный путь к файлу из свойства Tag выбранного узла  
                    string filePath = treeViewVideo.SelectedNode.Tag.ToString();

                    // Проверяем, существует ли файл перед его воспроизведением  
                    if (File.Exists(filePath))
                    {
                        // Загружаем выбранное видео в элемент управления Windows Media Player  
                        axWindowsMediaPlayer1.URL = filePath;
                    }
                    else
                    {
                        // Выводим сообщение об ошибке, если файл не существует  
                        MessageBox.Show("Файл не существует.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при попытке воспроизведения файла  
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
                }
            }
        }
        private void buttonTextDirectory_Click(object sender, EventArgs e)
        {
            // Устанавливаем путь в диалоговом окне выбора папки на основе текста из текстового поля  
            folderBrowserDialog_Text.SelectedPath = txtDirectoryPath.Text;

            // Показываем диалог выбора папки и сохраняем результат  
            DialogResult drtResult = folderBrowserDialog_Text.ShowDialog();

            // Если пользователь нажал "ОК", обновляем текстовое поле с выбранным путем директории  
            if (drtResult == System.Windows.Forms.DialogResult.OK)
                txtDirectoryPath.Text = folderBrowserDialog_Text.SelectedPath;
        }

        public void LoadDirectoryText(string DirT)
        {
            // Создаем объект DirectoryInfo для указанной директории  
            DirectoryInfo diT = new DirectoryInfo(DirT);

            // Устанавливаем максимальное значение для полосы прогресса  
            progressBarText.Maximum = Directory.GetFiles(DirT, "*.*", SearchOption.AllDirectories).Length +
                                      Directory.GetDirectories(DirT, "**", SearchOption.AllDirectories).Length;

            // Добавляем корневой узел к TreeView для директории  
            TreeNode tdsT = treeViewText.Nodes.Add(diT.Name);
            tdsT.Tag = diT.FullName; // Сохраняем полный путь в свойство Tag  
            tdsT.StateImageIndex = 0; // Устанавливаем индекс изображения состояния для узла  
            LoadFilesText(DirT, tdsT); // Загружаем файлы из директории  
            LoadSubDirectoriesText(DirT, tdsT); // Загружаем подпапки из директории  
        }

        private void LoadSubDirectoriesText(string dirT, TreeNode tdT)
        {
            // Получаем все подпапки в указанной директории  
            string[] subdirectoryEntries = Directory.GetDirectories(dirT);

            // Проходим по каждой подпапке  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo diT = new DirectoryInfo(subdirectory); // Создаем DirectoryInfo для подпапки  
                TreeNode tdsT = tdT.Nodes.Add(diT.Name); // Добавляем узел для подпапки  
                tdsT.StateImageIndex = 0; // Устанавливаем индекс изображения состояния для узла  
                tdsT.Tag = diT.FullName; // Сохраняем полный путь в свойство Tag  
                LoadFilesText(subdirectory, tdsT); // Загружаем файлы из подпапки  
                LoadSubDirectoriesText(subdirectory, tdsT); // Рекурсивно загружаем подпапки  
                UpdateProgressText(); // Обновляем прогресс  
            }
        }

        private void LoadFilesText(string dirT, TreeNode tdT)
        {
            // Получаем все файлы в указанной директории  
            string[] Files = Directory.GetFiles(dirT, "*.*");

            // Проходим по каждому файлу  
            foreach (string file in Files)
            {
                FileInfo fiT = new FileInfo(file); // Создаем FileInfo для файла  
                TreeNode tdsT = tdT.Nodes.Add(fiT.Name); // Добавляем узел для файла  
                tdsT.Tag = fiT.FullName; // Сохраняем полный путь в свойство Tag  
                tdsT.StateImageIndex = 1; // Устанавливаем индекс изображения состояния для файла  
                UpdateProgressText(); // Обновляем прогресс  
            }
        }

        private void UpdateProgressText()
        {
            // Проверяем, не достигнуто ли максимальное значение полосы прогресса  
            if (progressBarText.Value < progressBarText.Maximum)
            {
                progressBarText.Value++; // Увеличиваем значение полосы прогресса  

                // Вычисляем процент выполнения  
                int percent = (int)(((double)progressBarText.Value / (double)progressBarText.Maximum) * 100);

                // Отображаем процент выполнения на полосе прогресса  
                progressBarText.CreateGraphics().DrawString(percent.ToString() + "%",
                    new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular),
                    Brushes.Black,
                    new PointF(progressBarText.Width / 2 - 10, progressBarText.Height / 2 - 7));

                System.Windows.Forms.Application.DoEvents(); // Обновляем интерфейс  
            }
        }

        private void treeViewText_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли узел в TreeView  
            if (treeViewText.SelectedNode != null)
            {
                try
                {
                    // Получаем полный путь к файлу из свойства Tag выбранного узла  
                    string filePath = treeViewText.SelectedNode.Tag.ToString();

                    // Проверяем, существует ли файл  
                    if (File.Exists(filePath))
                    {
                        string text = string.Empty; // Переменная для хранения текста из файла  

                        // Если файл DOCX  
                        if (filePath.EndsWith(".docx", StringComparison.OrdinalIgnoreCase))
                        {
                            // Открываем файл и считываем текст  
                            using (var docxFile = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                            {
                                XWPFDocument document = new XWPFDocument(docxFile);
                                foreach (var paragraph in document.Paragraphs)
                                {
                                    text += paragraph.ParagraphText + Environment.NewLine; // Добавляем текст параграфа  
                                }
                            }
                        }
                        // Если файл DOC  
                        else if (filePath.EndsWith(".doc", StringComparison.OrdinalIgnoreCase))
                        {
                            // Открываем файл и считываем текст  
                            using (var docFile = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                            {
                                HWPFDocument namedoc = new HWPFDocument(docFile);
                                HWPFDocument document = new HWPFDocument(docFile);
                                NPOI.HWPF.UserModel.Range range = document.GetRange(); // Получаем диапазон документа  

                                // Проходим по всем параграфам и добавляем текст  
                                for (int i = 0; i < range.NumParagraphs; i++)
                                {
                                    NPOI.HWPF.UserModel.Paragraph paragraph = range.GetParagraph(i);
                                    text += paragraph.Text + Environment.NewLine; // Добавляем текст параграфа  
                                }
                            }
                        }

                        // Отображаем собранный текст в элементе richTextBox  
                        richTextBox1.Clear(); // Очищаем предыдущий текст  
                        richTextBox1.Text = text; // Заполняем richTextBox новым текстом  
                    }
                    else
                    {
                        // Если файл не существует, показываем сообщение об ошибке  
                        MessageBox.Show("Файл не существует.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при попытке чтения файла  
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
                }
            }
        }

        private void buttonLoadText_Click(object sender, EventArgs e)
        {
            // Устанавливаем начальное значение для полосы прогресса  
            progressBarText.Value = 0;

            // Очищаем все узлы в TreeView  
            treeViewText.Nodes.Clear();
            toolTipText.ShowAlways = true;

            // Проверяем, выбрана ли директория и существует ли она  
            if (!string.IsNullOrEmpty(txtDirectoryPath.Text) && Directory.Exists(txtDirectoryPath.Text))
                LoadDirectoryText(txtDirectoryPath.Text); // Загружаем директорию  
            else
                // Выводим сообщение об ошибке, если директория не выбрана  
                MessageBox.Show("Директория не выбрана или она не существует");
        }
    }
}
