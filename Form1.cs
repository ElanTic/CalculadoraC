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
        private ToolStripItem catTipo;
        private ToolStripItem miEstandor;
        private ToolStripItem miCientifica;
          

        //private Button x;
        private TextBox display;
        private Label lblOp;
        private string operacion;
        private Double resul;
        public Form1()
        {
            this.Size = new Size(600, 500);
            this.Text = "Calculator";
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




            display.Size = new Size(260,30);
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

            btnPi.Text =" ";
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
            x = 330;
            y = 85;
            foreach (Button button in cientific)
            {
                if (count == 4)
                {
                    x = 330;
                    y += 57;
                    count = 0;
                }
                button.Location = new Point(x, y);
                button.Click += new EventHandler(clicked);
                this.Controls.Add(button);
                x += 67;
                count++;
            }
          //  catTipo.DropDown

           // catTipo.DropDownItems().Add(miEstandor);
           // catTipo.DropDownItems().Add(miCientifica);
            menu.Items.Add(catTipo);

            this.Controls.Add(display);
            this.Controls.Add(lblOp);
            this.Controls.Add(menu);
            lblOp.BringToFront();
            InitializeComponent();
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
                        boton_operador(button.Text);

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
            operacion = operador;
            resul = Double.Parse(display.Text);
            lblOp.Text = display.Text+" "+operacion;
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
            }
        }
    }
}
