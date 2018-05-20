using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace verse
{
    public class Text
    {
        public TextBox t;
        public Get g;
        public Text(string s)
        {
            t = new TextBox();
            g = new verse.Get(s);
            t.Text = g.lines[Get.verseNo(1, 1)];
            t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            t.BackColor = System.Drawing.SystemColors.HighlightText;
            t.Cursor = System.Windows.Forms.Cursors.Default;
            t.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t.Location = new System.Drawing.Point(12, Program.location);
            t.Multiline = true;
            //t.Name = "";
            t.ReadOnly = true;
            t.ShortcutsEnabled = false;
            t.Size = new System.Drawing.Size(260, 168);
            t.TabIndex = 0;
            t.TabStop = false;
            t.Visible = true;
            Program.location += 180;
        }
        public Text(System.IO.StreamReader f)
        {
            t = new TextBox();
            g = new verse.Get(f);
            t.Text = g.lines[Get.verseNo(1, 1)];
            t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            t.BackColor = System.Drawing.SystemColors.HighlightText;
            t.Cursor = System.Windows.Forms.Cursors.Default;
            t.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t.Location = new System.Drawing.Point(12, 12);
            t.Multiline = true;
            //t.Name = "";
            t.ReadOnly = true;
            t.ShortcutsEnabled = false;
            t.Size = new System.Drawing.Size(260, 168);
            t.TabIndex = 0;
            t.TabStop = false;
            t.Visible = true;
            Program.location += 180;

        }
        public void update(decimal s, decimal v)
        {
            t.Text = g.lines[Get.verseNo(s, v)];
        }

    }
}
