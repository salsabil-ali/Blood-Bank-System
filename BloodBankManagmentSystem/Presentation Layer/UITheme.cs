using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    // Central place for the app's visual style.
    // Applying UITheme.Apply(this) to a form re-skins its existing buttons, grids and
    // group boxes with a flatter, more modern look WITHOUT changing the layout, control
    // positions or sizes that were already designed for each screen.
    public static class UITheme
    {
        // Core palette
        public static readonly Color FormBackground = Color.FromArgb(245, 246, 250);
        public static readonly Color HeaderAccent = Color.FromArgb(196, 30, 58);
        public static readonly Color GroupBoxText = Color.FromArgb(45, 49, 66);

        public static readonly Color GridHeaderBack = Color.FromArgb(62, 90, 130);
        public static readonly Color GridHeaderFore = Color.White;
        public static readonly Color GridAltRow = Color.FromArgb(246, 247, 250);
        public static readonly Color GridSelection = Color.FromArgb(197, 214, 250);
        public static readonly Color GridLine = Color.FromArgb(228, 230, 235);

        // Applies the theme to an entire form and every control it contains.
        public static void Apply(Form form)
        {
            if (form == null) return;
            form.BackColor = FormBackground;
            StyleChildren(form);
        }

        private static void StyleChildren(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                {
                    StyleButton(btn);
                    continue;
                }

                DataGridView grid = c as DataGridView;
                if (grid != null)
                {
                    StyleGrid(grid);
                    continue;
                }

                GroupBox gb = c as GroupBox;
                if (gb != null)
                {
                    gb.ForeColor = GroupBoxText;
                    StyleChildren(gb);
                    continue;
                }

                ComboBox combo = c as ComboBox;
                if (combo != null)
                {
                    combo.FlatStyle = FlatStyle.Flat;
                    continue;
                }

                TextBox tb = c as TextBox;
                if (tb != null)
                {
                    if (tb.BorderStyle == BorderStyle.Fixed3D)
                        tb.BorderStyle = BorderStyle.FixedSingle;
                    continue;
                }

                // Recurse into plain containers (panels, tab pages, etc.)
                if (c.Controls != null && c.Controls.Count > 0)
                {
                    StyleChildren(c);
                }
            }
        }

        // Restyles a single button: flat, rounded, with a modernized color derived
        // from whatever color it already had, plus a proper hover/press state.
        public static void StyleButton(Button btn)
        {
            Color fore;
            Color back = ResolveButtonColor(btn.BackColor, out fore);

            btn.BackColor = back;
            btn.ForeColor = fore;
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Lighten(back, 0.15);
            btn.FlatAppearance.MouseDownBackColor = Darken(back, 0.12);

            RoundCorners(btn, 8);
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.GridColor = GridLine;
            grid.EnableHeadersVisualStyles = false;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 34;
            grid.RowTemplate.Height = 30;
            grid.Font = new Font("Segoe UI", 9.5F);

            grid.ColumnHeadersDefaultCellStyle.BackColor = GridHeaderBack;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = GridHeaderFore;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = GridHeaderBack;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = GridHeaderFore;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(40, 42, 48);
            grid.DefaultCellStyle.SelectionBackColor = GridSelection;
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);

            grid.AlternatingRowsDefaultCellStyle.BackColor = GridAltRow;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = GridSelection;
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
        }

        // Maps the project's existing named/system colors to a modern equivalent while
        // preserving the original color-coding (green = add, red = delete, etc.).
        // Anything not recognized is left as-is (just gets the flat/rounded treatment).
        private static Color ResolveButtonColor(Color original, out Color foreColor)
        {
            foreColor = Color.White;

            if (original == Color.LightCoral) return Color.FromArgb(228, 88, 107);
            if (original == Color.Coral) return Color.FromArgb(255, 118, 87);
            if (original == Color.IndianRed) return Color.FromArgb(214, 69, 80);

            if (original == Color.LightGreen) return Color.FromArgb(52, 168, 104);
            if (original == Color.LawnGreen) return Color.FromArgb(46, 158, 109);
            if (original == Color.YellowGreen) return Color.FromArgb(111, 174, 60);

            if (original == Color.PaleGoldenrod)
            {
                foreColor = Color.FromArgb(53, 43, 10);
                return Color.FromArgb(227, 167, 46);
            }

            if (original == Color.LightGray)
            {
                foreColor = Color.FromArgb(51, 56, 63);
                return Color.FromArgb(231, 233, 238);
            }

            if (original == SystemColors.GradientActiveCaption) return Color.FromArgb(62, 109, 216);
            if (original == SystemColors.ActiveCaption) return Color.FromArgb(62, 109, 216);
            if (original == SystemColors.AppWorkspace) return Color.FromArgb(85, 96, 107);
            if (original == SystemColors.ControlDark) return Color.FromArgb(75, 85, 99);

            if (original == SystemColors.ControlLight)
            {
                foreColor = Color.FromArgb(51, 56, 63);
                return Color.FromArgb(237, 239, 243);
            }

            // Unknown color: keep the hue, just make sure the text is readable on it.
            foreColor = PerceivedBrightness(original) > 150
                ? Color.FromArgb(30, 30, 30)
                : Color.White;
            return original;
        }

        private static double PerceivedBrightness(Color c)
        {
            return (0.299 * c.R) + (0.587 * c.G) + (0.114 * c.B);
        }

        private static Color Lighten(Color c, double factor)
        {
            int r = c.R + (int)((255 - c.R) * factor);
            int g = c.G + (int)((255 - c.G) * factor);
            int b = c.B + (int)((255 - c.B) * factor);
            return Color.FromArgb(c.A, Clamp(r), Clamp(g), Clamp(b));
        }

        private static Color Darken(Color c, double factor)
        {
            int r = (int)(c.R * (1 - factor));
            int g = (int)(c.G * (1 - factor));
            int b = (int)(c.B * (1 - factor));
            return Color.FromArgb(c.A, Clamp(r), Clamp(g), Clamp(b));
        }

        private static int Clamp(int v)
        {
            if (v < 0) return 0;
            if (v > 255) return 255;
            return v;
        }

        // Gives a control soft rounded corners. Only safe to call once controls have
        // their final size (i.e. after InitializeComponent has run).
        public static void RoundCorners(Control c, int radius)
        {
            if (c.Width <= 0 || c.Height <= 0) return;

            int d = Math.Min(radius * 2, Math.Min(c.Width, c.Height));
            if (d <= 0) return;

            Rectangle rect = new Rectangle(0, 0, c.Width, c.Height);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }
    }
}