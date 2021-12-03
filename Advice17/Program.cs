namespace Advice17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用接口IMyEnumerable代替MyList
            IMyEnumerable list = new MyList();

            // 得到迭代器， 在循环中针对迭代器编码， 而不是集合MyList
            IMyEnumerator enumerator = list.GetEnumerator();

            foreach (var current in list)
            {

            }
        }
    }
}
