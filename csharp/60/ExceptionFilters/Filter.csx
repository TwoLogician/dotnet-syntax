
void foo() {
    try {
        throw new FileNotFoundException("A");
    } catch (Exception ex) when (ex.Message == "A") {

    }
}

foo();