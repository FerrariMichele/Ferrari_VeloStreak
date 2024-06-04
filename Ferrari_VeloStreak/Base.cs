namespace Ferrari_VeloStreak
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
       
        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form viewedForm;
            viewedForm = panelForm.Controls.OfType<MyForm>().FirstOrDefault();
            if (viewedForm == null)
            {
                viewedForm = new MyForm();
                viewedForm.TopLevel = false;
                viewedForm.FormBorderStyle = FormBorderStyle.None;
                viewedForm.Dock = DockStyle.Fill;
                panelForm.Controls.Add(viewedForm);
                panelForm.Tag = viewedForm;
                viewedForm.Show();
                viewedForm.BringToFront();
            }
            else
            {
                viewedForm.BringToFront();
            }
        }
        private void CloseForms()
        {
            Form[] forms = new Form[panelForm.Controls.Count];
            for (int i = 0; i < panelForm.Controls.Count; i++)
            {
                forms[i] = panelForm.Controls[i] as Form;
            }
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
    }
}
