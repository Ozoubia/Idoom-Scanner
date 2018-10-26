using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cards
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalImage= new Bitmap(dialog.FileName);                  
            }
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            Bitmap croppedImg;
            progress.Value = 0;
            //first column
            if (BCL.Checked == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Crop filter = new Crop(new Rectangle((int)(originalImage.Width * 0.02), (int)(originalImage.Height * (0.125 + i * 0.183)), (int)(originalImage.Width * 0.15), (int)(originalImage.Height * 0.016)));
                    croppedImg = filter.Apply(originalImage);                   
                    progress.Value += 1;
                    //img process
                    ProcessBar obj = new ProcessBar(croppedImg);
                    Bitmap beforeOCRimg = obj.applyAllEffects();  
                    progress.Value += 5;
                    //ocr
                    OCR ocrObj = new OCR(beforeOCRimg);
                    progress.Value += 3;
                    Result.AppendText(ocrObj.process());
                    progress.Value += 1;

                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Crop filter = new Crop(new Rectangle((int)(originalImage.Width * 0.14), (int)(originalImage.Height * (0.125 + i * 0.183)), (int)(originalImage.Width * 0.15), (int)(originalImage.Height * 0.016)));
                    croppedImg = filter.Apply(originalImage);                   
                    progress.Value += 1;
                    processQR obj = new processQR(croppedImg);
                    Bitmap beforeOCRimg = obj.applyAllEffects();
                    progress.Value += 5;
                    OCR ocrObj = new OCR(beforeOCRimg);
                    progress.Value += 3;
                    Result.AppendText(ocrObj.process());
                    progress.Value += 1;

                }
            }

            if (BCR.Checked == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Crop filter = new Crop(new Rectangle((int)(originalImage.Width * 0.421), (int)(originalImage.Height * (0.125 + i * 0.183)), (int)(originalImage.Width * 0.15), (int)(originalImage.Height * 0.016)));
                    croppedImg = filter.Apply(originalImage);                  
                    progress.Value += 1;
                    ProcessBar obj = new ProcessBar(croppedImg);
                    Bitmap beforeOCRimg = obj.applyAllEffects();
                    progress.Value += 5;
                    OCR ocrObj = new OCR(beforeOCRimg);
                    progress.Value += 3;
                    Result.AppendText(ocrObj.process());
                    progress.Value += 1;


                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Crop filter = new Crop(new Rectangle((int)(originalImage.Width * 0.533), (int)(originalImage.Height * (0.125 + i * 0.183)), (int)(originalImage.Width * 0.15), (int)(originalImage.Height * 0.016)));
                    croppedImg = filter.Apply(originalImage);
                    progress.Value += 1;
                    processQR obj = new processQR(croppedImg);
                    Bitmap beforeOCRimg = obj.applyAllEffects();
                    progress.Value += 5;
                    OCR ocrObj = new OCR(beforeOCRimg);
                    progress.Value += 3;
                    Result.AppendText(ocrObj.process());
                    progress.Value += 1;

                }
            }


        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            progress.Value = 0;
        }
    }
}
