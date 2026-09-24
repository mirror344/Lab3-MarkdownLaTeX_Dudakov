**Жирный текст**
_Курсив_
**_Жирный курсив_**
`Console.Writeline("Hello")`

```csharp

string name;
name = Console.Readline();
Console.WriteLine(name);
```

# Задание: Комментированная программа на C#

Создайте консольное приложение на C#, которое демонстрирует все форматы Markdown в комментариях к коду.

## Требования к программе:

1. **Имя файла:** `FormatDemo.cs`
2. **Логика**:
   - Запрашивает у пользователя **два числа**
   - Выполняет их **сложение**
   - Выводит результаты в **форматированном виде**.

---

## Пример структуры кода с комментариями в стиле Markdown:

```csharp

Console.WriteLine("Введите первое число:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double b = double.Parse(Console.ReadLine());
double sum = a + b;
Console.WriteLine($"Результат: {sum}");
```
