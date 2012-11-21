using System;
using System.Collections.Generic;
using System.Text;

namespace LaVie
{
    class MusicBox
    {
        /// <summary>
        /// Possible notes; "s" for sharps, "b" for flats
        /// </summary>
        internal enum Notes
        {
            C0,
            Cs0,
            Db0,
            D0,
            Ds0,
            Eb0,
            E0,
            F0,
            Fs0,
            Gb0,
            G0,
            Gs0,
            Ab0,
            A0,
            As0,
            Bb0,
            B0,
            C1,
            Cs1,
            Db1,
            D1,
            Ds1,
            Eb1,
            E1,
            F1,
            Fs1,
            Gb1,
            G1,
            Gs1,
            Ab1,
            A1,
            As1,
            Bb1,
            B1,
            C2,
            Cs2,
            Db2,
            D2,
            Ds2,
            Eb2,
            E2,
            F2,
            Fs2,
            Gb2,
            G2,
            Gs2,
            Ab2,
            A2,
            As2,
            Bb2,
            B2,
            C3,
            Cs3,
            Db3,
            D3,
            Ds3,
            Eb3,
            E3,
            F3,
            Fs3,
            Gb3,
            G3,
            Gs3,
            Ab3,
            A3,
            As3,
            Bb3,
            B3,
            C4,
            Cs4,
            Db4,
            D4,
            Ds4,
            Eb4,
            E4,
            F4,
            Fs4,
            Gb4,
            G4,
            Gs4,
            Ab4,
            A4,
            As4,
            Bb4,
            B4,
            C5,
            Cs5,
            Db5,
            D5,
            Ds5,
            Eb5,
            E5,
            F5,
            Fs5,
            Gb5,
            G5,
            Gs5,
            Ab5,
            A5,
            As5,
            Bb5,
            B5,
            C6,
            Cs6,
            Db6,
            D6,
            Ds6,
            Eb6,
            E6,
            F6,
            Fs6,
            Gb6,
            G6,
            Gs6,
            Ab6,
            A6,
            As6,
            Bb6,
            B6,
            C7,
            Cs7,
            Db7,
            D7,
            Ds7,
            Eb7,
            E7,
            F7,
            Fs7,
            Gb7,
            G7,
            Gs7,
            Ab7,
            A7,
            As7,
            Bb7,
            B7,
            C8,
            Cs8,
            Db8,
            D8,
            Ds8,
            Eb8
        }

        /// <summary>
        /// Play a musical note
        /// </summary>
        /// <param name="note">note to play</param>
        /// <param name="duration">duration in ms</param>
        internal static void PlayNote(Notes note, int duration)
        {
            Console.Beep(GetNote(note), duration);
        }

        /// <summary>
        /// Play some notes on start up
        /// </summary>
        /// <param name="tempo">(optional) tempo for notes</param>
        internal static void StartUpSong(int tempo = 400)
        {
            int m = (int)Math.Round(CalculateTimeMultiplier(tempo, 2));
            //dun dun da daaan
            PlayNote(Notes.C4, m * 2);
            PlayNote(Notes.C4, m * 2);
            PlayNote(Notes.C4, m * 1);
            PlayNote(Notes.F4, m * 5);
        }

        /// <summary>
        /// play the first few notes of Beethoven's 5th
        /// </summary>
        /// <param name="tempo">(optional) tempo for notes</param>
        internal static void Beethovens5th(int tempo = 132)
        {
            int m = (int)Math.Round(CalculateTimeMultiplier(tempo, 2));
            //beethoven's 5th
            PlayNote(Notes.F4, m * 1);
            PlayNote(Notes.F4, m * 1);
            PlayNote(Notes.F4, m * 1);
            PlayNote(Notes.D4, m * 4);
        }

