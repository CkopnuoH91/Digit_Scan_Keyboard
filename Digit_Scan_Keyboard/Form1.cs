using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.Windows.Input;


namespace Digit_Scan_Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                checkBoxStatus.Checked = false;
                checkBoxStatus.Text = "Отключен";
                checkBoxStatus.ForeColor = Color.Red;
                buttonConnect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Не удалось закрыть соединение", "Статус соединения",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            FormCOM FC = new FormCOM();
            FC.ShowDialog(this);
        }

        private void btnClearTx_Click(object sender, EventArgs e)
        {
            textBoxTx.Clear();
        }

        private void btnClearRx_Click(object sender, EventArgs e)
        {
            textBoxRx.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Обрабатываем только цифры и символ 'r' для выключения всех сегментов
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 'r')
            {
                if (serialPort1.IsOpen)
                {
                    textBoxTx.Text += e.KeyChar.ToString() + Environment.NewLine;
                    serialPort1.Write(e.KeyChar.ToString());
                }
                else
                {
                    MessageBox.Show("Не возможно отправить команду т.к. порт не подлючен!", "Ошибка отправки команды", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
        
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadExisting();
                BeginInvoke(new SetTextDeleg(si_DataReceived),
                new object[] { data });
            }
            catch
            {
            }
        }

        //Метод обработки полученных данных
        private void si_DataReceived(string data)
        {
            textBoxRx.Text += data + Environment.NewLine;
        }

        //Делегат для функции si_DataReceived
        private delegate void SetTextDeleg(string text);
    }
}
