using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace Internet_Cards
{
    class OCR
    {
        Bitmap toProcessImg;
        public OCR(Bitmap processImage)
        {
            this.toProcessImg = processImage;
        }

        public string process()
        {
            var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            ocr.SetVariable("tessedit_char_whitelist", "0123456789");
            //ocr.Init("./tessdata", "eng",false);
            var page = ocr.Process(toProcessImg);
            return page.GetText();
        }
    }
}