        internal static void LaVieEnRose()
        {
            int m = 500;

            //intro
            LaVieEnRoseIntro(m);

            //kick up the tempo
            m = 250;

            //repeat
            LaVieEnRoseRepeat(m);

            //ending 1
            LaVieEnRoseEnding1(m);

            //repeat
            LaVieEnRoseRepeat(m);

            //ending 2
            LaVieEnRoseEnding2(m);
        }
        internal static void WestminsterChimes(int tempo = 132)
        {
            int m = (int)Math.Round(CalculateTimeMultiplier(tempo, 1));

            //westminster chimes (FCGD sharps)
            //E. G#. F#. B... / E. F#. G#. E... / G#. E. F#. B... / B. F#. G#. E... / low E......
            PlayNote(Notes.E4, m * 1);
            PlayNote(Notes.Gs4, m * 1);
            PlayNote(Notes.Fs4, m * 1);
            PlayNote(Notes.B3, m * 3);

            PlayNote(Notes.E4, m * 1);
            PlayNote(Notes.Fs4, m * 1);
            PlayNote(Notes.Gs4, m * 1);
            PlayNote(Notes.E4, m * 3);

            PlayNote(Notes.Gs4, m * 1);
            PlayNote(Notes.E4, m * 1);
            PlayNote(Notes.Fs4, m * 1);
            PlayNote(Notes.B3, m * 3);

            PlayNote(Notes.B3, m * 1);
            PlayNote(Notes.Fs4, m * 1);
            PlayNote(Notes.Gs4, m * 1);
            PlayNote(Notes.E4, m * 3);

            PlayNote(Notes.E3, m * 6);
        }
        internal static void InTheHallOfTheMountainKing(int tempo = 138)
        {
            int m = (int)Math.Round(CalculateTimeMultiplier(tempo, 2));

            //(FC sharp) in the hall of the mountain king
            PlayNote(Notes.G3, m * 1);
            PlayNote(Notes.A3, m * 1);
            PlayNote(Notes.B3, m * 1);
            PlayNote(Notes.Cs4, m * 1);
            PlayNote(Notes.D4, m * 1);
            PlayNote(Notes.B3, m * 1);
            PlayNote(Notes.D4, m * 2);

            PlayNote(Notes.Cs4, m * 1);
            PlayNote(Notes.A3, m * 1);
            PlayNote(Notes.Cs4, m * 2);
            PlayNote(Notes.C4, m * 1);
            PlayNote(Notes.A3, m * 1);
            PlayNote(Notes.C4, m * 2);

            PlayNote(Notes.G3, m * 1);
            PlayNote(Notes.A3, m * 1);
            PlayNote(Notes.B3, m * 1);
            PlayNote(Notes.Cs4, m * 1);
            PlayNote(Notes.D4, m * 1);
            PlayNote(Notes.B3, m * 1);
            PlayNote(Notes.D4, m * 1);
            PlayNote(Notes.G4, m * 1);

            PlayNote(Notes.Fs4, m * 1);
            PlayNote(Notes.D4, m * 1);
            PlayNote(Notes.B3, m * 1);
            PlayNote(Notes.D4, m * 1);
            PlayNote(Notes.Fs4, m * 4);
        }

