using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class FormRullesMiniGame : Form
    {
        
        public FormRullesMiniGame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormRullesMiniGame_Load(object sender, EventArgs e)
        {
            labelFill.Text = "Перед вами представлено 25 выражений. " +
                "Среди них вам необходимо выбрать выражения, равные тому числу, " +
                "которое будет указано на верхней панели. Если вы ошибетесь 5 раз, " +
                "то вы проиграете. С помощью таймера вы можете отследить за какое время вы справились. \n" +
                "УДАЧИ!";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMiniGames form = new FormMiniGames();
            this.Close();
            form.ShowDialog();
            
            
        }
    }
}
