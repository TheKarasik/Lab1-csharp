using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class NoteRedactor
    {
        static Note currentNote;
        public static void FieldChanger(Note note)
        {
            currentNote = note;
            Console.WriteLine("Если вы хотите изменить поле Фамилия, введите \"Фамилия\"");
            Console.WriteLine("Если вы хотите изменить поле Имя, введите \"Имя\"");
            Console.WriteLine("Если вы хотите изменить поле Отчество, введите \"Отчество\"");
            Console.WriteLine("Если вы хотите изменить поле Страна, введите \"Страна\"");
            Console.WriteLine("Если вы хотите изменить поле Организация, введите \"Организация\"");
            Console.WriteLine("Если вы хотите изменить поле Должность, введите \"Должность\"");
            Console.WriteLine("Если вы хотите изменить поле Другие заметки, введите \"Другие заметки\"");
            Console.WriteLine("Если вы хотите изменить поле Номер телефона, введите \"Номер телефона\"");
            Console.WriteLine("Если вы хотите изменить поле День рождения, введите \"День рождения\"");
            Console.WriteLine("Если вы хотите остановить редактирование записи, введите \"Стоп\"");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Фамилия":
                    note.Surname = SurnameChanger();
                    break;
                case "Имя":
                    note.Name = NameChanger();
                    break;
                case "Отчество":
                    note.Patronym = PatronymChanger();
                    break;
                case "Страна":
                    note.Country = CountryChanger();
                    break;
                case "Организация":
                    note.Organization = OrganizationChanger();
                    break;
                case "Должность":
                    note.Position = PositionChanger();
                    break;
                case "Другие заметки":
                    note.OtherNotes = OtherNotesChanger();
                    break;
                case "Номер телефона":
                    note.PhoneNumber = PhoneNumberChanger();
                    break;
                case "День рождения":
                    note.Birthday = BirthdayChanger();
                    break;
                case "Стоп":
                    return;
                default:
                    Console.WriteLine("Команда введена некорректно.");
                    break;
            }
            FieldChanger(note);
        }
        static string SurnameChanger()
        {
            Console.WriteLine($"Старая фамилия: {currentNote.Surname}");
            Console.Write("Новая фамилия: ");
            return Console.ReadLine();
        }
        static string NameChanger()
        {
            Console.WriteLine($"Старое имя: {currentNote.Name}");
            Console.Write("Новое имя: ");
            return Console.ReadLine();
        }
        static string PatronymChanger()
        {
            if (currentNote.Patronym == null) Console.WriteLine("Старое отчество: Значение неизвестно");
            else Console.WriteLine($"Старое отчество: {currentNote.Patronym}");
            Console.Write("Новое отчество: ");
            return Console.ReadLine();
        }
        static string CountryChanger()
        {
            if (currentNote.Country == null) Console.WriteLine("Старая страна: Значение неизвестно");
            else Console.WriteLine($"Старая страна: {currentNote.Country}");
            Console.Write("Новая страна: ");
            return Console.ReadLine();
        }
        static string OrganizationChanger()
        {
            if (currentNote.Organization == null) Console.WriteLine("Старая организация: Значение неизвестно");
            else Console.WriteLine($"Старая организация: {currentNote.Organization}");
            Console.Write("Новая организация: ");
            return Console.ReadLine();
        }
        static string PositionChanger()
        {
            if (currentNote.Position == null) Console.WriteLine("Старая должность: Значение неизвестно");
            else Console.WriteLine($"Старая должность: {currentNote.Position}");
            Console.Write("Новая должность: ");
            return Console.ReadLine();
        }
        static List<string> OtherNotesChanger()
        {
            int i = 1;
            List<string> otherNotes = new List<string>();
            if (currentNote.OtherNotes == null) Console.WriteLine("Старые прочие заметки: Значение неизвестно");
            else
            {
                Console.Write($"Старые прочие заметки: ");
                foreach (string note in currentNote.OtherNotes)
                {
                    Console.Write($"Заметка №{i}: ");
                    Console.WriteLine(note);
                    i++;
                }
            }
            i = 1;
            Console.Write("Введите новые прочие заметки (Чтобы завершить ввод, введите \"Стоп\"): ");
            string input = Console.ReadLine();
            while (input != "Стоп")
            {
                Console.Write($"Заметка №{i}: ");
                otherNotes.Add(Console.ReadLine());
                i++;
            }
            return otherNotes;
        }
        static string PhoneNumberChanger()
        {
            if (currentNote.PhoneNumber == null) Console.WriteLine("Старый номер телефона: Значение неизвестно");
            else Console.WriteLine($"Старый номер телефона: {currentNote.PhoneNumber}");
            Console.Write("Новый номер телефона: ");
            return Console.ReadLine();
        }
        static string BirthdayChanger()
        {
            if (currentNote.Birthday == null) Console.WriteLine("Старая дата рождения: Значение неизвестно");
            else Console.WriteLine($"Старая дата рождения: {currentNote.Birthday}");
            Console.Write("Новая дата рождения: ");
            return Console.ReadLine();
        }
    }
}
