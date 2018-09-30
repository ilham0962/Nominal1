using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terbilang
{
    public class Terbilang1
    {
        public string TerbilangIndonesia(long nominal)
        {
            string strTot = string.Empty;
            string urai = string.Empty;
            string strJmlHuruf = string.Empty;
            string bil1 = string.Empty;
            string bil2 = string.Empty;

            long y = 0;
            int x = 0;
            int z = 0;

            strJmlHuruf = Convert.ToString(nominal);

            urai = string.Empty;
            while (x < strJmlHuruf.Length)
            {
                x++;
                strTot = strJmlHuruf.Substring(x - 1, 1);
                y = y + Convert.ToInt64(strTot);
                z = strJmlHuruf.Length - x + 1;
                switch (Convert.ToInt32(strTot))
                {
                    case 1:
                        if ((z == 1 | z == 7 | z == 10 | z == 13 | z == 16))
                        {
                            bil1 = "SATU ";
                        }
                        else if ((z == 4))
                        {
                            if ((x == 1))
                            {
                                bil1 = "SE";
                            }
                            else
                            {
                                bil1 = "SATU ";
                            }
                        }
                        else if ((z == 2 | z == 5 | z == 8 | z == 11 | z == 14 | z == 17))
                        {
                            x = x + 1;
                            strTot = strJmlHuruf.Substring(x - 1, 1);
                            z = strJmlHuruf.Length - x + 1;
                            bil2 = string.Empty;
                            switch (Convert.ToInt32(strTot))
                            {
                                case 0:
                                    bil1 = "SEPULUH ";
                                    break;
                                case 1:
                                    bil1 = "SEBELAS ";
                                    break;
                                case 2:
                                    bil1 = "DUA BELAS ";
                                    break;
                                case 3:
                                    bil1 = "TIGA BELAS ";
                                    break;
                                case 4:
                                    bil1 = "EMPAT BELAS ";
                                    break;
                                case 5:
                                    bil1 = "LIMA BELAS ";
                                    break;
                                case 6:
                                    bil1 = "ENAM BELAS ";
                                    break;
                                case 7:
                                    bil1 = "TUJUH BELAS ";
                                    break;
                                    case 8:
                                    bil1 = "DELAPAN BELAS ";
                                    break;
                                case 9:
                                    bil1 = "SEMBILAN BELAS ";
                                    break;
                            }
                        }
                        else
                        {
                            bil1 = "SE";
                        }
                        break;
                    case 2:
                        bil1 = "DUA ";
                        break;
                    case 3:
                        bil1 = "TIGA ";
                        break;
                    case 4:
                        bil1 = "EMPAT ";
                        break;
                    case 5:
                        bil1 = "LIMA ";
                        break;
                    case 6:
                        bil1 = "ENAM ";
                        break;
                    case 7:
                        bil1 = "TUJUH ";
                        break;
                    case 8:
                        bil1 = "DELAPAN ";
                        break;
                    case 9:
                        bil1 = "SEMBILAN ";
                        break;
                    default:
                        bil1 = string.Empty;
                        break;
                }

                if (Convert.ToUInt32(strTot) > 0)
                {
                    if ((z == 2 | z == 5 | z == 8 | z == 11 | z == 14 | z == 17))
                    {
                        bil2 = "PULUH ";
                    }
                    else if ((z == 3 | z == 6 | z == 9 | z == 12 | z == 15 | z == 18))
                    {
                        bil2 = "RATUS ";
                    }
                    else
                    {
                        bil2 = string.Empty;
                    }
                }
                else
                {
                    bil2 = string.Empty;
                }

                if ((y > 0))
                {
                    switch (z)
                    {
                        case 4:
                            bil2 = bil2 + "RIBU ";
                            y = 0;
                            break;
                        case 7:
                            bil2 = bil2 + "JUTA ";
                            y = 0;
                            break;
                        case 10:
                            bil2 = bil2 + "MILYAR ";
                            y = 0;
                            break;
                        case 13:
                            bil2 = bil2 + "TRILYUN ";
                            y = 0;
                            break;
                        case 16:
                            bil2 = bil2 + "KUADRILIUN ";
                            y = 0;
                            break;
                    }
                }
                urai = urai + bil1 + bil2;
            }

            return urai + "RUPIAH";
        }
        public string TerbilangInggris(long nominal)
        {
            string strTot = string.Empty;
            string urai = string.Empty;
            string strJmlHuruf = string.Empty;
            string bil1 = string.Empty;
            string bil2 = string.Empty;
            int q = 0;
            int y = 0;
            int x = 0;
            int z = 0;
            int a = 0;


            strJmlHuruf = Convert.ToString(nominal);

            urai = string.Empty;
            while (x < strJmlHuruf.Length)
            {
                x++;
                q = 0;
                strTot = strJmlHuruf.Substring(x - 1, 1);
                y = y + Convert.ToInt32(strTot);
                z = strJmlHuruf.Length - x + 1;
                if (z == 2 | z == 5 | z == 8 | z == 11 | z == 14 | z == 17) { q = 1; }
                switch (Convert.ToInt32(strTot))
                {
                    case 1:
                        if ((z == 1 | z == 7 | z == 10 | z == 13 | z == 16))
                        {
                            bil1 = "ONE ";
                        }
                        else if ((z == 4))
                        {
                            if ((x == 1))
                            {
                                bil1 = "TEN ";
                            }
                            else
                            {
                                bil1 = "ONE ";
                            }
                        }
                        else if ((q==1))
                        {
                            x++;
                            strTot = strJmlHuruf.Substring(x - 1, 1);
                            z = strJmlHuruf.Length - x + 1;
                            bil2 = string.Empty;
                            
                            switch (Convert.ToInt32(strTot))
                            {
                                case 0:
                                    bil1 = "TEN ";
                                    break;
                                case 1:
                                    bil1 = "ELEVEN ";
                                    break;
                                case 2:
                                    bil1 = "TWENTEEN ";
                                    break;
                                case 3:
                                    bil1 = "THIRTEEN ";
                                    break;
                                case 4:
                                    bil1 = "FOURTEEN ";
                                    break;
                                case 5:
                                    bil1 = "FIFTEEN ";
                                    break;
                                case 6:
                                    bil1 = "SIXTEEN ";
                                    break;
                                case 7:
                                    bil1 = "SEVENTEEN ";
                                    break;
                                case 8:
                                    bil1 = "EIGHTEEN ";
                                    break;
                                case 9:
                                    bil1 = "NINETEEN ";
                                    break;
                            }
                        }
                        else
                        {
                            bil1 = "ONE ";
                        }
                        break;
                    case 2:
                        if (q==1)
                        {   bil1 = "TWENTY ";
                        }
                        else
                        {
                            bil1 = "TWO";
                        }
                        break;
                    case 3:
                        if (q==1)
                        {
                            bil1 = "THIRTY ";
                        }
                        else
                        {
                            bil1 = "THREE";
                        }
                        break;
                    case 4:
                        bil1 = "FOUR";
                        break;
                    case 5:
                        if (q==1)
                        {
                            bil1 = "FIFTY ";
                        }
                        else
                        {
                            bil1 = "FIVE";
                        }
                        break;
                    case 6:
                        bil1 = "SIX";
                        break;
                    case 7:
                        bil1 = "SEVEN";
                        break;
                    case 8:
                        bil1 = "EIGHT";
                        break;
                    case 9:
                        bil1 = "NINE";
                        break;
                    default:
                        bil1 = string.Empty;
                        break;
                }
                a = Convert.ToInt32(strTot);
                if (Convert.ToUInt32(strTot) > 0)
                {
                    if (q==1)
                    {
                        if ((a==3 | a== 2 | a == 5))
                        {
                            bil2 = String.Empty;
                        }
                        else
                        {
                            bil2 = "TY ";
                        }
                    }
                    else if ((z == 3 | z == 6 | z == 9 | z == 12 | z == 15 | z == 18))
                    {
                        bil2 = " HUNDRED ";
                    }
                    else
                    {
                        bil2 = string.Empty;
                    }
                    }
                    else
                    {
                        bil2 = string.Empty;
                    }
                a = 0;
                if ((y > 0))
                    {
                        switch (z)
                        {
                            case 4:
                                bil2 = bil2 + " THOUSAND ";
                                y = 0;
                                break;
                            case 7:
                                bil2 = bil2 + " MILLION ";
                                y = 0;
                                break;
                            case 10:
                                bil2 = bil2 + " BILLION ";
                                y = 0;
                                break;
                            case 13:
                                bil2 = bil2 + " TRILLION ";
                                y = 0;
                                break;
                            case 16:
                                bil2 = bil2 + " QUADRILLION ";
                                y = 0;
                                break;
                        }
                    }
                    urai = urai + bil1 + bil2;
                }

                return urai + " RUPIAHS";
            }
        }
    }

