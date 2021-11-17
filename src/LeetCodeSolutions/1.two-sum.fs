//https://leetcode.com/problems/two-sum/
(*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*)

namespace TwoSum

module Solution =
let twoSum (nums:int[]) target =
    let rec search (map:Map<int,int>) (arr:int[]) idx = 
        if map.ContainsKey(target-arr.[idx]) then (map.Item(target-arr.[idx]),idx)
        else search (map.Add(arr.[idx],idx)) arr (idx+1)
    search Map.empty nums 0
