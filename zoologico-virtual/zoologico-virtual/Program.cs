using System;
using zoologico_virtual;

namespace zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool abandonar = false;
            Console.WriteLine("Bienvenido al Zoológico Virtual");
            do
            {
                Console.WriteLine("Guía: ¿Qué deseas hacer?");
                Console.WriteLine("0. Abandonar");
                Console.WriteLine("1. Visitar al León.");
                Console.WriteLine("2. Visitar a la Jirafa.");
                Console.WriteLine("3. Visitar al Tigre.");
                Console.WriteLine("4. Visitar al Mono.");
                Console.WriteLine("5. Visitar al Oso.");
                Console.WriteLine("6. Visitar al Cocodrilo.");
                Console.WriteLine("7. Visitar a la Serpiente.");
                Console.WriteLine("8. Visitar al Pingüino.");
                Console.WriteLine("9. Visitar al Lobo.");
                Console.WriteLine("10. Visitar a la Cebra.");
                Console.WriteLine("11. Visitar Rinoceronte.");
                Console.WriteLine("12. Visitar al Panda.");
                Console.WriteLine("13. Visitar al Pavo Real.");
                Console.WriteLine("14. Visitar a la Tortuga");
                Console.WriteLine("15. Visitar al ELefante.");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion) 
                {
                    case 0: abandonar = true; break;
                    case 1: VisitarLeon(); break;
                    case 2: VisitarJirafa(); break;
                    case 3: VisitarTigre(); break;
                    case 4: VisitarMono(); break;
                    case 5: VisitarOso(); break;
                    case 6: VisitarCocodrilo(); break;
                    case 7: VisitarSerpiente(); break;
                    case 8: VisitarPenguin(); break;
                    case 9: VisitarLobo(); break;
                    case 10: VisitarCebra(); break;
                    case 11: VisitarRinoceronte(); break;
                    case 12: VisitarPanda(); break;
                    case 13: VisitarPavoReal(); break;
                    case 14: VisitarTortuga(); break;
                    case 15: VisitarElefante(); break;
                    default: Console.WriteLine("Opción inválida"); break;
                }
                Console.ReadKey();
                Console.Clear();
            }while(!abandonar);
            Console.WriteLine("Gracias por venir! Vuelve pronto!!");
            Console.ReadKey();
        }
        static void VisitarLeon()
        {
            Leon leon = new Leon("Alex", "Macho", "feliz");
            Console.WriteLine("Esta es la jaula de: {0}", leon.Nombre + ", es " + leon.Sexo + " y se encuentra " + leon.Animo);

        }
        static void VisitarJirafa()
        {
            Jirafa jirafa = new Jirafa("Melman", "Macho", "estresado");
            Console.WriteLine("Esta es la jaula de: {0}", jirafa.Nombre + ", es " + jirafa.Sexo + " y se encuentra " + jirafa.Animo);

        }
        static void VisitarTigre()
        {
            Tigre tigre = new Tigre("Tigresa", "Hembra", "concentrada");
            Console.WriteLine("Esta es la jaula de: {0}", tigre.Nombre + ", es " + tigre.Sexo + " y se encuentra " + tigre.Animo);
            tigre.Watch();
        }
        static void VisitarMono()
        {
            Mono mono = new Mono("Jorge", "Macho", "curioso");
            Console.WriteLine("Esta es la jaula de: {0}", mono.Nombre + ", es " + mono.Sexo + " y se encuentra " + mono.Animo);
            mono.Near();
            mono.Alimentar();
        }
        static void VisitarOso()
        {
            Oso oso = new Oso("Teddy", "Macho", "dormido");
            Console.WriteLine("Esta es la jaula de: {0}", oso.Nombre + ", es " + oso.Sexo + " y se encuentra " + oso.Animo);
        }
        static void VisitarCocodrilo()
        {
            Cocodrilo coco = new Cocodrilo("Cocky", "Hembra", "Hambrienta");
            Console.WriteLine("Esta es la jaula de: {0}", coco.Nombre + ", es " + coco.Sexo + " y se encuentra " + coco.Animo);
            coco.Alimentar();
        }
        static void VisitarSerpiente()
        {
            Serpiente serp = new Serpiente("Snicky", "Hembra", "tímida");
            Console.WriteLine("Esta es la jaula de: {0}", serp.Nombre + ", es " + serp.Sexo + " y es " + serp.Animo);
            serp.Hide();
        }
        static void VisitarPenguin()
        {
            Penguin peng = new Penguin("Skiper", "Macho", "muy feliz");
            Console.WriteLine("Esta es la jaula de: {0}", peng.Nombre + ", es " + peng.Sexo + " y se encuentra " + peng.Animo);
            peng.Saludar();
        }
        static void VisitarLobo()
        {
            Lobo lobo = new Lobo("Wolfy", "Macho", "un poco enfadado");
            Console.WriteLine("Esta es la jaula de: {0}", lobo.Nombre + ", es " + lobo.Sexo + " y se encuentra " + lobo.Animo);
            lobo.Gruñir();
        }
        static void VisitarCebra()
        {
            Cebra cebra = new Cebra("Marty", "Macho", "jugando");
            Console.WriteLine("Esta es la jaula de: {0}", cebra.Nombre + ", es " + cebra.Sexo + " y se encuentra " + cebra.Animo);
        }
        static void VisitarRinoceronte()
        {
            Rinoceronte rino = new Rinoceronte("Bigboy", "Macho", "aburrido");
            Console.WriteLine("Esta es la jaula de: {0}", rino.Nombre + ", es " + rino.Sexo + " y se encuentra " + rino.Animo);
        }
        static void VisitarPanda()
        {
            Panda panda = new Panda("Poh", "Macho", "comiendo");
            Console.WriteLine("Esta es la jaula de: {0}", panda.Nombre + ", es " + panda.Sexo + " y se encuentra " + panda.Animo);
        }
        static void VisitarPavoReal()
        {
            PavoReal pavo = new PavoReal("Sheng", "Macho", "bailando");
            Console.WriteLine("Esta es la jaula de: {0}", pavo.Nombre + ", es " + pavo.Sexo + " y se encuentra " + pavo.Animo);
        }
        static void VisitarTortuga()
        {
            Tortuga tor = new Tortuga("Flash", "Macho", "girando en circulos");
            Console.WriteLine("Esta es la jaula de: {0}", tor.Nombre + ", es " + tor.Sexo + " y se encuentra " + tor.Animo);
        }
        static void VisitarElefante()
        {
            Elefante el = new Elefante("Ely", "Hembra", "juguetona");
            Console.WriteLine("Esta es la jaula de: {0}", el.Nombre + ", es " + el.Sexo + " y es " + el.Animo);
        }

    }
}