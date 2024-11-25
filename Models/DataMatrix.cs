using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;


namespace MyProjectXMLDSM_vs.Models
{
    //class DataMatrix
    //{
    //    public DataMatrix() { }
    //}

    #region Data_class_for_labels

    public class LabelData
    {
        public string ModelName { get; set; } = string.Empty;
        public string DataInDot { get; set; } = string.Empty;
        public string DataWithoutDot { get; set; } = string.Empty;
        public string Counter { get; set; }
        public string CustomerCode { get; set; } = "0 000 000 000 XX0";
        public string MadeInCountry { get; set; } = "Made in ...";
        public string LabelLetter { get; set; } = "X";
        public string Code1 { get; set; } = "X";
        public string Code2 { get; set; } = "XX00X0000";
        public string Number1 { get; set; } = "0000";
        public string Number2 { get; set; } = "0000";
        public string PartCode { get; set; } = "XX0";
        public string ProductCode { get; set; } = "0X0 000";
        public string ProductId { get; set; } = "000 X";
        public string ItemCode { get; set; } = "00XXXX";
        public string BarcodeContent1 { get; set; } = "000000000000";
        public string BarcodeContent2 { get; set; } = "0X00000000X";
    }
    public class Audi_723
    {
        public string ModelName = string.Empty;
        string data_inDot = string.Empty;
        string data_whitoutDot = string.Empty;
        string counter;
        string CustomerCod = "1 307 024 090 AA1";
        string madeInCountry = "Made in Poland";
        string labelLetter = "L";
        string code1 = "15S";
        string code2 = "LE10B6235";
        string number1 = "3066";
        string number2 = "3181";
        string partCode = "AH4";
        string productCode = "8K0 941";
        string productId = "043 F";
        string itemCode = "01XCER";
        string barcodeContent1 = "130702409022";
        string barcodeContent2 = "8K05941043F";

        public Audi_723(string dateDot_, string whitoutDot_, string con)
        {
            ModelName = "1 307 024 090 AA1";
            data_inDot = dateDot_;
            barcodeContent1 = $"{barcodeContent1} + {whitoutDot_} + {con}";
            counter = con; //^FT500,116^A0N,25,24^SN0001,1,Y^FS
        }

