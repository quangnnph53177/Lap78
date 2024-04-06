namespace PRL
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Ma = new TextBox();
            txt_Ten = new TextBox();
            cb_Quan = new ComboBox();
            btn_Thêm = new Button();
            btn_Xoa = new Button();
            btn__Clear = new Button();
            dtg_View = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_View).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 75);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã thành phố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 155);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên thành phố";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 226);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 2;
            label3.Text = "Quận";
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(199, 67);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(290, 25);
            txt_Ma.TabIndex = 3;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(199, 147);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(290, 25);
            txt_Ten.TabIndex = 4;
            // 
            // cb_Quan
            // 
            cb_Quan.FormattingEnabled = true;
            cb_Quan.Location = new Point(199, 226);
            cb_Quan.Name = "cb_Quan";
            cb_Quan.Size = new Size(290, 25);
            cb_Quan.TabIndex = 5;
            cb_Quan.SelectedIndexChanged += cb_Quan_SelectedIndexChanged;
            // 
            // btn_Thêm
            // 
            btn_Thêm.Location = new Point(636, 66);
            btn_Thêm.Name = "btn_Thêm";
            btn_Thêm.Size = new Size(83, 25);
            btn_Thêm.TabIndex = 6;
            btn_Thêm.Text = "Thêm";
            btn_Thêm.UseVisualStyleBackColor = true;
            btn_Thêm.Click += btn_Thêm_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(636, 146);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(83, 25);
            btn_Xoa.TabIndex = 7;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn__Clear
            // 
            btn__Clear.Location = new Point(636, 218);
            btn__Clear.Name = "btn__Clear";
            btn__Clear.Size = new Size(83, 25);
            btn__Clear.TabIndex = 8;
            btn__Clear.Text = "Clear";
            btn__Clear.UseVisualStyleBackColor = true;
            btn__Clear.Click += btn__Clear_Click;
            // 
            // dtg_View
            // 
            dtg_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_View.Location = new Point(23, 337);
            dtg_View.Name = "dtg_View";
            dtg_View.RowHeadersWidth = 45;
            dtg_View.Size = new Size(769, 166);
            dtg_View.TabIndex = 9;
            dtg_View.CellClick += dtg_View_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 515);
            Controls.Add(dtg_View);
            Controls.Add(btn__Clear);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Thêm);
            Controls.Add(cb_Quan);
            Controls.Add(txt_Ten);
            Controls.Add(txt_Ma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtg_View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Ma;
        private TextBox txt_Ten;
        private ComboBox cb_Quan;
        private Button btn_Thêm;
        private Button btn_Xoa;
        private Button btn__Clear;
        private DataGridView dtg_View;
    }
}
