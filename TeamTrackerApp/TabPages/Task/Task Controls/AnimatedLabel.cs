﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.Task.Task_Controls
{
    class AnimatedLabel: Label
    {
        public AnimatedLabel()
        {
            inTimer = new Timer();
            outTimer = new Timer();
            inTimer.Interval = outTimer.Interval = 1;
            inTimer.Tick += InTick;
            outTimer.Tick += OutTick;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            leftPt = rightPt = new Point(Width, 0);
            isInComplete = false;
            inTimer.Start();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            outTimer.Start();
        }

        private void InTick(object sender, EventArgs e)
        {
            leftPt.X = leftPt.X - 1;
            rightPt.Y = rightPt.Y + 1;

            if(rightPt.Y >= (Height / 4))
            {
                isInComplete = true;
                inTimer.Stop();
            }
            this.Invalidate();
        }

        private void OutTick(object sender, EventArgs e)
        {
            if (isInComplete)
            {
                leftPt.X = leftPt.X + 1;
                rightPt.Y = rightPt.Y - 1;

                if (rightPt.Y == 0)
                {
                    outTimer.Stop();
                }
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush1 = new SolidBrush(Color.White);
            int R, G, B;
            R = BackColor.R - 20 >= 0 ? BackColor.R - 20 : 0;
            G = BackColor.G - 20 >= 0 ? BackColor.G - 20 : 0;
            B = BackColor.B - 20 >= 0 ? BackColor.B - 20 : 0;
            Brush brush2 = new SolidBrush(Color.FromArgb(R, G, B));
            e.Graphics.FillPolygon(brush1, new Point[] { leftPt, rightPt, new Point(Width, 0) });
            e.Graphics.FillPolygon(brush2, new Point[] { leftPt, rightPt, new Point(leftPt.X, rightPt.Y) });
            brush1.Dispose();
            brush2.Dispose();
            base.OnPaint(e);
        }

        private Timer inTimer, outTimer;
        private bool isInComplete;
        private Point leftPt, rightPt;
    }
}