        public string getZpltoPrint()                                       // ZPL string
        {
            string zplCommand =
                            "[CT~~CD,~CC^~CT~" +
                            "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR6,6~SD22^JUS^LRN^CI0^XZ" +
                            "^XA" +
                            "^MMT" +
                            "^PW614" +
                            "^LL0496" +
                            "^LS0" +
                            "^FO64,0^GFA,01536,01536,00016,:Z64:eJztkjESgjAURImZDCWlpQexCNxAi9Q5SjyK97BQjuAN0MrWjhmQNSkk7m88AP4uvDyWv0NR/GeRo2rx4MDH8sJnLbgX3AoexPvB3IB9/YOvBN8LrpirBpzfMTdX9vWN+bplXgnfC98KP7ScjztxA/Y12C/B+RU43wvfCj+A88G+gvDBvgHn6+lM/gaB/Gri/f0YyLcP+72/wjP6yDfQRR/zDYM2+pg3iP9G/H5MOT71B+T41F/mfkz94TXH96k/9Dk+9Zf5qdsOx2HoPtzVzjXO7YoFzBunaqpw:A152" +
                            "^FO416,320^GFA,01024,01024,00016,:Z64:eJztkj1OBDEMhd9oipRpqTYXAeZaFEjJ0XKUHMFom0gbeNjOjHaQkChoKHAR+ZMS/7wX4D9+jFc71ub5whpYI7EN50BJ7BsbWYwdBvlGVuONH+Q7eSO9QEYmcl8pQYwHUkdqYFm6lRdEQarYirddBaE5A89zism5OIcKraPvlS+T9f2m9TQxLkjKcnAs1u9RcK2WO7+cGQe3gy8Hh+/56/2j3u3OHU/K9/7nefZ5Bbki2X7Oc5+d535bOe0f/bLpo6LFvutlhiyq50C2+qvpCZreHKp3lOkH89mPxOF+XXf/InukZFbS/V3Zpt+pz8+gUzwA8vtf9SfiE2f6tm4=:3530" +
                            "^FO352,256^GFA,00768,00768,00008,:Z64:eJzN0DEOwjAMBVCnQS1DpTJmQCpH6MiA2h4ld2BBKqg5QU/AYbIxcgPUrStbQYKGxDYHgAW8PFVR/W0D/HtFACaYgLBBCRK/hUnwXTwycspR2VVsSw06R+YjWbHtQD4d9buTcqL/E+6XTNyf8975Mc8z4/k+rz2RUS6U4or2oDDH+AjM8ZG+0jCCd75sbFCVztbeonVWB7dHKLx6UOwarU+kZlf8vhrJormgi4MzGvs2NiyWRgpzYqCF/RB4CL/1BufcwQ3Nzz0dyn15h1/WC9Q1O0s=:1386" +
                            "^FO96,224^GFA,00512,00512,00008,:Z64:eJytkDEOwjAMRX/UIVuzMiC4RocKrpUBQblZuUl7g7IVqVL43wl0QEIMRGpeFDuu/YB/LZcmY0iL8ZJSZ9dIA1kt8ErQNiutBw7kvnw6ez44KZexO8tVQ6Yb4EaV53FkbMPQjWxiZiSv5NzAG1t418PNW2NVCDKIcYfapR6x/kLlffL1PrPUFfXf2BY2a1/qlwNb3+rf5pnW+R6icsv88hC61Ys8neWENZbsM8gfrR7lFcfs+e3dme5f1xM012jW:1AFB" +
                            "^FT167,56^A0N,29,43^FH\\^FDAutomative Lighting^FS" +
                            "^FT95,132^A0N,38,38^FH\\^FD" + CustomerCod + "^FS" +
                            "^FT435,91^A0N,25,24^FH\\^FD" + data_inDot + "^FS" +
                            "^FT500,116^A0N,25,24^FH\\^FD" + counter + "^FS" +
                            "^BY3,3,75^FT90,226^BCN,,N,N^FD>;" + barcodeContent1 + "^FS" +
                            "^BY3,3,75^FT104,463^BCN,,N,N^FD>:" + barcodeContent2 + "^FS" +
                            "^FT274,258^A0N,25,36^FH\\^FD" + madeInCountry + "^FS" +
                            "^FT511,330^A0N,102,139^FH\\^FD" + labelLetter + "^FS" +
                            "^FT419,323^A0N,29,43^FH\\^FD" + code1 + "^FS" +
                            "^FT178,339^A0N,29,43^FH\\^FD" + code2 + "^FS" +
                            "^FT100,306^A0N,17,26^FH\\^FD" + number1 + "^FS" +
                            "^FT100,326^A0N,17,26^FH\\^FD" + number2 + "^FS" +
                            "^FT100,347^A0N,17,26^FH\\^FD" + partCode + "^FS" +
                            "^FT100,378^A0N,25,36^FH\\^FD" + productCode + "^FS" +
                            "^FT234,375^A0N,29,43^FH\\^FD" + productId + "^FS" +
                            "^FT159,295^A0N,25,36^FH\\^FD" + itemCode + "^FS" +
                            "^PQ1,0,1,Y^XZ";


            return zplCommand;
        }


    }
    public class GenericLabel<T>
    {
        public string ModelName { get; set; } = string.Empty;
        public T DataInDot { get; set; }
        public T DataWithoutDot { get; set; }
        public T Counter { get; set; }
        public string CustomerCode { get; set; } = "1 307 024 090 AA1";
        public string MadeInCountry { get; set; } = "Made in Poland";
        public string LabelLetter { get; set; } = "L";
        public string Code1 { get; set; } = "15S";
        public string Code2 { get; set; } = "LE10B6235";
        public string Number1 { get; set; } = "3066";
        public string Number2 { get; set; } = "3181";
        public string PartCode { get; set; } = "AH4";
        public string ProductCode { get; set; } = "8K0 941";
        public string ProductId { get; set; } = "043 F";
        public string ItemCode { get; set; } = "01XCER";
        public string BarcodeContent1 { get; set; } = "130702409022";
        public string BarcodeContent2 { get; set; } = "8K05941043F";

