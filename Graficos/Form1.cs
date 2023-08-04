using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _37___Graficos
{
    public partial class Form1 : Form
    {
        Dictionary<double, double> valores;
        int contadorX = 0;

        public Form1()
        {
            InitializeComponent();
            valores = new Dictionary<double, double>();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxX.Focus();   

            for (int i = 0; i < 35; i++)
            {
                comboTipoGrafico.Items.Add((SeriesChartType)i);   


            }

            for (int i = 0; i < 3; i++)
            {
                comboCores.Items.Add((ChartColorPalette)i);   
            }


        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxX.Text) || string.IsNullOrEmpty(textBoxY.Text))
            {
                MessageBox.Show("Os dois valores são obrigatórios");
                return;
            }

            if (valores.ContainsKey(double.Parse(textBoxX.Text)))   
            {
                valores[double.Parse(textBoxX.Text)] = double.Parse(textBoxY.Text); 
            }
            else  
            {
                valores.Add(double.Parse(textBoxX.Text),double.Parse(textBoxY.Text)); 
                string x = textBoxX.Text; 
                string y = textBoxY.Text; 
            }

            var items = from valor in valores orderby valor.Key ascending select valor;   
            dataGridView1.Rows.Clear();  
            grafico.Series[0].Points.Clear();   

            foreach (var item in items)   
            {
                dataGridView1.Rows.Add(item.Key, item.Value);  
                grafico.Series[0].Points.AddXY(item.Key, item.Value);   
            }

            grafico.Update();   

            textBoxX.Text = "";    
            textBoxY.Text = "";     
            textBoxX.Focus();       

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBoxX.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                        

            textBoxY.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                       
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            valores.Clear();       
            grafico.Series[0].Points.Clear();       
            dataGridView1.Rows.Clear();             
            contadorX = 0;         
            textBoxX.Text = "";    
            textBoxY.Text = "";    
            textBoxX.Focus();       
        }

        private void comboTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Series[0].ChartType = (SeriesChartType)comboTipoGrafico.SelectedItem;   
        }

        private void comboCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Palette = (ChartColorPalette)comboCores.SelectedItem;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grafico.ChartAreas[0].Area3DStyle.Enable3D = checkBox1.Checked; 
        }

        private void buttonValoresAle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;   
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (Char)44 ||
                (textBoxX.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;  
            }
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (Char)44 ||
                (textBoxY.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;   
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (grafico.Series[0].Points.Count > 10)   
            {
                grafico.Series[0].Points.RemoveAt(0);   
                grafico.Update();        
            }

            double y = (double)new Random((int)DateTime.Now.Ticks).Next(1000);  
            grafico.Series[0].Points.AddXY(contadorX++, y); 

            dataGridView1.Rows.Add(contadorX, y);  
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                          
        }
    }
}
