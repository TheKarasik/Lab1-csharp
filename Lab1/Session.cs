using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Session
    {
        public static void menu()
        {
            Console.WriteLine("Введите 1, чтобы создать новую запись");
            Console.WriteLine("Введите 2, чтобы отредактировать запись");
            Console.WriteLine("Введите 3, чтобы удалить запись");
            Console.WriteLine("Введите 4, чтобы просмотреть записи");
            Console.Write("Введите 5, чтобы просмотреть записи вкратце: ");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine($"Неверный ввод, потому что: {e.Message}");
            }
            Console.WriteLine();
            switch (input)
            {
                case 0:
                    Console.WriteLine("Неверный ввод");
                    break;
                case 1:
                    Notebook.AddNotes(NoteMaker.NoteFactory());
                    break;
                case 2:
                    Notebook.getOrderedNotes(Notebook.choosingModes.REDACTING);
                    break;
                case 3:
                    Notebook.getOrderedNotes(Notebook.choosingModes.DELETING);
                    break;
                case 4:
                    Notebook.printNotebook(false);
                    break;
                case 5:
                    Notebook.printNotebook(true);
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
            menu();
        }
    }
}
