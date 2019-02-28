
void foo() {
    try {
        throw new FileNotFoundException("B");
    } catch (Exception ex) when (ex.Message == "B") {
        Console.WriteLine("B");
    } catch (Exception ex) when (ex.Message == "A") {
        Console.WriteLine("A");
    }
}

void bar() {
    try {
        throw new FileNotFoundException("A");
    } catch (FileNotFoundException ex) {
        Console.WriteLine("A " + ex.Message);
        throw;
    } catch (Exception ex) {
        Console.WriteLine("B " + ex.Message);
    }
}

foo();
bar();