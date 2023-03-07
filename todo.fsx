type ToDoItemStatus =
    | Complete
    | Incomplete

type TodoListItem =
    { Taskname: string;
    Duedate: string;
    mutable Completeddate: string;
    mutable Iscomplete: ToDoItemStatus }

let Todoitemone =
    { Taskname = "breakfast";
    Duedate = "3/25/23";
    Completeddate = "";
    Iscomplete = Incomplete
    }

let Todoitemtwo =
    { Taskname = "Standup";
      Duedate = "3/7/23";
      Completeddate = "3/7/23";
      Iscomplete = Complete;
    }

let Todoitemthree =
    { Taskname = "Demo";
      Duedate = "3/9/23";
      Completeddate = "";
      Iscomplete = Incomplete;
    }

let randomitem = string
let randomitemtwo = System.DateTime

let todolist =
    [| Todoitemone;
       Todoitemtwo;
       Todoitemthree |]

for item in todolist do
    if item.Iscomplete = Incomplete then
        printf $"{item.Taskname}"

todolist[0].Completeddate <- "3/7/23"
todolist[0].Iscomplete <- Complete

let mutable incompletelist: TodoListItem array = [||]

for item in todolist do
    if item.Iscomplete = Incomplete then
        //incompletelist = Array.append item
        printfn $"{item.Taskname}"