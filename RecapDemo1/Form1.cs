using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // Button button = new Button();                               // Butuonlar bir class dır.

            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)              // sekiz satır için bir değer oluşturdum
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();                                        // [0,0],[0,1],[0,2],[0,3],[0,4],[0,5],[0,6],[0,7],,   // [0,0],[1,0],[2,0],[3,0],[4,0],[5,0],[6,0],[7,0]
                    buttons[i, j].Width = 50;                       
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;                                        // Kenardan uzaklığı demek
                    buttons[i, j].Top = top;
                    left += 50;                                                       // soldan sağa 50 kayar böylelikle butonlar üst üstte gelmemiş olur
                    this.Controls.Add(buttons[i, j]);

                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                
                }
                top += 50;
                left = 0;                                          // ikinci satıra geçiyor


            }


            
            // this.Controls.Add(button);                                  // oluşturmuş olduğum butonu ekrana koy demeketir.
            
        
        
        
        
        
        
        
        }
    }
}
