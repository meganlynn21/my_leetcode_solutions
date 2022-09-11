#Given an integer array nums, return true if any value appears at least
##twice in the array,
##and return false if every element is distinct.

from typing import List

def containsDuplicate(nums: List[int]) -> bool:
    hashset = set()
    for n in nums:
        if(n in hashset):
            return True
            
        hashset.add(n)
    return False
    
nums = [5,3,7,8,7]
containsDuplicate(nums)
