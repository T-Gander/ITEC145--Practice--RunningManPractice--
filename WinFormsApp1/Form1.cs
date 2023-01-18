namespace RunningManPractice
{
    public partial class Form1 : Form
    {
        Image[] myImageArray = new Image[10];
        int count = 0;
        bool runningRight = true;

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 6;  i++)
                myImageArray[i-1] = new Bitmap("walk_R_"+i+".png");

            for (int i = 1; i < 6; i++)
                myImageArray[i + 4] = new Bitmap("walk_L_" + i + ".png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = myImageArray[count];
            count++;

            if (count > 4 && runningRight)
            {
                count = 0;
            }
            else if (count > 9)
            {
                count = 5;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            runningRight = !runningRight;
            
            if (runningRight)
            {
                count = 0;
            }
            else
            {
                count = 6;
            }
            
        }
    }
}