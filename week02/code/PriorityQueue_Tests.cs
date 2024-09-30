using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them: Bob (1), Tim (2), Sue (3)
    // Expected Result: The item with the highest priority should be dequeued first.
    // Defect(s) Found:  None. This should pass.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        //added code start
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 3);
        //added code end
        //Assert.Fail("Implement the test case and then remove this.");
        //test code
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Sue", result, "Expected highest priority item to be dequeued.");
    }
    

    [TestMethod]
    // Scenario: Enqueue items and then dequeue the highest and the next highest.
    // Expected Result: Dequeue should return Bob first (highest priority), then Sue.
    // Defect(s) Found: If Sue is dequeued first instead of Bob.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 3);

        priorityQueue.Dequeue(); // Remove Item1 (highest priority)
        var result = priorityQueue.Dequeue(); // Next should be Sue
        Assert.AreEqual("Sue", result, "Expected Sue to be dequeued next.");
    }

    // Add more test cases as needed below.
}