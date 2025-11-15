# Java-like-Csharp

A dual-backend experimental language that mixes the simplicity of **Java syntax** with the expressive power of **C# features**. The goal is to explore a hybrid language model that compiles to **both Java and C#**, enabling cross-ecosystem interoperability.

---

## Overview

Java-like-Csharp (JLCS) is a research-oriented language that attempts to unify:

* Java-style structure and clarity
* C# inspired features (namespaces, properties, using blocks)
* A clean AST pipeline
* Dual backend: **Java** or **C#** code generation
* Minimal implementation with extendable grammar

You write **`.jlcs`** files:

```jlcs
namespace demo;

using System;

class Hello {
    property message: String = "Hello JLCS";

    method run(): void {
        Console.WriteLine(message);
    }
}
```

Then compile:

```
$ jlcs example.jlcs --java    # → generates example.java
$ jlcs example.jlcs --csharp  # → generates example.cs
```

---

## Language Goals

* Bridge the Java and C# developer communities
* Provide a playground for hybrid syntax design
* Support simple transpilation to host languages
* Enable experimentation with type systems and IR
* Integrate well with larger multi-language ecosystems

---

## Core Features

### ✔ Java-like syntax

* `class` declarations
* `method` definitions
* familiar statement flow

### ✔ C#-style extensions

* `namespace`
* `using` directives
* `property` field syntax

### ✔ Dual transpilation

* Emit valid Java source
* Emit valid C# source

### ✔ Extensible architecture

* Lexer / Tokenizer
* Parser
* AST builder
* Visitor model
* Transpiler targets

---

## Architecture

```
.jlcs → Lexer → Parser → AST → IR → Backend(Java/C#)
```

### Lexer

* Tokenizes identifiers, keywords, operators, literals

### Parser

* Recursive descent parser implementing core grammar

### AST

* Nodes for class, method, property, namespace, block, expression

### Backends

* Java generator creates `.java` files
* C# generator creates `.cs` files

---

## Example Output

### Input `.jlcs`

```jlcs
class Sample {
    method run(): void {
        print("JLCS running");
    }
}
```

### Generated Java

```java
public class Sample {
    public void run() {
        System.out.println("JLCS running");
    }
}
```

### Generated C#

```csharp
class Sample {
    public void run() {
        Console.WriteLine("JLCS running");
    }
}
```

---

## Build & Run

### 3OS GitHub Action

This repository includes a workflow that:

* builds on Ubuntu, macOS, Windows
* generates ProofLedger metadata
* bundles artifacts into auto releases

### Local Build

```
g++ -std=c++20 src/jlcs.cpp -o jlcs
./jlcs yourfile.jlcs --java
```

---

## ProofLedger

Each build produces:

* Repository name
* Commit hash
* OS information
* Build timestamp
* SHA256 of source files

This ensures reproducibility and transparent build history.

---

## Roadmap

* Function overloading
* Generic types
* Trait/interface merging
* JVM + .NET IL backend (experimental)
* Bytecode mode for both runtimes
* Spongelang IR integration

---

## License

MIT License

---

## Contributing

Feedback, ideas, or experiments are welcome. This is an open language laboratory project. Feel free to open issues or submit PRs.
