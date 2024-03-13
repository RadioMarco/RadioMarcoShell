namespace RMS2
{
    internal class ASCIIWriter
    {
        public static void ASCIIWritingMachine(string Word = "#RADIO MARCO")
        {
            Console.Clear();
            int width = 0;
            char[] chars = Word.ToUpper().ToCharArray();
            foreach (var item in chars)
            {
                char letter = item;
                if (width >= Console.WindowWidth)
                {
                    letter = ' ';
                }
                switch (letter)
                {
                    
                    case 'A':
                        width += LetterA(width);
                        break;
                    case 'B':
                        width += LetterB(width);
                        break;
                    case 'C':
                        width += LetterC(width);
                        break;
                    case 'D':
                        width += LetterD(width);
                        break;
                    case 'E':
                        width += LetterE(width);
                        break;
                    case 'F':
                        width += LetterF(width);
                        break;
                    case 'G':
                        width += LetterG(width);
                        break;
                    case 'H':
                        width += LetterH(width);
                        break;
                    case 'I':
                        width += LetterI(width);
                        break;
                    case 'J':
                        width += LetterJ(width);
                        break;
                    case 'K':
                        width += LetterK(width);
                        break;
                    case 'L':
                        width += LetterL(width);
                        break;
                    case 'M':
                        width += LetterM(width);
                        break;
                    case 'N':
                        width += LetterN(width);
                        break;
                    case 'O':
                        width += LetterO(width);
                        break;
                    case 'P':
                        width += LetterP(width);
                        break;
                    case 'Q':
                        width += LetterQ(width);
                        break;
                    case 'R':
                        width += LetterR(width);
                        break;
                    case 'S':
                        width += LetterS(width);
                        break;
                    case 'T':
                        width += LetterT(width);
                        break;
                    case 'U':
                        width += LetterU(width);
                        break;
                    case 'V':
                        width += LetterV(width);
                        break;
                    case 'W':
                        width += LetterW(width);
                        break;
                    case 'X':
                        width += LetterX(width);
                        break;
                    case 'Y':
                        width += LetterY(width);
                        break;
                    case 'Z':
                        width += LetterZ(width);
                        break;
                    case '0':
                        width += Letter0(width);
                        break;
                    case '1':
                        width += Letter1(width);
                        break;
                    case '2':
                        width += Letter2(width);
                        break;
                    case '3':
                        width += Letter3(width);
                        break;
                    case '4':
                        width += Letter4(width);
                        break;
                    case '5':
                        width += Letter5(width);
                        break;
                    case '6':
                        width += Letter6(width);
                        break;
                    case '7':
                        width += Letter7(width);
                        break;
                    case '8':
                        width += Letter8(width);
                        break;
                    case '9':
                        width += Letter9(width);
                        break;
                    case '#':
                        width += RadioMarcoLogo(width);
                        break;
                    case ' ':
                        {
                            width += 6;
                            break;
                        }
                    default:
                        Error.throwCustomError($"char {letter} was not found. Accepted are ABCDEFGHIJKLMNOPQRSTUVWXYZ and 0123456789, (or # to display the Radio Marco Logo)");
                        break;
                }
            }


        }
        public static int LetterA(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("-------A----");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("------A-A---");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("-----A---A--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("----AAAAAAA-");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---A-------A");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---A-------A");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---A-------A");
            return 12;
        }
        public static int LetterB(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---BBB-");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---B--B");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---B--B");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---BBB-");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---B--B");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---B--B");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---BBB-");
            return 7;
        }
        public static int LetterC(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("-----CCCCC");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("----C-----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---C------");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---C------");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---C------");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----C-----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-----CCCCC");
            return 10;

        }
        public static int LetterD(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---DDDDDD--");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---D-----D-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---D------D");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---D------D");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---D------D");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---D-----D-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---DDDDDD--");

            return 11;
        }
        public static int LetterE(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---EEEEEE");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---E-----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---E-----");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---EEEE--");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---E-----");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---E-----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---EEEEEE");
            return 9;
        }
        public static int LetterF(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---FFFFFF");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---F-----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---F-----");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---FFFF--");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---F-----");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---F-----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---F-----");
            return 9;
        }
        public static int LetterG(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---GGGGGGGGG");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---G--------");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---G--------");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---G----GGGG");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---G-------G");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---G-------G");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---GGGGGGGGG");
            return 12;
        }
        public static int LetterH(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---H---H");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---H---H");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---H---H");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---HHHHH");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---H---H");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---H---H");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---H---H");
            return 8;
        }
        public static int LetterI(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---I");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---I");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---I");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---I");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---I");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---I");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---I");
            return 4;
        }
        public static int LetterJ(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("--------J");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("--------J");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("--------J");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("--------J");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---J----J");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----J---J");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-----JJJJ");
            return 9;
        }
        public static int LetterK(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---K---K");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---K--K-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---K-K--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---KK---");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---K-K--");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---K--K-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---K---K");
            return 8;
        }
        public static int LetterL(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---L-----");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---L-----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---L-----");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---L-----");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---L-----");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---L-----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---LLLLLL");
            return 9;
        }
        public static int LetterM(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---MM------MM");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---M-M----M-M");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---M--M--M--M");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---M---MM---M");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---M--------M");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---M--------M");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---M--------M");
            return 13;
        }
        public static int LetterN(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---NN------N");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---N-N-----N");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---N--N----N");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---N---N---N");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---N----N--N");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---N-----N-N");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---N------NN");
            return 13;
        }
        public static int LetterO(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("------OOOOO---");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("----O-------O-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---O---------O");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---O---------O");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---O---------O");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----O-------O-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-----OOOOOOO--");
            return 14;
        }
        public static int LetterP(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---PPPP");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---P--P");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---P--P");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---P-P-");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---P---");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---P---");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---P---");
            return 7;
        }
        public static int LetterQ(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("------QQQQQ---");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("----Q-------Q-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---Q---------Q");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---Q---------Q");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---Q-----Q---Q");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----Q-----Q-Q-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-----QQQQQQQ-Q");
            return 14;
        }
        public static int LetterR(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---RRRR");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---R--R");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---R--R");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---R-R-");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---RR--");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---R-R-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("- -R--R");
            return 7;
        }
        public static int LetterS(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("----SS");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---S--");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---S--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("----S-");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("-----S");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("-----S");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---SS-");
            return 6;
        }
        public static int LetterT(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---TTTTTTTTT");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("-------T----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("-------T----");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("-------T----");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("-------T----");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("-------T----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-------T----");
            return 12;
        }
        public static int LetterU(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---U--------U");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---U--------U");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---U--------U");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---U--------U");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---U--------U");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----U------U-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-----UUUUUU--");
            return 14;
        }
        public static int LetterV(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---V-----V");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---V-----V");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---V-----V");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---V-----V");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("----V---V-");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("-----V-V--");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("------V---");
            return 10;
        }
        public static int LetterW(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---W--------W");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---W--------W");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---W--------W");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---W---WW---W");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---W--W--W--W");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---W-W----W-W");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---WW------WW");
            return 13;
        }
        public static int LetterX(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---X-----X");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("----X---X-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("-----X-X--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("------X---");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("-----X-X--");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----X---X-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---X-----X");
            return 10;
        }
        public static int LetterY(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---Y-----Y");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("----Y---Y-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("-----Y-Y--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("------Y---");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("------Y---");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("------Y---");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("------Y---");
            return 10;
        }
        public static int LetterZ(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---ZZZZZZZ");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("--------Z-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("-------Z--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("------Z---");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("-----Z----");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("----Z-----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---ZZZZZZZ");
            return 10;

        }
        public static int Letter1(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---111");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("-----1");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("-----1");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("-----1");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("-----1");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("-----1");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-----1");
            return 7;
        }
        public static int Letter2(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---222222");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("--------2");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("--------2");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---222222");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---2-----");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---2-----");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---222222");
            return 9;
        }
        public static int Letter3(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---333333");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("--------3");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("--------3");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---333333");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("--------3");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("--------3");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---333333");
            return 9;
        }
        public static int Letter4(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---4----4");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---4----4");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---4----4");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---444444");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("-------4");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("-------4");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("-------4");
            return 9;
        }
        public static int Letter5(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---555555");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---5-----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---5-----");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---555555");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("--------5");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("--------5");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---555555");
            return 9;
        }
        public static int Letter6(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---666666");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---6-----");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---6-----");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---666666");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---6----6");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---6----6");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---666666");
            return 9;
        }
        public static int Letter7(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---777777");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("--------7");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("--------7");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("------777");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("--------7");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("--------7");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("--------7");
            return 9;
        }
        public static int Letter8(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---888888");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---8----8");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---8----8");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---888888");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---8----8");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---8----8");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---888888");
            return 9;
        }
        public static int Letter9(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---999999");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---9----9");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---9----9");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---999999");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("--------9");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("--------9");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---999999");

            return 9;
        }
        public static int Letter0(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("---000000");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("---0----0");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("---0----0");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("---0----0");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("---0----0");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("---0----0");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("---000000");
            return 9;
        }
        public static int RadioMarcoLogo(int widthOtherLetters)
        {
            Console.SetCursorPosition(widthOtherLetters, 0);
            Console.WriteLine("------#");
            Console.SetCursorPosition(widthOtherLetters, 1);
            Console.WriteLine("-----#-");
            Console.SetCursorPosition(widthOtherLetters, 2);
            Console.WriteLine("----#--");
            Console.SetCursorPosition(widthOtherLetters, 3);
            Console.WriteLine("######-");
            Console.SetCursorPosition(widthOtherLetters, 4);
            Console.WriteLine("#----#-");
            Console.SetCursorPosition(widthOtherLetters, 5);
            Console.WriteLine("##--##-");
            Console.SetCursorPosition(widthOtherLetters, 6);
            Console.WriteLine("######-");
            return 7;
        }


    }
}
