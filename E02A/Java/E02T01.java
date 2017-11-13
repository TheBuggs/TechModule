//////////////////////////////////////////////////
// Problem 2. 	Anonymous Threat
//////////////////////////////////////////////////

import java.util.Scanner;

public class myJavaClass {
	
    public static final String stop = "3:1";

    public static String Merge(String result, int start, int end){
		
        String[] arr = result.split(" ");

        String str = "";

        if(start < 0 || start > arr.length){
            start = 0;
        }

        if(end < 0 || end > arr.length){
            end = arr.length;
        }

        if(start == end){
            return result;
        }

        for(int i = 0; i < start; i++){
            str += arr[i] + " ";
        }

        for(int i = start; i < end; i++){
            if(i == arr.length - 1){
                str += arr[i] + " ";
            }else {
                str += arr[i];
            }
        }

        for(int i = end; i < arr.length; i++){
            if(i == arr.length - 1){
                str += arr[i];
            }else {
                str += arr[i] + " ";
            }
        }

        return str;
    }

    public static String Divide(String result, int item, int parts) {
		
        String[] arr = result.split(" ");

        String str = "";

        if(item < 0) {
            item = 0;
        }

        if(item >= arr.length){
            item = arr.length - 1;
        }

        if (parts >= arr[item].length()) {
            parts = arr[item].length() - 1;
        }

        for(int i = 0; i < item; i++){
            str += arr[i] + " ";
        }

        int step = arr[item].length() / parts;

        char[] temp = arr[item].toCharArray();

        for(int i = 0, j = 0, c = 1; i < arr[item].length(); i++, j++) {
			
            if(step == j){
                str += " ";
                j = 0;
            }
            str += temp[i];
            if(i == arr[item].length() - 1 && arr.length - 1 == item){
                str += " ";
            }
        }

        for(int i = item + 1; i < arr.length; i++){
			
            if(i == arr.length - 1){
                str += arr[i];
            }else {
                str += arr[i] + " ";
            }
        }
        return str;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String str = scanner.nextLine();
        String msg = "";

        while(!msg.equals(stop)){

            msg = scanner.nextLine();
            String[] comm = msg.split(" ");

            switch(comm[0]) {
                case "merge":
                    str = Merge(str, Integer.parseInt(comm[1]), Integer.parseInt(comm[2]));
                    break;
                case "divide":
                    str = Divide(str, Integer.parseInt(comm[1]), Integer.parseInt(comm[2]));
                    break;
            }
        }
        System.out.println(str);
    }
}
