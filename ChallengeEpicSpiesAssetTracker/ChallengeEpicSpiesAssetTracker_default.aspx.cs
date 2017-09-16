using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class ChallengeEpicSpiesAssetTracker_default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                ViewState.Add("Names", assetName);

                double[] electionsRigged = new double[0];
                ViewState.Add("Elections", electionsRigged);
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            /*string[] assetName = (string[])ViewState["Names"]);

            Array.Resize(ref assetName, assetName.Length + 1);

            string newName = assetName.GetUpperBound(0);

            assetName[newName] = assetNameTextBox.Text();
            */
          
            double[] electionsRigged = (double[])ViewState["Elections"];

            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);

            int newInput = electionsRigged.GetUpperBound(0);

            electionsRigged[newInput] = double.Parse(electionsRiggedBox.Text);

            ViewState["Elections"] = electionsRigged;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Acts of Subterfuge Performed: {1:N2}<br />(Last Asset you Added: " + assetNameTextBox.Text + ")",
                electionsRigged.Sum(),
                electionsRigged.Average()
                );

            assetNameTextBox.Text = "";
            electionsRiggedBox.Text = "";
            actsSubterfugeBox.Text = "";
        }       
                
    }
}