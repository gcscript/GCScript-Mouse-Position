using System.Runtime.InteropServices;
using AutoIt;

namespace GCScript_Mouse_Position
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            MoveCursor((int)nud_X.Value, (int)nud_Y.Value, (int)nud_Speed.Value);
            SendKeys.SendWait("^");
        }

        
        private void MoveCursor(int x, int y, int speed)
        {
            AutoItX.MouseMove(x, y, speed);
        }
    }
}