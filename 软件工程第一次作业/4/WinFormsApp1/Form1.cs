namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point oriPoint;
        private void button1_MouseDown(object sender, MouseEventArgs e)

        {

            oriPoint = e.Location;

        }
        private void button1_MouseMove(object sender, MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Left)//���������������

            {

                Button b = sender as Button;

                //��ǰλ�õ�������ƶ�ǰ��λ�ü��Ϻ���ʼλ�õĲ��

                b.Location = new Point(b.Location.X + (e.X - oriPoint.X), b.Location.Y + (e.Y - oriPoint.Y));

            }

        }
    }
}