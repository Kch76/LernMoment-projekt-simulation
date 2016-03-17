namespace ProjektSimulation
{
    partial class MainForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabControl = new Telerik.WinControls.UI.RadPageView();
            this.tabEntwickler = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridEntwickler = new Telerik.WinControls.UI.RadGridView();
            this.tabProjekte = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridProjekte = new Telerik.WinControls.UI.RadGridView();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.btnStop = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabEntwickler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler.MasterTemplate)).BeginInit();
            this.tabProjekte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEntwickler);
            this.tabControl.Controls.Add(this.tabProjekte);
            this.tabControl.Location = new System.Drawing.Point(0, 44);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedPage = this.tabProjekte;
            this.tabControl.Size = new System.Drawing.Size(826, 376);
            this.tabControl.TabIndex = 0;
            this.tabControl.Text = "tabControl";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabControl.GetChildAt(0))).ShowItemCloseButton = false;
            // 
            // tabEntwickler
            // 
            this.tabEntwickler.Controls.Add(this.gridEntwickler);
            this.tabEntwickler.ItemSize = new System.Drawing.SizeF(67F, 28F);
            this.tabEntwickler.Location = new System.Drawing.Point(10, 37);
            this.tabEntwickler.Name = "tabEntwickler";
            this.tabEntwickler.Size = new System.Drawing.Size(805, 372);
            this.tabEntwickler.Text = "Entwickler";
            // 
            // gridEntwickler
            // 
            this.gridEntwickler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEntwickler.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridEntwickler.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridEntwickler.Name = "gridEntwickler";
            this.gridEntwickler.Size = new System.Drawing.Size(805, 372);
            this.gridEntwickler.TabIndex = 0;
            this.gridEntwickler.Text = "radGridView1";
            // 
            // tabProjekte
            // 
            this.tabProjekte.Controls.Add(this.gridProjekte);
            this.tabProjekte.ItemSize = new System.Drawing.SizeF(57F, 28F);
            this.tabProjekte.Location = new System.Drawing.Point(10, 37);
            this.tabProjekte.Name = "tabProjekte";
            this.tabProjekte.Size = new System.Drawing.Size(805, 328);
            this.tabProjekte.Text = "Projekte";
            // 
            // gridProjekte
            // 
            this.gridProjekte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProjekte.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridProjekte.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridProjekte.Name = "gridProjekte";
            this.gridProjekte.Size = new System.Drawing.Size(805, 328);
            this.gridProjekte.TabIndex = 0;
            this.gridProjekte.Text = "radGridView2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 24);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(130, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 24);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stopp";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 420);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabEntwickler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler)).EndInit();
            this.tabProjekte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView tabControl;
        private Telerik.WinControls.UI.RadPageViewPage tabEntwickler;
        private Telerik.WinControls.UI.RadGridView gridEntwickler;
        private Telerik.WinControls.UI.RadPageViewPage tabProjekte;
        private Telerik.WinControls.UI.RadGridView gridProjekte;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadButton btnStop;
    }
}