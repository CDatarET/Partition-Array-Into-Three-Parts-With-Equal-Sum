class Solution:
    def canThreePartsEqualSum(self, arr: List[int]) -> bool:
        avg = sum(arr) / 3
        if not avg.is_integer():
            return False
        
        s = 0
        p = 0
        for i in range(len(arr)):
            s += arr[i]
            if s == avg:
                p += 1
                s = 0
        
        return p >= 3
