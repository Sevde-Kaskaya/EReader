namespace kitap_okuma_v1
{
    partial class PDF_Form
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
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.pdfCommandBar1 = new DevExpress.XtraPdfViewer.Bars.PdfCommandBar();
            this.pdfFileOpenBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
            this.pdfFileSaveAsBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            this.pdfFilePrintBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
            this.pdfFindTextBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
            this.pdfPreviousPageBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
            this.pdfNextPageBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfSetPageNumberBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem();
            this.repositoryItemPageNumberEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.pdfZoomOutBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
            this.pdfZoomInBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
            this.pdfExactZoomListBarSubItem2 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.pdfZoom10CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
            this.pdfZoom25CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
            this.pdfZoom50CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
            this.pdfZoom75CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
            this.pdfZoom100CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
            this.pdfZoom125CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
            this.pdfZoom150CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
            this.pdfZoom200CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
            this.pdfZoom400CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
            this.pdfZoom500CheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
            this.pdfSetActualSizeZoomModeCheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
            this.pdfSetPageLevelZoomModeCheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
            this.pdfSetFitWidthZoomModeCheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
            this.pdfSetFitVisibleZoomModeCheckItem2 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
            this.pdfExportFormDataBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem();
            this.pdfImportFormDataBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 31);
            this.pdfViewer1.MenuManager = this.barManager1;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(794, 936);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Load += new System.EventHandler(this.pdfViewer1_Load_1);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.pdfCommandBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.pdfFileOpenBarItem2,
            this.pdfFileSaveAsBarItem2,
            this.pdfFilePrintBarItem2,
            this.pdfFindTextBarItem2,
            this.pdfPreviousPageBarItem2,
            this.pdfNextPageBarItem2,
            this.pdfSetPageNumberBarItem2,
            this.pdfZoomOutBarItem2,
            this.pdfZoomInBarItem2,
            this.pdfExactZoomListBarSubItem2,
            this.pdfZoom10CheckItem2,
            this.pdfZoom25CheckItem2,
            this.pdfZoom50CheckItem2,
            this.pdfZoom75CheckItem2,
            this.pdfZoom100CheckItem2,
            this.pdfZoom125CheckItem2,
            this.pdfZoom150CheckItem2,
            this.pdfZoom200CheckItem2,
            this.pdfZoom400CheckItem2,
            this.pdfZoom500CheckItem2,
            this.pdfSetActualSizeZoomModeCheckItem2,
            this.pdfSetPageLevelZoomModeCheckItem2,
            this.pdfSetFitWidthZoomModeCheckItem2,
            this.pdfSetFitVisibleZoomModeCheckItem2,
            this.pdfExportFormDataBarItem2,
            this.pdfImportFormDataBarItem2});
            this.barManager1.MaxItemId = 26;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit2});
            // 
            // pdfCommandBar1
            // 
            this.pdfCommandBar1.Control = this.pdfViewer1;
            this.pdfCommandBar1.DockCol = 0;
            this.pdfCommandBar1.DockRow = 0;
            this.pdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.pdfCommandBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFileOpenBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFileSaveAsBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFilePrintBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFindTextBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfPreviousPageBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfNextPageBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageNumberBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoomOutBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoomInBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfExactZoomListBarSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfExportFormDataBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfImportFormDataBarItem2)});
            // 
            // pdfFileOpenBarItem2
            // 
            this.pdfFileOpenBarItem2.Id = 0;
            this.pdfFileOpenBarItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.pdfFileOpenBarItem2.Name = "pdfFileOpenBarItem2";
            // 
            // pdfFileSaveAsBarItem2
            // 
            this.pdfFileSaveAsBarItem2.Id = 1;
            this.pdfFileSaveAsBarItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem2.Name = "pdfFileSaveAsBarItem2";
            // 
            // pdfFilePrintBarItem2
            // 
            this.pdfFilePrintBarItem2.Id = 2;
            this.pdfFilePrintBarItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.pdfFilePrintBarItem2.Name = "pdfFilePrintBarItem2";
            // 
            // pdfFindTextBarItem2
            // 
            this.pdfFindTextBarItem2.Id = 3;
            this.pdfFindTextBarItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.pdfFindTextBarItem2.Name = "pdfFindTextBarItem2";
            // 
            // pdfPreviousPageBarItem2
            // 
            this.pdfPreviousPageBarItem2.Id = 4;
            this.pdfPreviousPageBarItem2.Name = "pdfPreviousPageBarItem2";
            // 
            // pdfNextPageBarItem2
            // 
            this.pdfNextPageBarItem2.Id = 5;
            this.pdfNextPageBarItem2.Name = "pdfNextPageBarItem2";
            // 
            // pdfSetPageNumberBarItem2
            // 
            this.pdfSetPageNumberBarItem2.Edit = this.repositoryItemPageNumberEdit2;
            this.pdfSetPageNumberBarItem2.EditValue = 0;
            this.pdfSetPageNumberBarItem2.Enabled = false;
            this.pdfSetPageNumberBarItem2.Id = 6;
            this.pdfSetPageNumberBarItem2.Name = "pdfSetPageNumberBarItem2";
            // 
            // repositoryItemPageNumberEdit2
            // 
            this.repositoryItemPageNumberEdit2.AutoHeight = false;
            this.repositoryItemPageNumberEdit2.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit2.Name = "repositoryItemPageNumberEdit2";
            this.repositoryItemPageNumberEdit2.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal;
            // 
            // pdfZoomOutBarItem2
            // 
            this.pdfZoomOutBarItem2.Id = 7;
            this.pdfZoomOutBarItem2.Name = "pdfZoomOutBarItem2";
            // 
            // pdfZoomInBarItem2
            // 
            this.pdfZoomInBarItem2.Id = 8;
            this.pdfZoomInBarItem2.Name = "pdfZoomInBarItem2";
            // 
            // pdfExactZoomListBarSubItem2
            // 
            this.pdfExactZoomListBarSubItem2.Id = 9;
            this.pdfExactZoomListBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem2)});
            this.pdfExactZoomListBarSubItem2.Name = "pdfExactZoomListBarSubItem2";
            this.pdfExactZoomListBarSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // pdfZoom10CheckItem2
            // 
            this.pdfZoom10CheckItem2.Id = 10;
            this.pdfZoom10CheckItem2.Name = "pdfZoom10CheckItem2";
            // 
            // pdfZoom25CheckItem2
            // 
            this.pdfZoom25CheckItem2.Id = 11;
            this.pdfZoom25CheckItem2.Name = "pdfZoom25CheckItem2";
            // 
            // pdfZoom50CheckItem2
            // 
            this.pdfZoom50CheckItem2.Id = 12;
            this.pdfZoom50CheckItem2.Name = "pdfZoom50CheckItem2";
            // 
            // pdfZoom75CheckItem2
            // 
            this.pdfZoom75CheckItem2.Id = 13;
            this.pdfZoom75CheckItem2.Name = "pdfZoom75CheckItem2";
            // 
            // pdfZoom100CheckItem2
            // 
            this.pdfZoom100CheckItem2.Id = 14;
            this.pdfZoom100CheckItem2.Name = "pdfZoom100CheckItem2";
            // 
            // pdfZoom125CheckItem2
            // 
            this.pdfZoom125CheckItem2.Id = 15;
            this.pdfZoom125CheckItem2.Name = "pdfZoom125CheckItem2";
            // 
            // pdfZoom150CheckItem2
            // 
            this.pdfZoom150CheckItem2.Id = 16;
            this.pdfZoom150CheckItem2.Name = "pdfZoom150CheckItem2";
            // 
            // pdfZoom200CheckItem2
            // 
            this.pdfZoom200CheckItem2.Id = 17;
            this.pdfZoom200CheckItem2.Name = "pdfZoom200CheckItem2";
            // 
            // pdfZoom400CheckItem2
            // 
            this.pdfZoom400CheckItem2.Id = 18;
            this.pdfZoom400CheckItem2.Name = "pdfZoom400CheckItem2";
            // 
            // pdfZoom500CheckItem2
            // 
            this.pdfZoom500CheckItem2.Id = 19;
            this.pdfZoom500CheckItem2.Name = "pdfZoom500CheckItem2";
            // 
            // pdfSetActualSizeZoomModeCheckItem2
            // 
            this.pdfSetActualSizeZoomModeCheckItem2.Id = 20;
            this.pdfSetActualSizeZoomModeCheckItem2.Name = "pdfSetActualSizeZoomModeCheckItem2";
            // 
            // pdfSetPageLevelZoomModeCheckItem2
            // 
            this.pdfSetPageLevelZoomModeCheckItem2.Id = 21;
            this.pdfSetPageLevelZoomModeCheckItem2.Name = "pdfSetPageLevelZoomModeCheckItem2";
            // 
            // pdfSetFitWidthZoomModeCheckItem2
            // 
            this.pdfSetFitWidthZoomModeCheckItem2.Id = 22;
            this.pdfSetFitWidthZoomModeCheckItem2.Name = "pdfSetFitWidthZoomModeCheckItem2";
            // 
            // pdfSetFitVisibleZoomModeCheckItem2
            // 
            this.pdfSetFitVisibleZoomModeCheckItem2.Id = 23;
            this.pdfSetFitVisibleZoomModeCheckItem2.Name = "pdfSetFitVisibleZoomModeCheckItem2";
            // 
            // pdfExportFormDataBarItem2
            // 
            this.pdfExportFormDataBarItem2.Id = 24;
            this.pdfExportFormDataBarItem2.Name = "pdfExportFormDataBarItem2";
            // 
            // pdfImportFormDataBarItem2
            // 
            this.pdfImportFormDataBarItem2.Id = 25;
            this.pdfImportFormDataBarItem2.Name = "pdfImportFormDataBarItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(794, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 967);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(794, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 936);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(794, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 936);
            // 
            // pdfBarController1
            // 
            this.pdfBarController1.BarItems.Add(this.pdfFileOpenBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfFileSaveAsBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfFilePrintBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfFindTextBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfPreviousPageBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfNextPageBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageNumberBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoomOutBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoomInBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfExactZoomListBarSubItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem2);
            this.pdfBarController1.BarItems.Add(this.pdfExportFormDataBarItem2);
            this.pdfBarController1.BarItems.Add(this.pdfImportFormDataBarItem2);
            this.pdfBarController1.Control = this.pdfViewer1;
            // 
            // PDF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 967);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PDF_Form";
            this.Text = "PDF_Form";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraPdfViewer.Bars.PdfCommandBar pdfCommandBar1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem pdfFileOpenBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem pdfFilePrintBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem pdfFindTextBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem pdfPreviousPageBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem pdfSetPageNumberBarItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem pdfZoomOutBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem pdfZoomInBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem pdfExportFormDataBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem pdfImportFormDataBarItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
    }
}