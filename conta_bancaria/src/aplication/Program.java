package aplication;

import java.util.Locale;
import java.util.Scanner;

import entities.Account;
import model.entities.DomainExceptions;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		try {
			System.out.println("Enter account data:");
			System.out.print("Number: ");
			int number = sc.nextInt();
			sc.nextLine();
			System.out.print("Holder: ");
			String holder = sc.next();
			System.out.print("Balance: ");
			double balance = sc.nextDouble();
			System.out.print("Withdraw Limit: ");
			double withdrawLimit = sc.nextDouble();
			Account acc = new Account(number, holder, balance, withdrawLimit);
			
			System.out.println();
			System.out.print("Enter amount for withdraw: ");
			double amount = sc.nextDouble();
			acc.withdraw(amount);
			System.out.println(acc);
		}
		catch(DomainExceptions e) {
			System.out.println(e.getMessage());
		}
		catch(RuntimeException e) {
			System.out.println("Error unexpected");
		}
		
		sc.close();
	}

}
