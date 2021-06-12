package aplication;

import entities.DB;

public class Program {

	public static void main(String[] args) {
		
		DB.getConnection();
		DB.getClose();

	}

}
