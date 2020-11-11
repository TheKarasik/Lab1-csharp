using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Notebook
    {
        static List<Note> Notes = new List<Note>();
        public enum choosingModes {REDACTING, DELETING}
        public static void AddNotes(Note note)
        {
            Notes.Add(note);
        }
        public static void deleteNote(int index)
        {
            Notes.Remove(Notes[index]);
        }
        public static void getOrderedNotes(choosingModes currentMode)
        {
            int capacity = Notes.Count;
            if (capacity == 0)
            {
                if(currentMode == choosingModes.REDACTING)
                {
                    Console.WriteLine("Записи нельзя редактировать, потому что их нет.");
                }
                else if(currentMode == choosingModes.DELETING)
                {
                    Console.WriteLine("Записи нельзя удалять, потому что их нет.");
                }
                return;
            }
            else if (capacity == 1)
            {
                if (currentMode == choosingModes.REDACTING)
                {
                    Console.WriteLine("В телефонной книжке лишь одна запись - именно она и будет доступна для редактирования.");
                    NoteRedactor.FieldChanger(Notes[0]);
                }
                else if (currentMode == choosingModes.DELETING)
                {
                    Console.WriteLine("В телефонной книжке лишь одна запись - именно она и будет удалена.");
                    deleteNote(0);
                }
                return;
            }
            else Console.Write($"Введите номер записи от 1 до {capacity}: ");
            if (int.TryParse(Console.ReadLine(), out int noteNumber) && noteNumber >= 1 && noteNumber <= capacity)
            {
                if (currentMode == choosingModes.REDACTING)
                {
                    NoteRedactor.FieldChanger(Notes[noteNumber - 1]);
                }
                else
                {
                    deleteNote(noteNumber - 1);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }
        }
        public static void printNotebook(bool printMode)
        {
            int i = 1;
            if (Notes.Count == 0) Console.WriteLine("Записная книжка пуста, в ней нечего выводить.");
            else
            {
                Console.WriteLine($"Вывод записной книжки, размером {Notes.Count} записей:");
                foreach (Note note in Notes)
                {
                    note.ToStringMode = printMode;
                    Console.Write($"Запись №{i}:");
                    Console.WriteLine(note);
                    Console.WriteLine();
                    i++;
                }
            }
        }
    }
}
