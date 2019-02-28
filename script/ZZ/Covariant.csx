

class Animal { }
class Cat : Animal { }

Animal GetCat(Animal an) => new Cat();

Func<Animal, Cat> f1 = (x) => new Cat();
Func<Cat, Animal> f2 = f1;
Func<Cat, Animal> f3 = GetCat;
