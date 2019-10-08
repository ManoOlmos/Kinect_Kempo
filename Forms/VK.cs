using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace IPN1
{
    public partial class VK : Form
    {
        Mode _mode = Mode.Color;

        KinectSensor miKinect;
        MultiSourceFrameReader _reader;
        IList<Body> _bodies;

        bool _displayBody = false;

        public VK()
        {
            InitializeComponent();

            string ruta = Application.StartupPath;
            string rutaOriginal = ruta.Substring(0, ruta.Length - 9);
            string ruta2 = rutaOriginal + @"Videos\Secuencia1.mp4";

            axWindowsMediaPlayer1.URL = ruta2;
        }

        private void VK_Load(object sender, EventArgs e)
        {
            miKinect = KinectSensor.GetDefault();
            miKinect.Open();
            _reader = miKinect.OpenMultiSourceFrameReader(FrameSourceTypes.Color);
            _reader.MultiSourceFrameArrived += Reader_MultiSourceFrameArrived;

        }

        void Reader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            var reference = e.FrameReference.AcquireFrame();

            using (var frame = reference.ColorFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    if (_mode == Mode.Color)
                    {
                        var width = frame.FrameDescription.Width;
                        var height = frame.FrameDescription.Height;
                        var data = new byte[width * height * 32 / 8];
                        frame.CopyConvertedFrameDataToArray(data, ColorImageFormat.Bgra);

                        var bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
                        var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                                            ImageLockMode.WriteOnly, bitmap.PixelFormat);

                        Marshal.Copy(data, 0, bitmapData.Scan0, data.Length);
                        bitmap.UnlockBits(bitmapData);
                        pictureBox1.Image = bitmap;
                    }
                }
            }
        }
    }

    public enum Mode
    {
        Color,
        Depth,
        Infrared
    }
}
