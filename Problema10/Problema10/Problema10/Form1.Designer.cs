namespace Problema10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpTickets     = new GroupBox();
            chkBox         = new CheckBox();
            txtBox         = new TextBox();
            chkPavilion    = new CheckBox();
            txtPavilion    = new TextBox();
            chkLawn        = new CheckBox();
            txtLawn        = new TextBox();
            chk10Discount  = new CheckBox();
            lblTotalTickets= new Label();
            txtTotalTickets= new TextBox();
            lblTotalDue    = new Label();
            txtTotalDue    = new TextBox();
            btnCalculate   = new Button();
            btnExit        = new Button();
            grpTickets.SuspendLayout();
            SuspendLayout();

            // ── grpTickets ────────────────────────────────────────────
            grpTickets.Controls.Add(chkBox);
            grpTickets.Controls.Add(txtBox);
            grpTickets.Controls.Add(chkPavilion);
            grpTickets.Controls.Add(txtPavilion);
            grpTickets.Controls.Add(chkLawn);
            grpTickets.Controls.Add(txtLawn);
            grpTickets.Controls.Add(chk10Discount);
            grpTickets.Location = new Point(15, 15);
            grpTickets.Name     = "grpTickets";
            grpTickets.Size     = new Size(440, 105);
            grpTickets.TabIndex = 0;
            grpTickets.Text     = "Tickets";

            // ── chkBox ────────────────────────────────────────────────
            chkBox.AutoSize = true;
            chkBox.Location = new Point(15, 28);
            chkBox.Name     = "chkBox";
            chkBox.Size     = new Size(45, 19);
            chkBox.TabIndex = 1;
            chkBox.Text     = "Box";
            chkBox.CheckedChanged += chkBox_CheckedChanged;

            // ── txtBox ────────────────────────────────────────────────
            txtBox.Enabled  = false;
            txtBox.Location = new Point(15, 58);
            txtBox.Name     = "txtBox";
            txtBox.Size     = new Size(65, 23);
            txtBox.TabIndex = 2;

            // ── chkPavilion ───────────────────────────────────────────
            chkPavilion.AutoSize = true;
            chkPavilion.Location = new Point(115, 28);
            chkPavilion.Name     = "chkPavilion";
            chkPavilion.Size     = new Size(72, 19);
            chkPavilion.TabIndex = 3;
            chkPavilion.Text     = "Pavilion";
            chkPavilion.CheckedChanged += chkPavilion_CheckedChanged;

            // ── txtPavilion ───────────────────────────────────────────
            txtPavilion.Enabled  = false;
            txtPavilion.Location = new Point(115, 58);
            txtPavilion.Name     = "txtPavilion";
            txtPavilion.Size     = new Size(65, 23);
            txtPavilion.TabIndex = 4;

            // ── chkLawn ───────────────────────────────────────────────
            chkLawn.AutoSize = true;
            chkLawn.Location = new Point(220, 28);
            chkLawn.Name     = "chkLawn";
            chkLawn.Size     = new Size(49, 19);
            chkLawn.TabIndex = 5;
            chkLawn.Text     = "Lawn";
            chkLawn.CheckedChanged += chkLawn_CheckedChanged;

            // ── txtLawn ───────────────────────────────────────────────
            txtLawn.Enabled  = false;
            txtLawn.Location = new Point(220, 58);
            txtLawn.Name     = "txtLawn";
            txtLawn.Size     = new Size(65, 23);
            txtLawn.TabIndex = 6;

            // ── chk10Discount ─────────────────────────────────────────
            chk10Discount.AutoSize = true;
            chk10Discount.Location = new Point(315, 28);
            chk10Discount.Name     = "chk10Discount";
            chk10Discount.Size     = new Size(96, 19);
            chk10Discount.TabIndex = 7;
            chk10Discount.Text     = "10% discount";

            // ── lblTotalTickets ───────────────────────────────────────
            lblTotalTickets.AutoSize = true;
            lblTotalTickets.Location = new Point(15, 142);
            lblTotalTickets.Name     = "lblTotalTickets";
            lblTotalTickets.Text     = "Total tickets:";

            // ── txtTotalTickets ───────────────────────────────────────
            txtTotalTickets.Location = new Point(15, 162);
            txtTotalTickets.Name     = "txtTotalTickets";
            txtTotalTickets.ReadOnly = true;
            txtTotalTickets.Size     = new Size(75, 23);
            txtTotalTickets.TabIndex = 8;

            // ── lblTotalDue ───────────────────────────────────────────
            lblTotalDue.AutoSize = true;
            lblTotalDue.Location = new Point(115, 142);
            lblTotalDue.Name     = "lblTotalDue";
            lblTotalDue.Text     = "Total due:";

            // ── txtTotalDue ───────────────────────────────────────────
            txtTotalDue.Location = new Point(115, 162);
            txtTotalDue.Name     = "txtTotalDue";
            txtTotalDue.ReadOnly = true;
            txtTotalDue.Size     = new Size(115, 23);
            txtTotalDue.TabIndex = 9;

            // ── btnCalculate ──────────────────────────────────────────
            btnCalculate.Location = new Point(290, 161);
            btnCalculate.Name     = "btnCalculate";
            btnCalculate.Size     = new Size(80, 27);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text     = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            // ── btnExit ───────────────────────────────────────────────
            btnExit.Location = new Point(378, 161);
            btnExit.Name     = "btnExit";
            btnExit.Size     = new Size(60, 27);
            btnExit.TabIndex = 11;
            btnExit.Text     = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            // ── Form1 ─────────────────────────────────────────────────
            grpTickets.ResumeLayout(false);
            grpTickets.PerformLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize    = new Size(460, 210);
            Controls.Add(grpTickets);
            Controls.Add(lblTotalTickets);
            Controls.Add(txtTotalTickets);
            Controls.Add(lblTotalDue);
            Controls.Add(txtTotalDue);
            Controls.Add(btnCalculate);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Ticket Miser";
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Controles ─────────────────────────────────────────────────
        private GroupBox grpTickets;
        private CheckBox chkBox;
        private TextBox  txtBox;
        private CheckBox chkPavilion;
        private TextBox  txtPavilion;
        private CheckBox chkLawn;
        private TextBox  txtLawn;
        private CheckBox chk10Discount;
        private Label    lblTotalTickets;
        private TextBox  txtTotalTickets;
        private Label    lblTotalDue;
        private TextBox  txtTotalDue;
        private Button   btnCalculate;
        private Button   btnExit;
    }
}
