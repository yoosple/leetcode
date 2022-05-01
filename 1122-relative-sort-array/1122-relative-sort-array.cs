public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
            Queue<int> temp = new Queue<int>();
            List<int> listA = new List<int>(arr1);
            List<int> listB = new List<int>(arr2);
            List<int> orverlap = listA.Where(x => listB.Select(y => y).Contains(x)).ToList();
            List<int> noneOrverlap = listA.Where(x => !listB.Select(y => y).Contains(x)).ToList();
            noneOrverlap = noneOrverlap.OrderBy(x => x).ToList();

            for(int i = 0; i < arr2.Length; i++)
            {
                for(int j = 0; j < orverlap.Count; j++)
                {
                    if (arr2[i] == orverlap[j])
                    {
                        temp.Enqueue(orverlap[j]);
                    }
                }
            }

            for(int i = 0; i < noneOrverlap.Count; i++)
            {
                temp.Enqueue(noneOrverlap[i]);
            }

            int[] result = new int[temp.Count()];
            int q = 0;
            while(temp.Count() > 0)
            {
                result[q] = temp.Dequeue();
                q++;
            }
            
        return result;
    }
}