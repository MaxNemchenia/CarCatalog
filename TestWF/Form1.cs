using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using TestWF.Models;
using TestWF.Interfaces;
using System.IO;

namespace TestWF
{
    public partial class Form1 : Form
    {
        #region Variables
        ICarService carService;
        ICollection<Car> currentCarCollection;
        #endregion

        #region FormEvents
        public Form1(ICarService carService)
        {
            MaximizeBox = false;
            this.carService = carService;
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            currentCarCollection = carService.GetCars();
            carsDataGridView1.RowTemplate.Height = 100;
            dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
            comboBoxProducer.Items.Add(new Item() { Name = "Without Filter", Value = 0 });
            foreach (var producer in carService.GetProducers())
            {
                comboBoxProducer.Items.Add(new Item() { Name = producer.ProducerName, Value = producer.ProducerId });
            }

            comboBoxMark.Items.Clear();
        }


        private void carsDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == carsDataGridView1.Columns["Edit"]?.Index && e.RowIndex >= 0)
            {
                var idObj = carsDataGridView1.Rows[e.RowIndex].Tag;
                int id;
                int.TryParse(idObj.ToString(), out id);
                Car car = carService.GetCarById(id);
                if (car != null)
                {
                    AddForm addForm = new AddForm(carService, car, true);
                    addForm.FormClosed += new FormClosedEventHandler(addFormClosedEvent);
                    addForm.ShowDialog();
                }
            }
            if (e.ColumnIndex == carsDataGridView1.Columns["Delete"]?.Index && e.RowIndex >= 0)
            {
                var idObj = carsDataGridView1.Rows[e.RowIndex].Tag;
                int id;
                int.TryParse(idObj.ToString(), out id);
                carService.DeleteCar(id);
                currentCarCollection = carService.GetCars();
                dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
            }
        }


        private void dataDisplayCarOnDataGridView(DataGridView dataGridView, dynamic obj)
        {
            int i = 0;
            dataGridView.Rows.Clear();
            foreach (var car in obj)
            {
                PictureBox pictureBox = new PictureBox();
                if (car.Image != null)
                {
                    pictureBox.Image = ByteToImage(car.Image);
                }

                var addedRow = new object[] { new ItemTag() { Name = "Edit", Tag = car.Id }, new ItemTag() { Name = "Delete", Tag = car.Id }, car.Mark.Producer.ProducerName.ToString(), car.Mark.MarkName.ToString(), car.Cost.ToString(), car.Color.ToString(), car.Date.ToString(), car.Mileage.ToString(), ResizeImage(100, pictureBox.Image) };
                dataGridView.Rows.Add(addedRow);
                dataGridView.Rows[i++].Tag = car.Id;
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            carsDataGridView1.Sort(carsDataGridView1.Columns["Cost"], ListSortDirection.Ascending);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            carsDataGridView1.Sort(carsDataGridView1.Columns["Cost"], ListSortDirection.Descending);
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(carService, null, false);
            addForm.FormClosed += new FormClosedEventHandler(addFormClosedEvent);
            addForm.ShowDialog();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            Car car = carService.GetCarById(1);
            if (car != null)
            {
                AddForm addForm = new AddForm(carService, car, true);
                addForm.FormClosed += new FormClosedEventHandler(addFormClosedEvent);
                addForm.ShowDialog();
            }
        }


        private void comboBoxProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMark.Items.Clear();
            comboBoxMark.Text = "WithoutFilter";
            comboBoxMark.Items.Add(new Item() { Name = "Without Filter", Value = 0 });
            if (((Item)comboBoxProducer.SelectedItem).Value != 0)
            {
                currentCarCollection = carService.GetCarsByProducer(((Item)comboBoxProducer.SelectedItem).Value);
                dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection );
                Producer prod = carService.GetProducers().SingleOrDefault(p => p.ProducerId == ((Item)comboBoxProducer.SelectedItem).Value);
                var selectionMark = carService.GetMarks().Where(m => m.Producer.ProducerId == prod.ProducerId).ToList();
                foreach (var mark in selectionMark)
                {
                    comboBoxMark.Items.Add(new Item() { Name = mark.MarkName, Value = mark.MarkId });
                }
            }
            else
            {
                currentCarCollection = carService.GetCars();
                dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
            }
        }


        private void comboBoxMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Item)comboBoxMark.SelectedItem).Value != 0)
            {
                currentCarCollection = carService.GetCarsByMark(((Item)comboBoxMark.SelectedItem).Value);
                dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
            }
            else
            {
                dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
            }
        }


        void addFormClosedEvent(object sender, FormClosedEventArgs e)
        {
            currentCarCollection = carService.GetCars();
            dataDisplayCarOnDataGridView(carsDataGridView1, currentCarCollection);
        }
        #endregion

        #region Methods
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        private static Image ResizeImage(int newSize, Image originalImage)
        {
            if (originalImage != null)
            {
                if (originalImage.Width <= newSize)
                    newSize = originalImage.Width;

                var newHeight = 100;
                if (newHeight > newSize)
                {
                    newSize = originalImage.Width * newSize / originalImage.Height;
                    newHeight = newSize;
                }

                return originalImage.GetThumbnailImage(newSize, newHeight, null, IntPtr.Zero);
            }
            else
            {
                return originalImage;
            }
        }
        #endregion

        #region Nested classes
        private class ItemTag
        {
            public string Name { get; set; }
            public int Tag { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

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
