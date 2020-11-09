using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiFish_application
{
    public partial class visInformatie : Form
    {
        public visInformatie()
        {
            InitializeComponent();
        }

        private void visInformatie_Load(object sender, EventArgs e)
        {
            Vis[] vissen = new Vis[]
             {
                new Vis("Baars", "Zoetwater", 60, false, false),
                new Vis("Snoek", "Zoetwater", 140, false, false),
                new Vis("katvis", "Zoetwater", 160, false, false),
                new Vis("snoekbaars", "Zoetwater", 120, true, false),
                new Vis("stier haai", "Zoutwater", 240, true, false),
                new Vis("steur", "Zoetwater", 200, true, true),
                new Vis("kabeljauw", "Zoutwater", 150, true, true),
                new Vis("karper", "Zoetwater", 120, true, false),
                new Vis("marene", "Zoetwater", 70, true, true),
                new Vis("zalm", "Zoutwater/Zoetwater", 100, false, false)
             };

            lvVisInformatie.View = View.Details;
            
            lvVisInformatie.Columns.Add("Naam", 69);
            lvVisInformatie.Columns.Add("Soort", 140);
            lvVisInformatie.Columns.Add("Lengte", 50);
            lvVisInformatie.Columns.Add("terug gooien?", 90);
            lvVisInformatie.Columns.Add("bedreigd", 60);

            foreach (Vis vis in vissen)
            {
               /* lvVisInformatie.Items.Add(vis.getNaam);

                lvVisInformatie.Items.Add(vis.getSoortVis);

                lvVisInformatie.Items.Add(Convert.ToString(vis.getMaxLengte));

                lvVisInformatie.Items.Add(vis.convertVisInfoSchermBool(vis.getLosLatenYN));

                lvVisInformatie.Items.Add(vis.convertVisInfoSchermBool(vis.getBedrijgdeSoortYN));*/

                lvVisInformatie.Items.Add(new ListViewItem(new string[] { vis.getNaam, vis.getSoortVis, Convert.ToString(vis.getMaxLengte), vis.convertVisInfoSchermBool(vis.getLosLatenYN), vis.convertVisInfoSchermBool(vis.getBedrijgdeSoortYN) }));
            }
        }
    }
}
