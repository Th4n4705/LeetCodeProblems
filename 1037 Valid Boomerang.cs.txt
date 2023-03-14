class Solution {
public:
    bool isBoomerang(vector<vector<int>>& p) {
        int x1 = p[0][0];
        int y1 = p[0][1];
        int x2 = p[1][0];
        int y2 = p[1][1];
        int x3 = p[2][0];
        int y3 = p[2][1];
        if ((x1 == x2 && y1 == y2) || (x2 == x3 && y2 == y3) || (x1 == x3 && y1 == y3) || (x1 - x2) * (y3 - y2) == (x3 - x2) * (y1 - y2))
            return false;
        return true;
    }
};