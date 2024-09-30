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


    [TestMethod]
    // Scenario: The Enqueue function adds an item to the back of the queue.
    // Expected Result: Tim is added successfully and can be dequeued later.
    // Defect(s) Found: If dequeued item is not the one just added.
    public void TestPriorityQueue_EnqueueAddsToBack()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result, "Expected Tim to be dequeued first as it has higher priority.");
    }

    [TestMethod]
    // Scenario: The Dequeue function removes the item with the highest priority.
    // Expected Result: Sue - with the highest priority should be returned.
    // Defect(s) Found: If an item with lower priority is returned instead.
    public void TestPriorityQueue_DequeueRemovesHighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Sue", result, "Expected highest priority item (Sue) to be dequeued.");
    }

    [TestMethod]
    // Scenario: Multiple items with the same highest priority are in the queue.
    // Expected Result: The item closest to the front should be removed and returned.
    // Defect(s) Found: If the wrong item is dequeued.
    public void TestPriorityQueue_DequeueRemovesClosestItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result, "Expected Tim to be dequeued first as it was added first with highest priority.");
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty priority queue.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: If no exception is thrown when dequeuing from an empty queue.
    public void TestPriorityQueue_EmptyQueueDequeue()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Expected an exception when dequeuing from an empty queue.");
    }

    [TestMethod]
    // Scenario: Enqueue items and ensure the order is maintained.
    // Expected Result: Dequeue should return items in order of their priority.
    // Defect(s) Found: If the order is incorrect or items are not dequeued as expected.
    public void TestPriorityQueue_SamePriorityItems()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 1);

        var result1 = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result1, "Expected BOb to be dequeued first.");

        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result2, "Expected Tim to be dequeued next.");
    }

}