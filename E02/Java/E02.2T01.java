/////////////////////////////////////////////////
// Choose A Drink
/////////////////////////////////////////////////

import java.util.Scanner;

public class ChooseADrink {

    public static void main(String[] args) {
		
        Scanner scanner = new Scanner(System.in);
        String profession = scanner.nextLine();
        String result = "";
        switch(profession){
            case "Athlete": result = "Wather";
            break;
            case "Bisnessman": 
            case "Bisnesswoman":  result = "Coffe";
            break;
            case "SoftUni Student": result = "Beer";
            break;
            default: result = "Tea";
            break;
        }
        System.out.println(result);
    }
}