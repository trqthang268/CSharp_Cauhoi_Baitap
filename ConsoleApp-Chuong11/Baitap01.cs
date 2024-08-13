using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace ConsoleApp_Chuong11
{
    internal class Baitap01
    {
        /*
         1) Xây dựng một ứng dụng quản lý ngân hàng theo hướng dẫn sau:
        - Tạo một lớp Account (Account.cs) biểu diễn thông tin của một tài 
        khoản khách hàng gồm: accountNumber (số tài khoản), accountName (tên
        tài khoản) và accountBalance (số dư tài khoản) và các phương thức khác

        - Tạo một lớp Bank (Bank.cs) lưu thông tin chi tiết về các tài khoản
        của khách hang. Các phương thức gồm:
        i. createAccount (tạo một tài khỏan). Hãy cung cấp cơ chế quản lý 
        khoảng 100 tài khoản, cần có sự kiểm soát nếu số lượng tài khoản
        vượt quá 100.
        ii. withDraw (rút tiền) và Deposit (gửi tiền): nhập số tài khoản, số
        tiền trong giao dịch và thực hiện giao dịch
        iii. display() hiển thị thông tin các tài khoản

        - Lớp bankTest (bankTest.cs) chứa menu như sau
        Menu
        --------------------------
        5. Create an Account
        6. withDraw
        7. Deposit
        8. Save to file
        9. Display
        10. Exit
        Your choice: _ 
        - Xây dựng các hàm khác trong lớp này ñể thực hiện các tính
        năng trên.
        - Save to file: thông tin Account ñược lưu xuống tệp nhị phân
        account.dat
        - Display: hiển thị thông tin của tất cả các tài khoản có số dư
        tài khoản > 100
         */
    }
}

namespace BankApp
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }

        public Account(string accountNumber, string accountName, decimal accountBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.AccountBalance = accountBalance;
        }
       
        /// <summary>
        /// Hàm gửi tiền vào tài khoản
        /// </summary>
        /// <param name="amount"> số tiền gửi </param>
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                AccountBalance += amount;
                Console.WriteLine($"Successfully deposited {amount}. New balance is {AccountBalance}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        /// <summary>
        /// Hàm rút tiền ra khỏi tài khoản
        /// </summary>
        /// <param name="amount"> số tiền rút </param>
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= AccountBalance)
            {
                AccountBalance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}. New balance is {AccountBalance}.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Account Name: {AccountName}, Balance: {AccountBalance:C}$";
        }
    }

    public class Bank
    {
        private Dictionary<string, Account> accounts = new Dictionary<string, Account>();
        private Random random = new Random();
        private const int MaxAccounts = 100;
        /// <summary>
        /// phương thức tạo tài khoản 
        /// </summary>
        /// <param name="accountName"> tên chủ tài khoản </param>
        /// <param name="initialBalance"> giá trị ban đầu có trong tài khoản </param>
        public void CreateAccount(string accountName, decimal initialBalance)
        {
            if (accounts.Count >= MaxAccounts)
            {
                Console.WriteLine("Cannot create more accounts. Maximum limit reached.");
                return;
            }

            string accountNumber = GenerateAccountNumber();
            Account newAccount = new Account(accountNumber, accountName, initialBalance);
            accounts.Add(accountNumber, newAccount);
            Console.WriteLine($"Account created successfully. Account Number: {accountNumber}.");
        }
        /// <summary>
        /// phương thức tạo số tài khoảng
        /// </summary>
        /// <returns> trả về số tài khoản được ép sang kiểu string </returns>
        private string GenerateAccountNumber()
        {
            string accountNumber;
            do
            {
                accountNumber = random.Next(0, 999999999).ToString("D11");
            } while (accounts.ContainsKey(accountNumber));
            return accountNumber;
        }
        /// <summary>
        /// phương thức gửi tiền vào tài khoản
        /// </summary>
        /// <param name="accountNumber"> số tài khoản gửi tiền vào </param>
        /// <param name="amount"> số tiền gửi </param>
        public void Deposit(string accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
        /// <summary>
        /// phương thức rút tiền khỏi tài khoản
        /// </summary>
        /// <param name="accountNumber"> số tài khoản bị rút tiền </param>
        /// <param name="amount"> sô tiền rút </param>
        public void Withdraw(string accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
        /// <summary>
        /// Hiển thị thông tin của tất cả tài khoản có số dư >100
        /// </summary>
        public void Display()
        {
            foreach (var account in accounts.Values)
            {
                if (account.AccountBalance > 100)
                {
                    Console.WriteLine(account.ToString());
                }
            }
        }
        /// <summary>
        /// lưu xuống tệp nhị phân
        /// </summary>
        /// <param name="filePath">tên file</param>
        public void SaveToFile(string filePath)
        {
            string jsonString = JsonSerializer.Serialize(accounts);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Data saved successfully.");
        }
        /// <summary>
        /// đọc thông tin account từ file
        /// </summary>
        /// <param name="filePath"> tên file </param>
        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                accounts = JsonSerializer.Deserialize<Dictionary<string, Account>>(jsonString);
            }
            else
            {
                Console.WriteLine("File not found. Starting with an empty account list.");
                accounts = new Dictionary<string, Account>();
            }
        }
    }


    public class BankTest
    {
        public static void MenuBank()
        {
            Bank bank = new Bank();
            string filePath = "account.dat";
            bank.LoadFromFile(filePath);
            bool isExit = true;

            while (isExit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Save to file");
                Console.WriteLine("5. Display");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice: ");

                byte choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter account name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter initial balance: ");
                        decimal balance = decimal.Parse(Console.ReadLine());
                        bank.CreateAccount(name, balance);
                        break;
                    case 2:
                        Console.Write("Enter account number: ");
                        string withdrawAccount = Console.ReadLine();
                        Console.Write("Enter amount to withdraw: ");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        bank.Withdraw(withdrawAccount, withdrawAmount);
                        break;
                    case 3:
                        Console.Write("Enter account number: ");
                        string depositAccount = Console.ReadLine();
                        Console.Write("Enter amount to deposit: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        bank.Deposit(depositAccount, depositAmount);
                        break;
                    case 4:
                        bank.SaveToFile(filePath);
                        break;
                    case 5:
                        bank.Display();
                        break;
                    case 6:
                        bank.SaveToFile(filePath);
                        isExit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
