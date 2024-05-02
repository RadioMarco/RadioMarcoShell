using Windows.UI.Input.Inking;

namespace RMS2
{
    /// <summary>
    /// Dies ist der Interpretter und Generierer für die Buchstaben, die man zu oberst in der Konsole anzeigen kann
    /// </summary>
    internal class ASCIIWriter
    {
        public static void ASCIIWritingMachine(string Word,int width = 0, int height = 0)
        {
            
            char[] chars = Word.ToUpper().ToCharArray();
            foreach (var item in chars)
            {
                char letter = item;
                if (width >= Console.WindowWidth-10)
                {
                    letter = ' ';
                }
                switch (letter)
                {

                    case 'A':
                        width += LetterA(width,height);
                        break;
                    case 'B':
                        width += LetterB(width,height);
                        break;
                    case 'C':

                        width += LetterC(width,height);
                        break;
                    case 'D':
                        width += LetterD(width,height);
                        break;
                    case 'E':
                        width += LetterE(width, height);
                        break;
                    case 'F':
                        width += LetterF(width, height);
                        break;
                    case 'G':
                        width += LetterG(width, height);
                        break;
                    case 'H':
                        width += LetterH(width,height);
                        break;
                    case 'I':
                        width += LetterI(width,height);
                        break;
                    case 'J':
                        width += LetterJ(width,height);
                        break;
                    case 'K':
                        width += LetterK(width,height);
                        break;
                    case 'L':
                        width += LetterL(width,height);
                        break;
                    case 'M':
                        width += LetterM(width,height);
                        break;
                    case 'N':
                        width += LetterN(width, height);
                        break;
                    case 'O':
                        width += LetterO(width,height);
                        break;
                    case 'P':
                        width += LetterP(width,height);
                        break;
                    case 'Q':
                        width += LetterQ(width, height);
                        break;
                    case 'R':
                        width += LetterR(width, height);
                        break;
                    case 'S':
                        width += LetterS(width, height);
                        break;
                    case 'T':
                        width += LetterT(width, height);
                        break;
                    case 'U':
                        width += LetterU(width, height);
                        break;
                    case 'V':
                        width += LetterV(width, height);
                        break;
                    case 'W':
                        width += LetterW(width, height);
                        break;
                    case 'X':
                        width += LetterX(width, height);
                        break;
                    case 'Y':
                        width += LetterY(width, height);
                        break;
                    case 'Z':
                        width += LetterZ(width, height);
                        break;
                    case '0':
                        width += Number0(width, height);
                        break;
                    case '1':
                        width += Number1(width, height);
                        break;
                    case '2':
                        width += Number2(width, height);
                        break;
                    case '3':
                        width += Number3(width, height);
                        break;
                    case '4':
                        width += Number4(width, height);
                        break;
                    case '5':
                        width += Number5(width, height);
                        break;
                    case '6':
                        width += Number6(width, height);
                        break;
                    case '7':
                        width += Number7(width, height);
                        break;
                    case '8':
                        width += Number8(width, height);
                        break;
                    case '9':
                        width += Number9(width, height);
                        break;
                    case '#':
                        width += RadioMarcoLogo(width, height);
                        break;
                    case ' ':
                        {
                            width += 6;
                            break;
                        }
                    case '_':
                        {
                            width += SignUnderscore(width, height);
                            break;
                        }
                    case '<':
                        {
                            width += SignOpenCornerBracket(width, height);
                            break;
                        }
                    case '>':
                        {
                            width += SignCloseCornerBracket(width, height);
                            break;
                        }
                    case ';':
                        {
                            width += SignSemiColumn(width, height);
                            break;
                        }
                    case ':':
                        {
                            width += SignDoubleColumn(width, height);
                            break;
                        }
                    case '?':
                        {
                            width += SignQuestionmark(width, height);
                            break;
                        }
                    case '!':
                        {
                            width += SignExklamationmark(width, height);
                            break;
                        }
                    case '\'':
                        {
                            width += SignApostroph(width, height);
                            break;
                        }
                    case ',':
                        {
                            width += SignKomma(width, height);
                            break;
                        }
                    case '.':
                        {
                            width += SignColumn(width, height);
                            break;
                        }
                    case '+':
                        {
                            width += SignPlus(width, height);
                            break;
                        }
                    case '-':
                        {
                            width += SignMinus(width, height);
                            break;
                        }
                    case 'Ä':
                        {
                            width += LetterA(width, height);
                            width += LetterE(width, height);
                            break;
                        }
                    case 'Ö':
                        {
                            width += LetterO(width, height);
                            width += LetterE(width, height);
                            break;
                        }
                    case 'Ü':
                        {
                            width += LetterU(width, height);
                            width += LetterE(width, height);
                            break;
                        }
                    case '(':
                        {
                            width += SignOpenRoundBrackets(width, height);
                            break;
                        }
                    case ')':
                        {
                            width += SignColseRoundBrackets(width, height);
                            break;
                        }
                    default:
                        Error.throwCustomError($"char {letter} was not found. Accepted are ABCDEFGHIJKLMNOPQRSTUVWXYZ,0123456789, >_<;:?!',.(or # to display the Radio Marco Logo)");
                        break;
                }
            }


        }
        /// <summary>
        /// Buchstabe 'A'
        /// </summary>
        /// <param name="widthOtherLetters">breite, damit nicht mit anderen Zeichen kolidiert</param>
        /// <param name="height">höhe, für dass der Buchstabe auf einer beliebigen höhe sein kann.</param>
        /// <returns></returns>
        public static int LetterA(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("       A    ");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("      A A   ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("     A   A  ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("    AAAAAAA ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   A       A");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   A       A");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   A       A");
            return 12;
        }
        /// <summary>
        /// Buchstabe 'B'
        /// </summary>
        /// <param name="widthOtherLetters">breite, damit nicht mit anderen Zeichen kolidiert</param>
        /// <param name="height">höhe, für dass der Buchstabe auf einer beliebigen höhe sein kann.</param>
        /// <returns></returns>
        public static int LetterB(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   BBB ");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   B  B");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   B  B");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   BBB ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   B  B");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   B  B");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   BBB ");
            return 7;
        }
        /// <summary>
        /// Buchstabe 'C'
        /// </summary>
        /// <param name="widthOtherLetters">breite, damit nicht mit anderen Zeichen kolidiert</param>
        /// <param name="height">höhe, für dass der Buchstabe auf einer beliebigen höhe sein kann.</param>
        /// <returns></returns>
        public static int LetterC(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("     CCCCC");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("    C     ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   C      ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   C      ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   C      ");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("    C     ");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("     CCCCC");
            return 10;

        }
        /// <summary>
        /// Buchstabe 'D'
        /// </summary>
        /// <param name="widthOtherLetters">breite, damit nicht mit anderen Zeichen kolidiert</param>
        /// <param name="height">höhe, für dass der Buchstabe auf einer beliebigen höhe sein kann.</param>
        /// <returns></returns>
        public static int LetterD(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   DDDDDD  ");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   D     D ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   D      D");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   D      D");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   D      D");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   D     D ");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   DDDDDD  ");

            return 11;
        }
        public static int LetterE(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   EEEEEE");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   E     ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   E     ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   EEEE  ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   E     ");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   E     ");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   EEEEEE");
            return 9;
        }
        public static int LetterF(int widthOtherLetters,int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   FFFFFF");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   F     ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   F     ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   FFFF  ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   F     ");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   F     ");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   F     ");
            return 9;
        }
        public static int LetterG(int widthOtherLetters,int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   GGGGGGGGG");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   G        ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   G        ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   G    GGGG");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   G       G");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   G       G");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   GGGGGGGGG");
            return 12;
        }
        public static int LetterH(int widthOtherLetters,int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters,height+0);
            Console.WriteLine("   H   H");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   H   H");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   H   H");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   HHHHH");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   H   H");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   H   H");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   H   H");
            return 8;
        }
        public static int LetterI(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   I");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   I");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   I");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   I");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   I");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   I");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   I");
            return 4;
        }
        public static int LetterJ(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("        J");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("        J");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("        J");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("        J");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   J    J");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("    J   J");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("     JJJJ");
            return 9;
        }
        public static int LetterK(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   K   K");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   K  K ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   K K  ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   KK   ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   K K  ");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   K  K ");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   K   K");
            return 8;
        }
        public static int LetterL(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   L     ");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   L     ");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   L     ");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   L     ");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   L     ");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   L     ");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   LLLLLL");
            return 9;
        }
        public static int LetterM(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   MM      MM");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   M M    M M");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   M  M  M  M");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   M   MM   M");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   M        M");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   M        M");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   M        M");
            return 13;
        }
        public static int LetterN(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("   NN      N");
            Console.SetCursorPosition(widthOtherLetters, height+1);
            Console.WriteLine("   N N     N");
            Console.SetCursorPosition(widthOtherLetters, height+2);
            Console.WriteLine("   N  N    N");
            Console.SetCursorPosition(widthOtherLetters, height+3);
            Console.WriteLine("   N   N   N");
            Console.SetCursorPosition(widthOtherLetters, height+4);
            Console.WriteLine("   N    N  N");
            Console.SetCursorPosition(widthOtherLetters, height+5);
            Console.WriteLine("   N     N N");
            Console.SetCursorPosition(widthOtherLetters, height+6);
            Console.WriteLine("   N      NN");
            return 13;
        }
        public static int LetterO(int widthOtherLetters, int height = 0)

        {
            Console.SetCursorPosition(widthOtherLetters, height+0);
            Console.WriteLine("      OOOOO   ");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("    O       O ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   O         O");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   O         O");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   O         O");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("    O       O ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("     OOOOOOO  ");
            return 14;
        }
        public static int LetterP(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   PPPP");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   P  P");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   P  P");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   P P ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   P   ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   P   ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   P   ");
            return 7;
        }
        public static int LetterQ(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("      QQQQQ   ");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("    Q       Q ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   Q         Q");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   Q         Q");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   Q     Q   Q");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("    Q     Q Q ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("     QQQQQQQ Q");
            return 14;
        }
        public static int LetterR(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   RRRR");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   R  R");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   R  R");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   R R ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   RR  ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   R R ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   R  R");
            return 7;
        }
        public static int LetterS(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("    SS");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   S  ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   S  ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("    S ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("     S");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("     S");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   SS ");
            return 6;
        }
        public static int LetterT(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   TTTTTTTTT");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("       T    ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("       T    ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("       T    ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("       T    ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("       T    ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("       T    ");
            return 12;
        }
        public static int LetterU(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   U        U");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   U        U");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   U        U");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   U        U");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   U        U");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("    U      U ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("     UUUUUU  ");
            return 14;
        }
        public static int LetterV(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   V     V");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   V     V");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   V     V");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   V     V");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("    V   V ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("     V V  ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("      V   ");
            return 10;
        }
        public static int LetterW(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   W        W");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   W        W");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   W        W");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   W   WW   W");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   W  W  W  W");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   W W    W W");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   WW      WW");
            return 13;
        }
        public static int LetterX(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   X     X");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("    X   X ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("     X X  ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("      X   ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("     X X  ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("    X   X ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   X     X");
            return 10;
        }
        public static int LetterY(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   Y     Y");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("    Y   Y ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("     Y Y  ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("      Y   ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("      Y   ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("      Y   ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("      Y   ");
            return 10;
        }
        public static int LetterZ(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   ZZZZZZZ");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("        Z ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("       Z  ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("      Z   ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("     Z    ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("    Z     ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   ZZZZZZZ");
            return 10;

        }
        public static int Number1(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   111");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("     1");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("     1");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("     1");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("     1");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("     1");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("     1");
            return 9;
        }
        public static int Number2(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   222222");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("        2");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("        2");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   222222");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   2     ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   2     ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   222222");
            return 9;
        }
        public static int Number3(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   333333");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("        3");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("        3");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   333333");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("        3");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("        3");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   333333");
            return 9;
        }
        public static int Number4(int widthOtherLetters,int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   4    4");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   4    4");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   4    4");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   444444");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("        4");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("        4");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("        4");
            return 9;
        }
        public static int Number5(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   555555");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   5     ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   5     ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   555555");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("        5");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("        5");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   555555");
            return 9;
        }
        public static int Number6(int widthOtherLetters,int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   666666");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   6     ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   6     ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   666666");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   6    6");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   6    6");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   666666");
            return 9;
        }
        public static int Number7(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   777777");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("        7");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("        7");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("      777");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("        7");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("        7");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("        7");
            return 9;
        }
        public static int Number8(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   888888");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   8    8");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   8    8");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   888888");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   8    8");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   8    8");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   888888");
            return 9;
        }
        public static int Number9(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   999999");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   9    9");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   9    9");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   999999");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("        9");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("        9");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   999999");

            return 9;
        }
        public static int Number0(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   000000");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   0    0");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   0    0");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   0    0");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   0    0");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("   0    0");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   000000");
            return 9;
        }
        public static int RadioMarcoLogo(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("      #");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("     # ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("    #  ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("###### ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("#    # ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("##  ## ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("###### ");
            return 7;
        }
        public static int SignQuestionmark(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   ????");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   ?  ?");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("      ?");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("     ? ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("    ?  ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("       ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("    ?  ");
            return 7;
        }
        public static int SignExklamationmark(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   !");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("   !");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   !");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   !");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   !");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("    ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   !");
            return 4;
        }
        public static int SignApostroph(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("||||");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("||||");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("||||");

            return 4;
        }
        public static int SignKomma(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("||||");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("||||");
            Console.SetCursorPosition(widthOtherLetters, height + 7);
            Console.WriteLine("////");

            return 4;



        }
        public static int SignColumn(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("....");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("....");

            return 4;



        }
        public static int SignDoubleColumn(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("....");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("....");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("....");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("....");

            return 4;



        }
        public static int SignSemiColumn(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("....");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("....");
            //3
            //4
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("||||");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("||||");
            Console.SetCursorPosition(widthOtherLetters, height + 7);
            Console.WriteLine("////");


            return 4;
        }
        public static int SignOpenCornerBracket(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("          <");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("       <   ");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("     <     ");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   <       ");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("     <     ");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("       <   ");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("          <");
            return 11;
        }
        public static int SignCloseCornerBracket(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   >");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("     >");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("       >");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("         >");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("       >");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("     >");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   >");
            return 11;
        }
        public static int SignUnderscore(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   _________");
            return 13;
        }
        public static int SignPlus(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("         |");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("         |");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("         |");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   ------+------");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("         |");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("         |");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("         |");
            return 16;
        }
        public static int SignMinus(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   -------------");
            return 13;
        }
        public static int SignOpenRoundBrackets(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("       (");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("     (");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("   (");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("   (");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("   (");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("     (");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("       (");
            return 8; 
        }
        public static int SignColseRoundBrackets(int widthOtherLetters, int height = 0)
        {
            Console.SetCursorPosition(widthOtherLetters, height + 0);
            Console.WriteLine("   )");
            Console.SetCursorPosition(widthOtherLetters, height + 1);
            Console.WriteLine("     )");
            Console.SetCursorPosition(widthOtherLetters, height + 2);
            Console.WriteLine("       )");
            Console.SetCursorPosition(widthOtherLetters, height + 3);
            Console.WriteLine("       )");
            Console.SetCursorPosition(widthOtherLetters, height + 4);
            Console.WriteLine("       )");
            Console.SetCursorPosition(widthOtherLetters, height + 5);
            Console.WriteLine("     )");
            Console.SetCursorPosition(widthOtherLetters, height + 6);
            Console.WriteLine("   )");
            return 8;

        }
    }
}
