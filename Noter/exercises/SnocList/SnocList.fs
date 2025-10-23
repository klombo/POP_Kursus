//SnocList definition
namespace SnocLists

module SnocList = 

    type SnocList<'a> = Nil | Snoc of 'a SnocList * 'a

    let rec length (inputList: 'a SnocList) : int =
        match inputList with
        | Nil -> 0
        | Snoc(head, _) -> 1 + length head

    let rec sum (inputList: int SnocList) : int =
        match inputList with
        | Nil -> 0
        | Snoc(head, tail) -> tail + sum head

    let rec append (inputList1: 'a SnocList) (inputList2 : 'a SnocList) : 'a SnocList =
        match inputList2 with
        | Nil -> inputList1
        | Snoc(tail, head) -> Snoc(append inputList1 tail, head)
