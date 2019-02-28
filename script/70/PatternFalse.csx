// https://stackoverflow.com/questions/50895572/c-sharp-pattern-matching-issue-use-of-unassigned-local-variable
// https://stackoverflow.com/questions/49523905/inline-variable-declaration-doesnt-compile-when-using-false-instead-of-neg

void F1(object o) {
    if ((o is string s) == false) {
        //Console.WriteLine(s);   // Use of unassigned local variable 's'
    }
    //Console.WriteLine(s);
}

void F2(object o) {
    if (o is string s) {
        Console.WriteLine(s);
    }
    // Console.WriteLine(s);       // Use of unassigned local variable 's'
}


