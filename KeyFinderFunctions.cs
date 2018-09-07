using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics.Contracts;

namespace KeyFinder
{
    public static class KeyFinderFunctions
    {
        public static string KeyFinderFunc(string StKey = null, string Instrument = null)
        {

            if (StKey == null) {
                StKey = "A";
            }
            if (Instrument == null) {
                Instrument = "Alto clarinet";
            }

            string tonality = TonalityCheck(StKey);

            ArrayList ReducedKeys = KeyReducer(tonality, StKey);

            int step = StepFinder(Instrument);

            string UpDown = StepDirection(Instrument);

            string FinalKey = FinalKeyFinder(ReducedKeys, step, UpDown, StKey);

            return FinalKey;
        }

        public static string TonalityCheck(string StKey) 
        {
            if ("AB♭CD♭DE♭EFF#G♭GA♭".Contains(StKey))
            {
                return "major";
            } else {
                return "minor";
            }
            
        }

        static ArrayList KeyReducer(string tonality, string StKey)
        {
            Contract.Ensures(Contract.Result<ArrayList>() != null);
            ArrayList ReducedKeys = new ArrayList();
            if (tonality == "major") {
                if ("ABCDEF#G".Contains(StKey)) {
                    ReducedKeys.Add('A');
                    ReducedKeys.Add("B♭");
                    ReducedKeys.Add('B');
                    ReducedKeys.Add('C');
                    ReducedKeys.Add("D♭");
                    ReducedKeys.Add('D');
                    ReducedKeys.Add("E♭");
                    ReducedKeys.Add('E');
                    ReducedKeys.Add('F');
                    ReducedKeys.Add("F#");
                    ReducedKeys.Add('G');
                    ReducedKeys.Add("A♭");

                    ReducedKeys.Add('A');
                    ReducedKeys.Add("B♭");
                    ReducedKeys.Add('B');
                    ReducedKeys.Add('C');
                    ReducedKeys.Add("D♭");
                    ReducedKeys.Add('D');
                    ReducedKeys.Add("E♭");
                    ReducedKeys.Add('E');
                    ReducedKeys.Add('F');
                    ReducedKeys.Add("F#");
                    ReducedKeys.Add('G');
                    ReducedKeys.Add("A♭");

                    return ReducedKeys;
                } else {
                    ReducedKeys.Add('A');
                    ReducedKeys.Add("B♭");
                    ReducedKeys.Add('B');
                    ReducedKeys.Add('C');
                    ReducedKeys.Add("D♭");
                    ReducedKeys.Add('D');
                    ReducedKeys.Add("E♭");
                    ReducedKeys.Add('E');
                    ReducedKeys.Add('F');
                    ReducedKeys.Add("G♭");
                    ReducedKeys.Add('G');
                    ReducedKeys.Add("A♭");

                    ReducedKeys.Add('A');
                    ReducedKeys.Add("B♭");
                    ReducedKeys.Add('B');
                    ReducedKeys.Add('C');
                    ReducedKeys.Add("D♭");
                    ReducedKeys.Add('D');
                    ReducedKeys.Add("E♭");
                    ReducedKeys.Add('E');
                    ReducedKeys.Add('F');
                    ReducedKeys.Add("G♭");
                    ReducedKeys.Add('G');
                    ReducedKeys.Add("A♭");

                    return ReducedKeys;
                }
            } else {
                if ("ABC#D#EF#G#".Contains(StKey)) {
                    ReducedKeys.Add("Am");
                    ReducedKeys.Add("B♭m");
                    ReducedKeys.Add("Bm");
                    ReducedKeys.Add("Cm");
                    ReducedKeys.Add("C#m");
                    ReducedKeys.Add("Dm");
                    ReducedKeys.Add("D#m");
                    ReducedKeys.Add("Em");
                    ReducedKeys.Add("Fm");
                    ReducedKeys.Add("F#m");
                    ReducedKeys.Add("Gm");
                    ReducedKeys.Add("G#m");

                    ReducedKeys.Add("Am");
                    ReducedKeys.Add("B♭m");
                    ReducedKeys.Add("Bm");
                    ReducedKeys.Add("Cm");
                    ReducedKeys.Add("C#m");
                    ReducedKeys.Add("Dm");
                    ReducedKeys.Add("D#m");
                    ReducedKeys.Add("Em");
                    ReducedKeys.Add("Fm");
                    ReducedKeys.Add("F#m");
                    ReducedKeys.Add("Gm");
                    ReducedKeys.Add("G#m");

                    return ReducedKeys;
                } else {
                    ReducedKeys.Add("Am");
                    ReducedKeys.Add("B♭m");
                    ReducedKeys.Add("Bm");
                    ReducedKeys.Add("Cm");
                    ReducedKeys.Add("C#m");
                    ReducedKeys.Add("Dm");
                    ReducedKeys.Add("E♭m");
                    ReducedKeys.Add("Em");
                    ReducedKeys.Add("Fm");
                    ReducedKeys.Add("F#m");
                    ReducedKeys.Add("Gm");
                    ReducedKeys.Add("G#m");

                    ReducedKeys.Add("Am");
                    ReducedKeys.Add("B♭m");
                    ReducedKeys.Add("Bm");
                    ReducedKeys.Add("Cm");
                    ReducedKeys.Add("C#m");
                    ReducedKeys.Add("Dm");
                    ReducedKeys.Add("E♭m");
                    ReducedKeys.Add("Em");
                    ReducedKeys.Add("Fm");
                    ReducedKeys.Add("F#m");
                    ReducedKeys.Add("Gm");
                    ReducedKeys.Add("G#m");

                    return ReducedKeys;
                }
            }
        }

