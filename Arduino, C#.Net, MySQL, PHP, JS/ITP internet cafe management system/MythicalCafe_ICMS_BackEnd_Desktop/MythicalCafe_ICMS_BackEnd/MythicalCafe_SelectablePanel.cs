using System;
using System.Drawing;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    class MythicalCafe_SelectablePanel : TableLayoutPanel
    {
        public MythicalCafe_SelectablePanel()
        {
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;

            this.Paint += delegate (Object set_Object, PaintEventArgs set_PaintEventArgs)
            {
                pnl_Gender_Paint(get_Color_Border_Idle, set_Object, set_PaintEventArgs);
            };

            AddNestedMouseHandler(this, NestedControl_Mousemove);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Focus();
            base.OnMouseDown(e);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down) return true;
            if (keyData == Keys.Left || keyData == Keys.Right) return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnEnter(EventArgs e)
        {
            this.Invalidate();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Focused)
                return;

            if (get_Color_Border_Current != Color.White)
                return;

            CellBorderStyle = TableLayoutPanelCellBorderStyle.None;


            Paint += delegate (Object set_Object_1, PaintEventArgs set_PaintEventArgs)
            {
                get_Color_Border_Current = get_Color_Border_Idle;

                Rectangle rectangle = set_PaintEventArgs.ClipRectangle;

                using (Pen pen = new Pen(get_Color_Border_Idle, 6))
                {
                    set_PaintEventArgs.Graphics.DrawRectangle(pen, rectangle);
                }
            };

            this.Invalidate();
            base.OnLeave(e);
        }

        protected override void OnPaint(PaintEventArgs set_PaintEventArgs)
        {
            base.OnPaint(set_PaintEventArgs);

            if (this.Focused)
            {
                using (Pen pen = new Pen(get_Color_Border_Focus, 6))
                {
                    Rectangle rectangle = set_PaintEventArgs.ClipRectangle;

                    set_PaintEventArgs.Graphics.DrawRectangle(pen, rectangle);

                    ControlPaint.DrawFocusRectangle(set_PaintEventArgs.Graphics, rectangle);

                }
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.Focused)
                return;

            if (get_Color_Border_Current != Color.White)
                return;

            CellBorderStyle = TableLayoutPanelCellBorderStyle.None;


            Paint += delegate (Object set_Object_1, PaintEventArgs set_PaintEventArgs)
            {
                get_Color_Border_Current = get_Color_Border_Idle;

                Rectangle rectangle = set_PaintEventArgs.ClipRectangle;

                using (Pen pen = new Pen(get_Color_Border_Idle, 6))
                {
                    set_PaintEventArgs.Graphics.DrawRectangle(pen, rectangle);
                }
            };

            this.Invalidate();
            base.OnLeave(e);
        }

        protected void OnMouseMove(Object set_Object, MouseEventArgs e)
        {
            if (get_Color_Border_Current == Color.White)
                return;

            CellBorderStyle = TableLayoutPanelCellBorderStyle.None;


            Paint += delegate (Object set_Object_1, PaintEventArgs set_PaintEventArgs)
            {
                get_Color_Border_Current = Color.White;

                Rectangle rectangle = set_PaintEventArgs.ClipRectangle;

                using (Pen pen = new Pen(get_Color_Border_Focus, 6))
                {
                    set_PaintEventArgs.Graphics.DrawRectangle(pen, rectangle);
                }
            };
        }

        private void pnl_Gender_Paint(Color set_Color, Object set_Object, PaintEventArgs set_PaintEventArgs)
        {
            TableLayoutPanel get_Panel = (TableLayoutPanel)set_Object;

            Rectangle rectangle = set_PaintEventArgs.ClipRectangle;

            using (Pen pen = new Pen(set_Color, 6))
            {
                set_PaintEventArgs.Graphics.DrawRectangle(pen, rectangle);
            }
        }

        Color get_Color_Border_Focus;
        Color get_Color_Border_Idle;
        Color get_Color_Border_Current;

        public Color BorderColoreFocused
        {
            set { get_Color_Border_Focus = value; }
        }

        public Color BorderColoreIdle
        {
            set { get_Color_Border_Idle = value; get_Color_Border_Current = value; }
        }

        protected virtual void NestedControl_Mousemove(object sender, MouseEventArgs e)
        {
            Control current = sender as Control;
            OnMouseMove(current, e);
        }

        protected virtual void AddNestedMouseHandler(Control root, MouseEventHandler nestedHandler)
        {
            root.MouseMove += new MouseEventHandler(nestedHandler);
            if (root.Controls.Count > 0)
                foreach (Control c in root.Controls)
                    AddNestedMouseHandler(c, nestedHandler);
        }

    }
}