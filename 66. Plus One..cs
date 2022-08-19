public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        List<int> newList = new List<int>();        
        int j = digits.Length - 1;
        int i = 0;
        int tmp = 0;
        Result(newList, digits, j, 1);
        j = newList.Count - 1;
        
        while (i <= j)
        {
            tmp = newList[i];
            newList[i] = newList[j];
            newList[j] = tmp;
            i++;
            j--;
        }
        return newList.ToArray();
    }
    
    public void Result(List<int> newList, int[] list, int index, int restToAdd)
    {
        if (index == 0)
        {
            if (list[index] == 9)
            {   
                if (restToAdd == 1)
                {
                    newList.Add(0);
                    newList.Add(1);
                }
                else
                    newList.Add(list[index]);
            }
            else
            {
                if (restToAdd == 1)
                    newList.Add(list[index] + 1);
                else
                    newList.Add(list[index]);
            }
            return ;
        }
        
        if(restToAdd == 1)
        {
            if (list[index] == 9)
            {
                newList.Add(0);
                Result(newList, list, index - 1, 1);
            }
            else
            {
                newList.Add(list[index] + 1);
                Result(newList, list, index - 1, 0);
            }
        }
        if(restToAdd == 0)
        {
            newList.Add(list[index]);
            Result(newList, list, index - 1, 0);
        }
    }
}