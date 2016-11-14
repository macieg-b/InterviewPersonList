using InterviewHomework.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewHomework
{
    /*
     * TODO  Uzupelnieniem Interview, jakie mialo miejsce u nas w firmie, proszę o podeslanie rozwiazania zadania domowego.
        Zadaniem jest stworzenie aplikacji konsolowej w języku C#, ktora pozwoli na dodanie użytkownika, usunięcie i wyswietlenie/przeglądanie listy użytkowników.
 
        Wymagania:
        ·        Wyświetlenie użytkowników w kolejności alfabetycznej,
        ·        Użytkownik powinien wprowadzić tylko imię i adres mailowy,
        ·        Adres mailowy musi być zapisany w formacie xxx@yyy.zz,
        ·        Imię maksymalnie na 10 znaków bez znaków specjalnych,
        ·        Maksymalnie 5 użytkowników w systemie,
        ·        Unikalny adres mailowy,
 
        Oceniania będzie funkcjonalnosc aplikacji jaki i kod zrodlowy (solution).
        Prosze również o opis jak aplikacja może zostać przetestowana
 
        Proszę o potwierdze e-mailem zamiaru wykonania zadania oraz na kiedy mogę spodziewac się rozwiazania.
 
        Pozdrawiam
        Grzegorz Paciorkiewicz
     */
    class Program
    {
        static void Main(string[] args)
        {
            ViewController vController = new ViewController();
            vController.Run();    
        }
    }
}
