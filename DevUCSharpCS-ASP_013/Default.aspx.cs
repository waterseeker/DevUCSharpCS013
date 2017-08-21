using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            comparisonTypeLabel.Text = "greater than";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);
            //resultLabel.Text = (first > second) ? "Yes" : "No";

            //resultLabel.Text = (!checkedCheckBox.Checked) ? "No" : "Yes";

            resultLabel.Text = ""; //clear the label

            if (checkedCheckBox.Checked
                && firstTextBox.Text == "Testy"
                && secondTextBox.Text == "McTestFace")
            {
                resultLabel.Text = "Perfect trifecta!";
            }
        }
    }
}