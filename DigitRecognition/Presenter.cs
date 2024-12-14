using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digit_Recognition
{
    internal class Presenter
    {
        Form view;
        Model model;
        public Presenter(Form form) {
            this.view = form;
            model = new Model();
        }

        public string submit_file(string file)
        {
            String result = model.Python_Prediction(file);
            return result;
        }
    }
}
