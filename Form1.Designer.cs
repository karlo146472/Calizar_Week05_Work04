namespace Facundo_Week05_Work04;

partial class ProductForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private Label lblBarcode;
    private TextBox txtBarcode;
    private Label lblName;
    private TextBox txtName;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblCategory;
    private ComboBox cboCategory;
    private GroupBox grpOrigin;
    private RadioButton rdoLocal;
    private RadioButton rdoAbroad;
    private Label lblStatus;
    private CheckBox chkActive;
    private Label lblCost;
    private TextBox txtCost;
    private Label lblPrice;
    private TextBox txtPrice;
    private Label lblMarkup;
    private TextBox txtMarkup;
    private Button btnCancel;
    private Button btnClear;
    private Button btnSave;

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
        lblBarcode = new Label();
        txtBarcode = new TextBox();
        lblName = new Label();
        txtName = new TextBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblCategory = new Label();
        cboCategory = new ComboBox();
        grpOrigin = new GroupBox();
        rdoAbroad = new RadioButton();
        rdoLocal = new RadioButton();
        lblStatus = new Label();
        chkActive = new CheckBox();
        lblCost = new Label();
        txtCost = new TextBox();
        lblPrice = new Label();
        txtPrice = new TextBox();
        lblMarkup = new Label();
        txtMarkup = new TextBox();
        btnCancel = new Button();
        btnClear = new Button();
        btnSave = new Button();
        lblOrigin = new Label();
        lblBarcodeDefinition = new Label();
        grpOrigin.SuspendLayout();
        SuspendLayout();
        // 
        // lblBarcode
        // 
        lblBarcode.AutoSize = true;
        lblBarcode.Location = new Point(18, 24);
        lblBarcode.Name = "lblBarcode";
        lblBarcode.Size = new Size(64, 20);
        lblBarcode.TabIndex = 19;
        lblBarcode.Text = "Barcode";
        // 
        // txtBarcode
        // 
        txtBarcode.Location = new Point(110, 20);
        txtBarcode.Name = "txtBarcode";
        txtBarcode.Size = new Size(282, 27);
        txtBarcode.TabIndex = 1;
        txtBarcode.Tag = "";
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(18, 85);
        lblName.Name = "lblName";
        lblName.Size = new Size(49, 20);
        lblName.TabIndex = 17;
        lblName.Text = "Name";
        // 
        // txtName
        // 
        txtName.Location = new Point(110, 81);
        txtName.Name = "txtName";
        txtName.Size = new Size(282, 27);
        txtName.TabIndex = 2;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(18, 122);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(85, 20);
        lblDescription.TabIndex = 15;
        lblDescription.Text = "Description";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(110, 118);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(282, 58);
        txtDescription.TabIndex = 3;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(18, 193);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(69, 20);
        lblCategory.TabIndex = 13;
        lblCategory.Text = "Category";
        // 
        // cboCategory
        // 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new Point(110, 189);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(282, 28);
        cboCategory.TabIndex = 4;
        // 
        // grpOrigin
        // 
        grpOrigin.Controls.Add(rdoAbroad);
        grpOrigin.Controls.Add(rdoLocal);
        grpOrigin.Location = new Point(110, 229);
        grpOrigin.Name = "grpOrigin";
        grpOrigin.Size = new Size(282, 58);
        grpOrigin.TabIndex = 5;
        grpOrigin.TabStop = false;
        grpOrigin.Text = "Manufactured";
        grpOrigin.Enter += grpOrigin_Enter;
        // 
        // rdoAbroad
        // 
        rdoAbroad.AutoSize = true;
        rdoAbroad.Location = new Point(128, 24);
        rdoAbroad.Name = "rdoAbroad";
        rdoAbroad.Size = new Size(80, 24);
        rdoAbroad.TabIndex = 0;
        rdoAbroad.Text = "Abroad";
        // 
        // rdoLocal
        // 
        rdoLocal.AutoSize = true;
        rdoLocal.Checked = true;
        rdoLocal.Location = new Point(16, 24);
        rdoLocal.Name = "rdoLocal";
        rdoLocal.Size = new Size(65, 24);
        rdoLocal.TabIndex = 1;
        rdoLocal.TabStop = true;
        rdoLocal.Text = "Local";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(18, 309);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(49, 20);
        lblStatus.TabIndex = 10;
        lblStatus.Text = "Status";
        // 
        // chkActive
        // 
        chkActive.AutoSize = true;
        chkActive.Location = new Point(110, 307);
        chkActive.Name = "chkActive";
        chkActive.Size = new Size(72, 24);
        chkActive.TabIndex = 6;
        chkActive.Text = "Active";
        // 
        // lblCost
        // 
        lblCost.AutoSize = true;
        lblCost.Location = new Point(18, 357);
        lblCost.Name = "lblCost";
        lblCost.Size = new Size(38, 20);
        lblCost.TabIndex = 8;
        lblCost.Text = "Cost";
        // 
        // txtCost
        // 
        txtCost.Location = new Point(18, 382);
        txtCost.Name = "txtCost";
        txtCost.Size = new Size(98, 27);
        txtCost.TabIndex = 7;
        // 
        // lblPrice
        // 
        lblPrice.AutoSize = true;
        lblPrice.Location = new Point(142, 357);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(41, 20);
        lblPrice.TabIndex = 6;
        lblPrice.Text = "Price";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(142, 382);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(98, 27);
        txtPrice.TabIndex = 5;
        // 
        // lblMarkup
        // 
        lblMarkup.AutoSize = true;
        lblMarkup.Location = new Point(280, 357);
        lblMarkup.Name = "lblMarkup";
        lblMarkup.Size = new Size(85, 20);
        lblMarkup.TabIndex = 4;
        lblMarkup.Text = "Markup (%)";
        // 
        // txtMarkup
        // 
        txtMarkup.Location = new Point(280, 382);
        txtMarkup.Name = "txtMarkup";
        txtMarkup.Size = new Size(112, 27);
        txtMarkup.TabIndex = 8;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(18, 434);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(108, 36);
        btnCancel.TabIndex = 9;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(142, 434);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(98, 36);
        btnClear.TabIndex = 10;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(280, 434);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(112, 36);
        btnSave.TabIndex = 11;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // lblOrigin
        // 
        lblOrigin.AutoSize = true;
        lblOrigin.Location = new Point(18, 229);
        lblOrigin.Name = "lblOrigin";
        lblOrigin.Size = new Size(50, 20);
        lblOrigin.TabIndex = 20;
        lblOrigin.Text = "Origin";
        // 
        // lblBarcodeDefinition
        // 
        lblBarcodeDefinition.AutoSize = true;
        lblBarcodeDefinition.Enabled = false;
        lblBarcodeDefinition.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblBarcodeDefinition.ForeColor = SystemColors.ActiveBorder;
        lblBarcodeDefinition.Location = new Point(110, 50);
        lblBarcodeDefinition.Name = "lblBarcodeDefinition";
        lblBarcodeDefinition.Size = new Size(145, 20);
        lblBarcodeDefinition.TabIndex = 21;
        lblBarcodeDefinition.Text = "Barcode is available.";
        lblBarcodeDefinition.Click += label1_Click_1;
        // 
        // ProductForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(416, 505);
        Controls.Add(lblBarcodeDefinition);
        Controls.Add(lblOrigin);
        Controls.Add(btnSave);
        Controls.Add(btnClear);
        Controls.Add(btnCancel);
        Controls.Add(txtMarkup);
        Controls.Add(lblMarkup);
        Controls.Add(txtPrice);
        Controls.Add(lblPrice);
        Controls.Add(txtCost);
        Controls.Add(lblCost);
        Controls.Add(chkActive);
        Controls.Add(lblStatus);
        Controls.Add(grpOrigin);
        Controls.Add(cboCategory);
        Controls.Add(lblCategory);
        Controls.Add(txtDescription);
        Controls.Add(lblDescription);
        Controls.Add(txtName);
        Controls.Add(lblName);
        Controls.Add(txtBarcode);
        Controls.Add(lblBarcode);
        Name = "ProductForm";
        Text = "Product Form";
        grpOrigin.ResumeLayout(false);
        grpOrigin.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblOrigin;
    private Label lblBarcodeDefinition;
}
