# .Net
**18 вариант**

## Контрольные вопросы
**1. Что понимается под термином «.NET Framework»?**

.NET Framework — программная платформа, выпущенная компанией Microsoft в 2002 году. Основой платформы является общеязыковая среда исполнения Common Language Runtime (CLR), которая подходит для разных языков программирования. Функциональные возможности CLR доступны в любых языках программирования, использующих эту среду.

**7. Приведите обобщенный синтаксис инициализации переменной на
языке C#.**

Перед использованием любую переменную надо определить. Синтаксис определения переменной выглядит следующим образом:

```ShellSession
  тип имя_переменной;
```
- имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания;
- в имени не должно быть знаков пунктуации и пробелов;
- имя не может быть ключевым словом языка C#. Таких слов не так много, и при работе в Visual Studio среда разработки подсвечивает ключевые слова синим цветом.;

Например:
```ShellSession
  int num = 1;
```

**13. Как соотносится время жизни переменной и область видимости?**

Время жизни переменной может быть глобальным и локальным. Переменная с глобальным временем жизни характеризуется тем, что в течение всего времени выполнения программы с ней ассоциирована ячейка памяти и значение. Переменной с локальным временем жизни выделяется новая ячейка памяти при каждом входе в блок, в котором она определена или объявлена. Время жизни функции всегда глобально.

Область видимости объекта (переменной или функции) определяет, в каких участках программы допустимо использование имени этого объекта.

**19.. Какое пространство имен использует системная библиотека .NET Framework? **

Пространства имен часто используются в программировании на C# двумя способами. Первый способ — .NET использует пространства имен для упорядочения множества ее классов следующим образом:

```ShellSession
  System.Console.WriteLine("Hello World!");
```
```ShellSession
Console.WriteLine("Hello");
Console.WriteLine("World!");
```

Второй способ — объявление собственных пространств имен поможет вам контролировать область имен классов и методов в более крупных проектах. Используйте ключевое слово namespace, чтобы объявить пространство имен, как показано в следующем примере:

```ShellSession
namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
              "SampleMethod inside SampleNamespace");
        }
    }
}
```
