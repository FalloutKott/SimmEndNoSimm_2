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

        



        public  void ResultBtn_Click(object sender, EventArgs e) // Событие по нажатию кнопки Результат
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

        public void ChoiceLoad_CheckedChanged(object sender, EventArgs e) // Чекбокс // Создать события исключения !!! 
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
