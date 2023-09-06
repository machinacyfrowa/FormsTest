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

            //szerokoœæ okna aplikacji
            int windowWidth = Size.Width;
            //wysokoœæ okna aplikacji
            int windowHeight = Size.Height;

            //¿eby unikn¹æ sytuacji, kiedy guzik wyl¹duje poza oknem aplikacji, odejmujemy jego szerokoœc i wysokoœæ odpowiednio
            windowWidth -= centerButton.Width;
            windowHeight -= centerButton.Height;

            //inicjalizacja generatora liczb losowych
            Random rnd = new Random();

            //losowa odleg³oœæ od lewej - nie wiêcej ni¿ szerokoœæ okna
            int randomLeft = rnd.Next(windowWidth);

            //analogicznie z odleg³oœci¹ od góry
            int randomTop = rnd.Next(windowHeight);

            //przesuwamy guzik
            //location musi byæ przekazany jako punkt na ekranie 
            Point topLeftCorner = new Point(randomLeft, randomTop);
            //centerButton to nazwa (atrybut Name) mojego guzika
            centerButton.Location = topLeftCorner;
        }
    }
}