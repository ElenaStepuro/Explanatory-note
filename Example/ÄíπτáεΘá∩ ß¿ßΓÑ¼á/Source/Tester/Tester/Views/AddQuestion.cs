using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ShoolTester
{
    /// <summary>
    /// Форма добавления вопроса
    /// </summary>
    public partial class AddQuestion : Form
    {
        public byte[] Image { get; set; }
        public byte[] ImageQuestion { get; set; }
        public String QuestionName { get; set; }

        public AddQuestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытие картинки которая 
        /// служит пояснениями
        /// </summary>
        /// 
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "изображения | *.jpg;*.jpeg;*.png;*.bmp";
            var result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Image = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Image, 0, Image.Length);
            }
        }

        /// <summary>
        /// Добавление вопроса
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            if (this.ImageQuestion == null)
                ImageQuestion = new byte[0];
            if (this.Image == null)
            {
                var im = System.Drawing.Image.FromFile(Environment.CurrentDirectory + @"\Images\img.jpg");
                MemoryStream ms = new MemoryStream();
                im.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Image = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Image, 0, Image.Length);
            }
            QuestionName = textBox1.Text;
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "изображения | *.jpg;*.jpeg;*.png;*.bmp";
            var result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox2.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImageQuestion = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(ImageQuestion, 0, ImageQuestion.Length);
                if (pictureBox2.Image == null)
                    ImageQuestion = new byte[0];

            }
        }
    }
}
