using System;
using System.Collections.Generic;
namespace lab9
{
    enum TypeBankAccount
    {
        Текущий,
        Сберегательный,
        Кредитный
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 9 главы\nУпражнения 9.1-9.2\nВ классе банковский счет удалить методы заполнения полей\nCоздать новый класс BankTransaction, который будет хранить информацию о всех банковских операциях\n");
            Bankaccount bankaccount1 = new Bankaccount(1300,TypeBankAccount.Сберегательный);
            Bankaccount bankaccount2 = new Bankaccount(300, TypeBankAccount.Кредитный);
            bankaccount1.Transfer(bankaccount2, 700);            
            bankaccount1.Info();
            bankaccount2.Info();
            foreach (BankTransaction transaction in bankaccount1.transactions)
            {
                Console.WriteLine($"Дата: {transaction.Date}\nСумма: {transaction.Amount}");
            }
            Console.WriteLine("\nДомашнее задание 9.1\nВ класс Song добавить конструкторы");
            List<Song> songs = new List<Song>();
            songs.Add(new Song("90", "Pompeya"));
            songs.Add(new Song("Something in the way", "Nirvana"));
            songs.Add(new Song("Stressed out", "Twenty One Pilots"));
            songs.Add(new Song("In the End", "Linkin Park"));
            foreach (Song song in songs)
            {
                song.Info();
            }
            Song firstSong = songs[0];
            Song secondSong = songs[1];
            bool equal = firstSong.Equals(secondSong);
            Console.WriteLine("Первая и вторая песни равны: {0}", equal);
            Console.ReadKey();
        }
    }
}
