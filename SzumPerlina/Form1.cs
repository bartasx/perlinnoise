using System;
using System.Drawing;
using System.Windows.Forms;

namespace SzumPerlina
{
    public partial class Form1 : Form
    {
        private int _number = 1;
        private int _shift = 1;
        private bool IsStartedGenerating = false;
        private int _currentX = 0;
        private float _currentY = 0;
        public Form1()
        {
            this.InitializeComponent();
        }

        private void gnerateButton_Click(object sender, EventArgs e)
        {
            if (!this.IsStartedGenerating)
            {
                for (int i = 0; i < 600; i++)
                {
                    var random = new Random();
                    float x = random.Next(10, 30);
                    var noiseResult = this.GeneratePerlinNoise(x);

                    if (!IsStartedGenerating)
                    {
                        this.Draw(100);
                        this.IsStartedGenerating = true;
                        this.Draw(noiseResult + 100);
                    }
                    else
                    {
                        this.Draw(this._currentY + noiseResult);
                    }
                }
            }
            else
            {
                MessageBox.Show("Szum zostal juz wygenerowany", "Uwaga");
            }
        }

        private void Draw(float position)
        {
            var graphics = this.CreateGraphics();
            this.Show();
            var blackPen = new Pen(Color.Black, 3);

            this._currentY = position;

            graphics.DrawRectangle(blackPen, this._shift, position, 1, 1);
            this._number++;
            this._shift += 1;
        }

        public float Noise(int x)
        {
            x = (x << 13) ^ x;
            return (float)(1.0 - ((x * (x * x * 15731 + 789221) + 1376312589) & 0x7fffffff) / 1073741824.0f);
        }

        public float SmoothedNoise(float x)
        {
            return Noise((int)x) / 2 + Noise((int)x - 1) / 4 + Noise((int)x + 1) / 4;
        }

        public float InterpolatedNoise(float x)
        {
            int integerX = (int)x;
            float fractionalX = x - integerX;
            float v1 = SmoothedNoise(integerX);
            float v2 = SmoothedNoise(integerX + 1);

            return v1 + (v2 - v1) * fractionalX;
        }

        public float GeneratePerlinNoise(float x)
        {
            float total = 0;
            float p = 0.25f;
            int n = 4;
            for (int i = 0; i <= n; i++)
            {
                float frequency = (float)Math.Pow(2, i);
                float amplitude = (float)Math.Pow(p, i);
                total += InterpolatedNoise(x * frequency) * amplitude;
            }
            return total;
        }
    }
}