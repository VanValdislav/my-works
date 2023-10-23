using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GrafipsDota2Map = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.SqlTypes;
using System.Dynamic;
using System.CodeDom.Compiler;
using System.Security.Policy;
using System.Security.Permissions;

namespace GrafipsDota2Map
{
    public partial class Form1 : Form
    {
        public static int counterMass = 1000;
        int counter = 136;
        public double[] massX1 = new double[counterMass];
        public double[] massY1 = new double[counterMass];

        string k = "";


        string pathX1 = @"C:\Users\fona1\source\repos\GrafipsDota2Map\MassX1.txt";
        string pathY1 = @"C:\Users\fona1\source\repos\GrafipsDota2Map\MassY1.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void drawMap_Click(object sender, EventArgs e)
        {
            StreamMass(massX1.Length);
            Thread.Sleep(2000);
            
            MoveMouse(SystemInformation.VirtualScreen.Width-1680 , SystemInformation.VirtualScreen.Height-850);
        }

        public void MoveMouse(int screenWhidth , int screenHeigt) 
        {
            POINT p = new POINT();
            int speed = 35;
            //////////////////////////////////////////////////////
            int c = 0;
            while (true) 
            {
                p.x = massX1[c];
                p.y = massY1[c] + 850;

                ClientToScreen(Handle,ref p);
                SetCursorPos(Convert.ToInt16(p.x) , Convert.ToInt16(p.y));

                c++; 
                DoMouseLeftClickDown(Convert.ToInt16(p.x), Convert.ToInt16(p.y));

                Thread.Sleep(speed);

                if (c == counter)
                {
                    break;
                }
            }
            DoMouseLeftClickUp(Convert.ToInt16(p.x), Convert.ToInt16(p.y));
        
        }

        public void StreamMass(int x1) 
        {
            using (StreamReader str = File.OpenText(pathX1))
            {
                for (int i = 0; i < x1; i++)
                {
                    k = Convert.ToString(str.ReadLine());
                    massX1[i] = Convert.ToDouble(k);
                }               
            }
            using (StreamReader str = File.OpenText(pathY1))
            {
                for (int i = 0; i < x1; i++)
                {
                    k = Convert.ToString(str.ReadLine());
                    massY1[i] = Convert.ToDouble(k);
                }
            }

        }


        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x , int y);

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hwnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT 
        {
            public double x;
            public double y;
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dsFlags, int dx, int dy,int cButtons,int dsExtrainfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        private void DoMouseLeftClickDown(int x, int y) 
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN,x,y,0,0);
        }
        private void DoMouseLeftClickUp(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref POINT lpPoint);

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ширина " + SystemInformation.VirtualScreen.Width +
                " Высота " + SystemInformation.VirtualScreen.Height);
        }

    }
}
