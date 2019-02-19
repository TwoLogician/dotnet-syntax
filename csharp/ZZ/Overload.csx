using System;
enum MyEnum { Zero }

static void Print(object a) {

    Console.WriteLine("Object {0}", a);
}

static void Print(MyEnum e) {
    Console.WriteLine("MyEnum {0}", e);
}

Print(0.0f);
Print(0.1f);