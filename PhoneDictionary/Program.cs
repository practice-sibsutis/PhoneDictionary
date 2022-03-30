// See https://aka.ms/new-console-template for more information

using PhoneDictionary;

IndexArray arr = new IndexArray(new PhoneRecord[]
{
    new PhoneRecord("Anton", "Mileshko", "12345667"),
    new PhoneRecord("Petr", "Petrov", "12345667"),
    new PhoneRecord("Maria", "Kim", "12345667"),
    new PhoneRecord("Alex", "Smolyar", "12345667")
});

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].ToString());
}

Console.WriteLine();

arr.Sort();

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].ToString());
}

Person p1 = new Person("A", "B");
Person p2 = p1;

Console.WriteLine($"{p1} {p2}");

p1.Name = "C";

Console.WriteLine($"{p1} {p2}");