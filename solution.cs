public class Solution {
    public bool CanThreePartsEqualSum(int[] arr) {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++) sum += arr[i];
        
        float avg = (float)sum / 3;
        if(avg != (int)avg) return false;

        int comp = (int)avg;
        sum = 0;
        int p = 0;
        for(int i = 0; i < arr.Length; i++){
            sum += arr[i];
            if(sum == comp){
                sum = 0;
                p++;
            }
        }

        return p >= 3;
    }
}
