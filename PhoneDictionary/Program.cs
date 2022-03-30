// See https://aka.ms/new-console-template for more information

using PhoneDictionary;

IndexArray arr = new IndexArray(new PhoneRecord[]
{
    new PhoneRecord("Zhou", "Guanyu", "12345667"),
    new PhoneRecord("Valtteri", "Bottas", "12345667"),
    new PhoneRecord("Pierre", "Gasly", "12345667"),
    new PhoneRecord("Yuki", "Tsunoda", "12345667"),
    new PhoneRecord("Fernando", "Alonso", "12345667"),
    new PhoneRecord("Esteban", "Ocon", "12345667"),
    new PhoneRecord("Nico", "Hülkenberg", "12345667"),
    new PhoneRecord("Charles", "Leclerc", "12345667"),
    new PhoneRecord("Carlos", "Sainz", "12345667"),
    new PhoneRecord("Lewis", "Hamilton", "12345667"),
});

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].ToString());
}

Console.WriteLine();

arr.Sort(new PhoneRecordComparerByFirstName());

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].ToString());
}

Console.WriteLine();

arr.Sort(new PhoneRecordComparerBySecondName());

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].ToString());
}