        public GenericLabel(string modelName, T dataInDot, T dataWithoutDot, T counter)
        {
            ModelName = modelName;
            DataInDot = dataInDot;
            DataWithoutDot = dataWithoutDot;
            Counter = counter;
            BarcodeContent1 = $"{BarcodeContent1} + {dataWithoutDot} + {counter}";
        }

        public string GetZplToPrint()
        {
            string zplCommand =
                "[CT~~CD,~CC^~CT~" +
                "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR6,6~SD22^JUS^LRN^CI0^XZ" +
                "^XA" +
                "^MMT" +
                "^PW614" +
                "^LL0496" +
                "^LS0" +
                "^FO64,0^GFA,01536,01536,00016,:Z64:eJztkjESgjAURImZDCWlpQexCNxAi9Q5SjyK97BQjuAN0MrWjhmQNSkk7m88AP4uvDyWv0NR/GeRo2rx4MDH8sJnLbgX3AoexPvB3IB9/YOvBN8LrpirBpzfMTdX9vWN+bplXgnfC98KP7ScjztxA/Y12C/B+RU43wvfCj+A88G+gvDBvgHn6+lM/gaB/Gri/f0YyLcP+72/wjP6yDfQRR/zDYM2+pg3iP9G/H5MOT71B+T41F/mfkz94TXH96k/9Dk+9Zf5qdsOx2HoPtzVzjXO7YoFzBunaqpw:A152" +
                "^FO416,320^GFA,01024,01024,00016,:Z64:eJztkj1OBDEMhd9oipRpqTYXAeZaFEjJ0XKUHMFom0gbeNjOjHaQkChoKHAR+ZMS/7wX4D9+jFc71ub5whpYI7EN50BJ7BsbWYwdBvlGVuONH+Q7eSO9QEYmcl8pQYwHUkdqYFm6lRdEQarYirddBaE5A89zism5OIcKraPvlS+T9f2m9TQxLkjKcnAs1u9RcK2WO7+cGQe3gy8Hh+/56/2j3u3OHU/K9/7nefZ5Bbki2X7Oc5+d535bOe0f/bLpo6LFvutlhiyq50C2+qvpCZreHKp3lOkH89mPxOF+XXf/InukZFbS/V3Zpt+pz8+gUzwA8vtf9SfiE2f6tm4=:3530" +
                "^FO352,256^GFA,00768,00768,00008,:Z64:eJzN0DEOwjAMBVCnQS1DpTJmQCpH6MiA2h4ld2BBKqg5QU/AYbIxcgPUrStbQYKGxDYHgAW8PFVR/W0D/HtFACaYgLBBCRK/hUnwXTwycspR2VVsSw06R+YjWbHtQD4d9buTcqL/E+6XTNyf8975Mc8z4/k+rz2RUS6U4or2oDDH+AjM8ZG+0jCCd75sbFCVztbeonVWB7dHKLx6UOwarU+kZlf8vhrJormgi4MzGvs2NiyWRgpzYqCF/RB4CL/1BufcwQ3Nzz0dyn15h1/WC9Q1O0s=:1386" +
                "^FO96,224^GFA,00512,00512,00008,:Z64:eJytkDEOwjAMRX/UIVuzMiC4RocKrpUBQblZuUl7g7IVqVL43wl0QEIMRGpeFDuu/YB/LZcmY0iL8ZJSZ9dIA1kt8ErQNiutBw7kvnw6ez44KZexO8tVQ6Yb4EaV53FkbMPQjWxiZiSv5NzAG1t418PNW2NVCDKIcYfapR6x/kLlffL1PrPUFfXf2BY2a1/qlwNb3+rf5pnW+R6icsv88hC61Ys8neWENZbsM8gfrR7lFcfs+e3dme5f1xM012jW:1AFB" +
                "^FT167,56^A0N,29,43^FH\\^FDAutomative Lighting^FS" +
                "^FT95,132^A0N,38,38^FH\\^FD" + CustomerCode + "^FS" +
                "^FT435,91^A0N,25,24^FH\\^FD" + DataInDot + "^FS" +
                "^FT500,116^A0N,25,24^FH\\^FD" + Counter + "^FS" +
                "^BY3,3,75^FT90,226^BCN,,N,N^FD>;" + BarcodeContent1 + "^FS" +
                "^BY3,3,75^FT104,463^BCN,,N,N^FD>:" + BarcodeContent2 + "^FS" +
                "^FT274,258^A0N,25,36^FH\\^FD" + MadeInCountry + "^FS" +
                "^FT511,330^A0N,102,139^FH\\^FD" + LabelLetter + "^FS" +
                "^FT419,323^A0N,29,43^FH\\^FD" + Code1 + "^FS" +
                "^FT178,339^A0N,29,43^FH\\^FD" + Code2 + "^FS" +
                "^FT100,306^A0N,17,26^FH\\^FD" + Number1 + "^FS" +
                "^FT100,326^A0N,17,26^FH\\^FD" + Number2 + "^FS" +
                "^FT100,347^A0N,17,26^FH\\^FD" + PartCode + "^FS" +
                "^FT100,378^A0N,25,36^FH\\^FD" + ProductCode + "^FS" +
                "^FT234,375^A0N,29,43^FH\\^FD" + ProductId + "^FS" +
                "^FT159,295^A0N,25,36^FH\\^FD" + ItemCode + "^FS" +
                "^PQ1,0,1,Y^XZ";

            return zplCommand;
        }
    }
    #endregion

