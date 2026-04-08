using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    internal class GerirForms
    {
        public static void TrocarForms(Form formAtual, Form formNovo)
        {
            formAtual.Hide();
            formNovo.ShowDialog();
            formAtual.Close();
        }

    }
}
