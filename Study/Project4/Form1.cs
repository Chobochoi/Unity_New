namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        Rectangle ball;
        bool[] blockVisible = new bool[100];

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        
        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;
        
        int nBlocks = 20;
        
        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        double slope; // 기울기
        double vDir; // 공 수직방향 여부

        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            // 그래픽 객체 생성
            g = this.CreateGraphics();
           
            
                // 블록 초기화
                InitBlocks();

                // 라켓 초기화
                InitRacket();

                // 공 초기화
                InitBall();

                // 기울기값 초기화
                slope = rand.Next(1, 20) / 10.0;
                if (rand.Next(2) % 2 == 1)
                {
                    slope = -slope;
                }
                vDir = 1;
            
           
        }       

        public void InitBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i%10*blockW, blockY + blockH * (i/10), blockW -1, blockH -1);

                blockVisible[i] = true;
            }
        }

        public void InitRacket()
        {
            racket.X = formW/2 - racketW/2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW/2 - ballW/2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i<nBlocks; i++)
            {
                if (blockVisible[i])
                {
                    // 벽돌 그리기
                    g.FillRectangle(blockColor, blocks[i]);
                }
            }
                // 라켓 그리기
                g.FillRectangle(racketColor, racket);

                // 공 그리기
                g.FillEllipse(ballColor, ball);
                g.DrawEllipse(pen, ball);                   

            
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("tick!");
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            int x = (int)dx;
            int y = (int)(vDir * slope * dx);


            ball.X += x;
            ball.Y += y;

            // ball이 좌우 벽에 충돌 했는지 체크
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope = -slope;
            }

            // ball이 racket에 맞았는지 체크
            if (ball.Y < 0 || racket.IntersectsWith(ball))
            {
                vDir = -vDir;
            }

            // ball이 벽돌을 맞았는지 체크
            for (int i = 0; i<nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]) && blockVisible[i])
                {
                    vDir = -vDir;
                    blockVisible[i] = false;
                }
            }

            // ball을 라켓으로 놓쳤을 때
            if (ball.Y > ClientSize.Height)
            {
               myTimer.Stop();
                
                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // 블록 초기화
                    InitBlocks();

                    // 라켓 초기화
                    InitRacket();

                    // 공 초기화
                    InitBall();
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
                                
            }
            
            // 모든 벽돌을 다 깼을 때
            

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (racket.X >= 0)
                {
                    racket.X -= 10;
                }
                
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (racket.X <= formW -racketW)
                {
                    racket.X += 10;
                }
            }
            
            Invalidate();

        }
    }
}