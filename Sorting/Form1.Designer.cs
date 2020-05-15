namespace Sorting
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnBubble = new System.Windows.Forms.RadioButton();
            this.btnHeap = new System.Windows.Forms.RadioButton();
            this.btnQuick = new System.Windows.Forms.RadioButton();
            this.btnDelay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBSwitch = new System.Windows.Forms.Label();
            this.lblBTime = new System.Windows.Forms.Label();
            this.lblBComp = new System.Windows.Forms.Label();
            this.lblBNum = new System.Windows.Forms.Label();
            this.lblDComp = new System.Windows.Forms.Label();
            this.lblDSwitch = new System.Windows.Forms.Label();
            this.lblDTime = new System.Windows.Forms.Label();
            this.lblDNum = new System.Windows.Forms.Label();
            this.lblQComp = new System.Windows.Forms.Label();
            this.lblQSwitch = new System.Windows.Forms.Label();
            this.lblQTime = new System.Windows.Forms.Label();
            this.lblQNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.output = new System.Windows.Forms.ListBox();
            this.btnSortSelected = new System.Windows.Forms.Button();
            this.btnSortAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numRand = new System.Windows.Forms.DomainUpDown();
            this.lblHComp = new System.Windows.Forms.Label();
            this.lblHSwitch = new System.Windows.Forms.Label();
            this.lblHTime = new System.Windows.Forms.Label();
            this.lblHNum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBubble
            // 
            this.btnBubble.AutoSize = true;
            this.btnBubble.Checked = true;
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.Location = new System.Drawing.Point(6, 83);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(77, 24);
            this.btnBubble.TabIndex = 0;
            this.btnBubble.TabStop = true;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.UseVisualStyleBackColor = true;
            // 
            // btnHeap
            // 
            this.btnHeap.AutoSize = true;
            this.btnHeap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeap.Location = new System.Drawing.Point(6, 147);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(66, 24);
            this.btnHeap.TabIndex = 1;
            this.btnHeap.Text = "Heap";
            this.btnHeap.UseVisualStyleBackColor = true;
            // 
            // btnQuick
            // 
            this.btnQuick.AutoSize = true;
            this.btnQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick.Location = new System.Drawing.Point(6, 207);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(67, 24);
            this.btnQuick.TabIndex = 2;
            this.btnQuick.Text = "Quick";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnDelay
            // 
            this.btnDelay.AutoSize = true;
            this.btnDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelay.Location = new System.Drawing.Point(6, 263);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(126, 44);
            this.btnDelay.TabIndex = 3;
            this.btnDelay.Text = "Delayed \r\nReplacement ";
            this.btnDelay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sorting Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of \r\nComparisons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of \r\nSwitches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time (seconds)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Numbers";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.92086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.07914F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.lblHNum, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHTime, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHSwitch, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBSwitch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBTime, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDelay, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuick, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHeap, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBubble, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBComp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBNum, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDComp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDSwitch, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDTime, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDNum, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQComp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQSwitch, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQTime, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQNum, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHComp, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.45544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.54456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 320);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblBSwitch
            // 
            this.lblBSwitch.AutoSize = true;
            this.lblBSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBSwitch.Location = new System.Drawing.Point(284, 80);
            this.lblBSwitch.Name = "lblBSwitch";
            this.lblBSwitch.Size = new System.Drawing.Size(13, 20);
            this.lblBSwitch.TabIndex = 18;
            this.lblBSwitch.Text = " ";
            // 
            // lblBTime
            // 
            this.lblBTime.AutoSize = true;
            this.lblBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBTime.Location = new System.Drawing.Point(451, 80);
            this.lblBTime.Name = "lblBTime";
            this.lblBTime.Size = new System.Drawing.Size(13, 20);
            this.lblBTime.TabIndex = 16;
            this.lblBTime.Text = " ";
            // 
            // lblBComp
            // 
            this.lblBComp.AutoSize = true;
            this.lblBComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBComp.Location = new System.Drawing.Point(142, 80);
            this.lblBComp.Name = "lblBComp";
            this.lblBComp.Size = new System.Drawing.Size(13, 20);
            this.lblBComp.TabIndex = 17;
            this.lblBComp.Text = " ";
            // 
            // lblBNum
            // 
            this.lblBNum.AutoSize = true;
            this.lblBNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBNum.Location = new System.Drawing.Point(596, 80);
            this.lblBNum.Name = "lblBNum";
            this.lblBNum.Size = new System.Drawing.Size(13, 20);
            this.lblBNum.TabIndex = 19;
            this.lblBNum.Text = " ";
            // 
            // lblDComp
            // 
            this.lblDComp.AutoSize = true;
            this.lblDComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDComp.Location = new System.Drawing.Point(142, 260);
            this.lblDComp.Name = "lblDComp";
            this.lblDComp.Size = new System.Drawing.Size(13, 20);
            this.lblDComp.TabIndex = 20;
            this.lblDComp.Text = " ";
            // 
            // lblDSwitch
            // 
            this.lblDSwitch.AutoSize = true;
            this.lblDSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDSwitch.Location = new System.Drawing.Point(284, 260);
            this.lblDSwitch.Name = "lblDSwitch";
            this.lblDSwitch.Size = new System.Drawing.Size(13, 20);
            this.lblDSwitch.TabIndex = 21;
            this.lblDSwitch.Text = " ";
            // 
            // lblDTime
            // 
            this.lblDTime.AutoSize = true;
            this.lblDTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDTime.Location = new System.Drawing.Point(451, 260);
            this.lblDTime.Name = "lblDTime";
            this.lblDTime.Size = new System.Drawing.Size(13, 20);
            this.lblDTime.TabIndex = 22;
            this.lblDTime.Text = " ";
            // 
            // lblDNum
            // 
            this.lblDNum.AutoSize = true;
            this.lblDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDNum.Location = new System.Drawing.Point(596, 260);
            this.lblDNum.Name = "lblDNum";
            this.lblDNum.Size = new System.Drawing.Size(13, 20);
            this.lblDNum.TabIndex = 23;
            this.lblDNum.Text = " ";
            // 
            // lblQComp
            // 
            this.lblQComp.AutoSize = true;
            this.lblQComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQComp.Location = new System.Drawing.Point(142, 204);
            this.lblQComp.Name = "lblQComp";
            this.lblQComp.Size = new System.Drawing.Size(13, 20);
            this.lblQComp.TabIndex = 24;
            this.lblQComp.Text = " ";
            // 
            // lblQSwitch
            // 
            this.lblQSwitch.AutoSize = true;
            this.lblQSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQSwitch.Location = new System.Drawing.Point(284, 204);
            this.lblQSwitch.Name = "lblQSwitch";
            this.lblQSwitch.Size = new System.Drawing.Size(13, 20);
            this.lblQSwitch.TabIndex = 25;
            this.lblQSwitch.Text = " ";
            // 
            // lblQTime
            // 
            this.lblQTime.AutoSize = true;
            this.lblQTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQTime.Location = new System.Drawing.Point(451, 204);
            this.lblQTime.Name = "lblQTime";
            this.lblQTime.Size = new System.Drawing.Size(13, 20);
            this.lblQTime.TabIndex = 26;
            this.lblQTime.Text = " ";
            // 
            // lblQNum
            // 
            this.lblQNum.AutoSize = true;
            this.lblQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQNum.Location = new System.Drawing.Point(596, 204);
            this.lblQNum.Name = "lblQNum";
            this.lblQNum.Size = new System.Drawing.Size(13, 20);
            this.lblQNum.TabIndex = 27;
            this.lblQNum.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "A Summary of Sorting Routines";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loklToolStripMenuItem,
            this.aasToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(94, 48);
            // 
            // loklToolStripMenuItem
            // 
            this.loklToolStripMenuItem.Name = "loklToolStripMenuItem";
            this.loklToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.loklToolStripMenuItem.Text = "lokl";
            // 
            // aasToolStripMenuItem
            // 
            this.aasToolStripMenuItem.Name = "aasToolStripMenuItem";
            this.aasToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.aasToolStripMenuItem.Text = "aas";
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(782, 133);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(215, 316);
            this.output.TabIndex = 15;
            // 
            // btnSortSelected
            // 
            this.btnSortSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortSelected.Location = new System.Drawing.Point(667, 455);
            this.btnSortSelected.Name = "btnSortSelected";
            this.btnSortSelected.Size = new System.Drawing.Size(109, 47);
            this.btnSortSelected.TabIndex = 12;
            this.btnSortSelected.Text = "Sort Selected";
            this.btnSortSelected.UseVisualStyleBackColor = true;
            this.btnSortSelected.Click += new System.EventHandler(this.btnSortAll_Click);
            // 
            // btnSortAll
            // 
            this.btnSortAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAll.Location = new System.Drawing.Point(552, 455);
            this.btnSortAll.Name = "btnSortAll";
            this.btnSortAll.Size = new System.Drawing.Size(109, 46);
            this.btnSortAll.TabIndex = 10;
            this.btnSortAll.Text = "Sort All";
            this.btnSortAll.UseVisualStyleBackColor = true;
            this.btnSortAll.Click += new System.EventHandler(this.btnSortSelected_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(858, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Display";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numRand);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Number Generator";
            // 
            // genBtn
            // 
            this.genBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBtn.Location = new System.Drawing.Point(298, 47);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(104, 31);
            this.genBtn.TabIndex = 2;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Select amount of numbers to generate:";
            // 
            // numRand
            // 
            this.numRand.Items.Add("1000");
            this.numRand.Items.Add("5000");
            this.numRand.Items.Add("10000");
            this.numRand.Location = new System.Drawing.Point(248, 17);
            this.numRand.Name = "numRand";
            this.numRand.Size = new System.Drawing.Size(154, 26);
            this.numRand.TabIndex = 0;
            // 
            // lblHComp
            // 
            this.lblHComp.AutoSize = true;
            this.lblHComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHComp.Location = new System.Drawing.Point(142, 144);
            this.lblHComp.Name = "lblHComp";
            this.lblHComp.Size = new System.Drawing.Size(13, 20);
            this.lblHComp.TabIndex = 28;
            this.lblHComp.Text = " ";
            // 
            // lblHSwitch
            // 
            this.lblHSwitch.AutoSize = true;
            this.lblHSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHSwitch.Location = new System.Drawing.Point(284, 144);
            this.lblHSwitch.Name = "lblHSwitch";
            this.lblHSwitch.Size = new System.Drawing.Size(13, 20);
            this.lblHSwitch.TabIndex = 29;
            this.lblHSwitch.Text = " ";
            // 
            // lblHTime
            // 
            this.lblHTime.AutoSize = true;
            this.lblHTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHTime.Location = new System.Drawing.Point(451, 144);
            this.lblHTime.Name = "lblHTime";
            this.lblHTime.Size = new System.Drawing.Size(13, 20);
            this.lblHTime.TabIndex = 30;
            this.lblHTime.Text = " ";
            // 
            // lblHNum
            // 
            this.lblHNum.AutoSize = true;
            this.lblHNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHNum.Location = new System.Drawing.Point(596, 144);
            this.lblHNum.Name = "lblHNum";
            this.lblHNum.Size = new System.Drawing.Size(13, 20);
            this.lblHNum.TabIndex = 31;
            this.lblHNum.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSortAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSortSelected);
            this.Controls.Add(this.output);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Sorting Techniques";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnBubble;
        private System.Windows.Forms.RadioButton btnHeap;
        private System.Windows.Forms.RadioButton btnQuick;
        private System.Windows.Forms.RadioButton btnDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBTime;
        private System.Windows.Forms.Label lblBSwitch;
        private System.Windows.Forms.Label lblBComp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aasToolStripMenuItem;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Button btnSortSelected;
        private System.Windows.Forms.Button btnSortAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown numRand;
        private System.Windows.Forms.Label lblBNum;
        private System.Windows.Forms.Label lblDComp;
        private System.Windows.Forms.Label lblDSwitch;
        private System.Windows.Forms.Label lblDTime;
        private System.Windows.Forms.Label lblDNum;
        private System.Windows.Forms.Label lblQComp;
        private System.Windows.Forms.Label lblQSwitch;
        private System.Windows.Forms.Label lblQTime;
        private System.Windows.Forms.Label lblQNum;
        private System.Windows.Forms.Label lblHNum;
        private System.Windows.Forms.Label lblHTime;
        private System.Windows.Forms.Label lblHSwitch;
        private System.Windows.Forms.Label lblHComp;
    }
}