    public class DataMatrix
    {
        #region PARAMETER
        private string ipAddress;
        private int port;

        private Connection connectionPrinter;
        private DateTime currentDateTime = DateTime.Now;
        #endregion

        public DataMatrix(string ipPrinter, int portToConnect)
        {
            this.ipAddress = ipPrinter;
            this.port = portToConnect;
            connectionPrinter = new TcpConnection(ipAddress, portToConnect);
        }

        public bool printDMCcodeforModel(string dmsCode, int counter)      // Print Label
        {
            try
            {
                connectionPrinter.Open();
                string dateOutDot = getTime(true);
                string dateInDot = getTime(false);
                string coun0000 = IntToZeroPaddedString(counter);

                Audi_723 label_301025 = new Audi_723(dateInDot, dateOutDot, coun0000);
                var zplCommand = label_301025.getZpltoPrint();

                byte[] zplBytes = Encoding.UTF8.GetBytes(zplCommand);       // Convert the ZPL command from string to byte[]
                connectionPrinter.Write(zplBytes);                          // Send the byte array to the printer
                connectionPrinter.Close();

                Console.WriteLine($"Printed Label {label_301025.ModelName}:{dateInDot}");
            }
            catch (ConnectionException e)
            {
                Console.WriteLine("Error connecting to printer: " + e.Message);
                return false;
            }
            return true;
        }

        private string getTime(bool swicht_)                                // Get current Time string
        {
            if (swicht_)
            {
                string formattedDateTime = currentDateTime.ToString("ddMMyyyy"); // Change format as needed HHmmss
                return formattedDateTime;
            }
            else
            {
                string formatDataTime = currentDateTime.ToString("dd.MM.yyyy");
                return formatDataTime;
            }
        }
        private string IntToZeroPaddedString(int number)                    // exchange 6 to 000006
        {
            return number.ToString("D4");
        }
        public int ZeroPaddedStringToInt(string paddedNumber)               // exchange 000006 to 6
        {
            return int.Parse(paddedNumber);
        }
    }


}
