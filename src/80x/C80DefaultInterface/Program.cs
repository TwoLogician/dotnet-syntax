using System;

namespace C80DefaultInterface {
    interface IService {
        void Start();
        void Stop();
        void Restart() {
            Stop();
            Start();
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
