namespace Advice17
{
    // 要求所有迭代器全部实现该接口
    interface IMyEnumerator
    {
        bool MoveNext();

        object Current { get; }
    }

    // 要求所有的集合实现该接口
    // 这样一来， 客户端就可以针对该接口编码， 而无需关注具体的实现
    interface IMyEnumerable
    {
        IMyEnumerator GetEnumerator();

        int Count { get; }
    }

    class MyList : IMyEnumerable
    {
        object[] items = new object[10];
        IMyEnumerator myEnumerator;

        public object this[int i]
        {
            get { return items[i]; }
            set { this.items[i] = value; }
        }

        public int Count => items.Length;

        public IMyEnumerator GetEnumerator()
        {
            if (myEnumerator == null)
            {
                myEnumerator = new MyEnumerator(this);
            }
            return myEnumerator;
        }
    }

    class MyEnumerator : IMyEnumerator
    {
        int index = 0;
        MyList myList;

        public MyEnumerator(MyList myList)
        {
            this.myList = myList;
        }

        public object Current => myList[index - 1];

        public bool MoveNext()
        {
            if (index + 1 > myList.Count)
            {
                index = 1;
                return false;
            }
            else
            {
                index++;
                return true;
            }
        }
    }
}
