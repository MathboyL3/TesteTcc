/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var currentNode1 = l1;
        var currentNode2 = l2;
        ListNode resultList = new ListNode();
        int carry = 0;

        ListNode currentNodeResult = resultList;
        while (currentNode1 is not null || currentNode2 is not null || carry != 0)
        {
            int sum = (currentNode1?.val ?? 0) + (currentNode2?.val ?? 0) + carry;
            carry = sum / 10;

            currentNodeResult.next = new ListNode(sum % 10);
            currentNodeResult = currentNodeResult.next;

            currentNode1 = currentNode1?.next;
            currentNode2 = currentNode2?.next;
        }

        return resultList.next;
    }
}
