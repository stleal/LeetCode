/********************
 * Name: Samir Leal 
 * Date: 03/21/2023 
 *******************/
 /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
 class Program {
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        
        // declare variables 
        int size; 
        int[] data; 
        ListNode cursor; 
        int counter; 
        ListNode sortedList; 

        // initialize variables 
        size = 0;      
        counter = 0;            
        sortedList = null; 

        // iterate through list1 
        cursor = list1;         
        while (cursor != null) 
        {
            size++; 
            cursor = cursor.next; 
        }

        // iterate through list2 
        cursor = list2; 
        while (cursor != null) 
        {
            size++; 
            cursor = cursor.next; 
        }

        // initialize data array 
        data = new int[size]; 

        // copies data into the array 
        cursor = list1; 
        while (cursor != null) 
        {
            data[counter] = cursor.val; 
            cursor = cursor.next; 
            counter++; 
        }

        // copies data into the array 
        cursor = list2; 
        while (cursor != null) 
        {
            data[counter] = cursor.val; 
            cursor = cursor.next;             
            counter++; 
        }

        // bubble sort 
        bubbleSort(data); 

        // builds a new linked list using data (sorted array) 
        if (list1 != null || list2 != null) 
        {
            sortedList = new ListNode(); 
            cursor = sortedList; 
            for (int i = 0; i < data.length; i++) 
            {
                cursor.val = data[i]; 
                if (i < data.length-1)
                {
                    cursor.next = new ListNode(); 
                    cursor = cursor.next; 
                }                  
            } 
        }

        // returns a sorted merged list 
        return sortedList; 

    }

    // sorts an array of Integers 
    public void bubbleSort(int[] data) 
    {
        int swap; 
        for (int i = 0; i < data.length; i++) 
        {
            for (int j = 0; j < data.length-1; j++) 
            {
                if (data[i] < data[j]) 
                {
                    swap = data[i]; 
                    data[i] = data[j]; 
                    data[j] = swap; 
                }
            }
        }
    }

}