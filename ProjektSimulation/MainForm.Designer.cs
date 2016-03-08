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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabControl = new Telerik.WinControls.UI.RadPageView();
            this.tabEntwickler = new Telerik.WinControls.UI.RadPageViewPage();
            this.tabProjekte = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridEntwickler = new Telerik.WinControls.UI.RadGridView();
            this.gridProjekte = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabEntwickler.SuspendLayout();
            this.tabProjekte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEntwickler);
            this.tabControl.Controls.Add(this.tabProjekte);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedPage = this.tabProjekte;
            this.tabControl.Size = new System.Drawing.Size(826, 420);
            this.tabControl.TabIndex = 0;
            this.tabControl.Text = "tabControl";
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
            // tabProjekte
            // 
            this.tabProjekte.Controls.Add(this.gridProjekte);
            this.tabProjekte.ItemSize = new System.Drawing.SizeF(57F, 28F);
            this.tabProjekte.Location = new System.Drawing.Point(10, 37);
            this.tabProjekte.Name = "tabProjekte";
            this.tabProjekte.Size = new System.Drawing.Size(805, 372);
            this.tabProjekte.Text = "Projekte";
            // 
            // gridEntwickler
            // 
            this.gridEntwickler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEntwickler.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridEntwickler.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridEntwickler.Name = "gridEntwickler";
            this.gridEntwickler.Size = new System.Drawing.Size(805, 372);
            this.gridEntwickler.TabIndex = 0;
            this.gridEntwickler.Text = "radGridView1";
            // 
            // gridProjekte
            // 
            this.gridProjekte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProjekte.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridProjekte.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.gridProjekte.Name = "gridProjekte";
            this.gridProjekte.Size = new System.Drawing.Size(805, 372);
            this.gridProjekte.TabIndex = 0;
            this.gridProjekte.Text = "radGridView2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 420);
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
            this.tabProjekte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntwickler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjekte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView tabControl;
        private Telerik.WinControls.UI.RadPageViewPage tabEntwickler;
        private Telerik.WinControls.UI.RadGridView gridEntwickler;
        private Telerik.WinControls.UI.RadPageViewPage tabProjekte;
        private Telerik.WinControls.UI.RadGridView gridProjekte;
    }
}