using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.Runtime.InteropServices;
 
namespace test
{
    class HelloWorld
    {
				static Form frm;
				
        public static void Main()
        {
         		frm = new Form();
         		frm.Size = new Size(200, 60);
         		frm.TopMost = true;
         		frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            frm.Paint += new PaintEventHandler(frm_Paint); //注册事件处理程序

            Application.Run(frm);
        }
        
       	static void mytimer_tick(object sender, EventArgs e)
        {
            frm.Text = Cursor.Position.X.ToString() + ":" + Cursor.Position.Y.ToString();
        }
 
        static void frm_Paint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            
            frm.Text = Cursor.Position.X.ToString() + ":" + Cursor.Position.Y.ToString();
            
            Graphics g = e.Graphics;
            //g.Clear(Color.Black);
            g.DrawString("鼠标当前位置", frm.Font, Brushes.Black, new Point(0, 0));
            
            Timer mytimer = new Timer();
            mytimer.Tick += new EventHandler(mytimer_tick);
            mytimer.Interval = 100;
       			mytimer.Start();
        }
    }
}