namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            //Application.Exit();

            //szeroko�� okna aplikacji
            int windowWidth = Size.Width;
            //wysoko�� okna aplikacji
            int windowHeight = Size.Height;

            //�eby unikn�� sytuacji, kiedy guzik wyl�duje poza oknem aplikacji, odejmujemy jego szeroko�c i wysoko�� odpowiednio
            windowWidth -= centerButton.Width;
            windowHeight -= centerButton.Height;

            //inicjalizacja generatora liczb losowych
            Random rnd = new Random();

            //losowa odleg�o�� od lewej - nie wi�cej ni� szeroko�� okna
            int randomLeft = rnd.Next(windowWidth);

            //analogicznie z odleg�o�ci� od g�ry
            int randomTop = rnd.Next(windowHeight);

            //przesuwamy guzik
            //location musi by� przekazany jako punkt na ekranie 
            Point topLeftCorner = new Point(randomLeft, randomTop);
            //centerButton to nazwa (atrybut Name) mojego guzika
            centerButton.Location = topLeftCorner;
        }
    }
}