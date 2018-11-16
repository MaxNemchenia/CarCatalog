using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWF.Interfaces;
using TestWF.Models;


namespace TestWF
{
    public partial class AddForm : Form
    {
        #region Variables
        bool isSaveImage = false;
        bool isModelValid = true;
        Car editedCar;
        ICarService carService;
        bool isChanged;
        #endregion

        #region FormEvents
        public AddForm(ICarService carService, Car editedCar, bool isChanged)
        {
            MaximizeBox = false;
            this.carService = carService;
            this.editedCar = editedCar;
            this.isChanged = isChanged;
            InitializeComponent();
        }


        private void AddForm_Load(object sender, EventArgs e)
        {
            if (isChanged)
            {
                comboBoxProducer.Text = editedCar.Mark.Producer.ProducerName;
                comboBoxMark.Text = editedCar.Mark.MarkName;
                comboBoxMark.Enabled = false;
                comboBoxProducer.Enabled = false;
                numericUpDownCost.Value = editedCar.Cost;
                textBoxColor.Text = editedCar.Color;
                numericUpDownDate.Value = editedCar.Date;
                numericUpDownMileage.Value = editedCar.Mileage;
                if (editedCar.Image != null)
                {
                    pictureBox1.Image = ByteToImage(editedCar.Image);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                }
            }

            foreach (var producer in carService.GetProducers())
            {
                comboBoxProducer.Items.Add(new Item() { Name = producer.ProducerName, Value = producer.ProducerId });
            }

            comboBoxMark.Items.Clear();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            Car car = createAddedModelCar();
            if (!isModelValid)
            {
                MessageBox.Show("All fields are required");
                isModelValid = true;
            }
            else
            {
                if (!isChanged)
                {
                    carService.AddCar(car);
                }
                else
                {
                    carService.EditCar(car);
                }
                this.Close();
            }
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            LoadPicture();
        }


        private void comboBoxProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producer = comboBoxProducer.SelectedItem.ToString();
            Producer prod = carService.GetProducers().Where(p => p.ProducerName == producer).Single();
            var selectionMark = carService.GetMarks().Where(m => m.Producer.ProducerId == prod.ProducerId).ToList();
            comboBoxMark.Items.Clear();
            comboBoxMark.Text = "";
            foreach (var mark in selectionMark)
            {
                comboBoxMark.Items.Add(new Item() { Name = mark.MarkName, Value = mark.MarkId });
            }
        }
        #endregion

        #region Methods
        Car createAddedModelCar()
        {
            Car car = new Car();
            if (!isChanged)
            {
                int markId = comboBoxMark.SelectedItem is Item item ? item.Value : 0;
                car.MarkId = markId;
                isModelValid = !(markId == 0);
            }
            else
            {
                car.Id = editedCar.Id;
                car.MarkId = editedCar.MarkId;
                car.Image = editedCar.Image;
            }

            if (textBoxColor.Text != "")
            {
                car.Color = textBoxColor.Text;
            }
            else
            {
                isModelValid = false;
            }
            car.Cost = (int)numericUpDownCost.Value;
            car.Date = (int)numericUpDownDate.Value;
            car.Mileage = (int)numericUpDownMileage.Value;
            if (isSaveImage)
                savePicture(car);
            return car;
        }


        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        private void LoadPicture()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                }

                isSaveImage = true;
            }
            catch { }
        }


        private void savePicture(Car car)
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                car.Image = a;
            }
        }
        #endregion

        #region Nested classes
        private class Item
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
        #endregion
    }
}
