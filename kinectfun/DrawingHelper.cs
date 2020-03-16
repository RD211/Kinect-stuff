using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinectfun
{
    public class DrawingHelper
    {
        public static void DrawLineBetweenJoints(ref Graphics g, Pen p, JointType a, JointType b)
        {
            var aPos = Form1.sensor.MapSkeletonPointToColor(Form1.skely.Joints[a].Position, ColorImageFormat.RgbResolution640x480Fps30);
            var bPos = Form1.sensor.MapSkeletonPointToColor(Form1.skely.Joints[b].Position, ColorImageFormat.RgbResolution640x480Fps30);

            g.DrawLine(p, aPos.X, aPos.Y, bPos.X, bPos.Y);
        }
        public static void DrawSkeli(ref Graphics g, Pen p, Skeleton skely)
        {
            DrawLineBetweenJoints(ref g, p, JointType.HandRight, JointType.WristRight);
            DrawLineBetweenJoints(ref g, p, JointType.ElbowRight, JointType.WristRight);
            DrawLineBetweenJoints(ref g, p, JointType.ElbowRight, JointType.ShoulderRight);
            DrawLineBetweenJoints(ref g, p, JointType.ShoulderCenter, JointType.ShoulderRight);
            DrawLineBetweenJoints(ref g, p, JointType.ShoulderCenter, JointType.Head);
            DrawLineBetweenJoints(ref g, p, JointType.ShoulderCenter, JointType.ShoulderLeft);
            DrawLineBetweenJoints(ref g, p, JointType.ElbowLeft, JointType.ShoulderLeft);
            DrawLineBetweenJoints(ref g, p, JointType.ElbowLeft, JointType.WristLeft);
            DrawLineBetweenJoints(ref g, p, JointType.HandLeft, JointType.WristLeft);
            DrawLineBetweenJoints(ref g, p, JointType.ShoulderCenter, JointType.Spine);
            DrawLineBetweenJoints(ref g, p, JointType.HipCenter, JointType.Spine);
            DrawLineBetweenJoints(ref g, p, JointType.HipCenter, JointType.HipLeft);
            DrawLineBetweenJoints(ref g, p, JointType.HipCenter, JointType.HipRight);
            DrawLineBetweenJoints(ref g, p, JointType.KneeRight, JointType.HipRight);
            DrawLineBetweenJoints(ref g, p, JointType.KneeRight, JointType.AnkleRight);
            DrawLineBetweenJoints(ref g, p, JointType.FootRight, JointType.AnkleRight);
            DrawLineBetweenJoints(ref g, p, JointType.KneeLeft, JointType.HipLeft);
            DrawLineBetweenJoints(ref g, p, JointType.KneeLeft, JointType.AnkleLeft);
            DrawLineBetweenJoints(ref g, p, JointType.FootLeft, JointType.AnkleLeft);
        }
    }
}
