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

        public void On_Click()
        {
            String result = model.Python_Prediction();
            view.On_Click_View(result);
        }
    }
}
