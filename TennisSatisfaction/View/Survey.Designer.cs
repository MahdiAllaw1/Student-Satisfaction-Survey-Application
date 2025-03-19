namespace TennisSatisfaction.View
{
    partial class Survey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            surveySplitContainer = new SplitContainer();
            questionPanel = new Panel();
            pictureBox1 = new PictureBox();
            progressBar = new ProgressBar();
            suivantButton = new Button();
            translateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)surveySplitContainer).BeginInit();
            surveySplitContainer.Panel1.SuspendLayout();
            surveySplitContainer.Panel2.SuspendLayout();
            surveySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // surveySplitContainer
            // 
            surveySplitContainer.Dock = DockStyle.Fill;
            surveySplitContainer.IsSplitterFixed = true;
            surveySplitContainer.Location = new Point(0, 0);
            surveySplitContainer.Name = "surveySplitContainer";
            surveySplitContainer.Orientation = Orientation.Horizontal;
            // 
            // surveySplitContainer.Panel1
            // 
            surveySplitContainer.Panel1.BackColor = Color.Black;
            surveySplitContainer.Panel1.Controls.Add(questionPanel);
            surveySplitContainer.Panel1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            surveySplitContainer.Panel1.ForeColor = Color.White;
            // 
            // surveySplitContainer.Panel2
            // 
            surveySplitContainer.Panel2.Controls.Add(pictureBox1);
            surveySplitContainer.Panel2.Controls.Add(progressBar);
            surveySplitContainer.Panel2.Controls.Add(suivantButton);
            surveySplitContainer.Panel2.Controls.Add(translateButton);
            surveySplitContainer.Size = new Size(968, 525);
            surveySplitContainer.SplitterDistance = 133;
            surveySplitContainer.SplitterWidth = 1;
            surveySplitContainer.TabIndex = 0;
            // 
            // questionPanel
            // 
            questionPanel.BackColor = Color.Blue;
            questionPanel.Location = new Point(0, 0);
            questionPanel.Name = "questionPanel";
            questionPanel.Size = new Size(968, 130);
            questionPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3295115;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 368);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(968, 23);
            progressBar.TabIndex = 3;
            // 
            // suivantButton
            // 
            suivantButton.BackColor = Color.Yellow;
            suivantButton.FlatStyle = FlatStyle.Popup;
            suivantButton.ForeColor = Color.Green;
            suivantButton.Location = new Point(833, 322);
            suivantButton.Name = "suivantButton";
            suivantButton.Size = new Size(123, 37);
            suivantButton.TabIndex = 2;
            suivantButton.Text = "Next";
            suivantButton.UseVisualStyleBackColor = false;
            suivantButton.Click += suivantButton_Click;
            suivantButton.MouseDown += suivantButton_MouseDown;
            suivantButton.MouseLeave += suivantButton_MouseLeave;
            suivantButton.MouseHover += suivantButton_MouseHover;
            suivantButton.MouseUp += suivantButton_MouseUp;
            // 
            // translateButton
            // 
            translateButton.BackColor = Color.Blue;
            translateButton.FlatStyle = FlatStyle.Popup;
            translateButton.ForeColor = Color.White;
            translateButton.Location = new Point(833, 3);
            translateButton.Name = "translateButton";
            translateButton.Size = new Size(123, 35);
            translateButton.TabIndex = 1;
            translateButton.Text = "Translate";
            translateButton.UseVisualStyleBackColor = false;
            translateButton.Click += translateButton_Click;
            // 
            // Survey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 525);
            Controls.Add(surveySplitContainer);
            Name = "Survey";
            Text = "Survey";
            surveySplitContainer.Panel1.ResumeLayout(false);
            surveySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)surveySplitContainer).EndInit();
            surveySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer surveySplitContainer;
        private Button suivantButton;
        private Button translateButton;
        private Panel questionPanel;
        private ProgressBar progressBar;
        private PictureBox pictureBox1;
    }
}