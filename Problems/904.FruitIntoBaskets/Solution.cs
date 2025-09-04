public class Solution {
    public int TotalFruit(int[] fruits) {
        int max = 0;
        int length = fruits.Length;
        for (int i = 0; i < length; i++)
        {
            if ((length - i) < max){
                break;
            }

            int count = 0;
            int firstFruit = fruits[i];
            int secondFruit = -1;

            for (int it = i; it < length; it++)
            {
                int fruit = fruits[it];
                if (fruit != firstFruit && secondFruit == -1){
                    secondFruit = fruit;
                } else if (fruit != firstFruit && fruit != secondFruit){
                    break;
                }
                count++;
            }

            if (count > max){
                max = count;
            }

        }
        return max;
    }
}