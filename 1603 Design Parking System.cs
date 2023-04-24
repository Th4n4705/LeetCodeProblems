public class ParkingSystem {
    private int _big = 0;
    private int _medium = 0;
    private int _small = 0;

    public ParkingSystem(int big, int medium, int small) {
        _big = big;
        _medium = medium;
        _small = small;
    }
    
    public bool AddCar(int carType) {
        if (carType == 1 && _big > 0)
            _big--;
        else if (carType == 2 && _medium > 0)
            _medium--;
        else if (carType == 3 && _small > 0)
            _small--;
        else
            return false;
        return true;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */