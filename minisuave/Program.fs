module minisuave
open Suave.Http
open Suave.Console
open Suave.Sucessful


[<EntryPoint>]
let main argv =
    let request = {Route = ""; Type = Suave.Http.GET}
    let response = {Content = ""; StatusCode = 200 }
    let context = {Request = request; Response = response}

    execute context (OK "Hello Suave!")
    0 // return an integer exit code
