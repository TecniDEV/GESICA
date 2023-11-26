namespace GESICA
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Menu = new ToolStrip();
            MenuSystem = new ToolStripDropDownButton();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(33, 66, 99);
            Menu.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.GripStyle = ToolStripGripStyle.Hidden;
            Menu.Items.AddRange(new ToolStripItem[] { MenuSystem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1006, 25);
            Menu.TabIndex = 0;
            Menu.Text = "Menú Principal";
            // 
            // MenuSystem
            // 
            MenuSystem.ForeColor = Color.White;
            MenuSystem.ImageTransparentColor = Color.Magenta;
            MenuSystem.Name = "MenuSystem";
            MenuSystem.ShowDropDownArrow = false;
            MenuSystem.Size = new Size(61, 22);
            MenuSystem.Text = "&Sistema";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1006, 721);
            Controls.Add(Menu);
            Font = new Font("MesloLGL NF", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESICA";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip Menu;
        private ToolStripDropDownButton MenuSystem;
    }
}
