using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_Valid_Arg_AddTheObjectToTheStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_ListCountEquals0_InvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTop()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Assert.That(stack.Pop(), Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_StackIsEmpty_ReturnInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithAFewObjects_ReturnsObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_StackWithAFewObjects_ListSizeRemainsTheSame()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));



        }




    }
}
