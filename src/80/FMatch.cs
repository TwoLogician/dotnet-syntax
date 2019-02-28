namespace Features {
    public class FMatch {
        public static string A() {
            var a = "hello";
            return a switch
            {
                "H" => "a",
                _ => "b"
            };
        }
    }
}