namespace Facundo_Week05_Work04;

public partial class ProductForm : Form
{
    public ProductForm()
    {
        InitializeComponent();

        cboCategory.Items.AddRange(["Beverages", "Food", "Office Supplies", "Personal Care"]);
        txtPrice.ReadOnly = true;

        txtCost.TextChanged += CalculatePrice;
        txtMarkup.TextChanged += CalculatePrice;
        btnClear.Click += btnClear_Click;
        btnCancel.Click += btnCancel_Click;
        btnSave.Click += btnSave_Click;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void grpOrigin_Enter(object sender, EventArgs e)
    {

    }

    private void CalculatePrice(object? sender, EventArgs e)
    {
        if (decimal.TryParse(txtCost.Text, out decimal cost) &&
            decimal.TryParse(txtMarkup.Text, out decimal markup))
        {
            txtPrice.Text = (cost + (cost * markup / 100)).ToString("0.00");
        }
        else
        {
            txtPrice.Clear();
        }
    }

    private bool ValidateForm()
    {
        if (string.IsNullOrWhiteSpace(txtBarcode.Text))
        {
            MessageBox.Show("Please enter a barcode.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtBarcode.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Please enter a product name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
            return false;
        }

        if (cboCategory.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboCategory.Focus();
            return false;
        }

        if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost < 0)
        {
            MessageBox.Show("Enter a valid cost that is zero or greater.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCost.Focus();
            return false;
        }

        if (!decimal.TryParse(txtMarkup.Text, out decimal markup) || markup < 0)
        {
            MessageBox.Show("Enter a valid markup that is zero or greater.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMarkup.Focus();
            return false;
        }

        return true;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        if (!ValidateForm())
        {
            return;
        }

        string origin = rdoLocal.Checked ? "Local" : "Abroad";
        string status = chkActive.Checked ? "Active" : "Inactive";

        MessageBox.Show(
            $"Product saved successfully!\n\n" +
            $"Name: {txtName.Text}\n" +
            $"Category: {cboCategory.Text}\n" +
            $"Price: {txtPrice.Text}\n" +
            $"Origin: {origin}\n" +
            $"Status: {status}",
            "Save Product",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void btnClear_Click(object? sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            if (control is TextBox textBox)
            {
                textBox.Clear();
            }
        }

        cboCategory.SelectedIndex = -1;
        rdoLocal.Checked = true;
        chkActive.Checked = false;
        txtBarcode.Focus();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Are you sure you want to cancel?",
            "Cancel",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            Close();
        }
    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }
}
