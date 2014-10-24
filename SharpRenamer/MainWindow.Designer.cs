namespace SharpRenamer
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.fdb = new System.Windows.Forms.FolderBrowserDialog();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.txtListPath = new System.Windows.Forms.TextBox();
            this.ofpList = new System.Windows.Forms.OpenFileDialog();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(688, 448);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder :";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(65, 10);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(617, 23);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(688, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // fdb
            // 
            this.fdb.ShowNewFolderButton = false;
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 15;
            this.lbxItems.Location = new System.Drawing.Point(12, 47);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(264, 424);
            this.lbxItems.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result example :";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(380, 448);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(302, 23);
            this.txtExample.TabIndex = 6;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(285, 47);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 15);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(330, 44);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ReadOnly = true;
            this.txtFilter.Size = new System.Drawing.Size(433, 23);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.Text = "{rootn} - Tome {fn0} - {lid}.pdf";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 90);
            this.label3.TabIndex = 9;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Additional list of anything :";
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(688, 193);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 12;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // txtListPath
            // 
            this.txtListPath.Location = new System.Drawing.Point(444, 193);
            this.txtListPath.Name = "txtListPath";
            this.txtListPath.ReadOnly = true;
            this.txtListPath.Size = new System.Drawing.Size(238, 23);
            this.txtListPath.TabIndex = 11;
            // 
            // ofpList
            // 
            this.ofpList.Filter = "Text file (*.txt)|*.txt";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 15;
            this.lbxList.Location = new System.Drawing.Point(291, 222);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(472, 184);
            this.lbxList.TabIndex = 13;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(291, 413);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 14;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 483);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtListPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRename);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "SharpRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog fdb;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExample;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.TextBox txtListPath;
        private System.Windows.Forms.OpenFileDialog ofpList;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label lblError;
    }
}

