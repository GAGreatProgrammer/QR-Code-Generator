using System.Collections.Generic;
using System.Windows.Forms;

namespace QR_Code_Generator.Classes
{
    public static class TopPanelState
    {
        public static int StateFlag;

        public static void DisableButtons(List<Bunifu.UI.WinForms.BunifuButton.BunifuButton> buttons)
        {
            foreach (Control button in buttons)
                button.Enabled = false;
        }

        public static void EnableButtons(List<Bunifu.UI.WinForms.BunifuButton.BunifuButton> buttons)
        {
            foreach (Control button in buttons)
                button.Enabled = true;
        }
    }
}
