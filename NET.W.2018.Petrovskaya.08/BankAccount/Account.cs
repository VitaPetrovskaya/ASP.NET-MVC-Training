using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     class Account
     {
          private long number;
          public long Number
          {
               get { return number; }
               set
               {
                    if (value < 0)
                         throw new ArgumentException($"Invalid {nameof(value)}");
                    number = value;
               }
          }
          private string ownerName;
          public string OwnerName
          {
               get { return ownerName; }
               set { ownerName = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string ownerSurname;
          public string OwnerSurname
          {
               get { return ownerSurname; }
               set { ownerSurname = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private double amount;
          public double Amount
          {
               get { return amount; }
               set
               {
                    if (value < 0)
                         throw new ArgumentException($"Invalid {nameof(value)}");
                    amount = value;
               }
          }
          public int bonus;
          public IAccountGradation gradation;
          private string infoFile = @"C:\Disk-D\new\Info.bin";
          private bool closeAccount;

          public Account(long input_number, string input_name, string input_surname, double input_amount, int input_bonus, IAccountGradation input_gradation)
          {
               Number = input_number;
               OwnerName = input_name;
               OwnerSurname = input_surname;
               Amount = input_amount;
               bonus = input_bonus;
               gradation = input_gradation;
               closeAccount = false;
          }

          public Account(string input_name, string input_surname, IAccountGradation input_gradation)
          {
               Number = new Random().Next(1, int.MaxValue);
               OwnerName = input_name;
               OwnerSurname = input_surname;
               Amount = 0; 
               bonus = 0;
               gradation = input_gradation;
          }
          /// <summary>
          /// Add money to amount of account.
          /// </summary>
          /// <param name="money">
          /// Adding money.
          /// </param>
          public void PutMoney(double money)
          {
               if(closeAccount)
                    throw new ArgumentException();
               this.Amount += money;
               bonus += gradation.PutMoney(money);
               SaveToFile();
          }
          /// <summary>
          /// Take money from amount of account.
          /// </summary>
          /// <param name="money">
          /// Taking money.
          /// </param>
          public void TakeMoney(double money)
          {
               if (closeAccount)
                    throw new ArgumentException();
               this.Amount -= money;
               bonus -= gradation.TakeMoney(money);
               SaveToFile();
          }

          public Account CreateNewAccount(IAccountGradation input_gradation)
          {
               return new Account(this.OwnerName, this.OwnerSurname, input_gradation);
          }
          /// <summary>
          /// Close account - taking and put ting are not available.
          /// </summary>
          public void CloseAccount()
          {
               closeAccount = true;
               this.Amount = 0;
          }
          /// <summary>
          /// Find account if binary file for changing data.
          /// </summary>
          /// <returns>
          /// Position in file to start write new information.
          /// </returns>
          public long FindAccountInFile()
          {
               long position = 0;
               using (BinaryReader reader = new BinaryReader(File.Open(infoFile, FileMode.OpenOrCreate)))
               {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                         position = reader.BaseStream.Position;
                         var num = reader.ReadInt64();
                         var name = reader.ReadString();
                         var surname = reader.ReadString();
                         var amount = reader.ReadDouble();
                         var bonus = reader.ReadInt32();
                         var nameOfGradation = reader.ReadString();
                         if (nameOfGradation == "Base")
                         {
                              IAccountGradation gradation = new BaseGradation();
                         }
                         if (nameOfGradation == "Gold")
                         {
                              IAccountGradation gradation = new GoldGradation();
                         }
                         if (nameOfGradation == "Platinum")
                         {
                              IAccountGradation gradation = new PlatinumGradation();
                         }
                         Account account = new Account(num, name, surname, amount, bonus, gradation);
                         if (this.Equals(account))
                              return position;
                         position = reader.BaseStream.Length;
                    }
               }
               return position;
          }
          /// <summary>
          /// Save changes in binary file.
          /// </summary>
          public void SaveToFile()
          {
               int pos = (int)FindAccountInFile();
               using (BinaryWriter writer = new BinaryWriter(File.Open(infoFile, FileMode.OpenOrCreate)))
               {
                    writer.Seek(pos, SeekOrigin.Begin);
                    writer.Write(this.Number);
                    writer.Write(this.OwnerName);
                    writer.Write(this.OwnerSurname);
                    writer.Write(this.Amount);
                    writer.Write(this.bonus);
                    writer.Write(this.gradation.GetGradation());
               }
          }
     }
}
