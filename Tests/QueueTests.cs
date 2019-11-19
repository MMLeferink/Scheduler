using Scheduler;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class QueueTests
    {
        [Test]
        public void MyQueue_1_Constructor_1_IsEmptyReturnsTrue()
        {
            // Arrange
            IMyQueue<string> q = DataTypeBuilder.CreateMyQueue();
            bool expected = true;

            // Act
            bool actual = q.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_2_Enqueue_1_IsEmptyReturnsFalse()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            bool expected = false;

            // Act
            stack.Enqueue("a");
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_2_Enqueue_2_GetFrontIsOkAfter1Enqueue()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "a";

            // Act
            stack.Enqueue("a");
            string actual = stack.GetFront();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_2_Enqueue_3_GetFrontIsOkAfter3Enqueue()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "a";

            // Act
            stack.Enqueue("a");
            stack.Enqueue("b");
            stack.Enqueue("c");
            string actual = stack.GetFront();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_2_Enqueue_4_DequeueIsOkAfter1Enqueue()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "a";

            // Act
            stack.Enqueue("a");
            string actual = stack.Dequeue();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_2_Enqueue_5_DequeueIsOkAfter3Enqueue()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "a";

            // Act
            stack.Enqueue("a");
            stack.Enqueue("b");
            stack.Enqueue("c");
            string actual = stack.Dequeue();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_2_Enqueue_6_TwoTimesDequeueIsOkAfter3Enqueue()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "b";

            // Act
            stack.Enqueue("a");
            stack.Enqueue("b");
            stack.Enqueue("c");
            stack.Dequeue();
            string actual = stack.Dequeue();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_3_GetFront_1_ThrowsExceptionOnEmptyStack()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();

            // Act & Assert
            Assert.Throws(typeof(MyQueueEmptyException), () => stack.GetFront());
        }

        [Test]
        public void MyQueue_3_GetFront_2_IsEmptyReturnsFalseAfterGetFrontOnOneElement()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            bool expected = false;

            // Act
            stack.Enqueue("a");
            stack.GetFront();
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_4_Dequeue_1_ThrowsExceptionOnEmptyList()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();

            // Act & Assert
            Assert.Throws(typeof(MyQueueEmptyException), () => stack.Dequeue());
        }

        [Test]
        public void MyQueue_4_Dequeue_2_IsEmptyReturnsTrueAfterGetFrontOnOneElement()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            bool expected = true;

            // Act
            stack.Enqueue("a");
            stack.Dequeue();
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_4_Dequeue_3_RandomDequeues()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "f";

            // Act
            stack.Enqueue("a");
            stack.Dequeue();
            stack.Enqueue("b");
            stack.Enqueue("c");
            stack.Enqueue("d");
            stack.Enqueue("e");
            stack.Dequeue();
            stack.Dequeue();
            stack.Enqueue("f");
            stack.Dequeue();
            stack.Dequeue();

            string actual = stack.GetFront();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_6_ToString_1_OnEmptyList()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "";

            // Act
            string actual = stack.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_6_ToString_2_OnSingleElement()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "3";

            // Act
            stack.Enqueue("3");
            string actual = stack.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_5_ToString_3_OnFullList()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20";

            // Act
            for (int i = 1; i <= 20; i++)
                stack.Enqueue(i.ToString());

            string actual = stack.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyQueue_5_ToString_4_AfterClear()
        {
            // Arrange
            IMyQueue<string> stack = DataTypeBuilder.CreateMyQueue();
            string expected = "";

            // Act
            stack.Enqueue("1");
            stack.Enqueue("2");
            stack.Enqueue("3");
            stack.Enqueue("4");
            stack.Enqueue("5");
            stack.Clear();
            string actual = stack.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}