        /// <summary>
        /// Get the frequency for Console.Beep for a particular note
        /// </summary>
        /// <param name="note">The target note</param>
        /// <returns>Frequency of note</returns>
        private static int GetNote(Notes note)
        {
            switch (note)
            {
                case Notes.C0: return 16;
                case Notes.Cs0: return 17;
                case Notes.Db0: return 17;
                case Notes.D0: return 18;
                case Notes.Ds0: return 19;
                case Notes.Eb0: return 19;
                case Notes.E0: return 21;
                case Notes.F0: return 22;
                case Notes.Fs0: return 23;
                case Notes.Gb0: return 23;
                case Notes.G0: return 25;
                case Notes.Gs0: return 26;
                case Notes.Ab0: return 26;
                case Notes.A0: return 28;
                case Notes.As0: return 29;
                case Notes.Bb0: return 29;
                case Notes.B0: return 31;
                case Notes.C1: return 33;
                case Notes.Cs1: return 35;
                case Notes.Db1: return 35;
                case Notes.D1: return 37;
                case Notes.Ds1: return 39;
                case Notes.Eb1: return 39;
                case Notes.E1: return 41;
                case Notes.F1: return 44;
                case Notes.Fs1: return 46;
                case Notes.Gb1: return 46;
                case Notes.G1: return 49;
                case Notes.Gs1: return 52;
                case Notes.Ab1: return 52;
                case Notes.A1: return 55;
                case Notes.As1: return 58;
                case Notes.Bb1: return 58;
                case Notes.B1: return 62;
                case Notes.C2: return 65;
                case Notes.Cs2: return 69;
                case Notes.Db2: return 69;
                case Notes.D2: return 73;
                case Notes.Ds2: return 78;
                case Notes.Eb2: return 78;
                case Notes.E2: return 82;
                case Notes.F2: return 87;
                case Notes.Fs2: return 93;
                case Notes.Gb2: return 93;
                case Notes.G2: return 98;
                case Notes.Gs2: return 104;
                case Notes.Ab2: return 104;
                case Notes.A2: return 110;
                case Notes.As2: return 117;
                case Notes.Bb2: return 117;
                case Notes.B2: return 123;
                case Notes.C3: return 131;
                case Notes.Cs3: return 139;
                case Notes.Db3: return 139;
                case Notes.D3: return 147;
                case Notes.Ds3: return 156;
                case Notes.Eb3: return 156;
                case Notes.E3: return 165;
                case Notes.F3: return 175;
                case Notes.Fs3: return 185;
                case Notes.Gb3: return 185;
                case Notes.G3: return 196;
                case Notes.Gs3: return 208;
                case Notes.Ab3: return 208;
                case Notes.A3: return 220;
                case Notes.As3: return 233;
                case Notes.Bb3: return 233;
                case Notes.B3: return 247;
                case Notes.C4: return 262;
                case Notes.Cs4: return 277;
                case Notes.Db4: return 277;
                case Notes.D4: return 294;
                case Notes.Ds4: return 311;
                case Notes.Eb4: return 311;
                case Notes.E4: return 330;
                case Notes.F4: return 349;
                case Notes.Fs4: return 370;
                case Notes.Gb4: return 370;
                case Notes.G4: return 392;
                case Notes.Gs4: return 415;
                case Notes.Ab4: return 415;
                case Notes.A4: return 440;
                case Notes.As4: return 466;
                case Notes.Bb4: return 466;
                case Notes.B4: return 494;
                case Notes.C5: return 523;
                case Notes.Cs5: return 554;
                case Notes.Db5: return 554;
                case Notes.D5: return 587;
                case Notes.Ds5: return 622;
                case Notes.Eb5: return 622;
                case Notes.E5: return 659;
                case Notes.F5: return 698;
                case Notes.Fs5: return 740;
                case Notes.Gb5: return 740;
                case Notes.G5: return 784;
                case Notes.Gs5: return 831;
                case Notes.Ab5: return 831;
                case Notes.A5: return 880;
                case Notes.As5: return 932;
                case Notes.Bb5: return 932;
                case Notes.B5: return 988;
                case Notes.C6: return 1047;
                case Notes.Cs6: return 1109;
                case Notes.Db6: return 1109;
                case Notes.D6: return 1175;
                case Notes.Ds6: return 1245;
                case Notes.Eb6: return 1245;
                case Notes.E6: return 1319;
                case Notes.F6: return 1397;
                case Notes.Fs6: return 1480;
                case Notes.Gb6: return 1480;
                case Notes.G6: return 1568;
                case Notes.Gs6: return 1661;
                case Notes.Ab6: return 1661;
                case Notes.A6: return 1760;
                case Notes.As6: return 1865;
                case Notes.Bb6: return 1865;
                case Notes.B6: return 1976;
                case Notes.C7: return 2093;
                case Notes.Cs7: return 2217;
                case Notes.Db7: return 2217;
                case Notes.D7: return 2349;
                case Notes.Ds7: return 2489;
                case Notes.Eb7: return 2489;
                case Notes.E7: return 2637;
                case Notes.F7: return 2794;
                case Notes.Fs7: return 2960;
                case Notes.Gb7: return 2960;
                case Notes.G7: return 3136;
                case Notes.Gs7: return 3322;
                case Notes.Ab7: return 3322;
                case Notes.A7: return 3520;
                case Notes.As7: return 3729;
                case Notes.Bb7: return 3729;
                case Notes.B7: return 3951;
                case Notes.C8: return 4186;
                case Notes.Cs8: return 4435;
                case Notes.Db8: return 4435;
                case Notes.D8: return 4699;
                case Notes.Ds8: return 4978;
                case Notes.Eb8: return 4978;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Calculate the time multiplier for a beep based on a tempo in beats per minute
        /// </summary>
        /// <param name="tempo">tempo, in beats per minute</param>
        /// <param name="valueOfQuarterNote">multiplier used for quarter notes in calculations</param>
        /// <returns></returns>
        private static double CalculateTimeMultiplier(double tempo, double valueOfQuarterNote)
        {
            if (valueOfQuarterNote == 0) valueOfQuarterNote = 1; //don't want a div by 0

            double multiplier = ((60 / tempo) * 1000) / valueOfQuarterNote;
            return multiplier;
        }

        private static void LaVieEnRoseIntro(int m)
        {
            //rest for 2.5 beats (5 * m)
            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E5, 1 * m);

            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.B4, 1 * m);
            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.F5, 1 * m);
            PlayNote(Notes.F5, 1 * m);
            PlayNote(Notes.E5, 1 * m);

            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.Cs5, 1 * m);
            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.F5, 1 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.F5, 1 * m);

            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.F5, 1 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.G5, 1 * m);

            PlayNote(Notes.G5, 2 * m);
            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.F5, 1 * m);
            PlayNote(Notes.G5, 2 * m);
        }

        private static void LaVieEnRoseRepeat(int m)
        {
            PlayNote(Notes.C5, 3 * m);
            PlayNote(Notes.B4, 1 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.B4, 3 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C4, 1 * m);
            PlayNote(Notes.B4, 1 * m);

            PlayNote(Notes.A4, 3 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.B3, 1 * m);
            PlayNote(Notes.C4, 1 * m);
            PlayNote(Notes.B4, 1 * m);

            PlayNote(Notes.A4, 4 * m);
            PlayNote(Notes.G4, 4 * m);

            PlayNote(Notes.D5, 3 * m);
            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.B4, 1 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.F4, 1 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.B4, 3 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.F4, 1 * m);
            PlayNote(Notes.D4, 1 * m);
            PlayNote(Notes.B4, 1 * m);

            PlayNote(Notes.A4, 3 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.F4, 1 * m);
            PlayNote(Notes.Cs4, 1 * m);
            PlayNote(Notes.D4, 1 * m);
            PlayNote(Notes.B4, 1 * m);

            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.B4, 2 * m);

            PlayNote(Notes.C5, 3 * m);
            PlayNote(Notes.B4, 1 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.B4, 3 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C4, 1 * m);
            PlayNote(Notes.B4, 1 * m);

            PlayNote(Notes.A4, 3 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.B3, 1 * m);
            PlayNote(Notes.C4, 1 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.C5, 8 * m);

            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.D5, 2 * m);
            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.D5, 2 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.D5, 2 * m);
            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.G4, 4 * m);

            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.D5, 2 * m);
            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.D5, 2 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.D5, 1 * m);
            PlayNote(Notes.D5, 2 * m);
            PlayNote(Notes.C5, 1 * m);
            PlayNote(Notes.E5, 2 * m);
            PlayNote(Notes.D5, 2 * m);
        }

        private static void LaVieEnRoseEnding1(int m)
        {
            PlayNote(Notes.C5, 3 * m);
            PlayNote(Notes.B4, 1 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.B4, 3 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C4, 1 * m);
            PlayNote(Notes.A4, 1 * m);

            PlayNote(Notes.A4, 3 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.A4, 2 * m);
            PlayNote(Notes.B4, 2 * m);

            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.B4, 2 * m);
        }

        private static void LaVieEnRoseEnding2(int m)
        {
            PlayNote(Notes.C5, 3 * m);
            PlayNote(Notes.B4, 1 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C5, 1 * m);

            PlayNote(Notes.B4, 3 * m);
            PlayNote(Notes.A4, 1 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.E4, 1 * m);
            PlayNote(Notes.C4, 1 * m);
            PlayNote(Notes.A4, 1 * m);

            PlayNote(Notes.A4, 3 * m);
            PlayNote(Notes.G4, 1 * m);
            PlayNote(Notes.A4, 2 * m);
            PlayNote(Notes.B4, 2 * m);

            PlayNote(Notes.C5, 2 * m);
            PlayNote(Notes.G5, 1 * m);
            PlayNote(Notes.E5, 1 * m);
            PlayNote(Notes.G5, 4 * m);
        }
    }
}