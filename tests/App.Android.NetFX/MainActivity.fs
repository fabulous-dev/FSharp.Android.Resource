namespace App.Android.NetFX

open Android.App
open Android.Widget

[<Activity (Label = "App.Android.NetFX", MainLauncher = true, Icon = "@mipmap/icon")>]
type MainActivity () =
    inherit Activity ()

    let mutable count:int = 1

    do Resource.UpdateIdValues()

    override this.OnCreate(bundle) =
        base.OnCreate(bundle)

        // Set our view from the "main" layout resource
        this.SetContentView(Resource.Layout.Main)

        // Get our button from the layout resource, and attach an event to it
        let button = this.FindViewById<Button>(Resource.Id.myButton)
        button.Click.Add (fun args -> 
            button.Text <- sprintf "%d clicks! NETFX" count
            count <- count + 1
        )
