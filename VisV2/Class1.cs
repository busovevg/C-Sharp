﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace VisV2
{
    public static class MoveCtrl
    {
        static List<ScrollEngine> Scrlrs = new List<ScrollEngine>();
        static public void EnableMove(Control c)
        {
            var scrollEngine = new ScrollEngine(c);
            Scrlrs.Add(scrollEngine);
        }

        static void scrollEngine_Scroll(object sender, MoveCtrl.ScrollEngine.ScrollEventArgs e)
        {

        }
        public class ScrollEngine
        {
            public static bool DefaultScrollCondition()
            {
                return Form.MouseButtons.HasFlag(MouseButtons.Left);
            }

            private Control scrollableControl;
            private Point positionBeforeMove;

            public ScrollEngine(Control scrollableControl)
            {
                ScrollCondition = DefaultScrollCondition;
                ScrollableControl = scrollableControl;
                this.Scroll += ScrollEngine_Scroll;
            }

            void ScrollEngine_Scroll(object sender, ScrollEngine.ScrollEventArgs e)
            {
                scrollableControl.Location += e.Offset;
            }

            public Control ScrollableControl
            {
                get
                {
                    return scrollableControl;
                }
                set
                {
                    Disconnect();
                    scrollableControl = value;
                    Connect();
                }
            }

            public Func<bool> ScrollCondition { get; set; }

            private void Connect()
            {
                if (scrollableControl != null)
                {
                    scrollableControl.MouseMove += ScrollableControl_MouseMove;
                }
            }

            private void Disconnect()
            {
                if (scrollableControl != null)
                {
                    scrollableControl.MouseMove -= ScrollableControl_MouseMove;
                }
            }

            private void ScrollableControl_MouseMove(object sender, MouseEventArgs e)
            {
                if (ScrollCondition())
                {
                    Size offset = new Size(Cursor.Position.X - positionBeforeMove.X, Cursor.Position.Y - positionBeforeMove.Y);
                    OnScroll(new ScrollEventArgs(offset));
                }
                positionBeforeMove = Cursor.Position;
            }

            protected virtual void OnScroll(ScrollEventArgs e)
            {
                if (Scroll != null)
                {
                    Scroll(this, e);
                }
            }

            public event EventHandler<ScrollEventArgs> Scroll;

            public class ScrollEventArgs : EventArgs
            {
                public ScrollEventArgs(Size offset)
                {
                    Offset = offset;
                }

                public Size Offset { get; private set; }
            }
        }
    }
}
