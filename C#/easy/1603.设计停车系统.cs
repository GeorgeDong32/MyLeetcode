/*
 * @lc app=leetcode.cn id=1603 lang=csharp
 *
 * [1603] 设计停车系统
 */

// @lc code=start
public class ParkingSystem
{

    private int parkBig;
    private int parkMedium;
    private int parkSmall;

    public ParkingSystem(int big, int medium, int small)
    {
        parkBig = big;
        parkMedium = medium;
        parkSmall = small;
    }

    public bool AddCar(int carType)
    {
        switch (carType)
        {
            case 1:
                return --parkBig >= 0;
            case 2:
                return --parkMedium >= 0;
            case 3:
                return --parkSmall >= 0;
            default:
                break;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
// @lc code=end

