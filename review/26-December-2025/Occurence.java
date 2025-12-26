import java.util.*;
public class Occurence {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        String s=sc.nextLine();
        Map<Character,Integer>map=new HashMap<>();
        for(int i = 0 ;i<s.length();i++){
            char ch=s.charAt(i);
            map.put(ch,map.getOrDefault(ch, 0)+1);
        }
        char [] c=s.toCharArray();
        for(char ch : c){
            System.out.println(ch+" ->"+map.get(ch));
        }
    }
}