        public static int StepFinder(string Instrument)
        {
            if ("Piccolo soprano bugle Treble flute Soprano recorder Alto flute G soprano clarinet Soprano bugle Mellophone bugle French horn bugle Contra-alto flute Baritone bugle Euphonium bugle Oud G subcontrabass flute Contrabass bugle".Contains(Instrument)) {
                return 5; 
            } else if ("Piccolo clarinet Csakan A♭ soprano clarinet Folk B♭ fife".Contains(Instrument)) {
                return 4; 
            } else if ("Basset clarinet (bass clef) A flûte d'amour Voice flute Oboe d'amore A soprano clarinet Basset clarinet (treble clef) A trumpet".Contains(Instrument)) {
                return 3;
            } else if ("Piccolo trumpet (B♭) Sopranissimo saxophone B♭ flûte d'amour B♭ clarinet Soprano saxophone Tenor Wagner tuba Trumpet Cornet Flugelhorn Bass clarinet B♭ marching horn Bass clarinet Tenor saxophone Euphonium Baritone horn Tenor trombone Tenor Wagner tuba B♭ tuba (treble clef) Contrabass clarinet Bass saxophone B♭ octocontrabass clarinet Subcontrabass saxophone".Contains(Instrument)) {
                return 2;
            } else if ("D♭ piccolo Great Highland Bagpipe".Contains(Instrument)) {
                return 1;
            } else if ("D clarinet D trumpet D bass trumpet".Contains(Instrument)) {
                return 2;
            } else if ("E♭ clarinet E♭ trumpet Soprano cornet Sopranino saxophone Alto clarinet Alto saxophone Tenor horn E♭ bass trumpet Contra-alto clarinet Baritone saxophone E♭ tuba (treble clef) Octocontra-alto clarinet Contrabass saxophone".Contains(Instrument)) {
                return 3;
            } else if ("F trumpet Descant horn F piccolo oboe Horn (bass clef) Cor anglais Horn Mellophone Bass Wagner tuba Basset horn F alto saxophone F baritone saxophone".Contains(Instrument)) {
                return 5;
            } else {
                return 4;
            }
        }

        public static string StepDirection(string Instrument)
        {
            if ("Piccolo soprano bugle Treble flute Soprano recorder Alto flute G soprano clarinet Soprano bugle Mellophone bugle French horn bugle Contra-alto flute Baritone bugle Euphonium bugle Oud G subcontrabass flute Contrabass bugle Piccolo clarinet Csakan A♭ soprano clarinet Folk B♭ fife Basset clarinet (bass clef) A flûte d'amour Voice flute Oboe d'amore A soprano clarinet Basset clarinet (treble clef) A trumpet Piccolo trumpet (B♭) Sopranissimo saxophone B♭ flûte d'amour B♭ clarinet Soprano saxophone Tenor Wagner tuba Trumpet Cornet Flugelhorn Bass clarinet B♭ marching horn Bass clarinet Tenor saxophone Euphonium Baritone horn Tenor trombone Tenor Wagner tuba B♭ tuba (treble clef) Contrabass clarinet Bass saxophone B♭ octocontrabass clarinet Subcontrabass saxophone".Contains(Instrument)) {
                return "Up";
            } else {
                return "Down";  
            }
        }
        public static string FinalKeyFinder(ArrayList ReducedKeys, int Step,
                                            string UpDown, String StKey)
        {
            if (UpDown == "Up")
            {
                for (int i = 0; i < ReducedKeys.Count; i++) {
                    if (StKey == ReducedKeys[i].ToString()) {
                        string FinalKey = ReducedKeys[i + Step].ToString();

                        return FinalKey;
                    } else {
                        continue;
                    }
                }
            } else {
                for (int i = ReducedKeys.Count-1; i >= 0; i--) {
                    if (StKey == ReducedKeys[i].ToString()) {
                        string FinalKey = ReducedKeys[i - Step].ToString();

                        return FinalKey;
                    } else {
                        continue;
                    }
                }
            }
            return "null";
            
        }

        static bool Contains(this string keyString, char c)
        {
            return keyString.IndexOf(c) >= 0;
        }
    }
}
