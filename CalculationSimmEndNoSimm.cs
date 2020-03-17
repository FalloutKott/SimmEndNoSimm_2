using System;
using System.Windows.Forms;

namespace SimmEndNoSimm_2
{
    public class CalculationSimmEndNoSimm
    {

        public static void CalculationSymmetricalLoad() // Расчёты СИММ // P = 3*Uф*I* cos(φ) = 1,73Uл*I* cos(φ)
        {
            double IL1 = Convert.ToDouble(TBL1.Text);
            double U1 = Convert.ToDouble(TBU1.Text);
            double result = 1.73 * U1 * IL1;                     // формула 
            ResultLable.Text = $"{result / 1000} kWt";
        }
        public static void CalculationNoSymmetricalLoad() // Расчёты НеСИММ // Pобщ = Ua*Ia* cos(φ1) + Ub*Ib* cos(φ2) + Uc*Ic* cos(φ3)
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

    }
}
