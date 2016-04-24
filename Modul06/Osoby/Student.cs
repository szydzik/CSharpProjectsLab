using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoby
{
    public class Student : Osoba
    {
        private readonly int numerIndeksu;
        public int NumerIndeksu
        {
            get { return numerIndeksu; }
        }

        public Student(string imie, string nazwisko, int rokUrodzenia, Plec plec, int numerIndeksu)
            : base(imie, nazwisko, rokUrodzenia, plec)
        {
            this.numerIndeksu = numerIndeksu;
        }

        public Student(Student student)
            :base(student.Imie, student.Nazwisko, student.RokUrodzenia, student.Plec)
        {
            this.numerIndeksu = student.NumerIndeksu;
        }

        public new string ZwrocInformacje()
        {
            return string.Format("{0} numer ideksu {1}", base.ZwrocInformacje(), NumerIndeksu);
        }

    }
}
