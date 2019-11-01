using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igor_oop_lab7
{
    class Program
    {
        public class human
        {
            private string name;
            private string surname;
            private string humandate;

            public human(human obj)
            {
                name = obj.name;
                surname = obj.surname;
                humandate = obj.humandate;
            }
            public human()
            {
                name = "";
                surname = "";
                humandate = "";
            }
            public human(string _name, string _surname, string _humandate)
            {
                name = _name;
                surname = _surname;
                humandate = _humandate;
            }

            public void set_name(string _name) { name = _name; }
            public void set_surname(string _surname) { surname = _surname; }
            public void set_humandate(string _humandate) { humandate = _humandate; }
            public string get_name() { return name; }
            public string get_surname() { return surname; }
            public string get_humandate() { return humandate; }

            public virtual void set_info()
            {
                string infa = "";
                Console.WriteLine("\nVvedit im`9 ");
                infa = Console.ReadLine();
                set_name(infa);

                Console.WriteLine("Vvedit prizvis4e ");
                infa = Console.ReadLine();
                set_surname(infa);

                Console.WriteLine("Vvedit daty narodjennya ");
                infa = Console.ReadLine();
                set_humandate(infa);
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"\nIm`9 - {get_name()}");
                Console.WriteLine($"Prizvis4e - {get_surname()}");
                Console.WriteLine($"Data narodjennya - {get_humandate()}");
            }

        }


        public class abityrient : human
        {
            private double balzno;
            private double baldyplom;
            private string zaklad;

            public abityrient(abityrient obj)
            {
                set_name(obj.get_name());
                set_surname(obj.get_surname());
                set_humandate(obj.get_humandate());
                baldyplom = obj.baldyplom;
                balzno = obj.balzno;
                zaklad = obj.zaklad;
            }
            public abityrient()
            {
                set_name("");
                set_surname("");
                set_humandate("");

                balzno = 0;
                baldyplom = 0;
                zaklad = "";
            }
            public abityrient(string _name, string _surname, string _humandate, double _balzno, double _baldyplom, string _zaklad)
            {
                set_name(_name);
                set_surname(_surname);
                set_humandate(_humandate);
                baldyplom = _baldyplom;
                balzno = _balzno;
                zaklad = _zaklad;
            }
            public void set_baldyplom(double _baldyplom) { baldyplom = _baldyplom; }
            public void set_balzno(double _balzno) { balzno = _balzno; }
            public void set_zaklad(string _zaklad) { zaklad = _zaklad; }
            public double get_baldyplom() { return baldyplom; }
            public double get_balzno() { return balzno; }
            public string get_zaklad() { return zaklad; }

            public virtual void set_info()
            {
                base.set_info();
                string infa1;
                double infa2;
                Console.WriteLine("Vvedit bal v duplomi ");
                infa1 = Console.ReadLine();
                infa2 = Convert.ToDouble(infa1);
                set_baldyplom(infa2);

                Console.WriteLine("Vvedit bal za ZNO ");
                infa1 = Console.ReadLine();
                infa2 = Convert.ToDouble(infa1);
                set_balzno(infa2);

                Console.WriteLine("Vvedit nav4alnuy zaklad ");
                infa1 = Console.ReadLine();
                set_zaklad(infa1);
            }

            public virtual void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Bal diplom - {get_baldyplom()}");
                Console.WriteLine($"Bal ZNO - {get_balzno()}");
                Console.WriteLine($"Nav4alnui zaklad - {get_zaklad()}\n");
            }
        }

        public class student : human
        {
            private int kurs;
            private string grupa;
            private string fakultet;
            private string vn_zaklad;

            public student()
            {
                set_name("");
                set_surname("");
                set_humandate("");

                kurs = 0;
                grupa = "";
                fakultet = "";
                vn_zaklad = "";
            }

            public student(student obj)
            {
                set_name(obj.get_name());
                set_surname(obj.get_surname());
                set_humandate(obj.get_humandate());

                kurs = obj.kurs;
                grupa = obj.grupa;
                fakultet = obj.fakultet;
                vn_zaklad = obj.vn_zaklad;
            }
            public student(string _name, string _surname, string _humandate, int _kurs, string _grupa, string _fakultet, string _vn_zaklad)
            {
                set_name(_name);
                set_surname(_surname);
                set_humandate(_humandate);
                kurs = _kurs;
                grupa = _grupa;
                fakultet = _fakultet;
                vn_zaklad = _vn_zaklad;
            }
            public void set_kurs(int _kurs) { kurs = _kurs; }
            public void set_grupa(string _grupa) { grupa = _grupa; }
            public void set_fakultet(string _fakultet) { fakultet = _fakultet; }
            public void set_vn_zaklad(string _vn_zaklad) { vn_zaklad = _vn_zaklad; }
            public double get_kurs() { return kurs; }
            public string get_grupa() { return grupa; }
            public string get_fakultet() { return fakultet; }
            public string get_vn_zaklad() { return vn_zaklad; }

            public virtual void set_info()
            {
                base.set_info();
                string infa1;
                int infa2;
                Console.WriteLine("Vvedit nomer kyrsy ");
                infa1 = Console.ReadLine();
                infa2 = Convert.ToInt32(infa1);
                set_kurs(infa2);

                Console.WriteLine("Vvedit grypy ");
                infa1 = Console.ReadLine();
                set_grupa(infa1);

                Console.WriteLine("Vvedit fakyltet ");
                infa1 = Console.ReadLine();
                set_fakultet(infa1);

                Console.WriteLine("Vvedit nazvy vus4ogo nav4alnogo zaklady ");
                infa1 = Console.ReadLine();
                set_vn_zaklad(infa1);
            }

            public virtual void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Kyrs - {get_kurs()}");
                Console.WriteLine($"Grypa - {get_grupa()}");
                Console.WriteLine($"Fakyltet - {get_fakultet()}");
                Console.WriteLine($"Nav4alnui zaklad - {get_vn_zaklad()}\n");
            }
        }
        public class vuklada4 : human
        {
            private string posada;
            private string kafedra;
            private string vn_zaklad;

            public vuklada4()
            {
                set_name("");
                set_surname("");
                set_humandate("");

                posada = "";
                kafedra = "";
                vn_zaklad = "";
            }

            public vuklada4(vuklada4 obj)
            {
                set_name(obj.get_name());
                set_surname(obj.get_surname());
                set_humandate(obj.get_humandate());

                posada = obj.posada;
                kafedra = obj.kafedra;
                vn_zaklad = obj.vn_zaklad;

            }
            public vuklada4(string _name, string _surname, string _humandate, string _posada, string _kafedra, string _vn_zaklad)
            {
                set_name(_name);
                set_surname(_surname);
                set_humandate(_humandate);
                posada = _posada;
                kafedra = _kafedra;
                vn_zaklad = _vn_zaklad;
            }
            public void set_posada(string _posada) { posada = _posada; }
            public void set_kafedra(string _kafedra) { kafedra = _kafedra; }
            public void set_vn_zaklad(string _vn_zaklad) { vn_zaklad = _vn_zaklad; }
            public string get_posada() { return posada; }
            public string get_kafedra() { return kafedra; }
            public string get_vn_zaklad() { return vn_zaklad; }

            public virtual void set_info()
            {
                base.set_info();
                string infa1;

                Console.WriteLine("Vvedit posady ");
                infa1 = Console.ReadLine();
                set_posada(infa1);

                Console.WriteLine("Vvedit kafedry ");
                infa1 = Console.ReadLine();
                set_kafedra(infa1);

                Console.WriteLine("Vvedit nazvy vus4ogo nav4alnogo zaklady ");
                infa1 = Console.ReadLine();
                set_vn_zaklad(infa1);
            }

            public virtual void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Posada - {get_posada()}");
                Console.WriteLine($"Kafedra - {get_kafedra()}");
                Console.WriteLine($"Nav4alnui zaklad - {get_vn_zaklad()}\n");
            }
        }
        public class korustyva4_biblioteki : human
        {
            private int nomerkvutka;
            private string datavuda4i;
            private double vnesok;

            public korustyva4_biblioteki()
            {
                set_name("");
                set_surname("");
                set_humandate("");

                nomerkvutka = 0;
                datavuda4i = "";
                vnesok = 0;
            }

            public korustyva4_biblioteki(korustyva4_biblioteki obj)
            {
                set_name(obj.get_name());
                set_surname(obj.get_surname());
                set_humandate(obj.get_humandate());

                nomerkvutka = obj.nomerkvutka;
                datavuda4i = obj.datavuda4i;
                vnesok = obj.vnesok;
            }
            public korustyva4_biblioteki(string _name, string _surname, string _humandate, int _nomerkvutka, string _datavuda4i, double _vnesok)
            {
                set_name(_name);
                set_surname(_surname);
                set_humandate(_humandate);
                nomerkvutka = _nomerkvutka;
                datavuda4i = _datavuda4i;
                vnesok = _vnesok;
            }
            public void set_nomerkvutka(int _nomerkvutka) { nomerkvutka = _nomerkvutka; }
            public void set_datavuda4i(string _datavuda4i) { datavuda4i = _datavuda4i; }
            public void set_vnesok(double _vnesok) { vnesok = _vnesok; }
            public int get_nomerkvutka() { return nomerkvutka; }
            public string get_datavuda4i() { return datavuda4i; }
            public double get_vnesok() { return vnesok; }

            public virtual void set_info()
            {
                base.set_info();
                string infa1;
                double infa2;
                int infa3;

                Console.WriteLine("Vvedit nomer kvutka ");
                infa1 = Console.ReadLine();
                infa3 = Convert.ToInt32(infa1);
                set_nomerkvutka(infa3);

                Console.WriteLine("Vvedit daty vuda4i ");
                infa1 = Console.ReadLine();
                set_datavuda4i(infa1);

                Console.WriteLine("Vvedit symy vnesky ");
                infa1 = Console.ReadLine();
                infa2 = Convert.ToDouble(infa1);
                set_vnesok(infa2);
            }

            public virtual void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Nomer kvutka - {get_nomerkvutka()}");
                Console.WriteLine($"Data vuda4i - {get_datavuda4i()}");
                Console.WriteLine($"Vnesok - {get_vnesok()}\n");
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Human");
            human dimas = new human("nikitos", "adidas", "11/05/0666");
            dimas.GetInfo();
            human newhuman = new human(dimas);

            newhuman.GetInfo();
            
            Console.WriteLine("\nAbityrient");
            abityrient noob = new abityrient();
            noob.set_info();
            noob.GetInfo();

            abityrient noob2 = new abityrient(noob);
            noob2.GetInfo();
            
            Console.WriteLine("\nStudent");
            student student1 = new student();
            student1.set_info();
            student1.GetInfo();

            Console.WriteLine("\nVuklada4");
            vuklada4 vuklada4_1 = new vuklada4();
            vuklada4_1.set_info();
            vuklada4_1.GetInfo();

            Console.WriteLine("\nKorustyva4 biblioteki");
            korustyva4_biblioteki korustyva4_biblioteki_1 = new korustyva4_biblioteki();
            korustyva4_biblioteki_1.set_info();
            korustyva4_biblioteki_1.GetInfo();
            Console.ReadLine();
            
        }
    }
}
