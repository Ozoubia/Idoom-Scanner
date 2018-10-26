using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Cards
{
    class processQR
    { 
        //vars
        Bitmap processImage;
        Bitmap tempImg;
        

        //constructor
        public processQR(Bitmap image)
        {
            this.processImage = image;
        }

        //function that apply all the preprocessing effects to the image taken by the camera
        public Bitmap applyAllEffects()
        {
            blackAndWhite();
            //SetContrast(20);
            Erotion();            
            removeNoise();
            
            return tempImg;
        }

        //method that turns the image black and white 
        public void blackAndWhite()
        {
            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(processImage);
            Image<Gray, byte> greyimg = myImage.Convert<Gray, byte>();
            tempImg = greyimg.ToBitmap();
        }

        //method that applies erotion
        public void Erotion()
        {
            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(tempImg);
            tempImg = myImage.Dilate(1).Bitmap;
        }

        //remove noise method
        public void removeNoise()
        {
            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(tempImg);
            tempImg = myImage.SmoothGaussian(3, 3, 34.3, 45.3).ToBitmap();
        }

        //method that adjusts the contrast of the image 
        public void SetContrast(double contrast)
        {

            Bitmap newimg = new Bitmap(tempImg);
            Bitmap bmap = (Bitmap)newimg.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    bmap.SetPixel(i, j,
        Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
            tempImg = (Bitmap)bmap.Clone();
        }
    }
}
