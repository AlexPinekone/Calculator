using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {
        public int op1,op2,tipoOp;
        public string cadOpe1, cadOpe2;
        public Boolean opDif=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Botones numericos
        private void num0_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "0";
            calculaDigitos();

        }
        private void num1_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "1";
            calculaDigitos();
        }
        private void num2_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "2";
            calculaDigitos();
        }
        private void num3_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "3";
            calculaDigitos();
        }
        private void num4_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "4";
            calculaDigitos();
        }
        private void num5_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "5";
            calculaDigitos();
        }
        private void num6_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "6";
            calculaDigitos();
        }
        private void num7_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "7";
            calculaDigitos();
        }
        private void num8_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "8";
            calculaDigitos();
        }
        private void num9_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = cajaResultado.Text + "9";
            calculaDigitos();
        }

        //Funciones generales
        private int calculaDigitos()
        {
            //Se escriben las cadenas para calcular su longitud individual
            if (opDif)
            {
                cadOpe1=cajaResultado.Text;
                if (cadOpe1.Equals(""))
                {
                    MessageBox.Show("Valor vacio");
                    return 0;
                }
                else
                {
                    try { 
                        op1 = int.Parse(cajaResultado.Text);
                        return 1;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Valor no valido, solo numeros");
                        cajaResultado.Text = "";
                        return 0;
                    }
                }
                
            }
            else
            {
                cadOpe2 = cajaResultado.Text.Remove(0,cadOpe1.Length+1);
                if (cadOpe2.Equals(""))
                {
                    MessageBox.Show("Valor vacio");
                    return 0;
                }
                else
                {
                    try
                    {
                        op2 = int.Parse(cadOpe2);
                        return 1;
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Valor no valido, solo numeros");
                        cajaResultado.Text = "";
                        return 0;
                    }
                }
                
            }
        }

        //Botones Operadores(op)
        private void opDel_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "";
            opDif = true;
            op1 = 0;
            op2 = 0;
            cadOpe1 = "";
            cadOpe2 = "";
        }

        //Suma es el tipo de operacion 1
        private void opSuma_Click(object sender, EventArgs e)
        {
            if (opDif)
            {
                //Define el primer operador
                if (calculaDigitos() == 1)
                {
                    cajaResultado.Text += "+";
                    tipoOp = 1;
                    opDif = false;
                }
            }
            else
            {
                //Por si usa el simbolo en lugar del igual
                if (calculaDigitos() == 1)
                {
                    int resul = hazOperacion();
                    op1 = resul;
                    cadOpe1 = resul.ToString();

                    listHistorial.Items.Add(cajaResultado.Text + "=" + resul);
                    cajaResultado.Text = resul + "";
                    opDif = true;
                    calculaDigitos();
                    cajaResultado.Text += "+";
                    tipoOp = 1;
                    opDif = false;
                }
            }
        }

        //Resta es el tipo de operacion 2
        private void opResta_Click(object sender, EventArgs e)
        {
            if (opDif)
            {
                //Define el primer operador
                if (calculaDigitos() == 1)
                {
                    cajaResultado.Text += "-";
                    tipoOp = 2;
                    opDif = false;
                }
            }
            else
            {
                //Por si usa el simbolo en lugar del igual
                if (calculaDigitos() == 1)
                {
                    int resul = hazOperacion();
                    op1 = resul;
                    cadOpe1 = resul.ToString();

                    listHistorial.Items.Add(cajaResultado.Text + "=" + resul);
                    cajaResultado.Text = resul + "";
                    opDif = true;
                    calculaDigitos();
                    cajaResultado.Text += "-";
                    tipoOp = 2;
                    opDif = false;
                }
            }
        }

        //Multiplicacion es el tipo de operacion 3
        private void opMulti_Click(object sender, EventArgs e)
        {
            if (opDif)
            {
                //Define el primer operador
                if (calculaDigitos() == 1)
                {
                    cajaResultado.Text += "*";
                    tipoOp = 3;
                    opDif = false;
                }
            }
            else
            {
                //Por si usa el simbolo en lugar del igual
                if (calculaDigitos() == 1)
                {
                    int resul = hazOperacion();
                    op1 = resul;
                    cadOpe1 = resul.ToString();

                    listHistorial.Items.Add(cajaResultado.Text + "=" + resul);
                    cajaResultado.Text = resul + "";
                    opDif = true;
                    calculaDigitos();
                    cajaResultado.Text += "*";
                    tipoOp = 3;
                    opDif = false;
                }
            }
        }


        //Division es el tipo de operacion 4
        private void opDivi_Click(object sender, EventArgs e)
        {
            if (opDif)
            {
                //Define el primer operador
                if (calculaDigitos() == 1)
                {
                    cajaResultado.Text += "/";
                    tipoOp = 4;
                    opDif = false;
                }
            }
            else
            {
                //Por si usa el simbolo en lugar del igual
                if (calculaDigitos() == 1)
                {
                    int resul = hazOperacion();
                    op1 = resul;
                    cadOpe1 = resul.ToString();

                    listHistorial.Items.Add(cajaResultado.Text + "=" + resul);
                    cajaResultado.Text = resul + "";
                    opDif = true;
                    calculaDigitos();
                    cajaResultado.Text += "/";
                    tipoOp = 4;
                    opDif = false;
                }
            }
        }


        //Simbolo igual
        private void opIgual_Click(object sender, EventArgs e)
        {
            if (calculaDigitos() == 1)
            {
                //Define el segundo operador
                int resul = hazOperacion();
                op1 = resul;
                cadOpe1 = resul.ToString();
                cadOpe2 = "";

                listHistorial.Items.Add(cajaResultado.Text + "=" + resul);
                cajaResultado.Text = resul + "";
                opDif = true;
                calculaDigitos();
            }
        }

       //El switch que usa los dos operadores leidos
        private int hazOperacion()
        {
            int res=0;
            switch (tipoOp)
            {
                case 1:
                    res = op1 + op2; break;
                case 2:
                    res = op1 - op2; break;
                case 3:
                    res = op1 * op2; break;
                case 4:
                    res = op1 / op2; break;
                default: MessageBox.Show("Operacion no valida");
                    cajaResultado.Text = "";
                    break;
            }
            return res;
        }

        private void opMemoria_Click(object sender, EventArgs e)
        {
            try
            {
                int mem = int.Parse(cajaResultado.Text);
                listMemoria.Items.Add(mem);
            }
            catch(Exception ex) { MessageBox.Show("Este no es un valor valido"); }
            
            
        }


        private void listMemoria_DoubleClick(object sender, EventArgs e)
        {


            if (sender.Equals(""))
            {
                MessageBox.Show("No hay valor");
            }
            else
            {
                //Recuperar la memoria primer valor
                if (opDif)
                {
                    cajaResultado.Text = "";
                    op1 = 0;
                    op2 = 0;
                    cadOpe1 = "";
                    cadOpe2 = "";
                    cajaResultado.Text = cajaResultado.Text + listMemoria.Items[listMemoria.SelectedIndex];
                    cadOpe1 = cajaResultado.Text;


                }
                else
                {
                    //Recuperar la memoria segundo valor
                    cajaResultado.Text = cajaResultado.Text + listMemoria.Items[listMemoria.SelectedIndex];

                    op2 = int.Parse(cajaResultado.Text.Remove(0, cadOpe1.Length + 1));
                    
                  
                }
            }
            
        }

    }
}
