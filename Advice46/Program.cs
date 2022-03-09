using System;
using System.Runtime.InteropServices;

namespace Advice46
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SampleClass : IDisposable
    {
        // 演示创建一个非托管资源
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);

        // 演示创建一个托管资源

        private AnotherResource managedResource = new AnotherResource();
        private bool disposed = false;

        public void Dispose()
        {
            // must be true
            Dispose(true);
            // 通知垃圾回收机制不再调用终结器（析构器）
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 不是必要的，提供一个Close方法仅仅是为了更符合其他语言的规范
        /// </summary>
        public void Close()
        {
            Dispose();
        }

        /// <summary>
        /// 必须的，防止程序员忘记了显式调用Dispose方法
        /// </summary>
        ~SampleClass()
        {
            // 必须为false
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // 清理托管资源
                if (managedResource != null)
                {
                    managedResource.Dispose();
                    managedResource = null;
                }
            }

            // 清理非托管资源
            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            // 让类型知道自己已经被释放
            disposed = true;
        }

        public void SamplePublicMethod()
        {
            if (disposed)
            {
                throw new ObjectDisposedException("SampleClass", "SampleClass is disposed");
            }
        }
    }

    internal class AnotherResource
    {
        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
