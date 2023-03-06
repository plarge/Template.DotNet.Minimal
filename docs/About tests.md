# About tests

In this page, you will find some explanation about my test configuration.

## Components

The current template use:

- [xUnit](https://xunit.net/) as unit testing tool;  
Nunit is an alternative, but I prefer **xUnit** (see [.NET meetup Vienna March 2020](https://youtu.be/rLbF8u46tfE) for more information).

- [NFluent](https://www.n-fluent.net/) as assertion tool;  
I support **NFluent** developped by a french team, but [FluentAssertions](https://fluentassertions.com/) is a good option.

All are available as nuget packages.

## Naming rule

My naming rule for writting test methods is **_MethodNameToTest_ShouldXXX_WhenYYY_**.

For example :

```c#
public void DoSomething_ShouldReturnOne_WhenCalled()
{
    // Arrange

    // Act

    // Assert
}
```

I use this convention since I follow [Nick Chapsas](https://github.com/Elfocrash).
