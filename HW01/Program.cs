using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new Form_Game_FlappyBird());
            Application.Run(new Form_HW17_Window());
            //Application.Run(new Form_HW15_Guess());
            //Application.Run(new Form_HW14_PictureViewer());
            //Application.Run(new Form_HW13_DrawPaint());
            //Application.Run(new Form_HW11_ScreenSaver()); 
            //Application.Run(new Form_HW10_XOGame());
            //Application.Run(new Form_HW10_XOGame_new());
            //Application.Run(new Form_HW08_Clac());
            //Application.Run(new Form_HW06_StudentList());
            //Application.Run(new Form_HW05_StudentGrade());
            //Application.Run(new Form_HW04_StudentStruct());
            //Application.Run(new Form_HW03_POS());
            //Application.Run(new Form_HW02_Loan());
            //Application.Run(new Form_HW02_LoanReport());
        }
    }
}
