# Evaluator
- Implementation of a take-home challenge

# How to run
   - Open Visual Studio and run the Evaluator project.

#  Description
   - Lazy evaluation is an evaluation strategy that delays the evaluation of an expression until its value is needed.
   The challenge is for you to implement an `Evaluator<T>` class. Its requirements and the specification of its interface follows.
   
   - `public Evaluator<T>()`: 
     - A parameterless constructor that can be used for initialisation.</br>
     - The generic `T` parameter expresses the type on which the evaluator will operate and ultimately return.</br>
   
   - `public void add(Func<T, T[], T> func, params T[] additionalArgs)`:
      - Associates a `func`, and additional arguments for said `func` with an `Evaluator<T>` instance. Note that `func` should:</br>
        1) Accept an accumulated value of type `T`</br>
        2) Accept `additionalArgs` via a second parameter of type `T[]`</br>
        3) Return a result of type T<br>
   
   - `public T Evaluate (T seed)`:
     - Invokes the `Evaluator<T>` instance's functions, in the order in which they were added, and returns the result. This requires an initial seed value.
