// #Regression #Conformance #DeclarationElements #Attributes 
// Regression test for FSHARP1.0:3797
// Using bitwise OR (|||) in AttributeUsage works (same as WithBitwiseOr02b.fsx, on class)
//<Expects status="success"></Expects>
#light

[<System.AttributeUsage(System.AttributeTargets.Class ||| System.AttributeTargets.Struct, AllowMultiple=true)>]  
[<Sealed>]
type FooAttribute() =
    inherit System.Attribute()

[<Foo>]
type C() = class
           end

