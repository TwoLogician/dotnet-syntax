using System;

namespace Not {
    class Program {
        static void Main(string[] args) {

        }
    }

    public class WTF {
        public bool HowDoesThisWork() {
            return this is not async or anything();
        }

        public class async : WTF { }
        public class anything : WTF { }
    }
}
