using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private object toolStripStatusLabel;
        private object richText;

        public Form1()
        {
            InitializeComponent();
        }


        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            // Thiết lập lại kiểu chữ và cỡ chữ mặc định
            richTextBox1.Font = new Font("Tahoma", 12);
            richTextBox1.ForeColor = Color.Black;

            // Nếu bạn muốn hiển thị một thông báo cho người dùng
            MessageBox.Show("Một văn bản mới đã được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedItem != null)
            {
                // Lấy kích thước chữ mà người dùng đã chọn
                string selectedSizeStr = toolStripComboBox2.SelectedItem.ToString();
                float selectedSize;

                // Chuyển đổi chuỗi sang số thực
                if (float.TryParse(selectedSizeStr, out selectedSize))
                {
                    // Cập nhật cỡ chữ cho văn bản được chọn
                    string currentFontName = richTextBox1.SelectionFont?.FontFamily.Name ?? "Tahoma"; // Kiểu chữ mặc định nếu không có kiểu chữ nào
                    richTextBox1.SelectionFont = new Font(currentFontName, selectedSize);
                }
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null && toolStripComboBox1.SelectedItem != null)
            {
                string selectedFont = toolStripComboBox1.SelectedItem.ToString();
                float currentSize = richTextBox1.SelectionFont.Size;

                // Cập nhật kiểu chữ cho văn bản được chọn
                richTextBox1.SelectionFont = new Font(selectedFont, currentSize);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            // Thiết lập lại kiểu chữ và cỡ chữ mặc định
            richTextBox1.Font = new Font("Tahoma", 12);
            richTextBox1.ForeColor = Color.Black;

            // Nếu bạn muốn hiển thị một thông báo cho người dùng
            MessageBox.Show("Một văn bản mới đã được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }

            // Gán sự kiện SelectedIndexChanged cho ComboBox
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            toolStripComboBox2.SelectedIndexChanged += toolStripComboBox2_SelectedIndexChanged;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;  // Cho phép hiển thị màu sắc
            fontDlg.ShowApply = true;   // Hiển thị nút Apply
            fontDlg.ShowEffects = true;  // Hiển thị hiệu ứng chữ
            fontDlg.ShowHelp = true;     // Hiển thị nút Help

            if (fontDlg.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng ấn OK
            {
                // Thay đổi màu chữ và kiểu chữ trong RichTextBox
                richTextBox1.ForeColor = fontDlg.Color; // Cập nhật màu chữ
                richTextBox1.Font = fontDlg.Font;       // Cập nhật kiểu chữ
            }
        }
    }
}
