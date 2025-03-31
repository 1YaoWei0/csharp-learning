

# 类型系统

## 概述

具体可见官方文档：[类型系统概述]([C# 类型系统 | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/))

### 值类型

值类型派生自[System.ValueType](https://learn.microsoft.com/zh-cn/dotnet/api/system.valuetype)（派生自 [System.Object](https://learn.microsoft.com/zh-cn/dotnet/api/system.object)）。 派生自 [System.ValueType](https://learn.microsoft.com/zh-cn/dotnet/api/system.valuetype) 的类型在 CLR 中具有特殊行为。 值类型变量直接包含其值。 **结构的内存在声明变量的任何上下文中进行内联分配**。 对于值类型变量，**没有单独的堆分配或垃圾回收开销**。

- struct
- enum

#### 内置类型

- 基本数值类型：这些类型表示整数、浮点值、布尔表达式、文本字符、十进制值和其他数据类型；
- `string`和`object`。

### 引用类型

**创建对象时，会在托管堆上分配内存。 变量只保留对对象位置的引用。 对于托管堆上的类型，在分配内存和回收内存时都会产生开销。** “垃圾回收”是 CLR 的自动内存管理功能，用于执行回收。

- class
- record
- delegete
- 数组
- interface

### 文本值的类型

在 C# 中，文本值从编译器接收类型。 可以通过在数字末尾追加一个字母来指定数字文本应采用的类型。 例如，若要指定应按 `float` 来处理值 `4.56`，则在该数字后追加一个“f”或“F”，即 `4.56f`。 如果没有追加字母，那么编译器就会推断文本值的类型。 若要详细了解可以使用字母后缀指定哪些类型，请参阅[整型数值类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)和[浮点数值类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)。

由于文本已类型化，且所有类型最终都是从 [System.Object](https://learn.microsoft.com/zh-cn/dotnet/api/system.object) 派生，因此可以编写和编译如下所示的代码：

```csharp
string s = "The answer is " + 5.ToString();
// Outputs: "The answer is 5"
Console.WriteLine(s);

Type type = 12345.GetType();
// Outputs: "System.Int32"
Console.WriteLine(type);
```

### 泛型类型

可使用一个或多个类型参数声明的类型，用作实际类型（具体类型）的占位符 。

### 隐式类型、匿名类型和可以为 null 的值类型

你可以使用 [`var`](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/var) 关键字隐式键入一个局部变量（但不是类成员）。 变量仍可在编译时获取类型，但类型是由编译器提供。 有关详细信息，请参阅[隐式类型局部变量](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables)。

不方便为不打算存储或传递外部方法边界的简单相关值集合创建命名类型。 因此，可以创建*匿名类型*。 有关详细信息，请参阅[匿名类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/anonymous-types)。

普通值类型不能具有 [`null`](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/null) 值。 不过，可以在类型后面追加 `?`，创建可为空的值类型。 例如，`int?` 是还可以包含值 [`null`](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/null) 的 `int` 类型。 可以为 null 的值类型是泛型结构类型 [System.Nullable](https://learn.microsoft.com/zh-cn/dotnet/api/system.nullable-1) 的实例。 在将数据传入和传出数据库（数值可能为 `null`）时，可为空的值类型特别有用。 有关详细信息，请参阅[可以为 null 的值类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/nullable-value-types)。

