public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add three items to the queue and see if they dequeue in their proper order. (homework, 3), (work, 6), (family, 1).
        // Expected Result:  (work, 6), (homework, 3), (family, 1)
        Console.WriteLine("Test 1:");
        priorityQueue.Enqueue("homework", 3);
        priorityQueue.Enqueue("work", 6);
        priorityQueue.Enqueue("family", 1);
        Console.WriteLine("Items in the queue after enqueuing:");
        Console.WriteLine(priorityQueue);
        while (priorityQueue.Count > 0) {
            var item = priorityQueue.Dequeue();
            Console.WriteLine(item);
        }

        // Defect(s) Found: The code seems to re-organize the items however, in the wrong order so we need to make sure it organzies the items from the value of greatest to least rather than the other way around.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: When there are two items of similar value which one is taken first:  (video games, 3), (homework, 3), (work, 6), (family, 1).
        // Expected Result: (work, 6), (video games, 3), (homework, 3), (family, 1).
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("video games", 3);
        priorityQueue.Enqueue("homework", 3);
        priorityQueue.Enqueue("work", 6);
        priorityQueue.Enqueue("family", 1);
        Console.WriteLine("Items in the queue after enqueuing:");
        Console.WriteLine(priorityQueue);
        while (priorityQueue.Count > 0) {
            var item = priorityQueue.Dequeue();
            Console.WriteLine(item);
        }



        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: An error message will be displayed.
        Console.WriteLine("Test 3");
        Console.WriteLine(priorityQueue.Dequeue()); // This should show an error message.
        // Defect(s) Found: None
        Console.WriteLine("---------");
    }
}