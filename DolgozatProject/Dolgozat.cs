using System.Drawing;

namespace DolgozatProject
{
    public class Dolgozat
    {
        private List<int> pontok;

        public Dolgozat()
        {
            this.pontok = new List<int>();
        }

        public int Bukas 
        { 
            get
            {
                return this.pontok.Count(x => x < 50 && x > -1);
            } 
        }

        public int Elegseges
        {
            get
            {
                return this.pontok.Count(x => x <= 60 && x >= 50);
            }
        }

        public int Kozepes
        {
            get
            {
                return this.pontok.Count(x => x <= 70 && x >= 61);
            }
        }

        public int Jo
        {
            get
            {
                return this.pontok.Count(x => x <= 80 && x >= 71);
            }
        }

        public int Jeles
        {
            get
            {
                return this.pontok.Count(x => x >= 81);
            }
        }

        public bool Ervenytelen
        {
            get
            {
                int nemirt = this.pontok.Count(x => x == -1);
                double szazalek = (double)nemirt / this.pontok.Count;
                if (szazalek >= 0.5)
                {
                    return true;
                }
                return false;
            }
        }

        public void PontFelvesz(int pont)
        {
            if (pont < -1 || pont > 100)
            {
                throw new ArgumentException("A pontnak -1 és 100 között kell lennie", nameof(pont));
            }
            else
            {
                this.pontok.Add(pont);
            }
        }

        public bool MindenkiMegirta()
        {
            return this.pontok.Count(x => x == -1) == 0;
        }

        public bool Gyanus(int kivalok)
        {
            if (kivalok < 0)
            {
                throw new ArgumentException("A kiválók száma nem lehet mínusz", nameof(kivalok));
            }
            else
            {
                if (this.Jeles > kivalok)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
