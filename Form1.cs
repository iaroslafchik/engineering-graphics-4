using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace graphics_lab_4
{
    public partial class Form1 : Form
    {
        double scalingX = 1.0;
        double scalingY = 1.0;
        double scalingZ = 1.0;

        double x = 0, y = 0, z = 0;


        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            // очистка окна
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            // установка порта вывода в соответствии с размерами элементаanT
            Gl.glViewport(0, 0, simpleOpenGlControl1.Width, simpleOpenGlControl1.Height);
            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)simpleOpenGlControl1.Width / simpleOpenGlControl1.Height, 0.1f, 100.0f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // настройка параметровOpenGL для визуализации
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBarSlices_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBarStacks_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            x = checkBoxX.Checked ? 1 : 0;
            y = checkBoxY.Checked ? 1 : 0;
            z = checkBoxZ.Checked ? 1 : 0;

            scalingX = checkBoxScalingX.Checked ? trackBarScale.Value / 1000.0 : 1.0;
            scalingY = checkBoxScalingY.Checked ? trackBarScale.Value / 1000.0 : 1.0;
            scalingZ = checkBoxScalingZ.Checked ? trackBarScale.Value / 1000.0 : 1.0;

            label1.Text = "Size = " + trackBarSize.Value / 1000.0;
            label2.Text = "Stacks = " + trackBarStacks.Value;
            label3.Text = "Slices = " + trackBarSlices.Value;
            label4.Text = "Height = " + trackBarHeight.Value;
            label5.Text = "Angle = " + trackBarAngle.Value;
            label6.Text = "Scale = " + trackBarScale.Value / 1000.0;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -10);
            Gl.glRotated(trackBarAngle.Value, x, y, z);
            Gl.glScaled(scalingX, scalingY, scalingZ);

            if (comboBox1.SelectedIndex == 0)
            {
                trackBarStacks.Enabled = false;
                trackBarSlices.Enabled = false;
                trackBarHeight.Enabled = false;

                Glut.glutWireCube(trackBarSize.Value / 1000.0);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                trackBarStacks.Enabled = true;
                trackBarSlices.Enabled = true;
                trackBarHeight.Enabled = false;

                Glut.glutWireSphere(trackBarSize.Value / 1000.0, trackBarSlices.Value, trackBarStacks.Value);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                trackBarStacks.Enabled = true;
                trackBarSlices.Enabled = true;
                trackBarHeight.Enabled = true;
                Glut.glutWireCylinder(trackBarSize.Value / 1000.0, trackBarHeight.Value, trackBarSlices.Value, trackBarStacks.Value);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                trackBarStacks.Enabled = true;
                trackBarSlices.Enabled = true;
                trackBarHeight.Enabled = true;
                Glut.glutWireCone(trackBarSize.Value / 1000.0, trackBarHeight.Value, trackBarSlices.Value, trackBarStacks.Value);
            }
            Gl.glPopMatrix();
            Gl.glFlush();
            simpleOpenGlControl1.Invalidate();
        }
    }
}
