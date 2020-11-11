using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Note
    {
        string surname;
        string name;
        string patronym;
        string country;
        string organization;
        string position;
        List<string> otherNotes;
        long phoneNumber;
        DateTime birthday;
        public bool ToStringMode { get; set; } //true - кратко; false - полно
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != "") surname = value;
                else
                {
                    Console.Write("Поле \"Фамилия\" не может быть пустым. Введите его ещё раз: ");
                    Surname = Console.ReadLine();
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "") name = value;
                else
                {
                    Console.Write("Поле \"Имя\" не может быть пустым. Введите его ещё раз: ");
                    Name = Console.ReadLine();
                }
            }
        }
        public string Patronym
        {
            get { return patronym; }
            set
            {
                if (value == "") patronym = null;
                else patronym = value;
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (value != "") country = value;
                else
                {
                    Console.Write("Поле \"Страна\" не может быть пустым. Введите его ещё раз: ");
                    Country = Console.ReadLine();
                }
            }
        }
        public string Organization
        {
            get { return organization; }
            set
            {
                if (value == "") organization = null;
                else organization = value;
            }
        }
        public string Position
        {
            get { return position; }
            set
            {
                if (value == "") position = null;
                else position = value;
            }
        }
        public List<string> OtherNotes
        {
            get { return otherNotes; }
            set
            {
                foreach(string str in value.ToArray())
                {
                    if (str == "") value.Remove(str);
                }
                if (value.Count == 0) otherNotes = null;
                else otherNotes = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber.ToString(); }
            set
            {
                if(!long.TryParse(value, out phoneNumber))
                {
                    Console.Write("В поле \"Номер телефона\" должно быть введено только числовое значение. Попробуйте ввести его ещё раз: ");
                    PhoneNumber = Console.ReadLine();
                }
            }
        }
        public string Birthday
        {
            get { return birthday.ToString("dd.MM.yyyy"); }
            set
            {
                if (value == "") birthday = DateTime.MinValue;
                else
                {
                    try
                    {
                        birthday = Convert.ToDateTime(value);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка в чтении даты. Введите её ещё раз через пробел: ");
                        Birthday = Console.ReadLine();
                    }
                }
            }
        }
        public override string ToString()
        {
            if (ToStringMode)
            {
                return $"Фамилия: {Surname};\n" +
                    $"Имя: {Name};\n" +
                    $"Номер телефона: {PhoneNumber}.";
            }
            string patronymStr, organizationStr, positionStr, otherNotesStr = "", birthdayStr; //Нет номера телефона и страны
            if (Patronym == null) patronymStr = "Значение неизвестно";
            else patronymStr = Patronym;
            if (Organization == null) organizationStr = "Значение неизвестно";
            else organizationStr = Organization;
            if (Position == null) positionStr = "Значение неизвестно";
            else positionStr = Position;
            if (OtherNotes == null) otherNotesStr = "Значение неизвестно";
            else
            {
                int i = 1;
                foreach (string note in OtherNotes)
                {
                    otherNotesStr += $"Прочая заметка №{i}: {note};\n";
                    i++;
                }
            }
            if (Birthday == DateTime.MinValue.ToString("dd.MM.yyyy")) birthdayStr = "Значение неизвестно";
            else birthdayStr = Birthday;
            return $"Фамилия: {Surname};\n" +
                    $"Имя: {Name};\n" +
                    $"Отчество: {patronymStr};\n" +
                    $"Номер телефона: {PhoneNumber};\n" +
                    $"Страна: {Country};\n" +
                    $"Организация: {organizationStr};\n" +
                    $"Должность: {positionStr};\n" +
                    $"Дата рождения: {birthdayStr};\n" +
                    $"Прочие заметки: {otherNotesStr}";
        }
    }
}
