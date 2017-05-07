using System;
class Solution {
    static void Main(String[] args) {
        double mealCost = Convert.ToDouble(Console.ReadLine());
        int tipPercent = Convert.ToInt32(Console.ReadLine());
        int taxPercent = Convert.ToInt32(Console.ReadLine());

        int totalCost = Convert.ToInt32(mealCost + mealCost * (tipPercent + taxPercent)/ 100);
        Console.WriteLine("The total meal cost is {0} dollars.", totalCost);
    }
}