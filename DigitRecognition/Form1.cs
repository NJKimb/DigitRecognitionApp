using System.Xml.Serialization;
using System.Diagnostics;

namespace Digit_Recognition
{
    public partial class Form : System.Windows.Forms.Form
    {
        Presenter presenter;
        public Form()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        private void InitializeComponent()
        {
            submit_button = new Button();
            result_text = new Label();
            SuspendLayout();
            // 
            // submit_button
            // 
            submit_button.Location = new Point(166, 103);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(157, 46);
            submit_button.TabIndex = 0;
            submit_button.Text = "Infer Number";
            submit_button.UseVisualStyleBackColor = true;
            submit_button.Click += submit_click;
            // 
            // result_text
            // 
            result_text.AutoSize = true;
            result_text.Location = new Point(150, 161);
            result_text.Name = "result_text";
            result_text.Size = new Size(0, 32);
            result_text.TabIndex = 1;
            // 
            // Form
            // 
            ClientSize = new Size(523, 422);
            Controls.Add(result_text);
            Controls.Add(submit_button);
            Name = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        private void submit_click(object sender, EventArgs e)
        {
            string file = get_file();
            string result = presenter.submit_file(file);
            result_text.Text = result;
        }
        private string get_file()
        {
            var dialogue = new OpenFileDialog()
            {
                InitialDirectory = "c:",
                RestoreDirectory = true
            };

            if (dialogue.ShowDialog() != DialogResult.OK)
                return "";

            return dialogue.FileName;
        }
    }
}
