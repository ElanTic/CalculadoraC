using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC
{
    public partial class Form1 : Form
    {
        private Button del;
        private Button delAll;
        private Button limpiar;
        private Button minus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSuma;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMult;
        private Button btn0; 
        private Button btnDot;
        private Button btnIgual;
        private Button btndiv;
        private Button btnPi;
        private Button btnlog;
        private Button btnSqrt;
        private Button btnCuad;
        private Button btnSinh;
        private Button btnSin;
        private Button btnDec;
        private Button btnXy;
        private Button btnCosh;
        private Button btnCos;
        private Button btnBin;
        private Button btn1x;
        private Button btnTanh;
        private Button btnTan;
        private Button btnHex;
        private Button btnLnx;
        private Button btnExp;
        private Button btnMod;
        private Button btnOct;

        private MenuStrip menu;
        private ToolStripMenuItem catTipo;
        private ToolStripMenuItem miEstandor;
        private ToolStripMenuItem miCientifica;
          

        //private Button x;
        private TextBox display;
        private Label lblOp;
        private string operacion;
        private Double resul;
        private int basenum;
        public Form1()
        {
            basenum = 10;
            operacion = "";
            resul = 0;
            display= new TextBox();
            display.TextAlign = HorizontalAlignment.Right;
            lblOp = new Label();
            del = new Button();
            delAll = new Button();
            limpiar = new Button();
            minus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnSuma = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnResta = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMult = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnIgual = new Button();
            btndiv = new Button();
            btnPi= new Button();
            btnlog= new Button();
            btnSqrt= new Button();
            btnCuad= new Button();
            btnSinh= new Button();
            btnSin= new Button();
            btnDec= new Button();
            btnXy= new Button();
            btnCosh= new Button();
            btnCos= new Button();
            btnBin= new Button();
            btn1x= new Button();
            btnTanh= new Button();
            btnTan= new Button();
            btnHex= new Button();
            btnLnx= new Button();
            btnExp= new Button();
            btnMod= new Button();
            btnOct= new Button();
            

            menu = new MenuStrip();
            catTipo= new ToolStripMenuItem();
            miEstandor= new ToolStripMenuItem();
            miCientifica= new ToolStripMenuItem();




            del.Size= new Size(60,60);
            delAll.Size= new Size(60,60);
            limpiar.Size= new Size(60,60);
            minus.Size= new Size(60,60);
            btn7.Size= new Size(60,60);
            btn8.Size= new Size(60,60);
            btn9.Size= new Size(60,60);
            btnSuma.Size= new Size(60,60);
            btn4.Size= new Size(60,60);
            btn5.Size= new Size(60,60);
            btn6.Size= new Size(60,60);
            btnResta.Size= new Size(60,60);
            btn1.Size= new Size(60,60);
            btn2.Size= new Size(60,60);
            btn3.Size= new Size(60,60);
            btnMult.Size= new Size(60,60);
            btn0.Size= new Size(60,60);
            btnDot.Size= new Size(60,60);
            btnIgual.Size= new Size(60,60);
            btndiv.Size= new Size(60,60);

            btnPi.Size = new Size(60,60);
            btnlog.Size = new Size(60,60);
            btnSqrt.Size = new Size(60,60);
            btnCuad.Size = new Size(60,60);
            btnSinh.Size = new Size(60,60);
            btnSin.Size = new Size(60,60);
            btnDec.Size = new Size(60,60);
            btnXy.Size = new Size(60,60);
            btnCosh.Size = new Size(60,60);
            btnCos.Size = new Size(60,60);
            btnBin.Size = new Size(60,60);
            btn1x.Size = new Size(60,60);
            btnTanh.Size = new Size(60,60);
            btnTan.Size = new Size(60,60);
            btnHex.Size = new Size(60,60);
            btnLnx.Size = new Size(60,60);
            btnExp.Size = new Size(60,60);
            btnMod.Size = new Size(60,60);
            btnOct.Size = new Size(60,60);




            display.Size = new Size(558,50);
            display.Multiline = true;
            lblOp.AutoSize = true;

            del.Text = "⌫";
            delAll.Text="CE";
            limpiar.Text="C";
            minus.Text= "±";
            btn7.Text="7";
            btn8.Text="8";
            btn9.Text="9";
            btnSuma.Text="+";
            btn4.Text="4";
            btn5.Text="5";
            btn6.Text="6";
            btnResta.Text="-";
            btn1.Text="1";
            btn2.Text="2";
            btn3.Text="3";
            btnMult.Text="*";
            btn0.Text="0";
            btnDot.Text=".";
            btnIgual.Text="=";
            btndiv.Text="/";

            btnPi.Text = "π";
            btnlog.Text ="Log";
            btnSqrt.Text ="Sqrt";
            btnCuad.Text ="x^2";
            btnSinh.Text = "Sinh";
            btnSin.Text ="Sin";
            btnDec.Text= "Dec";
            btnXy.Text="x^y";
            btnCosh.Text="Cosh";
            btnCos.Text ="Cos";
            btnBin.Text= "Bin";
            btn1x.Text ="1/x";
            btnTanh.Text="Tanh";
            btnTan.Text ="Tan";
            btnHex.Text ="Hex";
            btnLnx.Text ="Ln x";
            btnExp.Text ="Exp";
            btnMod.Text ="Mod";
            btnOct.Text = "Oct";

            catTipo.Text="Tipo";
            miEstandor.Text="Estandar";
            miCientifica.Text="Cientifica";
            display.Text = "0";



            display.Location = new Point(10, 30);
            lblOp.Location = new Point(10, 30);
            //lblOp.BringToFront();

            List<Button> buttons = new List<Button>();
            //buttons.Add(lblOp);
            buttons.Add(del);
            buttons.Add(delAll);
            buttons.Add(limpiar);
            buttons.Add(minus);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(btnSuma);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btnResta);
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btnMult);
            buttons.Add(btn0);
            buttons.Add(btnDot);
            buttons.Add(btnIgual);
            buttons.Add(btndiv);
            List<Button> cientific = new List<Button>();
            cientific.Add(btnPi);
            cientific.Add(btnlog);
            cientific.Add(btnSqrt);
            cientific.Add(btnCuad);
            cientific.Add(btnSinh);
            cientific.Add(btnSin);
            cientific.Add(btnDec);
            cientific.Add(btnXy);
            cientific.Add(btnCosh);
            cientific.Add(btnCos);
            cientific.Add(btnBin);
            cientific.Add(btn1x);
            cientific.Add(btnTanh);
            cientific.Add(btnTan);
            cientific.Add(btnHex);
            cientific.Add(btnLnx);
            cientific.Add(btnExp);
            cientific.Add(btnMod);
            cientific.Add(btnOct);




            int count = 0;
            int x = 10;
            int y = 85;
            foreach (Button button in buttons)
            {
                if(count == 4)
                {
                    x = 10;
                    y += 57;
                    count = 0;
                }
                button.Location = new Point(x, y);
                button.Click+= new EventHandler(clicked);
                this.Controls.Add(button);
                x += 67;
                count++;
            }
             count = 0;
            x = 320;
            y = 85;
            foreach (Button button in cientific)
            {
                if (count == 4)
                {
                    x = 320;
                    y += 57;
                    count = 0;
                }
                button.Location = new Point(x, y);
                //button.Click += new EventHandler(clicked);
                this.Controls.Add(button);
                x += 67;
                count++;
            }
            miEstandor.Click += new EventHandler(menuEstandar_click);
            miCientifica.Click += new EventHandler(menuCientifica_click);
            catTipo.DropDownItems.Add(miEstandor);
            catTipo.DropDownItems.Add(miCientifica);
            menu.Items.Add(catTipo);

            btnPi.Click += new EventHandler(btnPi_Click);
            btnlog.Click += new EventHandler(btnLog_Click);
            btnLnx.Click += new EventHandler(btnLn_Click);
            btnSin.Click += new EventHandler(btnSin_Click);
            btnSinh.Click += new EventHandler(btnSinh_Click);
            btnCos.Click += new EventHandler(btnCos_Click);
            btnCosh.Click += new EventHandler(btnCosh_Click);
            btnTan.Click += new EventHandler(btnTan_Click);
            btnTanh.Click += new EventHandler(btnTanh_Click);
            btnExp.Click += new EventHandler(btnExp_Clic);
            btnMod.Click += new EventHandler(clicked);
            btnXy.Click += new EventHandler(clicked);
            btn1x.Click += new EventHandler(btn1x_Click);
            btnCuad.Click += new EventHandler(btnCuad_Click);
            btnSqrt.Click += new EventHandler(btnSqrt_Click);
            btnBin.Click += new EventHandler(toBin);
            btnOct.Click += new EventHandler(toOct);
            btnDec.Click += new EventHandler(toDec);
            btnHex.Click += new EventHandler(toHex);
            //btnSqrt.Click += new EventHandler(btnSqrt_Click);

            this.Controls.Add(display);
            this.Controls.Add(lblOp);
            this.Controls.Add(menu);
            lblOp.BringToFront();
            InitializeComponent();
            this.Size = new Size(600, 500);
            this.Text = "Calculator";
        }

       
        private void toBin(Object sender, EventArgs e )
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            int num = int.Parse(display.Text);
            lblOp.Text = $"Bin({display.Text})";
            display.Text = Convert.ToString(num, 2);//.ToString();
            //resul = (Double)(Convert.ToInt32(display.Text, 2));
            basenum = 2;
        }

        private void toOct(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            int num = int.Parse(display.Text);
            lblOp.Text = $"Oct({display.Text})";
            display.Text = Convert.ToString(num, 8);//.ToString();
            //resul = (Double)(Convert.ToInt32(display.Text, 8));
            basenum = 8;
        }
        private void toDec(Object sender, EventArgs e)
        {
            //int num = int.Parse(display.Text);
            if (basenum != 10)
            {
               display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Dec({display.Text})";
            display.Text = Convert.ToInt32(display.Text, 10).ToString();//.ToString();
        }
        private double decimalVal(string number)
        {
            int intValue = Convert.ToInt32(number, basenum);
            return (Double)intValue;
        }
        private void toHex(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            int num = int.Parse(display.Text);
            lblOp.Text = $"Hex({display.Text})";
            display.Text = Convert.ToString(num, 16);//.ToString();
            //resul = (Double) (Convert.ToInt32(display.Text,16));
            basenum = 16;
        }

        private void btnPi_Click(Object sender, EventArgs e)
        {
            display.Text = "3.141592";
        }

        private void btn1x_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"(1/{display.Text}";
            display.Text = (1 / Double.Parse(display.Text)).ToString();
        }

        private void btnSqrt_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"sqrt({display.Text})";
            display.Text = Math.Sqrt(Double.Parse(display.Text)).ToString();
        }
        private void btnCuad_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"({display.Text})^2";
            display.Text = (Double.Parse(display.Text) * Double.Parse(display.Text) ).ToString();
        }
        private void btnLog_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Log({display.Text})";
            display.Text = Math.Log10(Double.Parse(display.Text)).ToString();
        }
        private void btnLn_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Ln({display.Text})";
            display.Text = Math.Log(Double.Parse(display.Text)).ToString();
        }

        private void btnExp_Clic(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Exp({display.Text})";
            display.Text = Math.Exp(Double.Parse(display.Text)).ToString();
        }


        private void btnSin_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Sin({display.Text})";
            display.Text = Math.Sin(Double.Parse(display.Text)).ToString();
        }
        private void btnSinh_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Sinh({display.Text})";
            display.Text = Math.Sinh(Double.Parse(display.Text)).ToString();
        }

        private void btnCos_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Cos({display.Text})";
            display.Text = Math.Cos(Double.Parse(display.Text)).ToString();
        }
        private void btnCosh_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Cosh({display.Text})";
            display.Text = Math.Cosh(Double.Parse(display.Text)).ToString();
        }
        private void btnTan_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Tan({display.Text})";
            display.Text = Math.Tan(Double.Parse(display.Text)).ToString();
        }
        private void btnTanh_Click(Object sender, EventArgs e)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            lblOp.Text = $"Tanh({display.Text})";
            display.Text = Math.Tanh(Double.Parse(display.Text)).ToString();
        }


        private void menuEstandar_click(object sender, EventArgs e)
        {
            this.Size=new Size(300, 500);
            display.Size = new Size(260, 50);
        }

        private void menuCientifica_click(object sender, EventArgs e)
        {
            this.Size=new Size(600, 500);
            display.Size = new Size(558, 50);
        }

        private void clicked(object sender, EventArgs e)
        {
            if(sender != null)
            {
                Button button = sender as Button;
                switch (button.Text)
                {
                    case "⌫":
                        if(display.Text.Length > 0)
                        {
                            display.Text = display.Text.Remove(display.Text.Length - 1, 1);
                        }
                        if(display.Text =="")
                        {
                            display.Text = "0";
                        }
                        break;
                    case "CE":
                        display.Text = "0";

                        break;
                    case "C":
                        display.Text = "0";
                        lblOp.Text = "";
                        break;
                    case "±":
                        display.Text = (Double.Parse(display.Text) * -1).ToString();
                        break;
                    case "=":
                        boton_igual();
                        break;

                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case ".":
                        boton_num(button.Text);
                        break;
                    case "+":
                    case "-":
                    case "*": 
                    case "/":
                    case "Mod":
                        boton_operador(button.Text);
                        break ;
                    case "x^y":
                    //case "1/x":
                        boton_operador2(button.Text);

                        break;

                }
            }
        }
        private void boton_num(string val)
        {
            if(display.Text== "0")
            {
                display.Text = "";
            }
            if(val == ".")
            {
                if (!display.Text.Contains("."))
                {
                    display.Text += val;
                }
            }
            else
            {
                display.Text += val;
            }
        }

        private void boton_operador(string operador)
        {
            if (basenum != 10)
            {
                display.Text = decimalVal(display.Text).ToString();
            }
            operacion = operador;
            resul = Double.Parse(display.Text);
            lblOp.Text = display.Text+" "+operacion;
            display.Text = "0";
        }
        private void boton_operador2(string operador)
        {
            operacion = operador;
            resul = Double.Parse(display.Text);
            lblOp.Text = display.Text + " ";
            switch (operador)
            {
                case "x^y":
                    lblOp.Text += "^";
                    break;
            }
            display.Text = "0";
        }
        private void boton_igual()
        {
            lblOp.Text += " "+ display.Text+" =";
            switch (operacion)
            {
                case "+":
                    display.Text = (resul += Double.Parse(display.Text)).ToString() ;
                    break;
                case "-":
                    display.Text = (resul -= Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (resul *= Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (resul /= Double.Parse(display.Text)).ToString();
                    break;
                case "Mod":
                    display.Text = (resul %= Double.Parse(display.Text)).ToString();
                    break;
                    case "x^y":
                    display.Text = Math.Pow(resul,Double.Parse(display.Text)).ToString();
                    break;
                    
            }
        }
    }
}
