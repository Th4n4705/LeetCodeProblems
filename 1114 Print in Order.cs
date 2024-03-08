using System.Threading;

public class Foo {
    private static Semaphore semaphore1;
    private static Semaphore semaphore2;

    public Foo() {
        semaphore1 = new (0, 1);
        semaphore2 = new (0, 1);
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        semaphore1.Release();
    }

    public void Second(Action printSecond) {
        
        semaphore1.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        semaphore2.Release();
    }

    public void Third(Action printThird) {
        
        semaphore2.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}