#r "nuget: XPlot.GoogleCharts"
#r "nuget: FSharp.Data"

open FSharp.Data
open XPlot.GoogleCharts

type WorldBank = 
    WorldBankDataProvider<"World Development Indicators", Asynchronous=true>
let data2 = WorldBank.GetDataContext()

type Chart =
    static member EntitleCo2 =
        Chart.WithTitle "CO2 emissions" 
        >> Chart.WithYTitle "Metric tons" 
        >> Chart.WithXTitle "Year"

let countries = [data2.Countries.Denmark; data2.Countries.Norway; 
                 data2.Countries.Sweden; data2.Countries.Finland]

countries
// |> Seq.map(fun c -> c.Indicators.``CO2 emissions (metric tons per capita)``)
  |> Seq.map(fun c -> c.Indicators.``Carbon dioxide (CO2) emissions excluding LULUCF per capita (t CO2e/capita)`` )
  |> Async.Parallel
  |> Async.RunSynchronously
  |> Chart.Line
  |> Chart.WithLabels (countries |> Seq.map(fun c -> c.Name)) 
  |> Chart.EntitleCo2
  |> Chart.Show
