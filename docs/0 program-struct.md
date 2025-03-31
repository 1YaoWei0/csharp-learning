# 程序结构

## 概述

这一章介绍了 c# 程序的常规结构，c# 程序由一个或多个以`.cs`结尾的文件组成。每一个文件包含**零个**或多个命名空间。命名空间包含了：类，结构，接口，委托，枚举和其它命名空间。

```csharp
using System;

Console.WriteLine("Hello world!");

namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }
}
```

### 程序入口

c# 可以在类中创建一个名为 Main 的方法用于做程序的入口。**一个程序只能有一个入口点**

> 同样可以使用**顶级语句**，只有一个文件可以有顶级语句

## Main 方法

- `Main`方法是 c# 应用程序的入口，它应该是程序启动后调用的第一个方法；
- **Main 方法必须在类或结构中进行声明**；
- **Main 方法必须为 static**；
- Main 方法可以具有任何访问修饰符；（`file`除外）
- Main 方法可以返回`void`, `int`, `Task` 或 `Task<int>`；
- Main 方法可以有入参，也可以没有入参；
- Main 方法可以用异步修饰符修饰，但当 Main 方法存在返回值 int 时，需要使用`Task` 或 `Task<int>`。

```csharp
static void Main() { }
static int Main() { }
static void Main(string[] args) { }
static int Main(string[] args) { }
static async Task Main() { }
static async Task<int> Main() { }
static async Task Main(string[] args) { }
static async Task<int> Main(string[] args) { }
```

## 顶级语句

在 **C# 9.0**（随 .NET 5 于 2020 年 11 月发布）中首次引入了**顶级语句（Top-level Statements）**功能。这一特性简化了小型程序或脚本的代码结构，允许开发者省略传统的 `Program` 类和 `Main` 方法，直接编写执行代码。

我们已知一个应用程序只能由一个入口点，**所以一个程序只能存在一个顶级文件**；顶级语句默认存在于全局命名空间，所以即便开发者创建了新的文件并显示的编写 `Main` 方法，系统依旧只会默认顶级文件中的第一行代码为程序的第一调用点。

> 顶级文件也可包含类和命名空间定义，但它们必须位于顶级语句之后。

关于顶级语句，具体可见：[c# 顶级语句]([顶级语句 - 不使用 Main 方法的程序 - C# | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/top-level-statements))

