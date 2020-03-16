using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;

namespace kinectfun
{
    
    public partial class Form1 : Form
    {
        public static KinectSensor sensor;
        public static Skeleton skely;
        Microsoft.Kinect.Toolkit.Interaction.InteractionStream interactionStream;
        Microsoft.Kinect.Toolkit.Interaction.UserInfo[] userInfos;
        bool leftGrip = false, rightGrip = false;
        Point rectanglePoint = new Point(50, 50);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sensorStatus = new KinectSensorChooser();
            
            
            sensorStatus.KinectChanged += KinectSensorChooserKinectChanged;
            sensorStatus.Start();
        }

        private void KinectSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            ColorImageFrame colorFrame = e.OpenColorImageFrame();
            if (colorFrame == null)
            {
                return;
            }
            Bitmap bitmapFrame = ColorImageFrameToBitmap(colorFrame);
            Graphics g = Graphics.FromImage(bitmapFrame);
            Pen p = new Pen(Color.Red)
            {
                Width = 10
            };
            if (skely != null)
            {
                DrawingHelper.DrawSkeli(ref g, p, skely);
                if(leftGrip)
                {
                    var tempPoint = sensor.MapSkeletonPointToColor(skely.Joints[JointType.HandLeft].Position, ColorImageFormat.RgbResolution640x480Fps30);
                    if(Math.Abs(rectanglePoint.Y-tempPoint.Y)+Math.Abs(rectanglePoint.X-tempPoint.X)<100)
                    {
                        rectanglePoint.X = tempPoint.X; rectanglePoint.Y = tempPoint.Y;
                    }
                }
                else if (rightGrip)
                {
                    var tempPoint = sensor.MapSkeletonPointToColor(skely.Joints[JointType.HandRight].Position, ColorImageFormat.RgbResolution640x480Fps30);
                    if (Math.Abs(rectanglePoint.Y - tempPoint.Y) + Math.Abs(rectanglePoint.X - tempPoint.X) < 100)
                    {
                        rectanglePoint.X = tempPoint.X; rectanglePoint.Y = tempPoint.Y;
                    }
                }
            }
            Brush brsh = new SolidBrush(Color.Blue);
            g.FillRectangle(brsh, rectanglePoint.X - 50, rectanglePoint.Y - 50, 100, 100);
            pictureBox1.Image = bitmapFrame;
        }


        private static Bitmap ColorImageFrameToBitmap(ColorImageFrame colorFrame)
        {
            byte[] pixelBuffer = new byte[colorFrame.PixelDataLength];
            colorFrame.CopyPixelDataTo(pixelBuffer);
            Bitmap bitmapFrame = new Bitmap(colorFrame.Width, colorFrame.Height,
                PixelFormat.Format32bppRgb);
            BitmapData bitmapData = bitmapFrame.LockBits(new Rectangle(0, 0,
                                                        colorFrame.Width, colorFrame.Height),
            ImageLockMode.WriteOnly, bitmapFrame.PixelFormat);
            IntPtr intPointer = bitmapData.Scan0;
            Marshal.Copy(pixelBuffer, 0, intPointer, colorFrame.PixelDataLength);
            bitmapFrame.UnlockBits(bitmapData);
            return bitmapFrame;
        }
        private void KinectSensorChooserKinectChanged(object sender, KinectChangedEventArgs e)
        {
            if (sensor != null) sensor.SkeletonFrameReady -= KinectSkeletonFrameReady;
            sensor = e.NewSensor;
            if (sensor == null) return;
            switch (Convert.ToString(e.NewSensor.Status))
            {
                case "Connected": lbl_status.Text = "Connected"; break;
                case "Disconnected": lbl_status.Text = "Disconnected"; break;
                case "Error": lbl_status.Text = "Error"; break;
                case "NotReady": lbl_status.Text = "Not Ready"; break;
                case "NotPowered": lbl_status.Text = "Not Powered"; break;
                case "Initializing": lbl_status.Text = "Initialising"; break;
                default: lbl_status.Text = "Undefined"; break;
            }
            this.interactionStream = new Microsoft.Kinect.Toolkit.Interaction.InteractionStream(sensor, new DummyInteractionClient());
            interactionStream.InteractionFrameReady += InteractionStreamOnInteractionFrameReady;
            sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
            sensor.ColorFrameReady +=
            new EventHandler<ColorImageFrameReadyEventArgs>(KinectSensor_ColorFrameReady);
            sensor.DepthStream.Enable();
            sensor.DepthFrameReady += Sensor_DepthFrameReady;
            sensor.SkeletonStream.Enable(); sensor.SkeletonFrameReady += KinectSkeletonFrameReady;
        }
        private void Sensor_DepthFrameReady(object sender, DepthImageFrameReadyEventArgs e)
        {
                interactionStream.ProcessDepth(e.OpenDepthImageFrame().GetRawPixelData(), System.DateTime.Now.Ticks);
        }

        private void InteractionStreamOnInteractionFrameReady(object sender, Microsoft.Kinect.Toolkit.Interaction.InteractionFrameReadyEventArgs e)
        {
            using (Microsoft.Kinect.Toolkit.Interaction.InteractionFrame frame = e.OpenInteractionFrame())
            {
                if (frame != null)
                {
                    if (this.userInfos == null)
                    {
                        this.userInfos = new Microsoft.Kinect.Toolkit.Interaction.UserInfo[Microsoft.Kinect.Toolkit.Interaction.InteractionFrame.UserInfoArrayLength];
                    }

                    frame.CopyInteractionDataTo(this.userInfos);
                }
                else
                {
                    return;
                }
            }

            foreach (Microsoft.Kinect.Toolkit.Interaction.UserInfo userInfo in this.userInfos)
            {
                foreach (Microsoft.Kinect.Toolkit.Interaction.InteractionHandPointer handPointer in userInfo.HandPointers)
                {
                    string action = null;

                    switch (handPointer.HandEventType)
                    {
                        case Microsoft.Kinect.Toolkit.Interaction.InteractionHandEventType.Grip:
                            action = "gripped";
                            break;

                        case Microsoft.Kinect.Toolkit.Interaction.InteractionHandEventType.GripRelease:
                            action = "released";

                            break;
                    }

                    if (action != null)
                    {
                        string handSide = "unknown";

                        switch (handPointer.HandType)
                        {
                            case Microsoft.Kinect.Toolkit.Interaction.InteractionHandType.Left:
                                handSide = "left";
                                break;

                            case Microsoft.Kinect.Toolkit.Interaction.InteractionHandType.Right:
                                handSide = "right";
                                break;
                        }

                        if (handSide == "left")
                        {
                            leftGrip = !(action == "released");
                            lbl_leftGripping.Text = !leftGrip ? "gripping" : "released";
                        }
                        else
                        {
                            rightGrip = action == "released";
                            lbl_rightGripping.Text = !rightGrip ? "gripping" : "released";

                        }
                    }
                }
            }
        }

        private void KinectSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            var skeletons = new Skeleton[0];
            using (var skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength]; skeletonFrame.CopySkeletonDataTo(skeletons);
                }
            }
            if (skeletons.Length == 0) { return; }
            var skel = skeletons.FirstOrDefault(x => x.TrackingState == SkeletonTrackingState.Tracked);
            if (skel == null) { return; }
           
            var rightHand = skel.Joints[JointType.WristRight]; lbl_rightX.Text = rightHand.Position.X.ToString(CultureInfo.InvariantCulture); lbl_rightY.Text = rightHand.Position.Y.ToString(CultureInfo.InvariantCulture); lbl_rightZ.Text = rightHand.Position.Z.ToString(CultureInfo.InvariantCulture);
            var leftHand = skel.Joints[JointType.WristLeft]; lbl_leftX.Text = leftHand.Position.X.ToString(CultureInfo.InvariantCulture); lbl_leftY.Text = leftHand.Position.Y.ToString(CultureInfo.InvariantCulture); lbl_leftZ.Text = leftHand.Position.Z.ToString(CultureInfo.InvariantCulture);
            var centreHip = skel.Joints[JointType.HipCenter];
            skely = skel;
            if (centreHip.Position.Z - rightHand.Position.Z > 0.35)
            {
                lbl_rightRaised.Text = "Raised";
            }
            else if (centreHip.Position.Z - leftHand.Position.Z > 0.35)
            {
                lbl_leftRaised.Text = "Raised";
            }
            else
            {
                lbl_leftRaised.Text = "Lowered"; lbl_rightRaised.Text = "Lowered";
            }
            interactionStream.ProcessSkeleton(skeletons,sensor.AccelerometerGetCurrentReading(),System.DateTime.Now.Ticks);
        }
    }
}
