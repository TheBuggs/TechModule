///////////////////////////////////////////
// Problem 10.	Triangle of Numbers
////////////////////////////////////////////

import java.util.Scanner;

public class E02T10 {

    public static void main(String[] args) {
		
        Scanner scanner = new Scanner(System.in);
        
		int n = Integer.parseInt(scanner.nextLine());
        
		for(int i = 0; i < n; i++){
            for(int j = 0; j <= i; j++){
                System.out.print(i + 1);
            }
            System.out.println();
        }
    }
}