using System;
using System.Collections.Generic;
using UIKit;

namespace KeyFinder
{
    public partial class ViewController : UIViewController
    {
       

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        List<string> keyLabels = new List<string> {
            "A",
            "Am",
            "B♭",
            "B♭m",
            "B",
            "Bm",
            "C",
            "Cm",
            "C#m",
            "D♭",
            "D",
            "Dm",
            "D#m",
            "E♭",
            "E♭m",
            "E",
            "Em",
            "F",
            "Fm",
            "F#",
            "F#m",
            "G♭",
            "G",
            "Gm",
            "G#m",
            "A♭"
        };

        List<string> Instruments = new List<string>
        {
            "Alto clarinet", "Alto saxophone","Alto flute","A trumpet", "A soprano clarinet", "Baritone bugle","Basset clarinet (treble clef)",
            "Basset clarinet (bass clef)", "Basset horn", "bass trumpet", "Baritone horn","Bass saxophone",
            "Contrabass clarinet","Contrabass saxophone","Contrabass bugle","Contrabassoon","Contraforte","Contrabass flute","Contra-alto flute","Contra-alto clarinet","Cor anglais",
            "D clarinet","D bass trumpet","D trumpet","Descant horn",
            "D♭ piccolo","Piccolo trumpet (B♭)", "B♭ tuba (treble clef)","E♭ trumpet","E♭ clarinet", "E♭ tuba (treble clef)","E♭ bass trumpet","E trumpet","Euphonium bugle","Euphonium",
            "F trumpet", "F piccolo oboe", "F alto saxophone", "F baritone saxophone", "French horn bugle", "Folk B♭ fife", "Flugelhorn", 
            "Great Highland Bagpipe", "G soprano clarinet", "G basset horn", "G subcontrabass flute", "Horn (treble clef)", "Horn (bass clef)", 
            "Mellophone", "Mellophone bugle", 
            "Octocontra-alto clarinet", "Oud", "Oboe d'amore", 
            "Piccolo clarinet", "Piccolo trumpet",
            "Soprano cornet", "Sopranino saxophone", "Soprano recorder", "Soprano bugle", "Sopranissimo saxophone", "Subcontrabass saxophone", 
            "Tenor horn","Tenor trombone","Tenor saxophone","Tenor Wagner tuba", "Treble flute", "Trumpet",  

        };

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var keyModel = new KeyPickerModel(keyLabels);
            keyPickerLabel.Model = keyModel;



            var instrumentModel = new InstrumentPickerModel(Instruments);
            instrumentPicker.Model = instrumentModel;

            //Send keypicker value and instrumentpicker value to function 
            string FinalKeyString = "";

            KeyFinderButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                FinalKeyString = KeyFinderFunctions.KeyFinderFunc(
                    keyModel.SelectedValue, instrumentModel.SelectedValue);

                FinalKeyLabel.Text = FinalKeyString;
            };

                
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }



};
