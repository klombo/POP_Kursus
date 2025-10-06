type Account = string * float // (ID, Balance)
type Customer =  string * string // (Navn, KundeID)
let allCustomer : Customer list = 
//    Navn:  KundeID:
    [("TinTin", "1"); 
     ("Kaptajn Haddock", "2"); 
     ("Professor Tournesol", "3"); 
     ("Dupond", "4"); 
     ("Dupont", "5")]

let allAccounts : Account list = 
//    ID:   Balance:
    [ ("11C", 1451.67)
      ("51S", 780.50)
      ("21C", 97.12)
      ("11S", 6124.31)
      ("21S", 520.55)
      ("31C", 5000.00)
      ("41S", 1500.45)
      ("33C", 250.75)
      ("41C", 200.00)
      ("22S", 1020.00)
      ("31S", 9310.00)
      ("51C", 300.00)
      ("52S", 1200.00)
      ("32S", 122.31)]

let findBalance (accountID : string) : float =
    match allAccounts |> List.filter (fun (accID, _) -> accID = accountID) with
    | [(_,balance)] -> balance
    | _ -> 0.0

// Funktionen der lader os transfer fra en saving til checking Account.
let internalTransfer (recipientAccountID: string) (senderAccountID: string) (amount: float) =
  let senderBalance = findBalance senderAccountID 
  let recipientBalance = findBalance recipientAccountID

  if senderBalance < amount then
    printfn "Overdraw not allowed"
    printfn "Your balance is: %A" (senderBalance)
  else
    if recipientAccountID.[0] = senderAccountID.[0] then
      printfn "Senders balance before: %A" (senderBalance)
      printfn "Senders balance after: %A" (senderBalance - amount)
      printfn "Recipients balance before: %A" (recipientBalance)
      printfn "Recipients balance after: %A" (recipientBalance + amount)
    else
      printfn "This is not an internal Transfer" 

let addInterest (interest: float) = 
  let savingAccounts = 
    allAccounts
    |> List.filter (fun (accID, _) -> accID.[accID.Length-1] =  'S')
  printfn "All saving accounts before interest: %A" savingAccounts
  savingAccounts
    |> List.map (fun (accID, balance) -> (accID, balance * (1.0 + interest)))

internalTransfer "51C" "52S" 1000.0
addInterest 0.15 |> printfn "All saving accounts after interest: %A"