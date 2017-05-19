using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
//using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataExtractor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr windowHandle = FindWindowByCaption(IntPtr.Zero, " Расчёт исполнительных размеров калибров-пробок");
            SetTextt(windowHandle, "66");

            //Get a handle for the "1" button
            ClickButtonOnForm(windowHandle, "H7");

            Image img = ScreenShot.CaptureWindow(windowHandle);

            //  this.BackgroundImage = img;

            tessnet2.Tesseract ocr = new tessnet2.Tesseract();
            ocr.SetVariable("tessedit_char_whitelist", "+-.0123456789"); // If digit only
            ocr.Init(@"C:\Users\pav\Source\Repos\Gauges\TestDataExtractor\tessdata", "eng", false); // To use correct tessdata

            StringBuilder sb = new StringBuilder();
            sb.Append("Размер: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(142, 171, 52, 17)));

            sb.Append("В. откл: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(299, 61, 59, 14)));

            sb.Append("Н. откл: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(299, 77, 59, 14)));

            sb.Append("ПР: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(142, 171, 52, 17)));

            sb.Append("НЕ: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(202, 171, 52, 17)));

            sb.Append("Откл: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(266, 171, 52, 17)));

            sb.Append("Изн: ");
            sb.AppendLine(GetText(img, ocr, new Rectangle(339, 171, 52, 17)));

            textBox2.Text = sb.ToString();
        }

        private string GetText(Image img, tessnet2.Tesseract ocr, Rectangle cropRect)
        {
            Bitmap src = new Bitmap(img);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);
            }

            //    target = make_bw(target);
            target = ResizeBitmap(target, target.Width * 10, target.Height * 10);

            this.BackgroundImage = img;


            List<tessnet2.Word> result = ocr.DoOCR(target, Rectangle.Empty);
            return result[0].Text;
        }

        private static void ClickButtonOnForm(IntPtr windowHandle, string buttonName)
        {
            IntPtr btnHandle = FindWindowEx((IntPtr)windowHandle, IntPtr.Zero, "ThunderRT6CommandButton", buttonName);

            //send BN_CLICKED message
            // SendMessage((int)hwndChild, BN_CLICKED, 0, IntPtr.Zero);
            SendMessage(btnHandle, WM_LBUTTONDOWN, 0, null);
            SendMessage(btnHandle, WM_LBUTTONUP, 0, null);
        }

        private Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                g.DrawImage(sourceBMP, 0, 0, width, height);
            }
            return result;
        }

        public Bitmap make_bw(Bitmap original)
        {

            Bitmap output = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {

                for (int j = 0; j < original.Height; j++)
                {

                    Color c = original.GetPixel(i, j);

                    int average = ((c.R + c.B + c.G) / 3);

                    if (average < 200)
                        output.SetPixel(i, j, Color.Black);

                    else
                        output.SetPixel(i, j, Color.White);

                }
            }

            return output;

        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string lpszWindow);

        [DllImport("user32.dll")]
        static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int Param, string s);

        const int WM_SETTEXT = 0x000c;
        const int WM_LBUTTONDOWN = 0x201;
        const int WM_LBUTTONUP = 0x202;

        private void SetTextt(IntPtr hWnd, string text)
        {
            IntPtr boxHwnd = GetDlgItem(hWnd, 0x00000017);
            SendMessage(boxHwnd, WM_SETTEXT, 0, text);
        }

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

            textBox1.Text = e.Location.ToString();// + " " + Control.MousePosition.X + " " + Control.MousePosition.Y;
        }
    }
}
