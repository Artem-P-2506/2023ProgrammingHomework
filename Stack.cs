using System;
using System.Collections.Generic;

namespace C__2023__КН_22_
{
    #region Stack
    public class Stack<T>
    {
        private const int defaultSizeOfStack = 100; // Розмір масиву для даних по умовчанню
        private T[] data; // Масив для зберігання даних
        private int topElement = -1; // Індекс вершини стеку

        // Конструктор класса
        public Stack(int size = defaultSizeOfStack)
        {
            data = new T[size];
        }

        public void Push(T element)
        {
            if (topElement >= 99)
            {
                Console.WriteLine("Stack is full! Unable to add item!");
            }
            else
            {
                topElement++;
                data[topElement] = element;
            }
        }
        public void Pop()
        {
            if (topElement < 0)
                Console.WriteLine("Stack is empty! Unable to delete item!");
            else
                topElement--;
        }
        public T Peek()
        {
            if (topElement < 0)
            {
                Console.WriteLine("Stack is empty!");
                return default(T); // Повертаємо значення за умовчанням
            }
            else return data[topElement];
        }
        public bool IsEmpty()
        {
            return (topElement < 0);
        }
    }
    #endregion
}