using System;

namespace Program
{
    public class Counter
    {
        public event Action<int> ThresholdReached;
        private int threshold;
        private int count;

        public Counter(int threshold)
        {
            this.threshold = threshold;
            this.count = 0;
        }

        public void Increment()
        {
            count++;
            if (count == threshold)
            {
                ThresholdReached?.Invoke(count);
            }
        }
    }

    class Program
    {
        public static void notification_event(int count)
        {
            Console.WriteLine("Threshold Reached: " + count);
        }

        public static void log_event(int count)
        {
            Console.WriteLine("Threshold Reached: " + count);
        }

        public static void Main(string[] args)
        {
            Counter counter = new Counter(5);
            // DECOUPLING DEMONSTRATION:
            // The 'Counter' (Producer) has no knowledge of 'notification_event' or 'log_event'.
            // It simply identifies that a state change occurred and notifies its subscribers.
            // This allows us to add or remove features (like logging or UI alerts) 
            // without ever touching the core Counter logic.
            counter.ThresholdReached += notification_event;
            counter.ThresholdReached += log_event;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Incrementing Count as: " + (i + 1));
                counter.Increment();
            }
        }
    }
}