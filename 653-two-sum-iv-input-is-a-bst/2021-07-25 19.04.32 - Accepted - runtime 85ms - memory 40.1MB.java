/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

import java.util.Arrays; 

class Solution 
{
    
    private int[] data; 
    private int count; 
    private int top; 
    
    public boolean findTarget(TreeNode root, int k) 
    {
        
        boolean found; 
        int sum; 
        
        count = 0; 
        top = 0; 
        found = false; 
        sum = 0; 
        
        findSize(root); 
        System.out.println("Number of elements: " + count); 
        
        data = new int[count]; 
        
        preorderTraversal(root); 
        
        System.out.println("Data: " + Arrays.toString(data)); 
        
        for (int i = 0; i < data.length; i++) 
        {
            
            for (int j = i+1; j < data.length; j++) 
            {
                
                sum = data[i] + data[j]; 
                
                if (sum == k) 
                {
                    
                    found = true; 
                    
                }
                
            }
            
        }
        
        return found; 
        
    }
    
    public void preorderTraversal(TreeNode root) 
    {
        
        if (root == null) 
        {
            
            return; 
            
        }
        else 
        {
            
            data[top] = root.val; 
            top++; 
            
            preorderTraversal(root.left); 
            preorderTraversal(root.right); 
            
        }
        
    }
    
    public void findSize(TreeNode root) 
    {

        if (root == null) 
        {
            
            return; 
            
        }
        else 
        {
            
            count++; 
            findSize(root.left); 
            findSize(root.right); 
                
        }
        
    }
    
}