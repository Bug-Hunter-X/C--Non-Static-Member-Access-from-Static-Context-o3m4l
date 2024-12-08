# C# Non-Static Member Access from Static Context

This repository demonstrates a common C# error: attempting to access a non-static member from a static context.  The code in `bug.cs` illustrates the issue, and `bugSolution.cs` provides a corrected version.

## Problem

In C#, static members belong to the class itself, not to any specific instance of the class.  Non-static members (instance members), on the other hand, are associated with individual objects of the class.

Trying to access an instance member directly from a static method results in a compile-time error because there's no specific object instance available to access the member.

## Solution

The solution involves either:

1. Making the member static if it's appropriate for the class as a whole.
2. Creating an instance of the class to access the instance member.

The `bugSolution.cs` file demonstrates both methods.