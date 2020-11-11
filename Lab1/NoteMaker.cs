using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class NoteMaker
    {
        static string input;
        public static Note NoteFactory()
        {
            Note note = new Note();
            note.Surname = SurnameMaker();
            note.Name = NameMaker();
            note.Patronym = PatronymMaker();
            note.Country = CountryMaker();
            note.Organization = OrganizationMaker();
            note.Position = PositionMaker();
            note.OtherNotes = OtherNotesMaker();
            note.PhoneNumber = PhoneNumberMaker();
            note.Birthday = BirthdayMaker();
            Console.WriteLine("Запись добавлена.");
            return note;
        }
        static string SurnameMaker()
        {
            Console.Write("Введите фамилию: ");
            return Console.ReadLine();
        }
        static string NameMaker()
        {
            Console.Write("Введите имя: ");
            return Console.ReadLine();
        }
        static string PatronymMaker()
        {
            Console.Write("Введите отчество: ");
            return Console.ReadLine();
        }
        static string CountryMaker()
        {
            Console.Write("Введите страну: ");
            return Console.ReadLine();
        }
        static string OrganizationMaker()
        {
            Console.Write("Введите организацию: ");
            return Console.ReadLine();
        }
        static string PositionMaker()
        {
            Console.Write("Введите должность: ");
            return Console.ReadLine();
        }
        static List<string> OtherNotesMaker()
        {
            List<string> otherNotes = new List<string>();
            int i = 1;
            Console.Write("Введите прочие заметки (Чтобы завершить ввод, введите \"Стоп\"): ");
            Console.Write($"Заметка №{i}: ");
            input = Console.ReadLine();
            while (input != "Стоп")
            {
                i++;
                otherNotes.Add(input);
                Console.Write($"Заметка №{i}: ");
                input = Console.ReadLine();
            }
            return otherNotes;
        }
        static string PhoneNumberMaker()
        {
            Console.Write("Введите номер телефона: ");
            return Console.ReadLine();
        }
        static string BirthdayMaker()
        {
            Console.Write("Введите дату рождения через пробел: ");
            return Console.ReadLine();
        }
    }
}
