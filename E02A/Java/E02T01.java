import java.util.Scanner;

public class E02T01 {
    public static final String stop = "3:1";

    public static String Marge(String str, int start, int end){
        String[] arr = str.split(" ");

        if(start < 0){
            start = 0;
        }
        if(end > arr.length){
            end = arr.length - 1;
        }

        String temp = "";

        str = "";
        for(int i = 0; i < start; i++){
            str += arr[i] + " ";
        }

        for(int i = start; i < end; i++){
            str += arr[i];
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

    public static String Divide(String in, int item, int parts) {
        String[] arr = in.split(" ");
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

        int step = (arr[item].length() - 1) / parts;

        char[] temp = arr[item].toCharArray();

        for(int i = 0, j = 0, c = 1; i < arr[item].length(); i++, j++) {
            if(step * parts * c == j){
                str += " ";
                j = 0;
                c++;
            }else{
                str += temp[i];
            }
            if(i == arr[item].length() - 1){
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
        while(msg.equals("3:1") == false){
            msg = scanner.nextLine();
            String[] comm = msg.split(" ");
            switch(comm[0]){
                case "marge":  str = Marge(str, Integer.parseInt(comm[1]), Integer.parseInt(comm[2]));
                break;
                case "divide": str = Divide(str, Integer.parseInt(comm[1]), Integer.parseInt(comm[2]));
                break;
            }
        }
        System.out.println(str);
    }
}
