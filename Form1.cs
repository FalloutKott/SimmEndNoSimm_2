using System;
using System.Windows.Forms;

namespace SimmEndNoSimm_2
{
    public partial class UIForm : Form
    {

        public UIForm()
        {
            InitializeComponent();
        }

        public void UIForm_Load(object sender, EventArgs e) // Загрузка формы
        {
            // Обработать исключения ввода символов
            // Ввод пустых полей

        }

        public void CalculationSymmetricalLoad() // Расчёты СИММ // P = 3*Uф*I* cos(φ) = 1,73Uл*I* cos(φ)
        {
            double IL1 = Convert.ToDouble(TBL1.Text);
            double U1 = Convert.ToDouble(TBU1.Text);
            double result = 1.73 * U1 * IL1;                     // формула 
            ResultLable.Text = $"{result / 1000} kWt";
        }
        public void CalculationNoSymmetricalLoad() // Расчёты НеСИММ // Pобщ = Ua*Ia* cos(φ1) + Ub*Ib* cos(φ2) + Uc*Ic* cos(φ3)
        {
            double IL1 = Convert.ToDouble(TBL1.Text);
            double IL2 = Convert.ToDouble(TBL2.Text);
            double IL3 = Convert.ToDouble(TBL3.Text);
            double U1 = Convert.ToDouble(TBU1.Text);
            double U2 = Convert.ToDouble(TBU2.Text);
            double U3 = Convert.ToDouble(TBU3.Text);
            double result = ((U1 * IL1) + (U2 * IL2) + (U3 * IL3)); // формула 
            ResultLable.Text = $"{result / 1000} kWt";
        }



        private void ResultBtn_Click(object sender, EventArgs e) // Событие по нажатию кнопки Результат
        {
            if (ChoiceLoad.Checked)
            {
                CalculationSymmetricalLoad();
            }
            else
            {
                CalculationNoSymmetricalLoad();
            }
        }

        private void ChoiceLoad_CheckedChanged(object sender, EventArgs e) // Чекбокс // Создать события исключения !!! 
        {
            if (ChoiceLoad.Checked)
            {
                TBL2.Enabled = false;
                TBL3.Enabled = false;

                //TBU1.Text = "380";
                TBU2.Enabled = false;
                TBU3.Enabled = false;
                ChoiceLoad.Text = "Расчёт симметричной нагрузки";
            }
            else
            {
                TBL1.Clear();
                TBL2.Clear();
                TBL3.Clear();
                TBL2.Enabled = true;
                TBL3.Enabled = true;

                TBU1.Clear();
                TBU2.Clear();
                TBU3.Clear();
                TBU2.Enabled = true;
                TBU3.Enabled = true;
                ChoiceLoad.Text = "Расчёт НЕсимметричной нагрузки";
            }
        }
    }
}
