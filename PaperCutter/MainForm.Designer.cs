namespace Tose2125.PaperCutter
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFormSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SettingPreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingPreviewLabel = new System.Windows.Forms.Label();
            this.SettingPreviewNextButton = new System.Windows.Forms.Button();
            this.SettingPreviewPreviousButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SettingOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingOutputMmReplaceButton = new System.Windows.Forms.Button();
            this.SettingOutputMmPresetSelector = new System.Windows.Forms.ComboBox();
            this.SettingOutputAnchorSelector = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SettingOutputMmWidth = new System.Windows.Forms.NumericUpDown();
            this.SettingOutputMmHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SettingInputGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingInputMmReplaceButton = new System.Windows.Forms.Button();
            this.SettingInputDpiSyncToggleButton = new System.Windows.Forms.CheckBox();
            this.SettingInputDpiWidth = new System.Windows.Forms.NumericUpDown();
            this.SettingInputMmWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SettingInputDpiHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingInputMmHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingInputDpiSelector = new System.Windows.Forms.RadioButton();
            this.SettingInputMmSelector = new System.Windows.Forms.RadioButton();
            this.DraganddropPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ImagePreviewBox = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormSplitContainer)).BeginInit();
            this.MainFormSplitContainer.Panel1.SuspendLayout();
            this.MainFormSplitContainer.Panel2.SuspendLayout();
            this.MainFormSplitContainer.SuspendLayout();
            this.SettingPreviewGroupBox.SuspendLayout();
            this.SettingOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingOutputMmWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingOutputMmHeight)).BeginInit();
            this.SettingInputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputDpiWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputMmWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputDpiHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputMmHeight)).BeginInit();
            this.DraganddropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormSplitContainer
            // 
            this.MainFormSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.MainFormSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainFormSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainFormSplitContainer.Name = "MainFormSplitContainer";
            // 
            // MainFormSplitContainer.Panel1
            // 
            this.MainFormSplitContainer.Panel1.Controls.Add(this.SettingPreviewGroupBox);
            this.MainFormSplitContainer.Panel1.Controls.Add(this.StartButton);
            this.MainFormSplitContainer.Panel1.Controls.Add(this.SettingOutputGroupBox);
            this.MainFormSplitContainer.Panel1.Controls.Add(this.SettingInputGroupBox);
            // 
            // MainFormSplitContainer.Panel2
            // 
            this.MainFormSplitContainer.Panel2.Controls.Add(this.DraganddropPanel);
            this.MainFormSplitContainer.Size = new System.Drawing.Size(784, 561);
            this.MainFormSplitContainer.SplitterDistance = 392;
            this.MainFormSplitContainer.SplitterWidth = 1;
            this.MainFormSplitContainer.TabIndex = 0;
            // 
            // SettingPreviewGroupBox
            // 
            this.SettingPreviewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingPreviewGroupBox.Controls.Add(this.DeleteButton);
            this.SettingPreviewGroupBox.Controls.Add(this.SettingPreviewLabel);
            this.SettingPreviewGroupBox.Controls.Add(this.SettingPreviewNextButton);
            this.SettingPreviewGroupBox.Controls.Add(this.SettingPreviewPreviousButton);
            this.SettingPreviewGroupBox.Location = new System.Drawing.Point(12, 256);
            this.SettingPreviewGroupBox.Name = "SettingPreviewGroupBox";
            this.SettingPreviewGroupBox.Size = new System.Drawing.Size(365, 50);
            this.SettingPreviewGroupBox.TabIndex = 0;
            this.SettingPreviewGroupBox.TabStop = false;
            this.SettingPreviewGroupBox.Text = "プレビュー設定";
            // 
            // SettingPreviewLabel
            // 
            this.SettingPreviewLabel.AutoSize = true;
            this.SettingPreviewLabel.Location = new System.Drawing.Point(50, 23);
            this.SettingPreviewLabel.Name = "SettingPreviewLabel";
            this.SettingPreviewLabel.Size = new System.Drawing.Size(0, 12);
            this.SettingPreviewLabel.TabIndex = 1;
            // 
            // SettingPreviewNextButton
            // 
            this.SettingPreviewNextButton.Location = new System.Drawing.Point(137, 18);
            this.SettingPreviewNextButton.Name = "SettingPreviewNextButton";
            this.SettingPreviewNextButton.Size = new System.Drawing.Size(38, 23);
            this.SettingPreviewNextButton.TabIndex = 16;
            this.SettingPreviewNextButton.Text = "▲";
            this.SettingPreviewNextButton.UseVisualStyleBackColor = true;
            this.SettingPreviewNextButton.Click += new System.EventHandler(this.SettingPreviewNextButton_Click);
            // 
            // SettingPreviewPreviousButton
            // 
            this.SettingPreviewPreviousButton.Location = new System.Drawing.Point(6, 18);
            this.SettingPreviewPreviousButton.Name = "SettingPreviewPreviousButton";
            this.SettingPreviewPreviousButton.Size = new System.Drawing.Size(38, 23);
            this.SettingPreviewPreviousButton.TabIndex = 15;
            this.SettingPreviewPreviousButton.Text = "▼";
            this.SettingPreviewPreviousButton.UseVisualStyleBackColor = true;
            this.SettingPreviewPreviousButton.Click += new System.EventHandler(this.SettingPreviewPreviousButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(12, 199);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(365, 50);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SettingOutputGroupBox
            // 
            this.SettingOutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingOutputGroupBox.Controls.Add(this.SettingOutputMmReplaceButton);
            this.SettingOutputGroupBox.Controls.Add(this.SettingOutputMmPresetSelector);
            this.SettingOutputGroupBox.Controls.Add(this.SettingOutputAnchorSelector);
            this.SettingOutputGroupBox.Controls.Add(this.label10);
            this.SettingOutputGroupBox.Controls.Add(this.label8);
            this.SettingOutputGroupBox.Controls.Add(this.label5);
            this.SettingOutputGroupBox.Controls.Add(this.SettingOutputMmWidth);
            this.SettingOutputGroupBox.Controls.Add(this.SettingOutputMmHeight);
            this.SettingOutputGroupBox.Controls.Add(this.label6);
            this.SettingOutputGroupBox.Controls.Add(this.label7);
            this.SettingOutputGroupBox.Location = new System.Drawing.Point(12, 93);
            this.SettingOutputGroupBox.Name = "SettingOutputGroupBox";
            this.SettingOutputGroupBox.Size = new System.Drawing.Size(365, 100);
            this.SettingOutputGroupBox.TabIndex = 0;
            this.SettingOutputGroupBox.TabStop = false;
            this.SettingOutputGroupBox.Text = "出力設定";
            // 
            // SettingOutputMmReplaceButton
            // 
            this.SettingOutputMmReplaceButton.Location = new System.Drawing.Point(247, 15);
            this.SettingOutputMmReplaceButton.Name = "SettingOutputMmReplaceButton";
            this.SettingOutputMmReplaceButton.Size = new System.Drawing.Size(39, 23);
            this.SettingOutputMmReplaceButton.TabIndex = 11;
            this.SettingOutputMmReplaceButton.Text = "交換";
            this.SettingOutputMmReplaceButton.UseVisualStyleBackColor = true;
            this.SettingOutputMmReplaceButton.Click += new System.EventHandler(this.SettingOutputMmReplaceButton_Click);
            // 
            // SettingOutputMmPresetSelector
            // 
            this.SettingOutputMmPresetSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingOutputMmPresetSelector.FormattingEnabled = true;
            this.SettingOutputMmPresetSelector.Location = new System.Drawing.Point(76, 43);
            this.SettingOutputMmPresetSelector.MaxDropDownItems = 9;
            this.SettingOutputMmPresetSelector.Name = "SettingOutputMmPresetSelector";
            this.SettingOutputMmPresetSelector.Size = new System.Drawing.Size(210, 20);
            this.SettingOutputMmPresetSelector.TabIndex = 12;
            this.SettingOutputMmPresetSelector.SelectedValueChanged += new System.EventHandler(this.SettingOutputMmPresetSelector_SelectedValueChanged);
            // 
            // SettingOutputAnchorSelector
            // 
            this.SettingOutputAnchorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingOutputAnchorSelector.FormattingEnabled = true;
            this.SettingOutputAnchorSelector.Location = new System.Drawing.Point(76, 69);
            this.SettingOutputAnchorSelector.MaxDropDownItems = 9;
            this.SettingOutputAnchorSelector.Name = "SettingOutputAnchorSelector";
            this.SettingOutputAnchorSelector.Size = new System.Drawing.Size(210, 20);
            this.SettingOutputAnchorSelector.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "基準位置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "プリセット";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "mm";
            // 
            // SettingOutputMmWidth
            // 
            this.SettingOutputMmWidth.Location = new System.Drawing.Point(181, 18);
            this.SettingOutputMmWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SettingOutputMmWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingOutputMmWidth.Name = "SettingOutputMmWidth";
            this.SettingOutputMmWidth.Size = new System.Drawing.Size(60, 19);
            this.SettingOutputMmWidth.TabIndex = 10;
            this.SettingOutputMmWidth.Value = new decimal(new int[] {
            210,
            0,
            0,
            0});
            // 
            // SettingOutputMmHeight
            // 
            this.SettingOutputMmHeight.Location = new System.Drawing.Point(76, 18);
            this.SettingOutputMmHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SettingOutputMmHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingOutputMmHeight.Name = "SettingOutputMmHeight";
            this.SettingOutputMmHeight.Size = new System.Drawing.Size(60, 19);
            this.SettingOutputMmHeight.TabIndex = 9;
            this.SettingOutputMmHeight.Value = new decimal(new int[] {
            297,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "縦";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "× 横";
            // 
            // SettingInputGroupBox
            // 
            this.SettingInputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingInputGroupBox.Controls.Add(this.SettingInputMmReplaceButton);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputDpiSyncToggleButton);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputDpiWidth);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputMmWidth);
            this.SettingInputGroupBox.Controls.Add(this.label4);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputDpiHeight);
            this.SettingInputGroupBox.Controls.Add(this.label2);
            this.SettingInputGroupBox.Controls.Add(this.label3);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputMmHeight);
            this.SettingInputGroupBox.Controls.Add(this.label1);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputDpiSelector);
            this.SettingInputGroupBox.Controls.Add(this.SettingInputMmSelector);
            this.SettingInputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettingInputGroupBox.Name = "SettingInputGroupBox";
            this.SettingInputGroupBox.Size = new System.Drawing.Size(365, 75);
            this.SettingInputGroupBox.TabIndex = 0;
            this.SettingInputGroupBox.TabStop = false;
            this.SettingInputGroupBox.Text = "入力設定";
            // 
            // SettingInputMmReplaceButton
            // 
            this.SettingInputMmReplaceButton.Location = new System.Drawing.Point(247, 15);
            this.SettingInputMmReplaceButton.Name = "SettingInputMmReplaceButton";
            this.SettingInputMmReplaceButton.Size = new System.Drawing.Size(39, 23);
            this.SettingInputMmReplaceButton.TabIndex = 4;
            this.SettingInputMmReplaceButton.Text = "交換";
            this.SettingInputMmReplaceButton.UseVisualStyleBackColor = true;
            this.SettingInputMmReplaceButton.Click += new System.EventHandler(this.SettingInputMmReplaceButton_Click);
            // 
            // SettingInputDpiSyncToggleButton
            // 
            this.SettingInputDpiSyncToggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SettingInputDpiSyncToggleButton.AutoSize = true;
            this.SettingInputDpiSyncToggleButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingInputDpiSyncToggleButton.Location = new System.Drawing.Point(247, 40);
            this.SettingInputDpiSyncToggleButton.Name = "SettingInputDpiSyncToggleButton";
            this.SettingInputDpiSyncToggleButton.Size = new System.Drawing.Size(39, 22);
            this.SettingInputDpiSyncToggleButton.TabIndex = 8;
            this.SettingInputDpiSyncToggleButton.Text = "同期";
            this.SettingInputDpiSyncToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingInputDpiSyncToggleButton.UseVisualStyleBackColor = true;
            // 
            // SettingInputDpiWidth
            // 
            this.SettingInputDpiWidth.Location = new System.Drawing.Point(181, 43);
            this.SettingInputDpiWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SettingInputDpiWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingInputDpiWidth.Name = "SettingInputDpiWidth";
            this.SettingInputDpiWidth.Size = new System.Drawing.Size(60, 19);
            this.SettingInputDpiWidth.TabIndex = 7;
            this.SettingInputDpiWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SettingInputDpiWidth.ValueChanged += new System.EventHandler(this.SettingInputDpiWidth_ValueChanged);
            // 
            // SettingInputMmWidth
            // 
            this.SettingInputMmWidth.Location = new System.Drawing.Point(181, 18);
            this.SettingInputMmWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SettingInputMmWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingInputMmWidth.Name = "SettingInputMmWidth";
            this.SettingInputMmWidth.Size = new System.Drawing.Size(60, 19);
            this.SettingInputMmWidth.TabIndex = 3;
            this.SettingInputMmWidth.Value = new decimal(new int[] {
            210,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "× 横";
            // 
            // SettingInputDpiHeight
            // 
            this.SettingInputDpiHeight.Location = new System.Drawing.Point(76, 43);
            this.SettingInputDpiHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SettingInputDpiHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingInputDpiHeight.Name = "SettingInputDpiHeight";
            this.SettingInputDpiHeight.Size = new System.Drawing.Size(60, 19);
            this.SettingInputDpiHeight.TabIndex = 6;
            this.SettingInputDpiHeight.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SettingInputDpiHeight.ValueChanged += new System.EventHandler(this.SettingInputDpiHeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "× 横";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "縦";
            // 
            // SettingInputMmHeight
            // 
            this.SettingInputMmHeight.Location = new System.Drawing.Point(76, 18);
            this.SettingInputMmHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SettingInputMmHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingInputMmHeight.Name = "SettingInputMmHeight";
            this.SettingInputMmHeight.Size = new System.Drawing.Size(60, 19);
            this.SettingInputMmHeight.TabIndex = 2;
            this.SettingInputMmHeight.Value = new decimal(new int[] {
            297,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "縦";
            // 
            // SettingInputDpiSelector
            // 
            this.SettingInputDpiSelector.AutoSize = true;
            this.SettingInputDpiSelector.Checked = true;
            this.SettingInputDpiSelector.Location = new System.Drawing.Point(6, 43);
            this.SettingInputDpiSelector.Name = "SettingInputDpiSelector";
            this.SettingInputDpiSelector.Size = new System.Drawing.Size(38, 16);
            this.SettingInputDpiSelector.TabIndex = 5;
            this.SettingInputDpiSelector.TabStop = true;
            this.SettingInputDpiSelector.Text = "dpi";
            this.SettingInputDpiSelector.UseVisualStyleBackColor = true;
            // 
            // SettingInputMmSelector
            // 
            this.SettingInputMmSelector.AutoSize = true;
            this.SettingInputMmSelector.Location = new System.Drawing.Point(6, 18);
            this.SettingInputMmSelector.Name = "SettingInputMmSelector";
            this.SettingInputMmSelector.Size = new System.Drawing.Size(41, 16);
            this.SettingInputMmSelector.TabIndex = 1;
            this.SettingInputMmSelector.TabStop = true;
            this.SettingInputMmSelector.Text = "mm";
            this.SettingInputMmSelector.UseVisualStyleBackColor = true;
            // 
            // DraganddropPanel
            // 
            this.DraganddropPanel.AllowDrop = true;
            this.DraganddropPanel.Controls.Add(this.label9);
            this.DraganddropPanel.Controls.Add(this.ImagePreviewBox);
            this.DraganddropPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DraganddropPanel.Location = new System.Drawing.Point(0, 0);
            this.DraganddropPanel.Name = "DraganddropPanel";
            this.DraganddropPanel.Size = new System.Drawing.Size(391, 561);
            this.DraganddropPanel.TabIndex = 0;
            this.DraganddropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DraganddropPanel_DragDrop);
            this.DraganddropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DraganddropPanel_DragEnter);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "ここに画像をドロップ";
            // 
            // ImagePreviewBox
            // 
            this.ImagePreviewBox.BackColor = System.Drawing.SystemColors.Control;
            this.ImagePreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePreviewBox.Location = new System.Drawing.Point(0, 0);
            this.ImagePreviewBox.Name = "ImagePreviewBox";
            this.ImagePreviewBox.Size = new System.Drawing.Size(391, 561);
            this.ImagePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreviewBox.TabIndex = 0;
            this.ImagePreviewBox.TabStop = false;
            this.ImagePreviewBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagePreviewBox_MouseDown);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AllowDrop = true;
            this.DeleteButton.Location = new System.Drawing.Point(181, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "消去";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.DeleteButton_DragDrop);
            this.DeleteButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.DeleteButton_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainFormSplitContainer);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "PaperCutter";
            this.MainFormSplitContainer.Panel1.ResumeLayout(false);
            this.MainFormSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormSplitContainer)).EndInit();
            this.MainFormSplitContainer.ResumeLayout(false);
            this.SettingPreviewGroupBox.ResumeLayout(false);
            this.SettingPreviewGroupBox.PerformLayout();
            this.SettingOutputGroupBox.ResumeLayout(false);
            this.SettingOutputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingOutputMmWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingOutputMmHeight)).EndInit();
            this.SettingInputGroupBox.ResumeLayout(false);
            this.SettingInputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputDpiWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputMmWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputDpiHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingInputMmHeight)).EndInit();
            this.DraganddropPanel.ResumeLayout(false);
            this.DraganddropPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainFormSplitContainer;
        private System.Windows.Forms.GroupBox SettingInputGroupBox;
        private System.Windows.Forms.NumericUpDown SettingInputDpiWidth;
        private System.Windows.Forms.NumericUpDown SettingInputMmWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SettingInputDpiHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SettingInputMmHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SettingInputDpiSelector;
        private System.Windows.Forms.RadioButton SettingInputMmSelector;
        private System.Windows.Forms.Panel DraganddropPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox SettingOutputGroupBox;
        private System.Windows.Forms.ComboBox SettingOutputAnchorSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SettingOutputMmWidth;
        private System.Windows.Forms.NumericUpDown SettingOutputMmHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SettingOutputMmReplaceButton;
        private System.Windows.Forms.ComboBox SettingOutputMmPresetSelector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SettingInputMmReplaceButton;
        private System.Windows.Forms.CheckBox SettingInputDpiSyncToggleButton;
        private System.Windows.Forms.PictureBox ImagePreviewBox;
        private System.Windows.Forms.GroupBox SettingPreviewGroupBox;
        private System.Windows.Forms.Label SettingPreviewLabel;
        private System.Windows.Forms.Button SettingPreviewNextButton;
        private System.Windows.Forms.Button SettingPreviewPreviousButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

