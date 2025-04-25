namespace IonideFsiBugExample

type Example =
    class
        member Property: int with get, set
    end

[<Class>]
type Example2 =
    member Property: int with get, set

[<Interface>]
type Example3 =
    member Property: int with get, set
