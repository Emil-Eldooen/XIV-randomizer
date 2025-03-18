using System.Linq.Expressions;
using System.Xml.Linq;

namespace XIV_rnadomizer
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        //All the classes in the game
        List<String> allClasses = new List<string> {"WAR", "PLD", "DRK", "GBN", "WHM", "SCH", "AST", "SGE", "MNK", "DRG", "NIN", "SAM", "RPR", "BRD", "MCH", "DNC", "BLM", "SMN", "RDM"};
        Random rand = new Random();
        Boolean useImage = false;
        //Renders the window
        public MainPage()
        {
            InitializeComponent();
        }

        //When button is clicked, random role and class is picked
        private void OnCounterClicked(object sender, EventArgs e)
        {
            int nextRole = rand.Next(allClasses.Count);
            if (allClasses.Count > 0)
            {
                String chosenClass = allClasses[nextRole];
                TextArea.Text = $"Your class is {chosenClass}";
                ClassIcon.Source = chosenClass + ".png";
            }
            else
            {
                TextArea.Text = $"You removed all the classes, please tick some boxes!";
                ClassIcon.Source = "meteor.png";
            }
            
            
            
            SemanticScreenReader.Announce(TextArea.Text);
        } 
        private void selectAll(Object sender, EventArgs args)
        {
            CheckBox allCheck = sender as CheckBox;

            String role = allCheck.StyleId.ToLower();

            bool checkStatus = allCheck.IsChecked;
            switch (role)
            {
                
                case "tanks":
                    WAR.IsChecked = PLD.IsChecked = DRK.IsChecked = GBN.IsChecked = checkStatus;
                    break;
                
                case "healers":
                    WHM.IsChecked = SCH.IsChecked = AST.IsChecked = SGE.IsChecked = checkStatus;
                    break;
                
                case "melees":
                    MNK.IsChecked = DRG.IsChecked = NIN.IsChecked = SAM.IsChecked = RPR.IsChecked = checkStatus;
                    break;
                
                case "physranged":
                    BRD.IsChecked = MCH.IsChecked = DNC.IsChecked = checkStatus;
                    break;

                case "casters":
                    BLM.IsChecked = RDM.IsChecked = SMN.IsChecked = checkStatus;
                    break;
            }
            
        }
        private void checkChange (object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            String sentClass = cb.StyleId;
            bool checkStatus = cb.IsChecked;

            //The checkbox IDs have the same name as the class being added/removed
            if (checkStatus)
            {
                allClasses.Add(sentClass);
            }
            else
            {
                allClasses.Remove(sentClass);
            }
            /*if (checkStatus)
            {
                
                if (!magic.Contains(sentClass))
                {
                    magic.Add(sentClass);
                    classes[magicType] = magic;
                }
            }
            if(!checkStatus)
            {
                if (magic.Contains(sentClass)){
                    magic.Remove(sentClass);
                    classes[magicType] = magic;
                }*/
        }
    }
}