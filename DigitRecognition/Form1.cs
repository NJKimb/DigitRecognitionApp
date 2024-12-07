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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(147, 129);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 0;
            button1.Text = "Infer Number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 161);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // Form
            // 
            ClientSize = new Size(494, 422);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.On_Click();
        }
        
        public void On_Click_View(String result)
        {
            label1.Text = result;
        }
    }
}
